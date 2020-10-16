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

            RulesContext obj1 = new RulesContext(new PhysicalPayment());
            obj1.Process();

            RulesContext obj2 = new RulesContext(new MemberShipPayment());
            obj2.Process();

            RulesContext obj3 = new RulesContext(new UpgradeMemberShip());
            obj3.Process();

            RulesContext obj4 = new RulesContext(new VideoPayment());
            obj4.Process();
          

            Console.ReadLine();
        }
    }
}
