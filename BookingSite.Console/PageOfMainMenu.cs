using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.ConsoleV
{
    public class PageOfMainMenu
    {
        private PageOfBooking _pageOfBooking;
        private PageOfProduct _pageOfProduct;
        private PageOfStore _pageOfStore;
        private PageOfTypeOfProduct _pageOfTypeOfProduct;
        
        private SelectedItems _selectedItems;

        private IServiceOfBooking _serviceOfBooking;
        private IServiceOfProduct _serviceOfProduct;
        private IServiceOfStore _serviceOfStore;
        private IServiceOfTypeOfProduct _serviceOfTypeOfProduct;

        public PageOfMainMenu(IServiceOfBooking serviceOfBooking, IServiceOfProduct serviceOfProduct, IServiceOfStore serviceOfStore, IServiceOfTypeOfProduct serviceOfTypeOfProduct)
        {
            _serviceOfBooking = serviceOfBooking;
            _serviceOfProduct = serviceOfProduct;
            _serviceOfStore = serviceOfStore;
            _serviceOfTypeOfProduct = serviceOfTypeOfProduct;
            
            _selectedItems = new SelectedItems();

            _pageOfBooking = new PageOfBooking(serviceOfBooking, _selectedItems);
            _pageOfProduct = new PageOfProduct(serviceOfProduct, _selectedItems, serviceOfBooking);
            _pageOfStore = new PageOfStore(serviceOfStore, _selectedItems);
            _pageOfTypeOfProduct = new PageOfTypeOfProduct(serviceOfTypeOfProduct, _selectedItems);
        }

        public void Run()
        {
            bool continueRunning = true;
            while (continueRunning)
            {

                Console.Write("\n------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Main Menu\n");
                if (_selectedItems.SelectedTypeOfProduct != null)
                    Console.WriteLine($"\nSelected type of product ID {_selectedItems.SelectedTypeOfProduct.Id,-4}");
                if (_selectedItems.SelectedStore != null)
                    Console.WriteLine($"Selected store ID {_selectedItems.SelectedStore.Id,-4}\n");
                WriteListOfCommand();

                Console.Write("\n>>");
                string command = Console.ReadLine();

                continueRunning = ProcessCommand(command);

            }
        }

        private bool ProcessCommand(string command)
        {
            bool continueRunning = true;
            if (command == "1")
            {
                _pageOfTypeOfProduct.Run();
            }
            else if (command == "2")
            {
                _pageOfStore.Run();
            }
            else if (command == "3")
            {
                _pageOfProduct.Run();
            }
            else if (command == "4")
            {
                _pageOfBooking.Run();
            }
            else if (command == "5")
            {
                continueRunning = false;
            }
            else
            {
                Console.WriteLine("Wrong command, please enter another one. ");
            }
            return continueRunning;


        }
        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - Choose a type of product.");
            Console.WriteLine("2 - Choose a store.");
            Console.WriteLine("3 - Choose a product.");
            Console.WriteLine("4 - Make a booking.");
            Console.WriteLine("5 - Close program.");
        }
        public void WriteErrorMeesage(string error)
        {
            Console.WriteLine(error);
        }

    }
}
