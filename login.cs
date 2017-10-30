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

namespace Cerner_Healthe_Steps_Logger
{
    public partial class login : Form
    {
        private IWebDriver driver;
        private string cernerHealthUrl;

        public login()
        {
            InitializeComponent();
        }
        public login(IWebDriver driver, string cernerHealthUrl)
        {
            InitializeComponent();
            this.driver = driver;
            userTextBox.Text = Environment.UserName;
            this.cernerHealthUrl = cernerHealthUrl;
            
        }
        private void loginBt_Click(object sender, EventArgs e)
        {
            failLab.Visible = false;
            loginLab.Visible = true;
            Application.DoEvents();
            driver.Navigate().GoToUrl(cernerHealthUrl);
            IWebElement loginForm = driver.FindElement(By.Id("login-form"));
            loginForm.FindElement(By.Id("login_username")).SendKeys(userTextBox.Text);
            loginForm.FindElement(By.Id("login_password")).SendKeys(passTextBox.Text);
            loginForm.FindElement(By.TagName("button")).Submit() ;

            IWebElement loginError = driver.FindElement(By.ClassName("topia-UserName"), 2);
            
            if(loginError == null)
            {
                failLab.Visible = true;
                loginLab.Visible = false;
            }
            else
            {
                this.Close();
            }
            
            
            
        }

        private void passTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                loginBt.PerformClick();
            }
        }
    }
}
