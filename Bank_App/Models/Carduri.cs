using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Bank_App.Models
{
    public class Carduri
    {
        [PrimaryKey, AutoIncrement]
        public int ID_Card { get; set; }
        public int pin { get; set; }

        [ForeignKey(typeof(Conturi))]
        public int id_cont { get; set; }
        public string Numar_Card { get; set; }
        public string Nume_Card { get; set; }

        [ForeignKey(typeof(Tip_Card))]
        public string id_tip_card { get; set; }
        public DateTime Data_Expirare_Card { get; set; }
        public int Card_CVV { get; set; }
    }
}
