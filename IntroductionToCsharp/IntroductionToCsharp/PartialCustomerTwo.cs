using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public partial class PartialCustomer
    {
        public string GetFullName()
        {
            return _Firstname + ", " + _Lastname;
        }
    }
}
