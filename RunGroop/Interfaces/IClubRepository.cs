﻿using RunGroop.Models;

namespace RunGroop.Interfaces;

public interface IClubRepository
{
    Task<IEnumerable<Club>> GetAll();
    Task<Club> GetByIdAsync(int id);
    Task<IEnumerable<Club>> GetClubByCity(string City);
    bool Add(Club club);
    bool Update(Club club);
    bool Delete(Club club);
    bool Save();

}
