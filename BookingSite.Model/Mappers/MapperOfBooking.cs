using BookingSite.Model.View;
using BookingSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Model.Mappers
{
    class MapperOfBooking
    {
        public static Booking ToEntityOfData(ViewOfBooking entityOfView)
        {
            Booking entityOfData = new Booking();
            entityOfData.Id = entityOfView.Id;
            entityOfData.DataOfBooking = entityOfView.DataOfBooking;
            entityOfData.LastDayOfBooking = entityOfView.LastDayOfBooking;
            entityOfData.ProductID = entityOfView.ProductID;
            entityOfData.ClientName = entityOfView.ClientName;
            return entityOfData;
        }

        public static ViewOfBooking ToEntityOfView(Booking entityOfData)
        {
            ViewOfBooking entityOfView = new ViewOfBooking();
            entityOfView.Id = entityOfData.Id;
            entityOfView.DataOfBooking = entityOfData.DataOfBooking;
            entityOfView.LastDayOfBooking = entityOfData.LastDayOfBooking;
            entityOfView.ProductID = entityOfData.ProductID;
            entityOfView.ClientName = entityOfData.ClientName;
            return entityOfView;
        }
    }
}
