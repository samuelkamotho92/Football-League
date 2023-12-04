using Football_League.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Services.TeamService
{
    public class Deleted
    {
        public void deleteTeam()
        {
            LeagueContext context = new LeagueContext();
            var team = context.teams.Find(4);
            Console.WriteLine($"{context.Entry(team).State}");
            context.teams.Remove(team);
            Console.WriteLine($"After deleting : {context.Entry(team).State}");
            context.SaveChanges();
            Console.WriteLine($"After saving : {context.Entry(team).State}");
        }
    }
}
