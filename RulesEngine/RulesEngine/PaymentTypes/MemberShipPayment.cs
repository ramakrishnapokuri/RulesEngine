using System;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class MemberShipPayment : IRulesContext,IEmail
    {
        /// <summary>
        /// Processs MemberShip Payments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Activated Membership");
            SendEmail();
        }

        /// <summary>
        /// send Mail
        /// </summary>
        public void SendEmail()
        {
            Helper.HelperService.SendEmail();
        }
    }
}
