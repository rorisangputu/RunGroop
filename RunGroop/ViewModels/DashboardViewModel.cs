using System;
using RunGroop.Models;

namespace RunGroop.ViewModels;

public class DashboardViewModel
{
    public List<Race> Races { get; set; }
    public List<Club> Clubs { get; set; }
}
