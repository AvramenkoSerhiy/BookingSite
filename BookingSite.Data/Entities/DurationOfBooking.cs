using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Entities
{
    public class DurationOfBooking : BaseEntity<int>
    {
        public int AmountOfDays { get; set; }
    }
}
