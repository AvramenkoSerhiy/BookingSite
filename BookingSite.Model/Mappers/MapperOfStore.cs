using BookingSite.Data.Entities;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Mappers
{
    class MapperOfStore
    {
        public static Store ToEntityOfData(ViewOfStore entityOfView)
        {
            Store entityOfData = new Store();
            entityOfData.Id = entityOfView.Id;
            entityOfData.Name = entityOfView.Name;
            entityOfData.Country = entityOfView.Country;
            entityOfData.City = entityOfView.City;
            entityOfData.Address = entityOfView.Address;
            entityOfData.ContactNumber = entityOfView.ContactNumber;
            return entityOfData;
        }

        public static ViewOfStore ToEntityOfView(Store entituOfData)
        {
            ViewOfStore entityOfView = new ViewOfStore();
            entityOfView.Id = entituOfData.Id;
            entityOfView.Name = entituOfData.Name;
            entityOfView.Country = entituOfData.Country;
            entityOfView.City = entituOfData.City;
            entityOfView.Address = entituOfData.Address;
            entityOfView.ContactNumber = entituOfData.ContactNumber;
            return entityOfView;
        }
    }
}
