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
            //int start = 0;
            //Console.WriteLine("Please enter the number limit for even numbers :");
            //int limit = Convert.ToInt32(Console.ReadLine());

            //while(start <= limit)
            //{
            //    Console.WriteLine(start);
            //    start += 2;
            //}

            //do while loop
            string UserChoice = string.Empty;
            
            do
            {
                Console.WriteLine("Please enter the number limit for even numbers :");
                int limit = Convert.ToInt32(Console.ReadLine());
                int start = 0;
                while (start <= limit)
                {
                    Console.WriteLine(start);
                    start += 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue ? yes/no");
                    UserChoice = Console.ReadLine().ToLower();
                    if(UserChoice != "yes" && UserChoice !="no")
                    {
                        Console.WriteLine("Your entered choice is incorrect..");
                    }

                } while (UserChoice != "yes" && UserChoice != "no");
            } while (UserChoice == "yes");
        }
    }
}
