using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveGamesWPF.DbConector
{
    //Clases POCO 
    [Table("Games")]
    public class GamesDb
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        
        public string SaveGames { get; set; }
        public string SaveGamesGame { get; set; }
        public string Image { get; set; }
        public string Descripcion { get; set; }
        public string DateSaveGame { get; set; }

    }
}
