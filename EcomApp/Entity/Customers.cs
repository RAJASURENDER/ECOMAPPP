using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomApp.Entity
{
        public class Customers
        {
            int customerId;
            string name;
            string email;
            string password;

            public Customers()
            {
            }

            public Customers(int customerId, string name, string email, string password)
            {
                this.customerId = customerId;
                this.name = name;
                this.email = email;
                this.password = password;
            }
            public int CustomerId
            {
                get { return customerId; }
                set { customerId = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public override string ToString()
            {
                return $"customerId : {customerId}, name : {name}, email : {email}, password : {password}";
            }
        }
}
