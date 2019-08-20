using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMProject.Core.Commands;
using SaveGamesWPF.Core;
using SaveGamesWPF.Models;

namespace SaveGamesWPF.ViewModels
{
    public class SaveGamesViewModel : IGeneric
    {
        private GamesCollection listaGames = new GamesCollection();
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

        public GamesCollection ListaGames
        {
            get { return listaGames; }
            set
            {
                listaGames = value;
                if (value != null && value.Count > 0)
                {
                    CurrentGame = value[0];
                }
            }
        }
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

        }
        private void AddGame()
        {

        }
        private void DeleteGame()
        {

        }
        private void DeleteGame(Games CurrentGame)
        {

        }
    }
}
