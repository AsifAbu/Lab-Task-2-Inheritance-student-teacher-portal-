using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTaskProblem2
{
    class Course
    {
        public string name, courseTopics;
        Teacher t;
        static int count = 0,r=0,s=0;
        CampusCourse cc = new CampusCourse();
        OffsiteCourse ofc = new OffsiteCourse();
        public Course(string name, Teacher t, CampusCourse cc)
        {
            this.name = name;
            this.t = t;
            this.cc = cc;
        }
        public Course(Course a)
        {
            this.name = a.name;
        }
        public Course(string name, Teacher t,OffsiteCourse of)
        {
            this.name = name;
            this.t = t;
            this.ofc = of;
        }
        public void AddTopic(string a)
        {
            this.courseTopics += a;
        }

        public string ShowTopic()
        {
            return this.courseTopics;
        }

        public void ToString_()
        {
            if(ofc.Town.Equals("0"))
            {
                Console.WriteLine("Campus Course: Name=" + name + "; Teacher=" + t.name + "; Topics= [" + this.ShowTopic() + "; Lab=" + cc.LabNumber + "]");
            }
            else
            {
                Console.WriteLine("Offsite Course: Name=" + name + "; Teacher=" + t.name + "; Topics= [" + this.ShowTopic() + "; Town=" + ofc.Town + "]");
            }
        }
    }
}
