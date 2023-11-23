using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class Customer
    {
        string _firstname;
        string _lastname;

        //public Customer(): this("No firstname","No lastname")
        //{

        //}
        //public Customer(string firstname, string lastname)
        //{
        //    this._firstname = firstname;
        //    this._lastname = lastname;
        //}

        //~Customer()
        //{

        //}
        public void PrintFullname(string firstname, string lastname)
        {

            Console.WriteLine("FullName is {0}", firstname + " " + lastname);
        }
    }
    

       
   }

