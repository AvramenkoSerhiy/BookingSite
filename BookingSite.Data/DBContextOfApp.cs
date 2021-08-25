using BookingSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data
{
    public class DBContextOfApp : DbContext
    {
        public DBContextOfApp() : base("bookingSitedb")
        {
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TypeOfProduct> TypesOfProduct { get; set; }
        public DbSet<DurationOfBooking> DurationOfBookings { get; set; }
    }
}
