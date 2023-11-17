using System;

namespace IntroductionToCsharp
{
    public class DatatypeConversion
    {
        public DatatypeConversion()
        {

        }

        public void ConversionDemo()
        {
            //float fvalue = 123.45F;

            //int ivalue = (int)fvalue;

            //Console.WriteLine(ivalue);

            //for string

            string str = "100";
            //int convertstrtoint = int.Parse(str);
            bool IsConvertible = int.TryParse(str , out int result);
            Console.WriteLine(IsConvertible);
        }
    }
}
