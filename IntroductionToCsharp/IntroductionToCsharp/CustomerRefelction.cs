using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class CustomerRefelction
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public CustomerRefelction()
        {
            this.ID = -1;
            this.Name = string.Empty;
        }
        public CustomerRefelction(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public void printid()
        {
            Console.WriteLine("Id = {0}",this.ID);
        }
        public void printname()
        {
            Console.WriteLine("Id = {0}", this.Name);
        }

    }
}
