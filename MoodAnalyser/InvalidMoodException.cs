﻿using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    internal class InvalidMoodException : Exception
    {
        public InvalidMoodException()
        {
        }

        public InvalidMoodException(string? message) : base(message)
        {
        }

        public InvalidMoodException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidMoodException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}