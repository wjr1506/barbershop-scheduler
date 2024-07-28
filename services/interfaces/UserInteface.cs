using BarberSchedules.Models;

namespace BarberSchedules.Services.Interfaces
{
    public interface IUserInterface
    {
        Task<IEnumerable<UserModel>> GetUsers();
        Task<UserModel> GetById(int id);
        Task<UserModel> CreateUser(UserModel user);
        Task<UserModel> UpdateById(UserModel user);
        Task<IEnumerable<UserModel>> DeleteById(int id);
    }
}