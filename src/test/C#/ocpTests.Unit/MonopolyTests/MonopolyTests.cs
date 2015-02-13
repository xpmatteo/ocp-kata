using NUnit.Framework;
using Ocp.Monopoly;

namespace ocpTests.Unit.MonopolyTests
{
    [TestFixture]
    public class MonopolyTests
    {
         private MonopolyPlayer _alice;
	private MonopolyPlayer _bob;

	[SetUp]
	public void setUp() 
    {
		_alice = new MonopolyPlayer("Alice");
		_bob = new MonopolyPlayer("Bob");
	}

	[Test]
	public void freeParking() 
    {
		_alice.LandsOn("FREE PARKING");
		Assert.AreEqual("FREE PARKING", _alice.location());
	}

	[Test, Ignore]
	public void go() 
    {
		_alice.SetBalance(100);
		_alice.LandsOn("GO");
		Assert.AreEqual(100 + 200, _alice.Balance);
		Assert.AreEqual("GO", _alice.location());
	}

	[Test, Ignore]
	public void luxuryTax() 
    {
		_alice.SetBalance(100);
		_alice.LandsOn("LUXURY TAX");
		Assert.AreEqual(100 - 75, _alice.Balance);
		Assert.AreEqual("LUXURY TAX", _alice.location());
	}

	[Test, Ignore]
	public void goToJail() 
    {
		_alice.LandsOn("GO TO JAIL");
		Assert.AreEqual("JAIL", _alice.location());
	}

	[Test, Ignore]
	public void incomeTax() 
    {
		// if balance is more than 2000 then pay 200
		_alice.SetBalance(3000);
		_alice.LandsOn("INCOME TAX");
		Assert.AreEqual(3000 - 200, _alice.Balance);

		// if balance is less than 2000 then pay 10% of balance
		_bob.SetBalance(1000);
		_bob.LandsOn("INCOME TAX");
		Assert.AreEqual(1000 - 100, _bob.Balance);
	}


	[Test, Ignore]
	public void payRentOnUnimprovedProperty() 
    {
		_alice.SetBalance(1000);
		_bob.SetBalance(1000);
        _bob.AddOwnedProperty("ORIENTAL AVENUE");

		_alice.LandsOn("ORIENTAL AVENUE");

		Assert.AreEqual(1000 - 6, _alice.Balance);
		Assert.AreEqual(1000 + 6, _bob.Balance);
	}
    }
}