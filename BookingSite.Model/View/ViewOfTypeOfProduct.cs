using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.View
{
     public class ViewOfTypeOfProduct
    {
        public int Id { get; set; }
        public int ExpirationDate { get; set; }
        public string Name { get; set; }
        public float PriceRecommendation { get; set; }
    }
}
