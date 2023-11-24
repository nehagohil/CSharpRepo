using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class Customr : IComparable<Customr>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }

        
        public int CompareTo(Customr other)
        {
            return this.salary.CompareTo(other.salary);
            //if(this.salary > other.salary)
            //{
            //    return 1;
            //}
            //else if(this.salary < other.salary)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}
        }
    }

    //public class SortByName : IComparer<Customr>
    //{
    //    public int Compare(Customr x, Customr y)
    //    {
    //        return x.Name.CompareTo(y.Name);
    //    }
    //}
    public class SortByName
    {
        public static int CompareCustomer(Customr x, Customr y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }
}
