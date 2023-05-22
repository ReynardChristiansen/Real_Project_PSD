using project.Factory;
using project.Model;
using project.Repositoy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace project.Controller
{
    public class RegisterController
    {
        public static void registration(string CustomerName, string CustomerEmail, String CustomerPassword, string CustomerAddress, string CustomerGender, string CustomerRole)
        {
            int id = CustomerRepository.NextID();
            Customer newCustomer = CustomerFactory.create(id, CustomerName, CustomerEmail, CustomerPassword, CustomerAddress, CustomerGender, CustomerRole);
            CustomerRepository.add(newCustomer);
        }


        public static string validation(string CustomerName, string CustomerEmail, String CustomerPassword, string CustomerAddress, string CustomerGender)
        {
            bool isAlphanumeric = CustomerPassword.All(char.IsLetterOrDigit);
            Customer x = CustomerRepository.findEmail(CustomerEmail);

            if ((CustomerName.Length < 5) || (CustomerName.Length > 50))
            {
                return "Name Must be Filled Between 5 and 50";
            }
            else if (CustomerEmail.Equals(""))
            {
                return "Email cannot be empty";
            }
            else if (x != null)
            {
                return "Email must be unique";
            }
            else if (CustomerGender.Equals(""))
            {
                return "Gender cannot be empty";
            }
            else if (!CustomerAddress.EndsWith("Street") || CustomerAddress.Equals(""))
            {
                return "Address must be filled and ends with 'Street'";
            }
            else if (CustomerPassword.Equals("") || !isAlphanumeric)
            {
                return "Password must be filled and alphanumeric";
            }


            return "";
        }
    }
}