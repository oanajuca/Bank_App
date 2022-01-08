using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Bank_App.Models
{
    class Tip_Card
    {
        [PrimaryKey, AutoIncrement]
        public int ID_tip_card { get; set; }
        public string descriere { get; set; }
    }
}
