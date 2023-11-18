using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    interface IInterfaceDemo
    {
        void PrintMessage();
    }
    interface IInterfaceDemo1 : IInterfaceDemo
    {
        void PrintMessagefromsecondinterface();
    }
    public class InterfaceDemo : IInterfaceDemo1
    {
        public void PrintMessage()
        {
            Console.WriteLine("Printing message from the class for the first interface");
        }
        public void PrintMessagefromsecondinterface()
        {
            Console.WriteLine("Printing message from the class for the second interface");
        }
    }
}
