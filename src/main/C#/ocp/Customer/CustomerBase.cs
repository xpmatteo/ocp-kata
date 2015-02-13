using System.Collections.Generic;
using System.Linq;

namespace Ocp.Customer
{
    public class CustomerBase
    {

        private readonly IList<Customer> _customers;

        public CustomerBase()
        {
            _customers = new List<Customer>();
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
        }

        public List<Customer> FindByLastName(string lastName)
        {
            //return _customers.
            //    Where(c => c.LastName.Equals(lastName)).
            //    ToList();
            var result = new List<Customer>();
            foreach (var customer in _customers)
            {
                if (customer.LastName.Equals(lastName))
                {
                    result.Add(customer);
                }
            }
            return result;
        }

        public IList<Customer> FindByFirstAndLastName(string firstName, string lastName)
        {
            //return _customers
            //    .Where(c => c.FirstName.Equals(firstName) &&
            //      c.LastName.Equals(lastName))
            //    .ToList();

            var result = new List<Customer>();
            foreach (var customer in _customers)
            {
                if (customer.FirstName.Equals(firstName) &&
                    customer.LastName.Equals(lastName))
                {
                    result.Add(customer);
                }
            }
            return result;
        }

        public IList<Customer> FindByCreditGreaterThan(int credit)
        {
            //return _customers
            //    .Where(c => c.Credit > credit)
            //    .ToList();

            var result = new List<Customer>();
            foreach (var customer in _customers)
            {
                if (customer.Credit > credit)
                    result.Add(customer);
            }
            return result;
        }
    }
}