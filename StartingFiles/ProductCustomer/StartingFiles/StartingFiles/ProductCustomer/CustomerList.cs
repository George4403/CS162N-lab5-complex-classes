using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
	public class CustomerList
	{
		private List<Customer> customers;

		public CustomerList()
		{
			customers = new List<Customer>();
		}

		public int Count 
		{ 
			get { return customers.Count; } 
		}

		public Customer this[int index]
		{
			get { return customers[index]; }
			set { customers[index] = value; }
		}

		public Customer GetCustomerByEmail(string email)
		{
			return customers.Find(c => c.Email == email);
		}

		public void AddCustomer(Customer customer)
		{ 
			customers.Add(customer);
		}

		public void AddCustomer(int id, string firstName, string lastName, string email, string phoneNumber) 
		{
			customers.Add(new Customer(id, firstName, lastName, email, phoneNumber));
		}

		public static CustomerList operator +(CustomerList list, Customer customer) 
		{
			list.AddCustomer(customer);
			return list;
		}

		public void SaveToXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, customers);
            }
        }

        public void LoadFromXml(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                customers = (List<Customer>)serializer.Deserialize(fs);
            }
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public static CustomerList operator -(CustomerList list, Customer customer)
        {
            list.RemoveCustomer(customer);
            return list;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, customers);
        }
    }
}
