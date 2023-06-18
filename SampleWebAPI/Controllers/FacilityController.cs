using Core;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleWebAPI.Models;
using SampleWebAPI.Models.Facility;
using SampleWebAPI.Service.Interfaces;

namespace SampleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class FacilityController : ControllerBase
    {
        private readonly ILogger<FacilityController> _logger;
        private readonly IFacilityService _service;

        public FacilityController(ILogger<FacilityController> logger, IFacilityService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet(Name = "GetFacilties")]
        public ResultWithData<Facility> GetFacilties()
        {
            ResultWithData<Facility> result = new();
            try
            {
                result.List = _service.GetAllFacilities().ToList();
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {

                result.ErrorMsg = ex.Message; 
            }

            return result;
        }

        [HttpGet("{FacilityId}", Name ="GetFacilitiesById")]
        public ResultWithData<Facility> GetFacilityById(Guid FacilityId)
        {
            ResultWithData<Facility> result = new();
            try
            {
                result.Data = _service.GetFacilityById(FacilityId).FirstOrDefault();
                result.IsSuccess = true;
            }
            catch (Exception e)
            {

                result.ErrorMsg = e.Message;
            }
            return result;
        }

    }
}