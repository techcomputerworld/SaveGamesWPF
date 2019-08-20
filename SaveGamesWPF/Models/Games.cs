using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveGamesWPF.Models
{
    public class Games
    {
        //ObservableCollection<Games> GamesCollection { get; set; }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //ubicación donde se guardan los juegos en la carpeta del usuario donde vas a guardar el juego
        private string saveGames;
        public string SaveGames
        {
            get { return saveGames; }
            set { saveGames = value; }
        }
        //Ubicación donde se guarda el juego en la carpeta del juego 
        private string saveGamesGame;
        public string SaveGamesGame
        {
            get { return saveGamesGame; }
            set { saveGamesGame = value; }
        }
        //imagen del juego por si quieres almacenarla.
        //si quiero almacenar varias imagenes ya hare otra versión del programa.
        private string image;
        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public Games (int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Games (int id, string name, string saveGames, string saveGamesGame)
        {
            Id = id;
            Name = name;
            SaveGames = saveGames;
            SaveGamesGame = saveGamesGame;
        }


    }
}
