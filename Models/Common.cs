
using System;

namespace StudentAPI
{
    public class Common : ICommon
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public Common() { Message = string.Empty; IsSuccess = false; }
        public Common(string msg, bool success)
        {
            Message = msg;
            IsSuccess = success;
        }

        public void SetError(string msg)
        {
            Message = msg;
            IsSuccess = false;
        }

        public void SetSuccess(string msg)
        {
            Message = msg;
            IsSuccess = false;
        }
        public void SetSuccess<T>(string msg) where T : class
        {
            Message = $"{typeof(T)} {msg}"; //string.Format(msg,typeof(T))
            IsSuccess = false;
        }
        public void SetError<T>(string msg) where T : class
        {
            Message = string.Format(msg, typeof(T));
            IsSuccess = false;
        }
    }

    public class APIConnectionString
    {
        public string AppDBConnection { get; set; }
    }

    public class StudentAPIException : System.Exception
    {
        static readonly string DefaultMessage = "Error occured in Student API";
        public StudentAPIException():base(DefaultMessage) { }
        public StudentAPIException(string message) : base(message)
        {
            ErrLogger.LogMessage($"An exception has occurred in the API controller {message}",ErrLogger.LogType.ERROR);
        }
        public StudentAPIException(string message, System.Exception inner) : base(message, inner)
        {
            ErrLogger.LogMessage($"An exception has occurred in the API controller {message}\nStackTrace: {Convert.ToString(inner)}",ErrLogger.LogType.ERROR);
        }
    }
}