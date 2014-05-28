package it.xpug.ocp.checkout;

import static org.junit.Assert.*;

import org.junit.*;

/*
Back to the Checkout
http://codekata.com/kata/kata09-back-to-the-checkout/

Item   Unit      Special
       Price     Price
--------------------------
  A     50       3 for 130
  B     30       2 for 45
  C     20
  D     15
*/
public class CheckoutTest {

	private CheckOut checkOut;

	@Before
	public void setUp() throws Exception {
		checkOut = new CheckOut();
	}

	@Test
	public void oneKindOfItem() throws Exception {
		assertEquals(0, checkOut.total());
		checkOut.scan("A");
		assertEquals(50, checkOut.total());
		checkOut.scan("A");
		assertEquals(50 + 50, checkOut.total());
	}

	@Test@Ignore
	public void twoKindsOfItems() throws Exception {
		checkOut.scan("A");
		assertEquals(50, checkOut.total());
		checkOut.scan("B");
		assertEquals(50 + 30, checkOut.total());
	}

	@Test@Ignore
	public void threeKindsOfItems() throws Exception {
		checkOut.scan("A");
		assertEquals(50, checkOut.total());
		checkOut.scan("B");
		assertEquals(50 + 30, checkOut.total());
		checkOut.scan("C");
		assertEquals(50 + 30 + 20, checkOut.total());
	}

	@Test@Ignore
	public void specialOffer() throws Exception {
		checkOut.scan("A");
		checkOut.scan("A");
		checkOut.scan("A");
		assertEquals(130, checkOut.total());
		checkOut.scan("A");
		assertEquals(130 + 50, checkOut.total());
	}

	@Test@Ignore
	public void anotherSpecialOffer() throws Exception {
		checkOut.scan("B");
		checkOut.scan("B");
		assertEquals(45, checkOut.total());
		checkOut.scan("B");
		checkOut.scan("B");
		assertEquals(45 + 45, checkOut.total());
	}

	@Test@Ignore
	public void thisIsDifficult() throws Exception {
		// One more variation:
		// "E" costs 55.
		// But it costs just 19 if you have bought two of "C".
		// This is probably going to be difficult!
		checkOut.scan("E");
		assertEquals(55, checkOut.total());
		checkOut.scan("C");
		assertEquals(55 + 20, checkOut.total());
		checkOut.scan("C");
		assertEquals(19 + 20 + 20, checkOut.total());
	}

}
