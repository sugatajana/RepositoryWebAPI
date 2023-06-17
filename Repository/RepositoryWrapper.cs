using Core;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly ApplicationDbContext _context;
        private IFacilityBookingRepository _facilityBookingRepository;
        private IFacilityRepository _facilityRepository;
        public RepositoryWrapper(ApplicationDbContext context) => _context = context;


        public IFacilityBookingRepository FacilityBookingRepository
        {
            get
            {
                if (_facilityBookingRepository == null)
                {
                    _facilityBookingRepository = new FacilityBookingRepository(_context);
                }
                return _facilityBookingRepository;
            }
        }

        public IFacilityRepository FacilityRepository
        {
            get
            {
                if (_facilityRepository == null)
                {
                    _facilityRepository = new FacilityRepository(_context);
                }
                return _facilityRepository;
            }
        }
    }
}
