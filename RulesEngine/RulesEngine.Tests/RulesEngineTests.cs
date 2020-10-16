using RulesEngine.PaymentTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RulesEngine.Tests
{
    [TestClass]
    public class RulesEngineTests
    {
        [TestMethod]
        public void Should_Crerate_RulesContext()
        {
            RulesContext rc = new RulesContext(new BookPayment());
            Assert.IsNotNull(rc);
        }

        public void Should_Create_PhysicalPayment()
        {
            RulesContext obj = new RulesContext(new PhysicalPayment());
            obj.Process();
        }

        public void Should_Create_BookPayment()
        {
            RulesContext obj = new RulesContext(new BookPayment());
            obj.Process();
        }

        public void Should_Create_MemberShipPayment()
        {
            RulesContext obj = new RulesContext(new MemberShipPayment());
            obj.Process();
        }

        public void Should_Create_UpgradeMemberShip()
        {
            RulesContext obj = new RulesContext(new UpgradeMemberShip());
            obj.Process();
        }

        public void Should_Create_VideoPayment()
        {
            RulesContext obj = new RulesContext(new VideoPayment());
            obj.Process();
        }
    }
}
