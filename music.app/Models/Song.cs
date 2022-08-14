using System;
using System.Collections.Generic;
using System.Text;

namespace music.app.Models
{
    class Song
    {
        private string _name;
        private string _genre;
        private int _singer;
        public string Name { get => _name; set { if (value.Length < 101) { value = _name; } } }
        public string Genre { get => _genre; set { if (value == "Pop" value = "Rock"  )  } }
        public int Singer { get; set; }
  public int  AddRating()
    { 
        return 0;
    }
        public int GetAverageRAting()
        {
            return 0;
        }

    }
}
