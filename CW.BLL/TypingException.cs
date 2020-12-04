using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CW.BLL
{
    [Serializable]
    internal class TypingException:Exception
    {
        public TypingException()
        {
        }

        public TypingException(string message) : base(message)
        {
        }

        public TypingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TypingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
