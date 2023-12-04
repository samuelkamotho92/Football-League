using Football_League.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_League.Services
{
    public class Create
    {
        public void createTeam()
        {
            try
            {
                Console.WriteLine("Enter Team Name");
                string teamName = Console.ReadLine();
                Console.WriteLine("Enter Team Description");
                string teamDescription = Console.ReadLine();
                LeagueContext context = new LeagueContext();
                Team team = new Team()
                {
                    Name = teamName,
                    Description = teamDescription
                };
                Console.WriteLine($"Current State Before: {context.Entry(team).State}");
                context.teams.Add(team);
                Console.WriteLine($"State after adding: {context.Entry(team).State}");
                context.SaveChanges();
                Console.WriteLine($"State after saving: {context.Entry(team).State}");
                //add a new team details
                Console.WriteLine($"{team.Name} created successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
}
