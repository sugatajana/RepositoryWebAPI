using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("T01200_FacilityBooking")]
    public class FacilityBooking
    {
        [Key]
        public Guid FacilityBookingId { get; set; }
        public int UserId { get; set; }
        public Guid FacilityId { get; set; }
        public Guid BookingType { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Duration { get; set; }
        public decimal Amount { get; set; }
        public decimal GST { get; set; }
        public decimal AdditonalDayRate { get; set; }
        public decimal SecurityDeposit { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal RefundDeposit { get; set; }
        public bool BookingStatus { get; set; }
        public bool isActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal AdditionalHourlyRate { get; set; }
        public Guid TransactionId { get; set; }
        public Guid TransationStatus { get; set; }
        public decimal RefundTaxAmount { get; set; }
    }
}
