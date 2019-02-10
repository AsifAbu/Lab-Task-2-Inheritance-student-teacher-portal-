using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLabTaskProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            CampusCourse campuscourse = new CampusCourse("LAB-6");
            OffsiteCourse offsitecourse = new OffsiteCourse("BANANI");
            Teacher teacher = new Teacher("Stany");
            Teacher teacher2 = new Teacher("Rozario");

            Course c1 = new Course("C#",teacher,campuscourse);
            Course c2 = new Course("JAVA", teacher2, campuscourse);

            c1.AddTopic("gui design, basic c sharp, project etc.");
            c2.AddTopic("gui, basic JAVA, JAVA project etc.");

            c1.ToString_();
            c2.ToString_();

            teacher.Add_Course(c1);
            teacher2.Add_Course(c2);

            teacher.ToString_Teacher_Course();
            teacher2.ToString_Teacher_Course();

            Console.ReadLine();
        }
    }
}
