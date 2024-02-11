using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDb.Services;

namespace ConsoleDb.UI
{
    internal class ManageCustomersScreen : IUserInterface
    {
        private readonly CustomerService _customerService;

        public ManageCustomersScreen(CustomerService customerService) {
            _customerService = customerService;
        
        }

        public void GetCustomerByID()
        {
            Console.WriteLine("Enter Customers ID to continue:");
            var id = Convert.ToInt32(Console.ReadLine());
            var customer = _customerService.GetCustomerById(id);
            if (customer != null)
            {
                Console.Clear();
                Console.WriteLine($"{customer.FirstName}, {customer.LastName}");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("customer was not found!");
            }
            Console.ReadKey();

        }

        private void ShowAllCustomers()
        {
            Console.Clear();
            Console.WriteLine("----- All Saved Customers -----");
            var allCusomers = _customerService.GetAllCustomers();

            foreach (var customer in allCusomers)
            {
                Console.Clear();
                Console.WriteLine(customer.FirstName);

            }
        }


        private void DeleteCustomer()
        {
            Console.WriteLine("Enter customers ID that you want to delete:");
            var id = Convert.ToInt32(Console.ReadLine());
            var customer = _customerService.GetCustomerById(id);
            if (customer != null)
            {
                _customerService.DeleteCustomer(id);
                Console.Clear();
                Console.WriteLine("Customer was deleted!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("customer was not found!");
            }
        }

        private void UpdateCustomers()
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
                Console.WriteLine("Enter new last name for customer:");
                customer.LastName = Console.ReadLine()!;
                var newCustomer = _customerService.UpdateCustomer(customer);
                Console.Clear();
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
            else
            {
                Console.WriteLine("customer was not found!");
            }

            Console.ReadKey();
        }


        public void Render()
        {
            
            Console.WriteLine("Choose an option to continue:");
            Console.WriteLine("1. Update a customer");
            Console.WriteLine("2. delete a customer");
            Console.WriteLine("3. Show all customers");
            Console.WriteLine("4. Show customers by ID");
            var i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Clear();
                    UpdateCustomers();
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    DeleteCustomer();
                    break;
                case 3:
                    Console.Clear();
                    ShowAllCustomers();
                    break;
                case 4:
                    Console.Clear();
                    GetCustomerByID();
                    break;
            }
        }
    }
}
