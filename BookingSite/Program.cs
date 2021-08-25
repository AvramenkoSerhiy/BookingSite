using BookingSite.ConsoleV;
using BookingSite.Model.Services.Abstr;
using BookingSite.Model.Services.Impl;
using System;

namespace BookingSite
{
    class Program
    {
        static void Main(string[] args)
        {
            IServiceOfBooking serviceOfBooking = new ServiceOfBooking();
            IServiceOfProduct serviceOfProduct = new ServiceOfProduct();
            IServiceOfStore serviceOfStore = new ServiceOfStore();
            IServiceOfTypeOfProduct serviceOfTypeOfProduct = new ServiceOfTypeOfProduct();
            PageOfMainMenu mainMenuCP = new PageOfMainMenu(serviceOfBooking, serviceOfProduct, serviceOfStore, serviceOfTypeOfProduct);
            mainMenuCP.Run(); 
        }
    }
}
