using System;

namespace Sales_ASPNET_Core.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {
        public DbConcurrencyException(string message) 
            : base(message)
        {
        }
    }
}
