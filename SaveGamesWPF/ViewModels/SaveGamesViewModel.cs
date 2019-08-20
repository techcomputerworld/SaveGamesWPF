using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using SaveGamesWPF.Core;
using SaveGamesWPF.Models;
using SaveGamesWPF.DbConector;
using SaveGamesWPF.Core.Commands;

namespace SaveGamesWPF.ViewModels
{
    public class SaveGamesViewModel : IGeneric
    {
        private GamesCollection listaGames = new GamesCollection();
        public GamesCollection ListaGames
        {
            get { return listaGames; }
            set { listaGames = value; }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                RaisePropertyChanged("name");
            }
        }
        /*
        public GamesCollection ListaGames
        {
            get { return listaGames; }
            set
            {
                listaGames = value;
                //para seleccionar el primer juego que haya en la lista
                if (value != null && value.Count > 0)
                {
                    CurrentGame = value[0];
                }
            }
        }
        */
        private Games currentGame;
        public Games CurrentGame
        {
            get { return currentGame; }
            set
            {
                currentGame = value;
                RaisePropertyChanged("CurrentGame");
                
            }
        }
        #region comandos
        private ICommand listarGamesCommand;
        public ICommand ListarGamesCommand
        {
            get
            {
                if (listarGamesCommand == null)
                    listarGamesCommand = new RelayCommand(new Action(ListarGames));
                return listarGamesCommand;
            }
        }
        private ICommand addGamesCommand;
        public ICommand AddGamesCommand
        {
            get
            {
                listarGamesCommand = new RelayCommand(new Action(AddGame));
                return listarGamesCommand;
            }
           
        }
        private ICommand deleteGamesCommand;
        public ICommand DeleteGamesCommand
        {
            get
            {
                deleteGamesCommand = new RelayCommand(new Action(DeleteGame));
                return deleteGamesCommand;
            }
        }
        #endregion
        private void ListarGames()
        {
            GamesDbContext dbContext = new GamesDbContext();
            var games = dbContext.GamesDb.ToList();
            //esta es justo la parte de codigo qure no se como hacerla.
            


            /*
            NorthwindContext context = new NorthwindContext();
            context.Employees.OrderBy(c => c.FirstName).Load();
            this.dataGrid.ItemsSource = context.Employees.Local;
            */
        }
        private void AddGame()
        {
            //esta parte de código tampoco se hacerla 
        }
        private void DeleteGame()
        {
            
        }
        private void DeleteGame(Games CurrentGame)
        {
            //esta parte de codigo mas bine seria aqui para borrar los juegos de la lista que veremos en el SaveGames.xaml
        }
    }
}
