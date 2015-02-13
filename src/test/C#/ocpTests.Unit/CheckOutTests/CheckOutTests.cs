using NUnit.Framework;
using Ocp;


namespace ocpTests.Unit.CheckOutTests
{
    [TestFixture]
    public class CheckoutTest
    {

        private CheckOut _checkOut;

        [SetUp]
        public void Setup()
        {
            _checkOut = new Ocp.CheckOut();
        }






        [Test]
        public void OneKindOfItem()
        {
            Assert.AreEqual(0, _checkOut.Total());

            _checkOut.Scan("A");
            Assert.AreEqual(50, _checkOut.Total());
            _checkOut.Scan("A");
            Assert.AreEqual(50 + 50, _checkOut.Total());
        }

        [Test, Ignore]
        public void TwoKindsOfItems()
        {
            _checkOut.Scan("A");
            Assert.AreEqual(50, _checkOut.Total());
            _checkOut.Scan("B");
            Assert.AreEqual(50 + 30, _checkOut.Total());
        }

        [Test, Ignore]
        public void ThreeKindsOfItems()
        {
            _checkOut.Scan("A");
            Assert.AreEqual(50, _checkOut.Total());
            _checkOut.Scan("B");
            Assert.AreEqual(50 + 30, _checkOut.Total());
            _checkOut.Scan("C");
            Assert.AreEqual(50 + 30 + 20, _checkOut.Total());
        }

        [Test, Ignore]
        public void SpecialOffer()
        {
            _checkOut.Scan("A");
            _checkOut.Scan("A");
            _checkOut.Scan("A");
            Assert.AreEqual(130, _checkOut.Total());

            _checkOut.Scan("A");
            Assert.AreEqual(130 + 50, _checkOut.Total());
        }


        [Test, Ignore]
        public void AnotherSpecialOffer()
        {

            _checkOut.Scan("B");
            _checkOut.Scan("B");
            Assert.AreEqual(45, _checkOut.Total());

            _checkOut.Scan("B");
            _checkOut.Scan("B");
            Assert.AreEqual(45 + 45, _checkOut.Total());
        }

        [Test, Ignore]
        public void ThisIsDifficult()
        {
            // One more variation:
            // "E" costs 55.
            // But it costs just 19 if you have bought two of "C".
            // This is probably going to be difficult!
            _checkOut.Scan("E");
            Assert.AreEqual(55, _checkOut.Total());

            _checkOut.Scan("C");
            Assert.AreEqual(55 + 20, _checkOut.Total());

            _checkOut.Scan("C");
            Assert.AreEqual(19 + 20 + 20, _checkOut.Total());
        }
    }

}