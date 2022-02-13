using System;
using System.Runtime.Serialization;

namespace MoodAnalyzer
{
    [Serializable]
    internal class MoodAnalyzerException : Exception
    {
        private object eMPTY_EXCEPTION;
        private string v;

        public MoodAnalyzerException()
        {
        }

        public MoodAnalyzerException(string message) : base(message)
        {
        }

        public MoodAnalyzerException(object eMPTY_EXCEPTION, string v)
        {
            this.eMPTY_EXCEPTION = eMPTY_EXCEPTION;
            this.v = v;
        }

        public MoodAnalyzerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyzerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}