using BookingSite.Model.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Abstr
{
    public interface IServiceOfBooking
    {
        public void MakeBooking(ViewOfBooking booking);
        public IEnumerable<ViewOfBooking> GetAllBookings();
        public void DeleteBooking(int bookingID);
        public ViewOfBooking GetBookingByID(int bookingID);
        public bool DoesProductAvailable(int productId);
    }
}
