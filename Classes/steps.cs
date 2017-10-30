using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerner_Healthe_Steps_Logger.Classes
{
    class steps
    {
        private DateTime stepsDate;

        public DateTime StepsDate
        {
            get { return stepsDate; }
            set { stepsDate = value; }
        }
        private string stepsCount;

        public string StepsCount
        {
            get { return stepsCount; }
            set { stepsCount = value; }
        }

        

        private int pointer;

        public int Pointer
        {
            get { return pointer; }
            set { pointer = value; }
        }

    }
}
