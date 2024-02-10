using ConsoleDb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDb.UI
{
    internal class UpdateDataScreen : IUserInterface
    {
        public void Render()
        {
            throw new NotImplementedException();
        }

        private readonly CustomerService _customerService;
        public UpdateDataScreen(CustomerService customerService)
        {
            _customerService = customerService;
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
            }else
            {
                Console.WriteLine("customer was not found!");
            }

            Console.ReadKey();

            
        }



    }
}
