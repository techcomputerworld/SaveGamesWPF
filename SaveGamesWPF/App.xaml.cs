using Microsoft.EntityFrameworkCore;
using SaveGamesWPF.DbConector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace SaveGamesWPF
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Método constructor
        public App()
        {
            InitializeComponent();
            using (GamesDbContext dbContext = new GamesDbContext())
            {
                dbContext.Database.Migrate();
            }
        }
    }
}
