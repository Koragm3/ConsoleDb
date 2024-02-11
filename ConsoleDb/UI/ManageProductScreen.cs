using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDb.Services;

namespace ConsoleDb.UI
{
    internal class ManageProductScreen : IUserInterface
    {
        private readonly ProductService _productService;

        public ManageProductScreen(ProductService productService)
        {
            _productService = productService;

        }

        public void Render()
        {

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
                    AddNewProduct();
                    break;
                case 2:
                    Console.Clear();
                    UpdateProductById();
                    break;
                case 3:
                    Console.Clear();
                    DeleteProductById();
                    break;
                case 4:
                    Console.Clear();
                    ShowAllProducts();
                    break;
            }

        }


        private void AddNewProduct()
        {
            Console.WriteLine("Enter your product title:");
            var title = Console.ReadLine()!;
            Console.WriteLine("Enter your product price:");
            var price = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter your product category:");
            var category = Console.ReadLine()!;
            _productService.CreateProduct(title, price, category);
        }
        private void DeleteProductById()
        {
            Console.WriteLine("Enter products id to delete:");
            var id = int.Parse(Console.ReadLine()!);

            if (id != null)
            {
                _productService.DeleteProduct(id);
                Console.Clear();
                Console.WriteLine("item was deleted!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("item was not found.");
            }
        }
        private void UpdateProductById()
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
            }
            else
            {
                Console.WriteLine("product was not found");
            }

        }
        private void ShowAllProducts()
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
