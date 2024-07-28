using BarberSchedules.Models;

namespace BarberSchedules.Services.Interfaces
{
    public interface ILocationInterface
    {
        Task<IEnumerable<LocationModel>> GetLocation();
        Task<LocationModel> GetById(int id);
        Task<LocationModel> CreateLocation(LocationModel location);
        Task<LocationModel> UpdateById(LocationModel location);
        Task<IEnumerable<LocationModel>> DeleteById(int id);
    }
}