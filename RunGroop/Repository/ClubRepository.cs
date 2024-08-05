using RunGroop.Models;

namespace RunGroop;

public class ClubRepository : IClubRepository
{
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
