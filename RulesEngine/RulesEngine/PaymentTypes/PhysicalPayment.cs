using System;
using RulesEngine.Helper;
using RulesEngine.Interfaces;

namespace RulesEngine.PaymentTypes
{
    public class PhysicalPayment : IRulesContext,ICommission
    {
        /// <summary>
        /// Processs Physical Payments
        /// </summary>
        public void Process()
        {
            Console.WriteLine("Physical Processing");
            GeneratePackingSlip();
            GenerateCommission();
        }

        /// <summary>
        /// Generate Packaging Slip
        /// </summary>
        private void GeneratePackingSlip()
        {
            Console.WriteLine("Generated Packing Slip");
        }

        /// <summary>
        /// Generate Commision
        /// </summary>
        public void GenerateCommission()
        {
            HelperService.GenerateCommission();
        }

    }
}
