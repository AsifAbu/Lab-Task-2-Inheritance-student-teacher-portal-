using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTaskProblem2
{
    public class Teacher
    {
        public string name;
        List<string> courseList = new List<string>();
        public Teacher(string name)
        {
            this.name = name;

        }
        public void Add_Course(object a)
        {
            this.courseList.Add(((Course)a).name);
        }
        
        public void fff(string a)
        {
            this.name = a;
        }
        public void ToString_Teacher_Course()
        {
            if (courseList.Count <= 0)
            {
                Console.WriteLine("Teacher Name : " + this.name+" has Added No Courses.");
            }
            else
            {
                Console.WriteLine("Teacher Name : " + this.name);
                Console.Write("Courses : [");
                for (int i = 0; i < courseList.Count; i++)
                {
                    Console.Write(courseList[i]+", ");
                }
                Console.WriteLine("]");
            }
        }
    }
}
