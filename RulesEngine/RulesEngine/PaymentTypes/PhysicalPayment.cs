using System;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class PhysicalPayment : IRulesContext
    {
        /// <summary>
        /// Processs Physical Payments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Physical Processing");
        }

    }
}
