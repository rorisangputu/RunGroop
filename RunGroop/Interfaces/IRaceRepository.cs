﻿using RunGroop.Models;

namespace RunGroop.Interfaces;

public interface IRaceRepository
{
    Task<IEnumerable<Race>> GetAll();
    Task<Race> GetByIdAsync(int id);
    Task<Race> GetByIdAsyncNoTracking(int id);
    Task<IEnumerable<Race>> GetAllRacesByCity(string City);
    bool Add(Race race);
    bool Update(Race race);
    bool Delete(Race race);
    bool Save();

}
