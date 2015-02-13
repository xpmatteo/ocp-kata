using NUnit.Framework;
using Ocp.RockPaperScissors;

namespace ocpTests.Unit.RockPaperScissorsTests
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
         private RockPaperScissorsGame _game;

	[SetUp]
	public void SetUp() 
    {
		_game = new RockPaperScissorsGame();
	}

	[Test]
	public void RockBeatsScissors() 
    {
		Assert.IsTrue(_game.Beats("rock", "scissors"));
	}

	[Test, Ignore]
	public void ScissorsDoNotBeatRock() 
    {
		Assert.IsFalse(_game.Beats("scissors", "rock"));
	}

	[Test, Ignore]
	public void RockDoesNotBeatRock() 
    {
		Assert.IsFalse(_game.Beats("rock", "rock"));
	}

	[Test, Ignore]
	public void ScissorsBeatPaper() 
    {
		Assert.IsFalse(_game.Beats("scissors", "paper"));
	}

	[Test, Ignore]
	public void PaperBeatsRock() 
    {
		Assert.IsTrue(_game.Beats("paper", "rock"));
	}
    }
}