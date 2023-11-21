using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace IntroductionToCsharp
{
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base()
        {

        }
        public UserAlreadyLoggedInException(string message) : base(message)
        {

        }
        public UserAlreadyLoggedInException(string message, Exception innerException)
        {

        }
        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context ) : base(info,context)
        {

        }
    }
}
