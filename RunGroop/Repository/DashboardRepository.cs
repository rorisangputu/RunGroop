using System;
using RunGroop.Data;
using RunGroop.Interfaces;
using RunGroop.Models;

namespace RunGroop.Repository;

public class DashboardRepository : IDashboardRepository
{
    private readonly ApplicationDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public DashboardRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }
    public async Task<List<Club>> GetAllUserClubs()
    {
        var curUser = _httpContextAccessor.HttpContext?.User;
        var userClubs = _context.Clubs.Where(r => r.AppUser.Id == curUser.ToString());
        return userClubs.ToList();
    }

    public async Task<List<Race>> GetAllUserRaces()
    {
        var curUser = _httpContextAccessor.HttpContext?.User;
        var userRaces = _context.Races.Where(r => r.AppUser.Id == curUser.ToString());
        return userRaces.ToList();
    }
}
