using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public struct StudentStructDemo
    {
        private int _id;
        private string _name;

        public StudentStructDemo(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public int Id 
        {   
            get { return this._id; } 
            set { this._id = value; } 
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public void PrintName()
        {
            Console.WriteLine("Id = {0} and Name = {1}",Id,Name);
        }
    }
}
