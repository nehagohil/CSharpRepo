using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class ConstructorInvocationDemo
    {
        public ConstructorInvocationDemo()
        {
            Console.WriteLine("This is parent class constructor");
        }
    }

    public class ConstructorInvocationDemoChild : ConstructorInvocationDemo
    {
        public ConstructorInvocationDemoChild()
        {
            Console.WriteLine("This is child class constructor");
        }
    }

}
