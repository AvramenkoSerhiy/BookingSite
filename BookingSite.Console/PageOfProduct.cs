using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.ConsoleV
{
    class PageOfProduct
    {
        private IServiceOfProduct _serviceOfProduct;
        private SelectedItems _selectedItems;
        private IServiceOfBooking _serviceOfBooking;

        public PageOfProduct(IServiceOfProduct serviceOfProduct, SelectedItems selectedItems, IServiceOfBooking serviceOfBooking)
        {
            _serviceOfProduct = serviceOfProduct;
            _selectedItems = selectedItems;
            _serviceOfBooking = serviceOfBooking;
        }
        public void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Console.Write("\n------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose a Product. \n");
                if (_selectedItems.SelectedTypeOfProduct != null)
                    Console.WriteLine($"\nSelected type of product ID {_selectedItems.SelectedTypeOfProduct.Id,-4}");
                if (_selectedItems.SelectedProduct != null)
                    Console.WriteLine($"\nselected type of product ID {_selectedItems.SelectedProduct.Id,-4}");
                if (_selectedItems.SelectedStore != null)
                    Console.WriteLine($"Selected store id {_selectedItems.SelectedStore.Id,-4}\n");
                WriteListOfCommand();
                Console.Write("\n>>");
                string command = Console.ReadLine();
                backToMenu = ProccessCommand(command);
            }
        }
        private bool ProccessCommand(string command)
        {
            bool backToMenu = false;
            if (command == "1")
            {
                ShowAllProducts();
            }
            else if (command == "2")
            {
                ShowProductsWithSelectedType();
            }
            else if (command == "3")
            {
                ShowProductsInSelectedStore();
            }
            else if (command == "4")
            {
                ShowProductsWithSelectedTypeInSelectedStore();
            }
            else if (command == "5")
            {
                ChooseProduct();
            }
            else if (command == "6")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - Show all products.");
            Console.WriteLine("2 - Show products with selected type.");
            Console.WriteLine("3 - Show products in selected store.");
            Console.WriteLine("4 - Show products with selected type in selected store.");
            Console.WriteLine("5 - Choose product.");
            Console.WriteLine("6 - Back to main menu.");
        }
        private void ChooseProduct()
        {
            Console.Write("\nWrite product id>> ");
            string productIdStr = Console.ReadLine();
            int productId;
            if (!int.TryParse(productIdStr, out productId))
            {
                Console.WriteLine("\nWrong Id.");
            }
            else if (!_serviceOfBooking.DoesProductAvailable(productId))
            {
                Console.WriteLine("This product doesn`t available.");
            }
            else
            {
                _selectedItems.SelectedProduct = _serviceOfProduct.GetProductByID(productId);
            }

        }

        private void ShowAllProducts()
        {
            List<ViewOfProduct> products = _serviceOfProduct.GetAllProducts().ToList();
            WriteListOfProducts(products);
        }

        private void ShowProductsWithSelectedType()
        {
            if (_selectedItems.SelectedTypeOfProduct == null)
            {
                Console.WriteLine("\n You have not choose type of product.");
            }
            else
            {
                List<ViewOfProduct> products = _serviceOfProduct.GetAllProductsWithSelectedTypeOfProduct(_selectedItems.SelectedTypeOfProduct.Id).ToList();
                WriteListOfProducts(products);
            }
        }

        private void ShowProductsWithSelectedTypeInSelectedStore()
        {
            if (_selectedItems.SelectedTypeOfProduct == null)
            {
                Console.WriteLine("\n You have not choose type of product.");
            }
            else if (_selectedItems.SelectedStore == null)
            {
                Console.WriteLine("\n You have not choose store.");
            }
            else
            {
                List<ViewOfProduct> products = _serviceOfProduct
                       .GetAllProductsWithSelectedTypeOfProductAndStore(_selectedItems.SelectedTypeOfProduct.Id, _selectedItems.SelectedStore.Id)
                       .ToList();
                WriteListOfProducts(products);
            }
        }

        private void ShowProductsInSelectedStore()
        {
            if (_selectedItems.SelectedStore != null)
            {
                List<ViewOfProduct> products = _serviceOfProduct.GetAllProductsInStore(_selectedItems.SelectedStore.Id).ToList();
                WriteListOfProducts(products);
            }
            else
            {
                Console.WriteLine("\n You have not choose store.");
            }
        }

        private void WriteListOfProducts(List<ViewOfProduct> products)
        {
            Console.WriteLine("ID       Type ID    Store ID   Date of Producing");
            foreach (ViewOfProduct product in products)
            {
                Console.WriteLine($"{product.Id,-8} {product.TypeOfProductId,-10} {product.StoreId,-10} {product.DateOfProducing}");
            }
        }

    }
}
