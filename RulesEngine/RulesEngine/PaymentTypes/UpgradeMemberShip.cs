using System;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class UpgradeMemberShip : IRulesContext
    {
        /// <summary>
        /// Processs Upgrade MemberShip 
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Upgrade MemberShip Processing");
        }
         
    }
}
