using System;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Repository;

public class DashboardRepository : IDashboardRepository
{
    public Task<List<Club>> GetAllUserClubs()
    {
        throw new NotImplementedException();
    }

    public Task<List<Race>> GetAllUserRaces()
    {
        throw new NotImplementedException();
    }
}
