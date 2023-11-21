using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public abstract class AbstractClassDemo
    {
        public abstract void Print();
    }

    public class derived : AbstractClassDemo
    {
        public override void Print()
        {
            Console.WriteLine("Hello from derived class implemented abstract method");
        }
    }
}
