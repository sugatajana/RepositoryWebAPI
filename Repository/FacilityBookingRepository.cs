using Core;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FacilityBookingRepository : RepositoryBase<FacilityBooking>, IFacilityBookingRepository
    {
        public FacilityBookingRepository(ApplicationDbContext context):base(context) { }
    }
}
