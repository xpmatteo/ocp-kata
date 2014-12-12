package it.xpug.ocp.monopoly;

import static org.junit.Assert.*;

import org.junit.*;

/*
	Our two cryptography heroes, Alice and Bob, finally meet to relax and
	play some Monopoly.
 */
public class MonopolyTest {
	private MonopolyPlayer alice;
	private MonopolyPlayer bob;

	@Before
	public void setUp() throws Exception {
		alice = new MonopolyPlayer("Alice");
		bob = new MonopolyPlayer("Bob");
	}

	@Test
	public void freeParking() throws Exception {
		alice.landsOn("FREE PARKING");
		assertEquals("FREE PARKING", alice.location());
	}

	@Test@Ignore
	public void go() throws Exception {
		alice.setBalance(100);
		alice.landsOn("GO");
		assertEquals(100 + 200, alice.balance());
		assertEquals("GO", alice.location());
	}

	@Test@Ignore
	public void luxuryTax() throws Exception {
		alice.setBalance(100);
		alice.landsOn("LUXURY TAX");
		assertEquals(100 - 75, alice.balance());
		assertEquals("LUXURY TAX", alice.location());
	}

	@Test@Ignore
	public void goToJail() throws Exception {
		alice.landsOn("GO TO JAIL");
		assertEquals("JAIL", alice.location());
	}

	@Test@Ignore
	public void incomeTax() throws Exception {
		// if balance is more than 2000 then pay 200
		alice.setBalance(3000);
		alice.landsOn("INCOME TAX");
		assertEquals(3000 - 200, alice.balance());

		// if balance is less than 2000 then pay 10% of balance
		bob.setBalance(1000);
		bob.landsOn("INCOME TAX");
		assertEquals(1000 - 100, bob.balance());
	}

	@Test@Ignore
	public void nameGift() throws Exception {
        // This square exists only in some very rare editions of Monopoly
        // The player receives one euro for each letter of his or her name
		alice.setBalance(100);
		alice.landsOn("GIFT OF NAME");
		assertEquals(100 + 5, alice.balance());

		bob.setBalance(100);
		bob.landsOn("GITF OF NAME");
		assertEquals(1000 + 3, bob.balance());
	}

	@Test@Ignore
	public void utilityTax() throws Exception {
        // This square exists only in some very rare editions of Monopoly
        // The player pays 10 for every Utility he or she owns
		// The utilities are: ELECTRIC COMPANY and WATER WORKS
		alice.setBalance(1000);
		alice.addOwnedProperty("ELECTRIC COMPANY");
		alice.landsOn("UTILITY TAX");
		assertEquals(1000 - 10, alice.balance());

		bob.setBalance(1000);
		bob.addOwnedProperty("ELECTRIC COMPANY");
		bob.addOwnedProperty("WATER WORKS");
		bob.landsOn("UTILITY TAX");
		assertEquals(1000 - 20, bob.balance());
	}

	@Test@Ignore
	public void payRentOnUnimprovedProperty() throws Exception {
		alice.setBalance(1000);
		bob.setBalance(1000);
		bob.addOwnedProperty("ORIENTAL AVENUE");

		alice.landsOn("ORIENTAL AVENUE");

		assertEquals(1000 - 6, alice.balance());
		assertEquals(1000 + 6, bob.balance());
	}
}
