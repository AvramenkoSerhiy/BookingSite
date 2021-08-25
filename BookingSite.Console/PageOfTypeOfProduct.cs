using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.ConsoleV
{
    class PageOfTypeOfProduct
    {
        private IServiceOfTypeOfProduct _serviceOfTypeOfProduct;
        private SelectedItems _selectedItems;

        public PageOfTypeOfProduct(IServiceOfTypeOfProduct serviceOfTypeOfProduct, SelectedItems selectedItems)
        {
            _serviceOfTypeOfProduct = serviceOfTypeOfProduct;
            _selectedItems = selectedItems;
        }

        public void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Console.Write("\n------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose a type of product.\n");
                if (_selectedItems.SelectedTypeOfProduct != null)
                    Console.WriteLine($"\nSelected type of product ID {_selectedItems.SelectedTypeOfProduct.Id,-4}");
                if (_selectedItems.SelectedStore != null)
                    Console.WriteLine($"Selected store ID {_selectedItems.SelectedStore.Id,-4}\n");
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
                ShowAllTypesOfProduct();
            }
            else if (command == "2")
            {
                FindByName();
            }
            else if (command == "3")
            {
                ChooseTypeOFProduct();
            }
            else if (command == "4")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - Show all types of product");
            Console.WriteLine("2 - Find type of product by name");
            Console.WriteLine("3 - Choose type of product");
            Console.WriteLine("4 - Back to main menu");
        }
        private void FindByName()
        {
            Console.Write("Write type of product name.");
            string name = Console.ReadLine();
            WriteListOfTypesOfProduct(_serviceOfTypeOfProduct.FindByName(name).ToList());
        }

        private void ChooseTypeOFProduct()
        {
            Console.Write("\nWrite product type ID>> ");
            string productTypeIdStr = Console.ReadLine();
            int typeOfProdcutId;
            if (int.TryParse(productTypeIdStr, out typeOfProdcutId))
            {
                _selectedItems.SelectedTypeOfProduct = _serviceOfTypeOfProduct.GetTypesOfProductByID(typeOfProdcutId);
            }
            else if (_selectedItems.SelectedTypeOfProduct == null)
            {
                Console.WriteLine("No type of product with such ID");
            }
            else
            {
                Console.WriteLine("\nWrong ID");
            }

        }

        private void ShowAllTypesOfProduct()
        {
            List<ViewOfTypeOfProduct> typesOfProduct = _serviceOfTypeOfProduct.GetAllTypesOfProduct().ToList();
            WriteListOfTypesOfProduct(typesOfProduct);
        }

        private void WriteListOfTypesOfProduct(List<ViewOfTypeOfProduct> typesOfProduct)
        {
            Console.WriteLine("     Type of product name   Recommended price");
            foreach (ViewOfTypeOfProduct typeOfProduct in typesOfProduct)
            {
                Console.WriteLine($"{typeOfProduct.Id,-5}{typeOfProduct.Name,-20}{typeOfProduct.PriceRecommendation.ToString()}");
            }
        }
    }
}
