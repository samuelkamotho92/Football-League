using Football_League.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Services.TeamService
{
    public class Read
    {
        public void readTeam()
        {
LeagueContext leagueContext = new LeagueContext();
//get teams
List<Team> teams = leagueContext.teams.ToList();
            foreach (var team in teams)
            {
                Console.WriteLine(leagueContext.Entry(team).State);
                Console.WriteLine($"{team.Id} : {team.Name}");
            }
        }
    }
}
