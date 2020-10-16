using System;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class MemberShipPayment : IRulesContext
    {
        /// <summary>
        /// Processs MemberShip Payments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Activated Membership");
        }          
    }
}
