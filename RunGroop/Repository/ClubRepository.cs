using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Repository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext context;
        public ClubRepository(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public bool Add(Club club)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Club club)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Club> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Club>> GetClubByCity(string City)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(Club club)
        {
            throw new NotImplementedException();
        }
    }
}


