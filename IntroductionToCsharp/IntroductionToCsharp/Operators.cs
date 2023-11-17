using System;

namespace IntroductionToCsharp
{
    public class Operators
    {
        public Operators()
        {

        }
       public void operations()
        {
            int number = 10;
            int anothernumber = 20;

            //Console.WriteLine("Addition is  :" + (number + anothernumber));
            //Console.WriteLine("Substraction is  :"+ (number - anothernumber));
            //Console.WriteLine("Multiplication is :" + (number * anothernumber));
            //Console.WriteLine("Division is  :" + (anothernumber / number));

            bool IsNumber = number == 10 ? true : false;
            Console.WriteLine("Number == 10 {0}", IsNumber);


        }
    }
}
