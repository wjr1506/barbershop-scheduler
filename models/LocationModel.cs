using System.ComponentModel.DataAnnotations;

namespace BarberSchedules.Models
{
    public class LocationModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
        public Guid Guid { get; set; }
        public bool Active { get; set; }
    }
}
