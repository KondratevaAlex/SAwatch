using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace SAwatch.Models
{
    public class Films
    {
        [PrimaryKey, AutoIncrement]
        public int FilmID { get; set; }
        public string DurationOfFilm { get; set; }
        public string NameOfFilm { get; set; }
    }
}
