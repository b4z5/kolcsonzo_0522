using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Game
    {
        public string GameID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsAvailable { get; set; }
        public decimal PricePerDay { get; set; }

        public Game(string gameID, string title, string genre, int releaseYear, bool isAvailable, decimal pricePerDay)
        {
            GameID = gameID;
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            IsAvailable = true;
            PricePerDay = pricePerDay;
        }

        public override string? ToString()
        {
            return $"Videójáték azonosítója {GameID}, címe {Title}, műfaja {Genre}, kiadás éve {ReleaseYear}, elérhetősége {IsAvailable}, napi díja {PricePerDay}";
        }
    }

}
