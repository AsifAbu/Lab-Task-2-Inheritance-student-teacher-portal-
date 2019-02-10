using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTaskProblem2
{
    class OffsiteCourse
    {
        string town;
        public OffsiteCourse(string a)
        {
            this.town = a;
        }
        public OffsiteCourse()
        {
            this.town = "0";
        }
        public string Town
        {
            set { this.town = value; }
            get { return town; }
        }
    }
}
