using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_stuff
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int year;
        public static int songCount = 0;

        public Songs(string aTitle, string aArtist, int aYear) 
        {
            title = aTitle;
            artist = aArtist;
            year = aYear;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}
