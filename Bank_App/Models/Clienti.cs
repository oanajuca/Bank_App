using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Bank_App.Models
{
   public class Clienti
    {
        [PrimaryKey, AutoIncrement]
        public int ID_client { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public DateTime data_nasterii { get; set; }
        public string ocupatie { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public DateTime data_inscrierii { get; set; }

        [ForeignKey(typeof(Tip_Client))]
        public int id_tip_client { get; set; }
    }
}
