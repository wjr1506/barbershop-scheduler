using System.ComponentModel.DataAnnotations;

namespace BarberSchedules.Models
{
    public class ScheduleModel
    {
        public int Id { get; set; }
        [Required]
        public int ServiceId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int BarberId { get; set; }
        public int Service { get; set; }
        [Required]
        public DateTime SchedulingDate { get; set; }
        public bool IsConfirmed { get; set; }
    }
}