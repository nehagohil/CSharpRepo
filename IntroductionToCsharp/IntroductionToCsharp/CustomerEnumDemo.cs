using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class CustomerEnumDemo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public static string GetGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.unknown:
                    return "Unknown";

                case Gender.male:
                    return "male";

                case Gender.female:
                    return "female";

                default:
                    return "Invalid data detected";
            }
        }
    }
    
    
    public enum Gender
    {
        unknown,
        male,
        female
    }

}
