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

        //public override string ToString()
        //{
        //    return this.Firstname + " " + this.Lastname;
        //}

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is CustomerToString))
            {
                return false;
            }


            return this.Firstname == ((CustomerToString)obj).Firstname && this.Lastname == ((CustomerToString)obj).Lastname;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
    }
}
