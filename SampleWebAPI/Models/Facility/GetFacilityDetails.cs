namespace SampleWebAPI.Models.Facility
{
    public class GetFacilityDetails
    {
        public Guid FacilityId { get; set; }
        public string? FacilityName { get; set; }
        public Guid FacilityTypeId { get; set; }
        public decimal RateHourly { get; set; }
        public decimal AdditonalHourRate { get; set; }
        public decimal DailyRate { get; set; }
        public decimal AdditonalDayRate { get; set; }
        public decimal SecurityDeposit { get; set; }
        public DateTime StartTIme { get; set; }
        public DateTime EndTime { get; set; }
        public int FacilityCapacilty { get; set; }
        public int BookingCapacilty { get; set; }
        public DateTime MaintainenceStartDate { get; set; }
        public DateTime MaintainenceEndDate { get; set; }
        public Guid ParkId { get; set; }
        public bool isActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string? Description { get; set; }
        public Guid TaxtypeId { get; set; }
    }
}
