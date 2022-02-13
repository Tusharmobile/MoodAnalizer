using System;
using System.Runtime.Serialization;

namespace MoodAnalizerTest
{
    [Serializable]
    internal class MoodAnalyzerException : Exception
    {
        public MoodAnalyzerException()
        {
        }

        public MoodAnalyzerException(string message) : base(message)
        {
        }

        public MoodAnalyzerException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyzerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}