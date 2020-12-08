using System;

namespace Exercise_039_Bank_account_with_exception_handling.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
