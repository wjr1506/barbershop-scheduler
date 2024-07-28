using System.Text.Json.Serialization;

namespace BarberSchedules.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserRole
    {
        Customer = 0,
        Barber = 1
    }
}
