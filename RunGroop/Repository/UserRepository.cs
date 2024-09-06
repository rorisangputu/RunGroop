using System;
using Microsoft.EntityFrameworkCore;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<AppUser>> GetAllUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<AppUser> GetUserById(string id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public bool Add(AppUser user)
    {
        throw new NotImplementedException();
    }

    public bool Update(AppUser user)
    {
        _dbContext.Update(user);
        return Save();
    }

    public bool Delete(AppUser user)
    {
        throw new NotImplementedException();
    }

    public bool Save()
    {
        var saved = _dbContext.SaveChanges();
        return saved > 0 ? true : false;
    }

}
