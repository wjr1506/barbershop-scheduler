using System.ComponentModel.DataAnnotations;
using BarberSchedules.Enums;

namespace BarberSchedules.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        [MaxLength(255)]
        public string PhoneNumber { get; set; }
        public int Role { get; set; }
        public Guid Guid { get; set; }
        public bool Active { get; set; }
        public int? Services { get; set; } //to role barber
    }
}
