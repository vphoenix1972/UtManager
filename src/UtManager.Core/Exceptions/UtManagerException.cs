using System;

namespace UtManager.Core.Exceptions
{
    public class UtManagerException : Exception
    {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public UtManagerException()
        {
            Code = UtManagerErrorCode.UnknownError;
        }

        public UtManagerException(string message) : base(message)
        {
            Code = UtManagerErrorCode.UnknownError;
        }

        public UtManagerException(UtManagerErrorCode code)
        {
            Code = code;
        }

        public UtManagerException(UtManagerErrorCode code, string message) : base(message)
        {
            Code = code;
        }

        public UtManagerException(string message, Exception inner) : base(message, inner)
        {
            Code = UtManagerErrorCode.UnknownError;
        }

        public UtManagerErrorCode Code { get; }
    }
}