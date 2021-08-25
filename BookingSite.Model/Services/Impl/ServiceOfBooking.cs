using BookingSite.Model.View;
using BookingSite.Model.Services.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Services.Impl
{
    public class ServiceOfBooking : IServiceOfBooking
    {
        private List<ViewOfBooking> _bookings;

        public ServiceOfBooking()
        {
            _bookings = new List<ViewOfBooking>();
        }
        public void DeleteBooking(int bookingID)
        {
            _bookings.Remove(_bookings.Where(booking => booking.Id == bookingID).FirstOrDefault());
        }

        public IEnumerable<ViewOfBooking> GetAllBookings()
        {
            return _bookings.ToList();
        }

        public ViewOfBooking GetBookingByID(int bookingID)
        {
            return _bookings.Where(booking => booking.Id == bookingID).FirstOrDefault();
        }

        public void MakeBooking(ViewOfBooking booking)
        {
            _bookings.Add(new ViewOfBooking()
            {
                Id = ViewOfBooking.nextId,
                ProductID = booking.ProductID,
                DataOfBooking = booking.DataOfBooking,
                ClientName = booking.ClientName
            });
            ViewOfBooking.nextId++;
        }
        public bool DoesProductAvailable(int productId)
        {
            return !_bookings.Where(booking => booking.ProductID == productId).Any();
        }
    }
}
