using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public partial class PartialMethodClass1
    {
        partial void PartialMethod();
        partial void PartialMethod()
        {
            Console.WriteLine("Hello from the partial method");
        }

        public void PrintMessage()
        {
            Console.WriteLine("Hello from the Nonpartial method");
            PartialMethod();
        }
    }
}
