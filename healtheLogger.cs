using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Threading;
using System.Globalization;
using System.Xml;


namespace Cerner_Healthe_Steps_Logger
{
    public partial class healtheLogger : Form
    {
        static IWebDriver driver;
        static Process chromeWin;
        static string url = "http:\\cernerhealth.com";
        static OpenFileDialog ofd = new OpenFileDialog();
        static DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
        static List<Cerner_Healthe_Steps_Logger.Classes.steps> apiSteps = new List<Classes.steps>();
        static List<Cerner_Healthe_Steps_Logger.Classes.steps> hlwrSteps = new List<Classes.steps>();
        static int totalPointsAvailable = 0;
        static int newDataCount = 0;
        static int STEPS_BUFFER = 0;
        static bool debugMode = false;

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern Int32 SetForegroundWindow(int hWnd);

        public healtheLogger()
        {
            InitializeComponent();
            initializeChromeDriver();
            login loginInst = new login(driver, url);
            loginInst.ShowDialog();
            navigateToPedoEntryPage();

            //Setting UI Elements
            apiSelect.SelectedIndex = 0;
            unLoggedGrpBox.Text = "Steps not logged since :" + startOfYear;
            loggedGrpBox.Text = "Steps already logged since :" + startOfYear;
            
        }

        
        public void initializeChromeDriver()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", "C:\\Temp");
            options.AddUserProfilePreference("intl.accept_languages", "nl");
            options.AddUserProfilePreference("download.prompt_for_download", "false");
            options.AddUserProfilePreference("safebrowsing.enabled", "true");
            options.AddArguments("--disable-extensions");
            //options.AddArgument("--no-startup-window");
            options.AddArguments("test-type");

            var chDrService = ChromeDriverService.CreateDefaultService(Environment.CurrentDirectory);
            chDrService.HideCommandPromptWindow = true;
            //checkUserCreds();
            driver = new ChromeDriver(chDrService, options);

            
            hideChromeWindow();
            
        }

        private void hideChromeWindow()
        {
            Stopwatch timeElapsed = new Stopwatch();
            timeElapsed.Start();

            while (timeElapsed.Elapsed < TimeSpan.FromMinutes(1))
            {
                Process[] p = Process.GetProcessesByName("chrome");
                foreach (Process item in p)
                {
                    if (item.MainWindowTitle.Equals("data:, - Google Chrome"))
                    {
                        timeElapsed.Stop();
                        chromeWin = item;
                        ShowWindowAsync(item.MainWindowHandle, 0);
                        break;
                    }
                }
                if (!timeElapsed.IsRunning)
                {
                    break;
                }
            }

            if (timeElapsed.Elapsed > TimeSpan.FromMinutes(1))
            {
                timeElapsed.Stop();
                MessageBox.Show("Cerner Healthe Steps Logger was unable to locate the chrome window, you can continue using the application, please do not close the chrome window"
                    , "Cerner Healthe Steps Logger", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void navigateToPedoEntryPage()
        {
            driver.Navigate().GoToUrl("https://healtheatcernerportal.cerner.com/dt/nutr/PedometerEntry.asp");
            ReadOnlyCollection<IWebElement> tdElements = driver.FindElement(By.TagName("table"), 3).FindElements(By.TagName("td"));

            tdElements[1].FindElement(By.TagName("a")).Click();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (apiSelect.Text.Equals("Google Fit"))
            {
                ofd.Filter = "CSV|*.csv";
            }
            else if(apiSelect.Text.Equals("Apple Health Kit"))
            {
                ofd.Filter = "XML|*.xml";
            }
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                fileNameText.Text = ofd.SafeFileName;
            }
        }

        private void resetProcessMsg()
        {
            processMsgLab.Text = "";
            processProgBar.Value = 0;
        }

       
        private void apiLogSteps_Click(object sender, EventArgs e)
        {
            resetApp();
            if (ofd.FileName != "")
            {
                processApiDataAnalatycsBackground();
            }
            else
            {
                processMsgLab.Text = "Please select a file";
                processMsgLab.ForeColor = Color.Red;

            }
        }

        private void processApiDataAnalatycsBackground()
        {
            BackgroundWorker processApiFileBW = new BackgroundWorker();
            processApiFileBW.WorkerReportsProgress = true;
            processApiFileBW.WorkerSupportsCancellation = true;
            processApiFileBW.DoWork += new DoWorkEventHandler(processApiFileBW_DoWork);
            processApiFileBW.ProgressChanged += new ProgressChangedEventHandler(processApiFileBW_ProgressChanged);
            processApiFileBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(processApiFileBW_RunWorkerCompleted);
            string[] arguments = { apiSelect.Text};
            processApiFileBW.RunWorkerAsync(arguments);

        }

        private void processApiFileBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<DataTable> dataTableList = (List<DataTable>)e.Result;
            unMatchedDataBox.DataSource = dataTableList[0];
            matchedDataBox.DataSource = dataTableList[1];

            totalPoints.Text = "Total Available Points: " + totalPointsAvailable.ToString() + " = $" + totalPointsAvailable.ToString();
            pointsPanel.Visible = true;
            if (dataTableList[0].Rows.Count == 0)
            {
                button1.Enabled = false;
                resetProcessMsg();
                processMsgLab.Text = "All data has already been logged";
                processMsgLab.ForeColor = Color.Red;
            }
            else
            {
                button1.Enabled = true;
                resetProcessMsg();
                processMsgLab.Text = "New data fetched, plesae click the button to log your steps.";
                processMsgLab.ForeColor = Color.Green;
            }
        }

        private void processApiFileBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processMsgLab.ForeColor = Color.Red;
            processProgBar.Value = e.ProgressPercentage;
            processMsgLab.Text = e.UserState.ToString();
            
        }

