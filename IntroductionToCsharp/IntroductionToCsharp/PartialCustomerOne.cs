using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public partial class PartialCustomer
    {
        private string _Firstname;
        private string _Lastname;

        public string Firstname
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }
        public string Lastname
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }
    }
}
