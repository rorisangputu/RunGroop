using System;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Repository;

public class UserRepository : IUserRepository
{
    public Task<IEnumerable<AppUser>> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task<AppUser> GetUserId(string id)
    {
        throw new NotImplementedException();
    }

    public bool Add(AppUser user)
    {
        throw new NotImplementedException();
    }

    public bool Update(AppUser user)
    {
        throw new NotImplementedException();
    }

    public bool Delete(AppUser user)
    {
        throw new NotImplementedException();
    }

    public bool Save()
    {
        throw new NotImplementedException();
    }

}
