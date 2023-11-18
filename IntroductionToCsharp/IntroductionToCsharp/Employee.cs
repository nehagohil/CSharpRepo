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
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
        public void printsal()
        {
            Console.WriteLine(hourlyRate);
        }
    }
}
