using System;
using RunGroop.Models;

namespace RunGroop.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<AppUser>> GetAllUsers();
    Task<AppUser> GetUserId(string id);
    bool Add(AppUser user);
    bool Update(AppUser user);
    bool Delete(AppUser user);
    bool Save();
}
