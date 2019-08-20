using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaveGamesWPF.DbConector
{
    public class GamesDbContext : DbContext
    {
        public DbSet<GamesDb> GamesDb { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Esto es usando SQLite con SQL Server o MySQL o PostgreSQL no sé como seria
            //This is using SQLite with SQL Server or MySQL or PostgreSQL I don't know how serious
            optionsBuilder.UseSqlite("Data Source=Games.sqlite");
        }
        //constructor
        public GamesDbContext()
        {

        }
    }
}
