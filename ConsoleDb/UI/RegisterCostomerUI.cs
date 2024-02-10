using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDb.Services;

namespace ConsoleDb.UI
{
    internal class RegisterCostomerUI : IUserInterface
    {

        private readonly CustomerService _customerService;

        public RegisterCostomerUI(CustomerService customerService)
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

        public void UpdateCustomers()
        {
            Console.WriteLine("Enter customers ID:");
            var id = Convert.ToInt32(Console.ReadLine());
            var customer = _customerService.GetCustomerById(id);

            if (customer != null)
            {
                Console.WriteLine($"{customer.FirstName}, {customer.LastName}");
                Console.WriteLine();

                Console.WriteLine("Enter new name for customer:");
                customer.FirstName = Console.ReadLine()!;

                var newCustomer = _customerService.UpdateCustomer(customer);
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
            else
            {
                Console.WriteLine("customer was not found!");
            }

            Console.ReadKey();


        }

    }
}
