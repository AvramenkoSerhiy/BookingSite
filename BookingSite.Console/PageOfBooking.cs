using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;

namespace BookingSite.ConsoleV
{
    class PageOfBooking
    {
        private IServiceOfBooking _serviceOfBooking;
        private SelectedItems _selectedItems;

        public PageOfBooking(IServiceOfBooking serviceOfBooking, SelectedItems selectedItems)
        {
            _serviceOfBooking = serviceOfBooking;
            _selectedItems = selectedItems;
        }

        public void Run()
        {
            bool backToMenu = false;
            while (!backToMenu)
            {
                Console.Write("\n------------------------------------------------------------------------------------------");
                Console.WriteLine("\nChoosing a Product. \n");
                if (_selectedItems.SelectedTypeOfProduct != null)
                    Console.WriteLine($"\nSelected type of product ID {_selectedItems.SelectedTypeOfProduct.Id,-4}");
                if (_selectedItems.SelectedProduct != null)
                    Console.WriteLine($"\nSelected type of product ID {_selectedItems.SelectedProduct.Id,-4}");
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
                ShowListOfBookings();
            }
            else if (command == "2")
            {
                MakeBooking();
            }
            else if (command == "3")
            {
                DeleteBooking();
            }
            else if (command == "4")
            {
                backToMenu = true;
            }
            return backToMenu;
        }

        private void WriteListOfCommand()
        {
            Console.WriteLine("1 - Show list of booking.");
            Console.WriteLine("2 - Make a booking.");
            Console.WriteLine("3 - Delete booking.");
            Console.WriteLine("4 - Back to main menu.");
        }
        private void DeleteBooking()
        {
            Console.Write("\nWrite booking ID>> ");
            string bookingIdStr = Console.ReadLine();
            int bookingId;
            if (!int.TryParse(bookingIdStr, out bookingId))
            {
                Console.WriteLine("\nWrong ID.");
            }
            else if (_serviceOfBooking.GetBookingByID(bookingId) == null)
            {
                Console.WriteLine("There is no such booking.");
            }
            else
            {
                _serviceOfBooking.DeleteBooking(bookingId);
            }
        }

        private void MakeBooking()
        {
            if (_selectedItems.SelectedProduct == null)
            {
                Console.WriteLine("\n You have not choose a product, please choose a product.");
            }
            else if (!_serviceOfBooking.DoesProductAvailable(_selectedItems.SelectedProduct.Id))
            {
                Console.WriteLine("Product doesn`t available, please choose another one.");
            }
            else
            {
                _serviceOfBooking.MakeBooking(new ViewOfBooking()
                {
                    ProductID = _selectedItems.SelectedProduct.Id,
                    DataOfBooking
                    = DateTime.Now
                });
            }
        }

        private void ShowListOfBookings()
        {
            Console.WriteLine("ID    Product ID    Date of Booking");
            foreach (ViewOfBooking booking in _serviceOfBooking.GetAllBookings())
            {
                Console.WriteLine($"{booking.Id,-5} {booking.ProductID,-13} {booking.DataOfBooking.ToShortDateString()}");
            }
        }
    }
}
