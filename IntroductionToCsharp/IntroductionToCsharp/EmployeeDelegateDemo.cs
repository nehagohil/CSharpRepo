using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class EmployeeDelegateDemo
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void EmployeePromotion(List<EmployeeDelegateDemo> emplist )
        {
            foreach (var emp in emplist)
            {
                if(emp.Experience >= 5)
                {
                    Console.WriteLine( emp.Name + " Promoted..!!");
                }
            }

        }
    }
}
