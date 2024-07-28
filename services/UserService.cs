using BarberSchedules.Data;
using BarberSchedules.Models;
using BarberSchedules.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberSchedules.Services
{
    public class UserService : IUserInterface
    {
        private readonly AplicationDBContext _context;

        public UserService(AplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserModel>> GetUsers()
        {
            try
            {
                return _context.User.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<UserModel> GetById(int id)
        {
            try
            {
                UserModel? userSelected = _context.User.FirstOrDefault(u => u.Id == id);

                if (userSelected == null)
                {
                    throw new Exception("Usuário não encontrado");
                }

                return userSelected;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<UserModel> CreateUser(UserModel user)
        {
            try
            {
                if (user == null)
                {
                    throw new Exception("Usuário não encontrado");
                }

                _context.User.Add(user);
                await _context.SaveChangesAsync();

                return _context.User.ToList().FirstOrDefault(u => u.Id == user.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<UserModel> UpdateById(UserModel user)
        {
            try
            {
                UserModel? userSelected = _context.User.AsNoTracking().FirstOrDefault(u => u.Id == user.Id);

                if (userSelected == null) { throw new Exception("Usuário não encontrado"); }

                _context.User.Update(user);
                await _context.SaveChangesAsync();

                return _context.User.FirstOrDefault(u => u.Id == user.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
        public async Task<IEnumerable<UserModel>> DeleteById(int id)
        {
            try
            {
                UserModel? userSelected = _context.User.AsNoTracking().FirstOrDefault(u => u.Id == id);

                if (userSelected == null)
                {
                    throw new Exception("Usuário não encontrado");
                }

                _context.User.Remove(userSelected);
                await _context.SaveChangesAsync();

                return _context.User.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}