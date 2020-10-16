using RulesEngine.PaymentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            RulesContext obj = new RulesContext(new BookPayment());
            obj.Process();

            Console.ReadLine();
        }
    }
}
