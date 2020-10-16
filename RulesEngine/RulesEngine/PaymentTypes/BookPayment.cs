using System;

namespace RulesEngine.PaymentTypes
{
    /// <summary>
    /// Book Payment Type
    /// </summary>
    public class BookPayment : Interfaces.IRulesContext
    {
        /// <summary>
        /// Process Book Payments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Book Processing");         
        }      
    }
}
