using System;


namespace SalesWebMvc.Views.Sellers.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message) 
        {
        }
    }
}
