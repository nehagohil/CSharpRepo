using System;

namespace IntroductionToCsharp
{
    public class MethodDemo
    {
        public MethodDemo()
        {

        }
        public static void EvenNumbers(int target)
        {
            int start = 0;

            for (int i=0; i<= target; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public int sum(int fn, int sn)
        {
            return fn+sn;
        }

        public static void refvalue(ref int j)
        {
            j = 101;
        }

        public static void calculate(int fn, int sn, out int sum, out int product)
        {
            sum = fn + sn;
            product = fn * sn;
        }
    }
}
