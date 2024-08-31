using System;
using RunGroop.Models;

namespace RunGroop.Interfaces;

public interface IDashboardRepository
{
    Task<List<Race>> GetAllUserRaces();
    Task<List<Club>> GetAllUserClubs();

}
