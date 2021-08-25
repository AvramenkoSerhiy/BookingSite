using BookingSite.Data.Entities;
using BookingSite.Data.Repositories.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.Repositories.Impl
{
    class RepositoryOfBooking : Repository<Booking, int>, IRepositoryOfBooking
    {
        public RepositoryOfBooking(DBContextOfApp dBContest) : base(dBContest)
        {
        }
    }
}
