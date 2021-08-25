using BookingSite.Data.Repositories.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.UOW.Abstr
{
    public interface IUOW : IDisposable
    {
        IRepositoryOfBooking RepositoryOfBooking { get; set; }
        IRepositoryOfDurationOfBooking RepositoryOfDurationOfBooking { get; set; }
        IRepositoryOfProduct RepositoryOfProduct { get; set; }
        IRepositoryOfTypeOfProduct RepositoryOfTypeOfProduct { get; set; }
        IRepositoryOfStore RepositoryOfStore { get; set; }
        void Save();
    }
}
