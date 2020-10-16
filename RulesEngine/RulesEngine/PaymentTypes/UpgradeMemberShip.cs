using System;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class UpgradeMemberShip : IRulesContext,IEmail
    {
        /// <summary>
        /// Processs Upgrade MemberShip 
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Upgrade MemberShip Processing");
            SendEmail();
        }

        public void SendEmail()
        {
            Helper.HelperService.SendEmail();
        }

    }
}
