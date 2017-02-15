using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    class Songs
    {

        private List<CDlevy> songs;

        public Songs()
        {
            songs = new List<CDlevy>();
        }

        public void AddCDlevy(CDlevy song)
        {
            songs.Add(song);
        }

        public Songs GetSong(int index)
        {
            if (index < songs.Count)
                return songs.ElementAt(index);
            else return null;
        }
        foreach (CDlevy song in songs())
        {
            Console.Writeline(song.Tostring());
        }

    }
}

