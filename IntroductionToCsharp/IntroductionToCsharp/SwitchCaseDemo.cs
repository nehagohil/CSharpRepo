using System;


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
    }
}
