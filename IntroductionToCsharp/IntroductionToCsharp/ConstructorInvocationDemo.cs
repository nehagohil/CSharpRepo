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
        public ConstructorInvocationDemo(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ConstructorInvocationDemoChild : ConstructorInvocationDemo
    {
        public ConstructorInvocationDemoChild() : base("I am calling base class parameterizec constructor from the child class")
        {
            Console.WriteLine("This is child class constructor");
        }
    }

}
