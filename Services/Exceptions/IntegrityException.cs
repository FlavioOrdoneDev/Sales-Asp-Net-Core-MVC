using System;

namespace Sales_ASPNET_Core.Services.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string message)
            : base(message)
        {

        }
    }
}
