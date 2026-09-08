using System.Runtime.Serialization;
using UltimateCourse;

throw new CustomException();

namespace UltimateCourse
{
    [Serializable]
    public class CustomException : Exception
    {
        public int StatusCode { get; }

        protected CustomException(SerializationInfo info, StreamingContext context)
        {
        }

        public CustomException()
        {
        }

        public CustomException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public CustomException(string message, int statusCode, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}