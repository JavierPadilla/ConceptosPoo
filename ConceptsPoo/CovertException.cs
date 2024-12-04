using System.Runtime.Serialization;

namespace ConceptsPoo
{
    [Serializable]
    internal class CovertException : Exception
    {
        public CovertException()
        {
        }

        public CovertException(string? message) : base(message)
        {
        }

        public CovertException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CovertException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}