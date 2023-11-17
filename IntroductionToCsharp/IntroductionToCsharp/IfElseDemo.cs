using System;

namespace IntroductionToCsharp
{
    public class IfElseDemo
    {
        public IfElseDemo()
        {

        }

        public void ifelsedemo()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num == 10)
            {
                Console.WriteLine("Number is {0}", num);
            }
            else if(num == 20)
            {
                Console.WriteLine("Number is {0}", num);
            }
            else if (num == 30)
            {
                Console.WriteLine("Number is {0}", num);
            }
            else if (num == 40)
            {
                Console.WriteLine("Number is {0}", num);
            }
            else
            {
                Console.WriteLine("Number is not between 10 to 40");
            }
        }
    }
}
