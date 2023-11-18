using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class StudentGetterSetterDemo
    {
        private int _id;
        private string _name;
        private int _passmarks;

        public void SetId(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Id shouldn't be negative and zero");
            }
            else
            {
                this._id = id;
            }
            
        }
        public int GetId()
        {
            return this._id;
        }

        public void SetName(string name)
        {
           if (name == null)
            {
                throw new Exception("Name shouldn't be null");
            }
            else
            {
                this._name = name;
            }

        }
        public string GetName()
        {
            return this._name;
        }
        public int GetPassMarks()
        {
            return 35;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Id is :"+_id);
            Console.WriteLine("Name is :" + _name);
            Console.WriteLine("Passmarks is :" + _passmarks);
        }
    }
}
