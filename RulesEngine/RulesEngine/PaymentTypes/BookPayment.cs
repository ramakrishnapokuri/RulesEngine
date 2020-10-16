using System;
using RulesEngine.Helper;
using RulesEngine.Interfaces;
namespace RulesEngine.PaymentTypes
{
    /// <summary>
    /// Book Payment Type
    /// </summary>
    public class BookPayment : IRulesContext,ICommission
    {
        /// <summary>
        /// Process Book Payments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Book Processing");
            CreateDuplicateSlip();
            GenerateCommission();
        }

        /// <summary>
        /// Duplicated Slip Creator
        /// </summary>
        private void CreateDuplicateSlip()
        {
            Console.WriteLine("Created Duplicate Slip");
        }

        /// <summary>
        /// Generate Commission
        /// </summary>
        public void GenerateCommission()
        {
            HelperService.GenerateCommission();
        }
    }
}
