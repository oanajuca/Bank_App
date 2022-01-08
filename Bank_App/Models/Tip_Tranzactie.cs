using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace Bank_App.Models
{
    class Tip_Tranzactie
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string descriere { get; set; }
    }
}
