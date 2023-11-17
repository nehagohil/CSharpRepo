using System;

namespace IntroductionToCsharp
{
    public class LoopDemo
    {
        public LoopDemo()
        {

        }

        public void loopsdemo()
        {
            //while loop
            int start = 0;
            Console.WriteLine("Please enter the number limit for even numbers :");
            int limit = Convert.ToInt32(Console.ReadLine());
            
            while(start <= limit)
            {
                Console.WriteLine(start);
                start += 2;
            }
        }
    }
}
