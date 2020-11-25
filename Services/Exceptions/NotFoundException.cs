using System;

namespace Sales_ASPNET_Core.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) 
            : base(message)
        {
        }
    }
}
