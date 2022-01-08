using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Bank_App.Models
{
   public class Tranzactii
    {
        [PrimaryKey, AutoIncrement]
        public int ID_tranzactie { get; set; }
        public string Beneficiar { get; set; }
        public DateTime Data_Tranzactie { get; set; }

        public string suma { get; set; }
        public string descriere { get; set; }
        public string iban { get; set; }
        [ForeignKey(typeof(Conturi))]
        public string id_cont { get; set; }
        [ForeignKey(typeof(Tip_Tranzactie))]
        public string id_tip_tranzactie { get; set; }
    }
}
