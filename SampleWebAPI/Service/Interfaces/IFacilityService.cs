using Entities.Models;

namespace SampleWebAPI.Service.Interfaces
{
    public interface IFacilityService
    {
        IQueryable<Facility> GetAllFacilities();
        IQueryable<Facility> GetFacilityById(Guid id);
    }
}
