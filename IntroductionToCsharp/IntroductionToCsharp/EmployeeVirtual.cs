using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class EmployeeVirtual
    {
        public string firstname = "FN";
        public string lastname = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(firstname +" "+ lastname);
        }
    }

    public class FullTimeVirtualEmployee : EmployeeVirtual
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstname + " " + lastname + "- Full Time");
        }
    }
    public class PartTimeVirtualEmployee : EmployeeVirtual
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstname + " " + lastname + "- Part Time");
        }
    }
    public class TemporaryVirtualEmployee : EmployeeVirtual
    {
        public override void PrintFullName()
        {
            Console.WriteLine(firstname + " " + lastname + "- Temporary");
        }
    }
}
