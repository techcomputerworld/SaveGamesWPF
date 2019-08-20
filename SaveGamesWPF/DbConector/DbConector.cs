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
            lista.Add(new Games(1, "");
            lista.Add(new Games(2, "Juan"));
            //lista.Add(new Persona(3, "Diego"));
            //lista.Add(new Persona(4, "Luis"));
            return lista;
        }

    }
}
