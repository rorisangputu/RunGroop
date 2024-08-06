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
            throw new NotImplementedException();
        }

        public bool Delete(Race race)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Race>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Race>> GetAllRacesByCity(string City)
        {
            throw new NotImplementedException();
        }

        public Task<Race> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Race race)
        {
            throw new NotImplementedException();
        }
    }
}