using BookingSite.Model.Services.Abstr;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Impl
{
    public class ServiceOfStore : IServiceOfStore
    {
        private List<ViewOfStore> _stores;

        public ServiceOfStore()
        {
            _stores = new List<ViewOfStore>();
            InitialiseData();

        }

        public IEnumerable<ViewOfStore> GetAllStores()
        {
            return _stores.ToList();
        }

        public ViewOfStore GetStoreByID(int storeID)
        {
            return _stores.Where(store => store.Id == storeID).FirstOrDefault();
        }

        private void InitialiseData()
        {
            _stores.Add(new ViewOfStore() { Id = 1, Address = "Dmytrivska street", City = "Kyiv", ContactNumber = 380123456, Country = "Ukraine", Name = "Brain" });
            _stores.Add(new ViewOfStore() { Id = 2, Address = "Sportivnaya square ", City = "Kyiv", ContactNumber = 380234567, Country = "Ukraine", Name = "Eldorado" });
            _stores.Add(new ViewOfStore() { Id = 3, Address = "Antonovycha street", City = "Kyiv", ContactNumber = 380345678, Country = "Ukraine", Name = "Foxtrot" });
            _stores.Add(new ViewOfStore() { Id = 4, Address = "Borshchahivska street", City = "Kyiv", ContactNumber = 380456789, Country = "Ukraine", Name = "Comfy" });
            _stores.Add(new ViewOfStore() { Id = 5, Address = "Velyka Vasylkivska street", City = "Kyiv", ContactNumber = 380567890, Country = "Ukraine", Name = "MOYO" });
        }
    }
}

