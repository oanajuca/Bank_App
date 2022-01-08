using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Bank_App.Models
{
     public class Conturi
    {
        [PrimaryKey, AutoIncrement]
        public int ID_cont { get; set; }
        public string Sold_cont { get; set; }
        public DateTime Data_deschiderii { get; set; }

        [ForeignKey(typeof(Tip_Cont))]
        public int id_tip_cont { get; set; }

        [ForeignKey(typeof(Clienti))]
        public int id_client { get; set; }
        
    }
}
