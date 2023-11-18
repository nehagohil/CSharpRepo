using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class MethodOverloadingDemo
    {

        public void add (int Fn, int Sn, int Tn)
        {
            Console.WriteLine(Fn+Sn+Tn);
        }

        public void add(int fn, int sn)
        {
            Console.WriteLine(fn+sn);
            
        }
    }
}
