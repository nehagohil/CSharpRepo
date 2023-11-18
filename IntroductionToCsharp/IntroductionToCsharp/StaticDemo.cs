using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class StaticDemo
    {
         static float _pi;
         int _radius;
        
        static StaticDemo()
        {
            Console.WriteLine("Static constructor called..");
            StaticDemo._pi = 3.14f;
        }
        public StaticDemo(int radius)
        {
            Console.WriteLine("Instance constructor called..");
            this._radius = radius;
        }
         public float calculateArea()
        {
            float areaofcircle = _pi * _radius * _radius;
            return areaofcircle;
        }
    }
}
