namespace Ocp.Customer
{
    public class Customer
    {

        public Customer(string firstName, string lastName, int credit)
        {
            FirstName = firstName;
            LastName = lastName;
            Credit = credit;
        }


        public override string ToString()
        {
            return string.Format("(Customer {0} {1})", FirstName, LastName);
        }

        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public int Credit { get; private set; }
    }

}