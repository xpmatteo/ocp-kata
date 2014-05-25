package it.xpug.ocp.customerbase;
import java.util.*;


public class CustomerBase {

	private List<Customer> customers = new ArrayList<Customer>();

	public void add(Customer customer) {
		customers.add(customer);
	}

	public List<Customer> findByLastName(String lastName) {
		List<Customer> result = new ArrayList<Customer>();
		for (Customer customer : customers) {
			if (customer.lastName().equals(lastName)) {
				result.add(customer);
			}
		}
		return result;
	}

	public List<Customer> findByFirstAndLastName(String firstName, String lastName) {
		List<Customer> result = new ArrayList<Customer>();
		for (Customer customer : customers) {
			if (customer.firstName().equals(firstName) && customer.lastName().equals(lastName) ) {
				result.add(customer);
			}
		}
		return result;
	}

	public List<Customer> findByCreditGreaterThan(int credit) {
		List<Customer> result = new ArrayList<Customer>();
		for (Customer customer : customers) {
			if (customer.credit() > credit) {
				result.add(customer);
			}
		}
		return result;
	}

}
