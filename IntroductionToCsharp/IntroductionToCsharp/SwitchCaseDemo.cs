using System;
using System.Security.Cryptography.X509Certificates;

namespace IntroductionToCsharp
{
    public class SwitchCaseDemo
    {
        public SwitchCaseDemo()
        {

        }
        public void SwitchDemo()
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            switch(num)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("The number is {0}",num);
                    break;
                default:
                    Console.WriteLine("The number is not between 10-30");
                    break;
            }
 
        }

        public void GotoDemo()
        {
            int TotalCoffeeCost = 0;
            start:
            Console.WriteLine("Please select your coffee. : 1 - small, 2 - medium, 3 - large ");
            int userchoice = Convert.ToInt32(Console.ReadLine());

            switch(userchoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
                case 2:
                    TotalCoffeeCost += 2;
                    break;
                case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice is invalid {0}", userchoice);
                    goto start;
            }
        Decide:
            Console.WriteLine("Do you want to buy another coffee ? YES/NO");
            string response = Console.ReadLine();
            switch (response.ToUpper())
            {
                case "YES":
                    goto start;
                    break;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your entered choice is incorrect {0}",response);
                    break;
            }

            Console.WriteLine("Thank you for shopping with us.....");
            Console.WriteLine("Bill Amount is {0}",TotalCoffeeCost);
        }

    }
}
