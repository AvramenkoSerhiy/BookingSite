using BookingSite.Data.Entities;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Mappers
{
    public static class MapperOfProduct
    {
        public static Product ToEntityOfData(ViewOfProduct entityOfView)
        {
            Product entityOfData = new Product();
            entityOfData.Id = entityOfView.Id;
            entityOfData.TypeOfProductId = entityOfView.TypeOfProductId;
            entityOfData.StoreId = entityOfView.StoreId;
            entityOfData.Price = entityOfView.Price;
            entityOfData.DateOfProducing = entityOfView.DateOfProducing;
            return entityOfData;
        }

        public static ViewOfProduct ToEntityOfView(Product entityOfData)
        {
            ViewOfProduct entityOfView = new ViewOfProduct();
            entityOfView.Id = entityOfData.Id;
            entityOfView.TypeOfProductId = entityOfData.TypeOfProductId;
            entityOfView.StoreId = entityOfData.StoreId;
            entityOfView.Price = entityOfData.Price;
            entityOfView.DateOfProducing = entityOfData.DateOfProducing;
            return entityOfView;
        }
    }
}
