using System;
using System.Diagnostics.Eventing.Reader;
using ConsoleDb.Repositories;
using ConsoleDb.UI.Navigation;

namespace ConsoleDb.UI
{
    internal class MainScreen : IUserInterface
    {


        private readonly Navigator _navigator;
        private readonly RegisterCostomerUI _registerCostomerUI;

        public MainScreen(Navigator navigator, RegisterCostomerUI registerCostomerUI)
        {
            _navigator = navigator;
            _registerCostomerUI = registerCostomerUI;
        }
        public void Render()
        {
            Console.WriteLine("Welcome to the Internet store 2024");
            Console.WriteLine("1. register a costomer");
            Console.WriteLine("2. manage product");
            while (true)
            {
                try
                {
                    var input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {

                        case 1:
                            _navigator.NatigateTo(_registerCostomerUI);// navigate to register a costomer
                            break;

                        case 2: // navigate to manage product
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