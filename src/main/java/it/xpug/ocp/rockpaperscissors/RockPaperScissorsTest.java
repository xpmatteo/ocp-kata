package it.xpug.ocp.rockpaperscissors;

import static org.junit.Assert.*;

import org.junit.*;

/*
	Rock beats Scissors.
	Scissors beat paper.
	Paper beats rock.
 */
public class RockPaperScissorsTest {

	private RockPaperScissorsGame game;

	@Before
	public void setUp() throws Exception {
		game = new RockPaperScissorsGame();
	}

	@Test
	public void rockBeatsScissors() throws Exception {
		assertTrue(game.beats("rock", "scissors"));
	}

	@Test@Ignore
	public void scissorsDoNotBeatRock() throws Exception {
		assertFalse(game.beats("scissors", "rock"));
	}

	@Test@Ignore
	public void rockDoesNotBeatRock() throws Exception {
		assertFalse(game.beats("rock", "rock"));
	}

	@Test@Ignore
	public void scissorsBeatPaper() throws Exception {
		assertTrue(game.beats("scissors", "paper"));
	}

	@Test@Ignore
	public void paperBeatsRock() throws Exception {
		assertTrue(game.beats("paper", "rock"));
	}

}
