using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberSchedules.Models
{
    public class ServiceModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public Guid Guid { get; set; }
        public DateTime Duration { get; set; }
        public int? BarberId { get; set; } //to role barber
    }
}