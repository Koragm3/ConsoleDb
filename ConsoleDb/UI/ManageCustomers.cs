using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDb.UI
{
    internal class ManageCustomers : IUserInterface
    {
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
                    _registerCustomerUI.UpdateCustomers();
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    _registerCustomerUI.DeleteCustomer();
                    break;
                case 3:
                    Console.Clear();
                    _registerCustomerUI.ShowAllCustomers();
                    break;
                case 4:
                    Console.Clear();
                    _registerCustomerUI.GetCustomerByID();
                    break;
            }
        }
    }
}
