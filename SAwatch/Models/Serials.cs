using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace SAwatch.Models
{
    public class Serials
    {
        [PrimaryKey, AutoIncrement]
        public int SerialsID { get; set; }
        public string NumberOfSeasons { get; set; }
        public string CurrentSeason { get; set; }
        public string NumberOfSeries { get; set; }
        public string CurrentSeria { get; set; }
        public string NameOfSerial { get; set; }

    }
}
