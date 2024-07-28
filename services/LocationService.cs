using BarberSchedules.Data;
using BarberSchedules.Models;
using BarberSchedules.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BarberSchedules.Services
{
    public class LocationService : ILocationInterface
    {
        private readonly AplicationDBContext _context;

        public LocationService(AplicationDBContext context)
        {
            _context = context;
        }

        public async Task<LocationModel> CreateLocation(LocationModel location)
        {
            try
            {
                if (location == null) throw new Exception("Informe os dados para o cadastro");

                _context.Location.Add(location);

                await _context.SaveChangesAsync();

                return _context.Location.FirstOrDefault(location => location.Id == location.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<LocationModel>> DeleteById(int id)
        {
            try
            {
                LocationModel? selectedLocation = _context.Location.AsNoTracking().FirstOrDefault(location => location.Id == id);
                if (selectedLocation == null) throw new Exception("Locação não encontrada");

                _context.Location.Remove(selectedLocation);
                await _context.SaveChangesAsync();

                return _context.Location.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<LocationModel> GetById(int id)
        {
            try
            {
                LocationModel? selectedLocation = _context.Location.FirstOrDefault(Location => Location.Id == id);

                if (selectedLocation == null) throw new Exception("Locação não encontrada");

                return selectedLocation;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<LocationModel>> GetLocation()
        {
            try { return _context.Location.ToList(); }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public async Task<LocationModel> UpdateById(LocationModel location)
        {
            try
            {
                LocationModel? selectedLocation = _context.Location.AsNoTracking().FirstOrDefault(l => l.Id == location.Id);

                if (selectedLocation == null) throw new Exception("Nenhuma locação encontrada");

                _context.Location.Update(location);
                await _context.SaveChangesAsync();

                return _context.Location.AsNoTracking().FirstOrDefault(l => l.Id == location.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}