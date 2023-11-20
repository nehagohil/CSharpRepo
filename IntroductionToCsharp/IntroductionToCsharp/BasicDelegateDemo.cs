using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public delegate void HelloDelegate(string strdel);
    class BasicDelegateDemo
    {
       
        public static void Hello(string strmessage)
        {
            Console.WriteLine(strmessage);
        }
    }
}
