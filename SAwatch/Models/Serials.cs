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
        public int NumberOfSeasons { get; set; }
        public int CurrentSeason { get; set; }
        public int NumberOfSeries { get; set; }
        public int CurrentSeria { get; set; }
        public string NameOfSerial { get; set; }

    }
}
