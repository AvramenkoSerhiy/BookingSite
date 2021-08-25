using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.ConsoleV
{
    class PageOfStore
    {
        private IServiceOfStore _serviceOfStore;
        private SelectedItems _selectedItems;

        public PageOfStore(IServiceOfStore serviceOfStore, SelectedItems selectedItems)
        {
            _serviceOfStore = serviceOfStore;
            _selectedItems = selectedItems;
        }

        public void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Console.Write("\n------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoose a Store.\n");
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
                ShowAllStores();
            }
            else if (command == "2")
            {
                ChooseStore();
            }
            else if (command == "3")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - Show all stores.");
            Console.WriteLine("2 - Choose store.");
            Console.WriteLine("3 - Back to main menu.");
        }

        private void ChooseStore()
        {
            Console.Write("\nWrite store ID>> ");
            string storeIdStr = Console.ReadLine();
            int storeId;
            if (int.TryParse(storeIdStr, out storeId))
            {
                _selectedItems.SelectedStore = _serviceOfStore.GetStoreByID(storeId);
            }
            else if (_selectedItems.SelectedStore == null)
            {
                Console.WriteLine("No store with such ID.");
            }
            else
            {
                Console.WriteLine("\nWrong ID.");
            }

        }

        private void ShowAllStores()
        {
            List<ViewOfStore> stores = _serviceOfStore.GetAllStores().ToList();
            WriteListOfStores(stores);
        }
        private void WriteListOfStores(List<ViewOfStore> stores)
        {
            Console.WriteLine("     Name            City        Country        Address                      ");
            foreach (ViewOfStore store in stores)
            {
                Console.WriteLine($"{store.Id,-4} {store.Name,-15} {store.City,-11} {store.Country,-14} {store.Address}");
            }
        }
    }
}
