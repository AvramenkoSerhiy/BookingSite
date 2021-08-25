using BookingSite.Data.Entities;
using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Mappers
{
    public static class MapperOfTypeOfProduct
    {
        public static TypeOfProduct ToEntityOfData(ViewOfTypeOfProduct entityOfView)
        {
            TypeOfProduct entityOfData = new TypeOfProduct();
            entityOfData.Id = entityOfView.Id;
            entityOfData.ExpirationDate = entityOfView.ExpirationDate;
            entityOfData.Name = entityOfView.Name;
            entityOfData.PriceRecomendation = entityOfView.PriceRecommendation;
            return entityOfData;
        }

        public static ViewOfTypeOfProduct ToEntityOfView(TypeOfProduct entityOfData)
        {
            ViewOfTypeOfProduct entityOfView = new ViewOfTypeOfProduct();
            entityOfView.Id = entityOfData.Id;
            entityOfView.ExpirationDate = entityOfData.ExpirationDate;
            entityOfView.Name = entityOfData.Name;
            entityOfView.PriceRecommendation = entityOfData.PriceRecomendation;
            return entityOfView;
        } 
    }
}
