using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.View
{
    public class ViewOfBooking
    {
        public static int nextId;

        public ViewOfBooking()
        {
        }

        static ViewOfBooking()
        {
            nextId = 0;
        }
        public int Id { get; set; }
        public DateTime DataOfBooking { get; set; }
        public DateTime LastDayOfBooking { get; set; }
        public int ProductID { get; set; }
        public string ClientName { get; set; }
    }
}
