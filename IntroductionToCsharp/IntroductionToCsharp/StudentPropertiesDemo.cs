using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class StudentPropertiesDemo
    {
        private int _id;
        private string _name;
        private int _passmarks = 35;
        public int id
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Value souldn't be negative and zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string name
        {
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name shouldn't be null");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }
        public int marks
        {
            get
            {
                return this._passmarks;
            }
        }
    }
}
