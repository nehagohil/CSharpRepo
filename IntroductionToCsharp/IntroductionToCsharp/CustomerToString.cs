using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class CustomerToString
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
