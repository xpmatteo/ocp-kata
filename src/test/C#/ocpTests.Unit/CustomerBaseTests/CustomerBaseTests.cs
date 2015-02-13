using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Ocp.Customer;

namespace ocpTests.Unit.CustomerBaseTests
{

    [TestFixture]
    public class CustomerBaseTest
    {

        private readonly Customer _alice = new Customer("Alice", "Rossi", 10000);
        private readonly Customer _bob = new Customer("Bob", "Rossi", 20000);
        private readonly Customer _charlie = new Customer("Charlie", "Bianchi", 30000);

        private readonly CustomerBase _customerBase = new CustomerBase();

        [SetUp]
        public void SetUp()
        {
            _customerBase.Add(_alice);
            _customerBase.Add(_bob);
            _customerBase.Add(_charlie);
        }

        private bool ListEquals<T>(IEnumerable<T> expected, IEnumerable<T> found)
        {
            Assert.AreEqual(0, expected.Except(found).Count());
            Assert.AreEqual(0, found.Except(expected).Count());
            return true;
        }

        [Test]
        public void FindByLastName()
        {
            var found = _customerBase.FindByLastName("Rossi");
            Assert.IsTrue(ListEquals(new List<Customer> { _alice, _bob }, found));
        }

        [Test]
        public void FindByFirstAndLastName()
        {
            var found = _customerBase.FindByFirstAndLastName("Alice", "Rossi");
            Assert.IsTrue(ListEquals(new List<Customer> { _alice }, found));
        }

        [Test]
        public void FindWithCreditGreaterThan()
        {
            var found = _customerBase.FindByCreditGreaterThan(20000);
            Assert.IsTrue(ListEquals(new List<Customer> { _charlie }, found));
        }

        [Test]
        public void FindWithCreditLessThan()
        {
            Assert.Fail("open-closed violation");
            // ...
            // We're sick and tired of adding new methods to CustomerBase.
            // CHALLENGE: can you refactor CustomerBase and its tests
            // so that new kinds of queries can be implemented WITHOUT CHANGING CUSTOMERBASE ???

        }


    }

}