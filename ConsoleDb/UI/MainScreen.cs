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
        private readonly ManageCustomersScreen _manageCustomersScreen;
        private readonly ManageProductScreen _manageProductScreen;
        public MainScreen(
            Navigator navigator, 
            RegisterCustomerUI registerCostomerUI,
            ManageCustomersScreen manageCustomersScreen,
            ManageProductScreen manageProductScreen)
        {
            _navigator = navigator;
            _registerCustomerUI = registerCostomerUI;
            _manageCustomersScreen = manageCustomersScreen;
            _manageProductScreen = manageProductScreen;
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
                            _navigator.NatigateTo(_manageCustomersScreen);
                            break;
                        case 3:
                            // 
                            _navigator.NatigateTo(_manageProductScreen);
                            
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