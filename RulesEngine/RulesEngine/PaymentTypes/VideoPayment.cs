using System;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class VideoPayment : IRulesContext
    {
        /// <summary>
        /// Processs VideoPayments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Video Processing");
        }           
    }
}
