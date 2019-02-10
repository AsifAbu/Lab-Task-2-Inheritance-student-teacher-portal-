using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTaskProblem2
{
    class CampusCourse
    {
        string labNumber;
        public string LabNumber
        {
            set{this.labNumber = value;}
            get{return labNumber;}
        }
        public CampusCourse(string a)
        {
            this.labNumber = a;
        }
        public CampusCourse()
        {
            this.labNumber = "0";
        }
    }
}
