using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveGamesWPF.Models;

namespace SaveGamesWPF.DbConector
{
    public class DbConector
    {
        public GamesCollection listarGames()
        {
            GamesCollection lista = new GamesCollection();
            GamesDbContext dbContext = new GamesDbContext();
            var listaGames = dbContext.GamesDb;
            
            
            return lista;
        }

    }
}
