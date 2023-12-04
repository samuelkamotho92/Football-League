using Football_League.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Services.TeamService
{
    public class Update
    {
        public void updateTeam()
        {
            LeagueContext context = new LeagueContext();
            var team = context.teams.Find(2);
            if (team != null)
            {
                //Update our value
                Console.WriteLine($"Before Update state: {context.Entry(team).State}");
                team.Name = "London FC";
                Console.WriteLine($"After Update state: {context.Entry(team).State}");
                context.SaveChanges();
                Console.WriteLine($"After saving state: {context.Entry(team).State}");
                Console.WriteLine("Update made successfully");
            }
        }
    }
}
