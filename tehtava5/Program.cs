using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava5
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] array1 = new object[3];

            Students student1 = new Students("Jorma");
            student1.Lastname = "Jorakainen";
            student1.Age = 21;
            student1.StudentID = "00201";
            student1.TakeCourse();
            array1[0] = student1;

            Students student2 = new Students("Kata");
            student2.Lastname = "Kaerkkaeinen";
            student2.Age = 65;
            student2.StudentID = "41222";
            student2.TakeCourse();
            array1[1] = student2;

            Students student3 = new Students("Make");
            student3.Lastname = "ItStop";
            student3.Age = 3;
            student3.StudentID = "27603";
            student3.TakeCourse();
            array1[2] = student3;

            foreach (Students student in array1)
            {
                student.PrintData();
            }

        }
    }
}