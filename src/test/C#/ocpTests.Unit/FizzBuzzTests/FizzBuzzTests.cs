using NUnit.Framework;
using Ocp.FizzBuzz;

namespace ocpTests.Unit.FizzBuzzTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
         private FizzBuzzGame _game;

	[SetUp]
	public void SetUp() 
    {
	   _game = new FizzBuzzGame();
	}

	[Test]
	public void JustSayTheNumber() 
    {
		Assert.AreEqual("1", _game.Say(1));
		Assert.AreEqual("2", _game.Say(2));
	}

	[Test, Ignore]
	public void MultiplesOfThree()
    {
		Assert.AreEqual("Fizz", _game.Say(3));
		Assert.AreEqual("Fizz", _game.Say(6));
	}

	[Test, Ignore]
	public void MultiplesOfFive()
    {
		Assert.AreEqual("Buzz", _game.Say(5));
		Assert.AreEqual("Buzz", _game.Say(10));
	}

	[Test, Ignore]
	public void MultiplesOfFiveAndThree() 
    {
		Assert.AreEqual("FizzBuzz", _game.Say(15));
		Assert.AreEqual("FizzBuzz", _game.Say(30));
	}

	[Test, Ignore]
	public void MultiplesOfSeven() 
    {
		Assert.AreEqual("Bang", _game.Say(7));
		Assert.AreEqual("Bang", _game.Say(14));
	}

	[Test, Ignore]
	public void MultiplesOfSevenAndThree() 
    {
		Assert.AreEqual("FizzBang", _game.Say(7*3));
		Assert.AreEqual("FizzBang", _game.Say(7*3*2));
	}
    }
}