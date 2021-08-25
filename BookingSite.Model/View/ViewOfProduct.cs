using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.View
{
    public class ViewOfProduct
    {
        public int Id { get; set; }
        public int TypeOfProductId { get; set; }
        public int StoreId { get; set; }
        public int Price { get; set; }
        public DateTime DateOfProducing { get; set; }
    }
}
