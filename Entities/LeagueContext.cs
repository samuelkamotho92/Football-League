using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Football_League.Entities
{
    public class LeagueContext : DbContext
    {
        public LeagueContext() :base()
        { 

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configurating the source
            var configBuilder =   new  ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            //get the path
            var configSection = configBuilder.GetSection("ConnectionStrings");
            //get string
            var connectionString = configSection["SQLServerConnection"] ?? null;
            //
            optionsBuilder.UseSqlServer(connectionString,builder=>builder.EnableRetryOnFailure());
        }
        public DbSet<Team> teams { get; set; }
        public DbSet<Coach> coaches { get; set; }
    }
}