        private void processApiFileBW_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if ((worker.CancellationPending == true))
            {
                e.Cancel = true;

            }
            else
            {
                DataTable unMatchedSteps = new DataTable("unMatchedSteps");
                DataTable matchedSteps = new DataTable("MatchedSteps");
                string[] arg = (string[])e.Argument;
                if (arg[0].Equals("Google Fit"))
                {
                    processGoogleData(worker);
                }
                else if(arg[0].Equals("Apple Health Kit"))
                {
                    processAppleData(worker);
                }

                processCernerHLWRData(worker);
                compareApiHLWRData(worker, unMatchedSteps, matchedSteps, arg[0]);
                List<DataTable> dataTableList = new List<DataTable>();
                dataTableList.Add(unMatchedSteps);
                dataTableList.Add(matchedSteps);
                e.Result = dataTableList;
            }
           
        }

        private void compareApiHLWRData(BackgroundWorker worker, DataTable unMatchedSteps, DataTable matchedSteps, string apiName)
        {
            DataColumn c0 = new DataColumn("Date (" + apiName + ")");
            DataColumn c1 = new DataColumn("Steps (HLWR) | Steps (" + apiName + ")");
            DataColumn c2 = new DataColumn("Points");

            DataColumn c10 = new DataColumn("Date (" + apiName + ")");
            DataColumn c11 = new DataColumn("Steps (" + apiName + ")");
            DataColumn c12 = new DataColumn("Date (HLWR)");
            DataColumn c13 = new DataColumn("Steps (HLWR)");

            unMatchedSteps.Columns.Add(c0);
            unMatchedSteps.Columns.Add(c1);
            unMatchedSteps.Columns.Add(c2);

            matchedSteps.Columns.Add(c10);
            matchedSteps.Columns.Add(c11);
            matchedSteps.Columns.Add(c12);
            matchedSteps.Columns.Add(c13);


            worker.ReportProgress(Convert.ToInt32(25), "Comparing Data!!");
            //Finding Matched Data
            for(int i=0; i<apiSteps.Count; i++)
            {
                for(int j=0; j<hlwrSteps.Count ; j++)
                {
                    if(hlwrSteps[j].StepsDate == apiSteps[i].StepsDate)
                    {
                        //Adding this condition in case there are steps from the API that have not been logged to Cerner HLWR.
                        if (Int32.Parse(hlwrSteps[j].StepsCount) >= Int32.Parse(apiSteps[i].StepsCount))
                        {
                            hlwrSteps[j].Pointer = i;
                            apiSteps[i].Pointer = j;
                            DataRow row = matchedSteps.NewRow();
                            row["Date (" + apiName + ")"] = apiSteps[i].StepsDate.ToString();
                            row["Steps (" + apiName + ")"] = apiSteps[i].StepsCount;
                            row["Date (HLWR)"] = hlwrSteps[j].StepsDate.ToString();
                            row["Steps (HLWR)"] = hlwrSteps[j].StepsCount.ToString();

                            matchedSteps.Rows.Add(row);
                        }
                        else
                        {
                            //logging the difference only to HLWR in case there is already an entry for it.
                            // In this scenario we will log the steps in the following format (original HLWR Step COunt / Difference in HLWR and API)
                            
                            
                            
                            apiSteps[i].StepsCount = hlwrSteps[j].StepsCount + " | " + (Int32.Parse(apiSteps[i].StepsCount) - Int32.Parse(hlwrSteps[j].StepsCount)).ToString();
                        }


                    }
                }
            }
            worker.ReportProgress(Convert.ToInt32(75), "Finding unmatched data");
            for (int i = 0; i < apiSteps.Count; i++)
            {
                if(apiSteps[i].Pointer == -1)
                {
                    newDataCount++;
                    DataRow row = unMatchedSteps.NewRow();
                    row["Date (" + apiName + ")"] = apiSteps[i].StepsDate.ToString();
                    row["Steps (HLWR) | Steps (" + apiName + ")"] = apiSteps[i].StepsCount;
                    


                    
                    int stepsCount = 0;

                    try
                    {
                        string[] stepCountSplit = apiSteps[i].StepsCount.Split('|');
                        if (stepCountSplit.Count() > 1)
                        {
                            stepsCount = Convert.ToInt32(stepCountSplit[0]) + Convert.ToInt32(stepCountSplit[1]);
                        }
                        else
                        {
                            stepsCount = Convert.ToInt32(stepCountSplit[0]);
                        }
                    }
                    catch
                    {
                        stepsCount = 0;
                    }
                    if(stepsCount > 5000 && stepsCount < 10000)
                    {
                        totalPointsAvailable++;
                        row["Points"] = "1";
                    }
                    else if (stepsCount > 10000 && stepsCount < 15000)
                    {
                        totalPointsAvailable += 2;
                        row["Points"] = "2";
                    }
                    else if (stepsCount > 15000 && stepsCount < 20000)
                    {
                        totalPointsAvailable += 3;
                        row["Points"] = "3";
                    }
                    else if (stepsCount > 20000)
                    {
                        totalPointsAvailable += 4;
                        row["Points"] = "4";
                    }
                    else
                    {
                        row["Points"] = "0";
                    }
                    unMatchedSteps.Rows.Add(row);
                }
            }
            worker.ReportProgress(Convert.ToInt32(100), "Finished Comparing");
        }
        private void processCernerHLWRData(BackgroundWorker worker)
        {
            driver.Navigate().GoToUrl("https://healtheatcernerportal.cerner.com/dt/nutr/pedometerentry.asp");
            
            //Click ALL Tab
            IWebElement graphTabsHeader = driver.FindElement(By.Id("GraphTabs"), 10);
            ReadOnlyCollection<IWebElement> graphTab = graphTabsHeader.FindElements(By.TagName("li"));
            graphTab[3].Click();

            ReadOnlyCollection<IWebElement> allPanelTables = driver.FindElement(By.Id("AllDataPanel")).FindElements(By.TagName("table"));
            ReadOnlyCollection<IWebElement> navTableTdTags = allPanelTables[1].FindElements(By.TagName("td"));

            String[] pages = navTableTdTags[2].Text.Split(' ');
            int totalPages = Convert.ToInt32(pages[2]);
            int dateFlag = 0;
            Double currentCount = 0;
            Double totalCount = totalPages * 20;
            for (int j = 0; j < totalPages; j++)
            {
                Thread.Sleep(1000);
                allPanelTables = driver.FindElement(By.Id("AllDataPanel"),3).FindElements(By.TagName("table"));
                navTableTdTags = allPanelTables[1].FindElements(By.TagName("td"));

                IWebElement tableAllData = driver.FindElement(By.Id("AllStepsHistory"));
                ReadOnlyCollection<IWebElement> trTagsAllData = tableAllData.FindElements(By.TagName("tr"));

                for (int i = 1; i < trTagsAllData.Count - 1; i++)
                {
                    ReadOnlyCollection<IWebElement> tdTagsAllData = trTagsAllData[i].FindElements(By.TagName("td"));
                    DateTime tdDate = Convert.ToDateTime(tdTagsAllData[0].Text);
                    currentCount++;
                    Double reportProg = ((double)currentCount / (double)totalCount) * 100;
                    worker.ReportProgress(Convert.ToInt32(reportProg), "Processing HLWR data, please wait !!");
                    if (tdDate < startOfYear)
                    {
                        dateFlag = 1;
                        break;
                    }
                    else
                    {
                        int stepsCount = int.Parse(tdTagsAllData[1].Text.Replace(",", ""));
                        Cerner_Healthe_Steps_Logger.Classes.steps stepsObj = new Classes.steps();

                        stepsObj.StepsDate = tdDate;
                        stepsObj.StepsCount = stepsCount.ToString();
                        stepsObj.Pointer = -1;

                        hlwrSteps.Add(stepsObj);
                    }

                    

                }

                if (j == 0)
                {
                    navTableTdTags[3].FindElement(By.TagName("a")).Click();
                }
                else if (j != totalPages - 1)
                {
                    navTableTdTags[5].FindElement(By.TagName("a")).Click();
                }
                else if(j== totalPages-1)
                {
                    worker.ReportProgress(Convert.ToInt32(100), "Finished processing data");
                }
                if(dateFlag == 1)
                {
                    worker.ReportProgress(Convert.ToInt32(100), "Finished processing data");
                    break;
                }
               
            }


        }


        private void processGoogleData(BackgroundWorker worker)
        {
            var lineCount = File.ReadLines(ofd.FileName).Count();
            using (TextFieldParser parser = new TextFieldParser(ofd.FileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                int lineNum = 0;


                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (lineNum > 0)
                    {
                        Double reportProg = ((double)lineNum / (double)lineCount) * 100;
                        worker.ReportProgress(Convert.ToInt32(reportProg), "Processing uploaded file, please wait!");


                
                        DateTime datefield = Convert.ToDateTime(fields[0]);
                        if (datefield >= startOfYear)
                        {
                            Cerner_Healthe_Steps_Logger.Classes.steps stepsObj = new Classes.steps();
                            stepsObj.StepsDate = datefield;
                            if (!fields[13].Equals(""))
                            {
                                stepsObj.StepsCount = (Convert.ToInt32(fields[13]) + STEPS_BUFFER).ToString();
                            }
                            else
                            {
                                stepsObj.StepsCount = (Convert.ToInt32("0")).ToString();
                            }
                            stepsObj.Pointer = -1;

                            apiSteps.Add(stepsObj);

                        }




                    }
                    lineNum++;
                }
            }
           
        }

        private void processAppleData(BackgroundWorker worker)
        {
            XmlDocument appleData = new XmlDocument();
            appleData.Load(ofd.FileName);

            XmlNodeList appleStepCount = appleData.GetElementsByTagName("Record");
            int count = 0;
            foreach(XmlNode step in appleStepCount)
            {
                
                if (step.Attributes["type"].Value.Equals("HKQuantityTypeIdentifierStepCount"))
                {
                    string tempDate = step.Attributes["startDate"].Value;
                    string[] tempDateSplit = tempDate.Split(' ');
                    DateTime date = Convert.ToDateTime(tempDateSplit[0]);

                    Double reportProg = ((double)count / (double)appleStepCount.Count) * 100;
                    worker.ReportProgress(Convert.ToInt32(reportProg), "Processing uploaded file, please wait!");

                    if(apiSteps.Count == 0)
                    {
                        Cerner_Healthe_Steps_Logger.Classes.steps appleStepsInst = new Classes.steps();
                        appleStepsInst.StepsDate = date;
                        appleStepsInst.StepsCount = step.Attributes["value"].Value;
                        appleStepsInst.Pointer = -1;
                        apiSteps.Add(appleStepsInst);
                        
                    }
                    else if(apiSteps[apiSteps.Count - 1].StepsDate == date)
                    {
                        apiSteps[apiSteps.Count - 1].StepsCount = (Convert.ToInt32(apiSteps[apiSteps.Count - 1].StepsCount) + Convert.ToInt32(step.Attributes["value"].Value)).ToString();
                    }
                    else
                    {
                        Cerner_Healthe_Steps_Logger.Classes.steps appleStepsInst = new Classes.steps();
                        appleStepsInst.StepsDate = date;
                        appleStepsInst.StepsCount = step.Attributes["value"].Value;
                        appleStepsInst.Pointer = -1;
                        apiSteps.Add(appleStepsInst);
                    }
                }
                count++;
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            logStepsBackgroundWork();
           
        }

        private void logStepsBackgroundWork()
        {
            BackgroundWorker stepsLoggerBW = new BackgroundWorker();
            stepsLoggerBW.WorkerReportsProgress = true;
            stepsLoggerBW.WorkerSupportsCancellation = true;
            stepsLoggerBW.DoWork += new DoWorkEventHandler(stepsLoggerBW_DoWork);
            stepsLoggerBW.ProgressChanged += new ProgressChangedEventHandler(stepsLoggerBW_ProgressChanged);
            stepsLoggerBW.RunWorkerCompleted += new RunWorkerCompletedEventHandler(stepsLoggerBW_RunWorkerCompleted);
            stepsLoggerBW.RunWorkerAsync();
        }

        private void stepsLoggerBW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            processMsgLab.ForeColor = Color.Green;
            processMsgLab.Text = "Logging steps completed. Please click Fetch Data again to make sure all your steps were logged.";
            resetApp();
        }

        private void stepsLoggerBW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            processMsgLab.ForeColor = Color.Red;
            processProgBar.Value = e.ProgressPercentage;
            processMsgLab.Text = e.UserState.ToString();
        }

        private void stepsLoggerBW_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int flag = 0;
            for (int i = 0; i < apiSteps.Count; i++)
            {
                int stepsCount = 0;
                string[] stepCountSplit = apiSteps[i].StepsCount.Split('|');
                if (stepCountSplit.Count() > 1)
                {
                    stepsCount = Convert.ToInt32(stepCountSplit[1]);
                }
                else
                {
                    stepsCount = Convert.ToInt32(stepCountSplit[0]);
                }

                if (apiSteps[i].Pointer == -1 && stepsCount > 0)
                {
                    try
                    {
                        //Thread.Sleep(5000);
                        driver.Navigate().GoToUrl("https://healtheatcernerportal.cerner.com/dt/nutr/PedometerEntry.asp");
                        IWebElement datePicker = driver.FindElement(By.Id("DatePickerText"), 2);
                        IWebElement steps = driver.FindElement(By.Id("steps"), 2);
                        IWebElement stride = driver.FindElement(By.Id("Stride"));

                        datePicker.Clear();
                        datePicker.SendKeys(apiSteps[i].StepsDate.Date.ToShortDateString());

                        
                        steps.SendKeys(stepsCount.ToString());
                        stride.Clear();
                        stride.SendKeys("2.5");

                        driver.FindElement(By.Name("btnSaveExercise")).Submit();
                        flag++;
                        Double reportProg = ((double)flag / (double)newDataCount) * 100;
                        worker.ReportProgress(Convert.ToInt32(reportProg), "Logging your steps...");
                    }
                    catch
                    {
                        //Something went wrong.

                    }
                    
                    
                }
            }
        }

        private void resetApp()
        {
            totalPointsAvailable = 0;
            apiSteps.Clear();
            hlwrSteps.Clear();
        }

        private void apiSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (apiSelect.Text.Equals("Apple Health Kit"))
            {
                apkPic.Image = Properties.Resources.Apple;
                apiTitle.Text = "Apple Health Kit";

            }
            else if (apiSelect.Text.Equals("Google Fit"))
            {
                apkPic.Image = Properties.Resources.Google;
                apiTitle.Text = "Google Fit";

            }
        }

        private void bufferStepsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            STEPS_BUFFER = (int)bufferStepsNumericUpDown.Value;
        }

        private void bufferStepsNumericUpDown_Enter(object sender, EventArgs e)
        {
            ToolTip buffertt = new ToolTip();
            buffertt.ToolTipTitle = "Buffer Steps";
            buffertt.IsBalloon = true;
            buffertt.SetToolTip(this.bufferStepsNumericUpDown, "Buffer steps can be a maximum value of 2000 to acount for steps \nnot counted when you are not wearing your fitness gear during the day");
            
        }

        private void healtheLogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            driver.Close();
        }

        private void debugModeOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(debugMode)
            {
                debugMode = false;
                ShowWindowAsync(chromeWin.MainWindowHandle, 0);
            }
            else
            {
                debugMode = true;
                ShowWindowAsync(chromeWin.MainWindowHandle, 1);
            }
        }

      
    }
}
