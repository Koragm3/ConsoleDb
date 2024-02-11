using System;
using System.Diagnostics.Eventing.Reader;
using ConsoleDb.Repositories;
using ConsoleDb.UI.Navigation;

namespace ConsoleDb.UI
{
    internal class MainScreen : IUserInterface
    {

        
        private readonly Navigator _navigator;
        private readonly RegisterCustomerUI _registerCustomerUI;

        public MainScreen(Navigator navigator, RegisterCustomerUI registerCostomerUI)
        {
            _navigator = navigator;
            _registerCustomerUI = registerCostomerUI;
         
        }
        public void Render()
        {
            
            while (true)
            {
                Console.WriteLine("Welcome to the Internet store 2024");
                Console.WriteLine("1. register a customer");
                Console.WriteLine("2. manage customers");
                Console.WriteLine("3. manage products");
                try
                {
                    var input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {

                        case 1:
                            _navigator.NatigateTo(_registerCustomerUI);// navigate to register a customer
                            break;

                        case 2: // navigate to manage product
                            Console.Clear();
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
                            
                            break;
                        case 3:
                            Console.WriteLine("----Select An Option----");
                            Console.WriteLine("1_Create a New Product");
                            Console.WriteLine("2_Update Products Info");
                            Console.WriteLine("3_Delete a Product");
                            Console.WriteLine("4_Show all Products");
                            var ii = Convert.ToInt32(Console.ReadLine());
                            switch (ii)
                            {
                                case 1:
                                    Console.Clear();
                                    _registerCustomerUI.AddNewProduct();
                                    break;
                                case 2:
                                    Console.Clear();
                                    _registerCustomerUI.UpdateProductById();
                                    break;
                                case 3:
                                    Console.Clear();
                                    _registerCustomerUI.DeleteProductById();
                                    break;
                                case 4: 
                                    Console.Clear();
                                    _registerCustomerUI.ShowAllProducts();
                                    break;
                            }
                            
                            break;
                        default:
                            Console.WriteLine("please input a valid option");
                            break;
                    }
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}