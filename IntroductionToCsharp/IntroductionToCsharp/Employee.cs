using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class Employee
    {
        public string firstname;
        public string lastname;
        public string email;

        public void PrintFullname()
        {
            Console.WriteLine(firstname+" "+lastname);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlysalary;
        public void printsal()
        {
            Console.WriteLine(yearlysalary);
        }
        /// <summary>
        /// This method is for demonstrating the method hiding demo using new keyword
        /// </summary>
        public new void PrintFullname()
        {
            //base.PrintFullname();
            Console.WriteLine(firstname + " " + lastname +" - Full Time");
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
        public void printsal()
        {
            Console.WriteLine(hourlyRate);
        }
        /// <summary>
        /// This method is for demonstrating the method hiding demo using new keyword
        /// </summary>
        public new void PrintFullname()
        {
            Console.WriteLine(firstname + " " + lastname + " - Part Time");
        }
    }
}
