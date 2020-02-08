using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Q9_Q10
{
    class Program
    {

        static void Main(string[] args)
        {

            getCustomers();

        }
        private static List<Customer> getCustomers()
        {
            Customer c1 = new Customer { Name = "Tom", City = "Dublin" };
            Customer c2 = new Customer { Name = "Sally", City = "Galway" };
            Customer c3 = new Customer { Name = "George", City = "Cork" };
            Customer c4 = new Customer { Name = "Molly", City = "Dublin" };
            Customer c5 = new Customer { Name = "Joe", City = "Galway" };

            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            customers.Add(c5);

            /*Linq Query*/
            var findDublin =
            from customer in customers
            orderby customer.Name
            where customer.City == "Dublin"|| customer.City == "Galway"
            select customer;

            foreach (var customer in findDublin)
            {
                Console.WriteLine(customer.ToString());
            }


            return customers;
        }


    }
    public class Customer
    {
        public string Name;
        public string City;

        public override string ToString()
        {
            return $"{Name} from {City}";
        }
    }
}
