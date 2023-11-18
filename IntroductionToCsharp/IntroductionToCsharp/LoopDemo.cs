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
            //string UserChoice = string.Empty;
            
            //do
            //{
            //    Console.WriteLine("Please enter the number limit for even numbers :");
            //    int limit = Convert.ToInt32(Console.ReadLine());
            //    int start = 0;
            //    while (start <= limit)
            //    {
            //        Console.WriteLine(start);
            //        start += 2;
            //    }
            //    do
            //    {
            //        Console.WriteLine("Do you want to continue ? yes/no");
            //        UserChoice = Console.ReadLine().ToLower();
            //        if(UserChoice != "yes" && UserChoice !="no")
            //        {
            //            Console.WriteLine("Your entered choice is incorrect..");
            //        }

            //    } while (UserChoice != "yes" && UserChoice != "no");
            //} while (UserChoice == "yes");

            //For loop

            //for(int i=0; i<=10;i++)
            //{
            //    if(i % 2==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //foreach loop
            int[] arr = new int[4];
            arr[0] = 5;
            arr[1] = 9;
            arr[2] = 12;
            arr[3] = 15;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
