using System.Runtime.Serialization;

namespace ConceptsPOO
{
    [Serializable]
    internal class DateException : Exception
    {
        public DateException()
        {
        }

        public DateException(string message) : base(message)
        {
        }

        public DateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}