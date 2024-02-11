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
        private readonly ProductService _productService;
        private readonly CustomerService _customerService;
        public RegisterCustomerUI(CustomerService customerService,ProductService productService)
        {
            _productService = productService;
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

        public void DeleteCustomer()
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
        public void ShowAllCustomers()
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

        //products

        

        
        public void AddNewProduct() 
        {
            Console.WriteLine("Enter your product title:");
            var title = Console.ReadLine()!;
            Console.WriteLine("Enter your product price:");
            var price = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter your product category:");
            var category = Console.ReadLine()!;
            _productService.CreateProduct(title, price, category);
        }
        public void DeleteProductById()
        {
            Console.WriteLine("Enter products id to delete:");
            var id = int.Parse(Console.ReadLine()!);
            
            if (id != null) 
            {
                _productService.DeleteProduct(id);
                Console.Clear();
                Console.WriteLine("item was deleted!");
            }else 
            {
                Console.Clear();
                Console.WriteLine("item was not found.");
            }
        }
        public void UpdateProductById() 
        {
            Console.WriteLine("Enter prodcuts Id that you want to update:");
            var id = int.Parse(Console.ReadLine()!);
            var product = _productService.GetProductById(id);
            if (product != null)
            { 
                Console.Clear();
                Console.WriteLine("Enter new name for product:");
                product.Title = Console.ReadLine()!;
                Console.WriteLine("Enter new Price for product:");
                product.Price = decimal.Parse(Console.ReadLine()!);
                _productService.UpdateProduct(product);
                Console.WriteLine(product.Title);
            }else
            {
                Console.WriteLine("product was not found");
            }

        }
        public void ShowAllProducts()
        {
           var products = _productService.GetAllProducts();
            Console.Clear();
            foreach (var product in products)
            {
                Console.WriteLine(product.Title);
            }
            Console.ReadKey();
        }
    }
}
