using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerList();
        }

        static void TestCustomerList()
        {
            CustomerList customerList = new CustomerList();

            // Add customers
            customerList.AddCustomer(new Customer(1, "John", "Doe", "john@example.com", "123456789"));
            customerList.AddCustomer(2, "Jane", "Smith", "jane@example.com", "987654321");

            // Display customers
            Console.WriteLine("Customers after adding:");
            Console.WriteLine(customerList);

            // Test count
            Console.WriteLine($"Customer count: {customerList.Count}");

            // Get customer by index
            Console.WriteLine($"Customer at index 1: {customerList[1]}");

            // Get customer by email
            Customer customer = customerList.GetCustomerByEmail("jane@example.com");
            Console.WriteLine($"Customer with email 'jane@example.com': {customer}");

            // Change customer
            customerList[1] = new Customer(3, "Alice", "Johnson", "alice@example.com", "111222333");
            Console.WriteLine("Customers after changing the second customer:");
            Console.WriteLine(customerList);

            // Add customer using + operator
            customerList += new Customer(4, "Bob", "Williams", "bob@example.com", "444555666");
            Console.WriteLine("Customers after adding using + operator:");
            Console.WriteLine(customerList);

            // Save to XML
            customerList.SaveToXml("customers.xml");

            // Clear list and load from XML
            customerList = new CustomerList();
            customerList.LoadFromXml("customers.xml");
            Console.WriteLine("Customers after loading from XML:");
            Console.WriteLine(customerList);

            // Remove customer
            customerList.RemoveCustomer(customer);
            Console.WriteLine("Customers after removing a customer:");
            Console.WriteLine(customerList);

            // Remove customer using - operator
            customerList -= new Customer(4, "Bob", "Williams", "bob@example.com", "444555666");
            Console.WriteLine("Customers after removing using - operator:");
            Console.WriteLine(customerList);
        }
    }
}
