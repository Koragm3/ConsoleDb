using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDb.Repositories;
using ConsoleDb.Services;

namespace ConsoleDb.UI
{
    internal class RegisterCustomerUI : IUserInterface
    {
        private readonly CustomerService _customerService;
        public RegisterCustomerUI(CustomerService customerService)
        {
            _customerService = customerService;
        }
        public void Render()
        {
            Console.WriteLine("Enter your first name:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter your email:");
            var email = Console.ReadLine();
            Console.WriteLine("Enter your role name:");
            var roleName = Console.ReadLine();
            Console.WriteLine("Enter your street name:");
            var streetName = Console.ReadLine();
            Console.WriteLine("Enter your postalCode:");
            var postalCode = Console.ReadLine();
            Console.WriteLine("Enter your city:");
            var city = Console.ReadLine();
            _customerService.CreateCustomer(firstName!, lastName!, email!, roleName!, streetName!, postalCode!, city!);
            Console.WriteLine("Customer added");
            Console.WriteLine("New List");


            var allCusomers = _customerService.GetAllCustomers();

            foreach (var customer in allCusomers)
            {
                Console.WriteLine(customer.FirstName);

            }

        }
    }
}
