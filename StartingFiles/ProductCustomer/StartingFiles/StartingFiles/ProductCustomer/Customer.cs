using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProductClasses
{
    public class Customer
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;

        public Customer()
        {
            id = 0;
            firstName = "";
            lastName = "";
            email = "";
            phoneNumber = "";
        }

        public Customer(int customerID, string customerFirstName, string customerLastName, string customerEmail, string customerPhoneNumber)
        {
            id = customerID;
            firstName = customerFirstName;
            lastName = customerLastName;
            email = customerEmail;
            phoneNumber = customerPhoneNumber;
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Id: {0} FirstName: {1} LastName: {2} Email: {3} PhoneNumber: {4}", id, firstName, lastName, email, phoneNumber);
        }
    }
}