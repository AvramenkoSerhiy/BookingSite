using BookingSite.Model.View;
using BookingSite.Model.Services.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Impl
{
    public class ServiceOfTypeOfProduct : IServiceOfTypeOfProduct
    {
        private List<ViewOfTypeOfProduct> _typesOfProduct;

        public ServiceOfTypeOfProduct()
        {
            _typesOfProduct = new List<ViewOfTypeOfProduct>();
            InitialiseData();
        }


        public IEnumerable<ViewOfTypeOfProduct> GetAllTypesOfProduct()
        {
            return _typesOfProduct.ToList();
        }


        public ViewOfTypeOfProduct GetTypesOfProductByID(int typeOfProductID)
        {
            return _typesOfProduct.Where(type => type.Id == typeOfProductID).FirstOrDefault();
        }
        public IEnumerable<ViewOfTypeOfProduct> FindByName(string name)
        {
            return _typesOfProduct.Where(type => type.Name.Contains(name ?? ""));
        }

        private void InitialiseData()
        {
            _typesOfProduct.Add(new ViewOfTypeOfProduct() { Id = 1, Name = "Phone", PriceRecommendation = 500.0f, ExpirationDate = 14 });
            _typesOfProduct.Add(new ViewOfTypeOfProduct() { Id = 2, Name = "Laptop", PriceRecommendation = 800.0f, ExpirationDate = 140 });
            _typesOfProduct.Add(new ViewOfTypeOfProduct() { Id = 3, Name = "TV", PriceRecommendation = 900.0f, ExpirationDate = 200 });
            _typesOfProduct.Add(new ViewOfTypeOfProduct() { Id = 4, Name = "Watch", PriceRecommendation = 400.0f, ExpirationDate = 20 });
            _typesOfProduct.Add(new ViewOfTypeOfProduct() { Id = 5, Name = "Headphone", PriceRecommendation = 40.0f, ExpirationDate = 10 });
        }


    }
}

