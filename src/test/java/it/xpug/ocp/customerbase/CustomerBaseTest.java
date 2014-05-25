package it.xpug.ocp.customerbase;

import static java.util.Arrays.*;
import static org.hamcrest.CoreMatchers.*;
import static org.junit.Assert.*;

import java.util.*;

import org.junit.*;


public class CustomerBaseTest {

	private Customer alice = new Customer("Alice", "Rossi", 10000);
	private Customer bob = new Customer("Bob", "Rossi", 20000);
	private Customer charlie = new Customer("Charlie", "Bianchi", 30000);

	private CustomerBase customerBase = new CustomerBase();

	@Before
	public void setUp() throws Exception {
		customerBase.add(alice);
		customerBase.add(bob);
		customerBase.add(charlie);
	}

	@Test
	public void findByLastName() throws Exception {
		List<Customer> found = customerBase.findByLastName("Rossi");
		assertThat(found, is(asList(alice, bob)));
	}

	@Test
	public void findByFirstAndLastName() throws Exception {
		List<Customer> found = customerBase.findByFirstAndLastName("Alice", "Rossi");
		assertThat(found, is(asList(alice)));
	}

	@Test
	public void findWithCreditGreaterThan() throws Exception {
		List<Customer> found = customerBase.findByCreditGreaterThan(20000);
		assertThat(found, is(asList(charlie)));
	}

	@Test
	public void findWithCreditLessThan() throws Exception {
		fail("open-closed violation");
		// ...
		// We're sick and tired of adding new methods to CustomerBase.
		// CHALLENGE: can you refactor CustomerBase and its tests
		// so that new kinds of queries can be implemented WITHOUT CHANGING CUSTOMERBASE ???

	}


}
