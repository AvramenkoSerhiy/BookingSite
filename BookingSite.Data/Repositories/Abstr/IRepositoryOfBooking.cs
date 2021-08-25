using BookingSite.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Abstr
{
    public interface IRepositoryOfBooking : IRepository<Booking, int>
    {
    }
}
