using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class EmployeeIndexer
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }
    }

    public class CompanyIndexer
    {
        private List<EmployeeIndexer> ListEmployees = new List<EmployeeIndexer>();

        public CompanyIndexer()
        {
            ListEmployees.Add(new EmployeeIndexer() { EmployeeId = 1, Name = "tarun", Gender = "male" });
            ListEmployees.Add(new EmployeeIndexer() { EmployeeId = 2, Name = "snehal", Gender = "female" });
            ListEmployees.Add(new EmployeeIndexer() { EmployeeId = 3, Name = "shashi", Gender = "female" });
            ListEmployees.Add(new EmployeeIndexer() { EmployeeId = 4, Name = "Suyash", Gender = "male" });
            ListEmployees.Add(new EmployeeIndexer() { EmployeeId = 5, Name = "bhumi", Gender = "female" });
            ListEmployees.Add(new EmployeeIndexer() { EmployeeId = 6, Name = "viraj", Gender = "male" });
        }

        public string this[int id]
        {
            get
            {
                return ListEmployees.FirstOrDefault(emp => emp.EmployeeId == id).Name;
            }
            set
            {
                ListEmployees.FirstOrDefault(emp => emp.EmployeeId == id).Name = value;
            }
        }
    }
}
