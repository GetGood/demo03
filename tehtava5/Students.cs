using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava5
{
    class Students
    {
        // properties

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string StudentID { get; set; }
        public int Age { get; set; }
        public string Courses { get; set; }

        // constructors

        public Students(string firstname)
        {
            Firstname = firstname;
        }

        // methods

        public void PrintData()
        {
            Console.WriteLine("Information about the student: ");
            Console.WriteLine("First name: " + Firstname);
            Console.WriteLine("Last name: " + Lastname);
            Console.WriteLine("Student ID: " + StudentID);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Courses: " + Courses);
        }
        public void TakeCourse()
        {
            Console.WriteLine("Give the name of the course:  type 0 to quit or move to next student");
            string coursetoadd = Console.ReadLine();
            while (true){
                if (coursetoadd != "0")
                {

                    Courses += coursetoadd;
                    Courses += ",";
                    Console.WriteLine("Course added!");
                    coursetoadd = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("exiting..");
                    break;
                }
            }
        }
    }
}