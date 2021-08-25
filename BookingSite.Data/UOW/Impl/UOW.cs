using BookingSite.Data.Entities;
using BookingSite.Data.Repositories.Abstr;
using BookingSite.Data.Repositories.Impl;
using BookingSite.Data.UOW.Abstr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSite.Data.UOW.Impl
{
    public class UnitOW : IUOW
    {
        public IRepositoryOfBooking RepositoryOfBooking { get; set; }
        public IRepositoryOfDurationOfBooking RepositoryOfDurationOfBooking { get; set; }
        public IRepositoryOfProduct RepositoryOfProduct { get; set; }
        public IRepositoryOfTypeOfProduct RepositoryOfTypeOfProduct { get; set; }
        public IRepositoryOfStore RepositoryOfStore { get; set; }

        private DBContextOfApp _dBContest;

        public UnitOW(IRepositoryOfBooking repositoryOfBooking, IRepositoryOfDurationOfBooking repositoryOfDurationOfBooking, IRepositoryOfProduct repositoryOfProduct, IRepositoryOfTypeOfProduct repositoryOfTypeOfProduct, IRepositoryOfStore repositoryOfStore, DBContextOfApp dBContest)
        {
            RepositoryOfBooking = repositoryOfBooking;
            RepositoryOfDurationOfBooking = repositoryOfDurationOfBooking;
            RepositoryOfProduct = repositoryOfProduct;
            RepositoryOfTypeOfProduct = repositoryOfTypeOfProduct;
            RepositoryOfStore = repositoryOfStore;
            _dBContest = dBContest;
        }

        ~UnitOW()
        {
            _dBContest.Dispose();
        }

        public void Dispose()
        {
            _dBContest.Dispose();
        }

        public void Save()
        {
            _dBContest.SaveChanges();
        }
    }
}
