using Core;
using Entities.Models;
using SampleWebAPI.Service.Interfaces;

namespace SampleWebAPI.Service.Implements
{
    public class FacilityService : IFacilityService
    {
        private readonly IRepositoryWrapper _repository;

        public FacilityService(IRepositoryWrapper repository) => _repository = repository;

        public IQueryable<Facility> GetAllFacilities()
        {
            return _repository.FacilityRepository.GetAll();
        }

        public IQueryable<Facility> GetFacilityById(Guid id)
        {
            return _repository.FacilityRepository.GetById(x => x.FacilityId == id);
        }
    }
}
