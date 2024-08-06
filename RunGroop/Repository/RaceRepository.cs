using Microsoft.EntityFrameworkCore;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Repository
{
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext context;
        public RaceRepository(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public bool Add(Race race)
        {
            context.Add(race);
            return Save();
        }

        public bool Delete(Race race)
        {
            context.Remove(race);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAll()
        {
            return await context.Races.ToListAsync();
        }

        public async Task<IEnumerable<Race>> GetAllRacesByCity(string City)
        {
            return await context.Races.Where(c => c.Address.City.Contains(City)).ToListAsync();
        }

        public async Task<Race> GetByIdAsync(int id)
        {
            return await context.Races.FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Race race)
        {
            context.Update(race);
            return Save();
        }
    }
}