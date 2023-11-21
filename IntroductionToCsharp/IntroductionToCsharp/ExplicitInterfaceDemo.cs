using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    interface I1
    {
        void interfaceMethod();
    }

    interface I2
    {
        void interfaceMethod();
    }
    public class ExplicitInterfaceDemo : I1, I2
    {
        void I1.interfaceMethod()
        {
            Console.WriteLine("This is from I1 interface");
        }
        void I2.interfaceMethod()
        {
            Console.WriteLine("This is from I2 interface");
        }
    }
    
}
