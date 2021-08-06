using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            List<Song> allSongs = new List<Song>();
            allSongs.Add(new Song("Creed", "Arms Wide Open"));
            allSongs.Add(new Song("Queen", "Don't Stop Me Now"));
            allSongs.Add(new Song("The White Stripes", "Seven Nation Army"));
            allSongs.Add(new Song("Led Zeppelin", "Kashmir"));
            allSongs.Add(new Song("CCR", "Born on the Bayou"));
            allSongs.Add(new Song("The Who", "Baba O'Riley"));
            allSongs.Add(new Song("Foo Fighters", "Everlong"));
            allSongs.Add(new Song("Creed", "My Sacrifice"));
            allSongs.Add(new Song("Nirvana", "Smells like Teen Spirit"));
            allSongs.Add(new Song("Iron Butterfly", "In-A-Gadda-Da-Vida"));
            allSongs.Add(new Song("Eagles", "Hotel California"));
            allSongs.Add(new Song("Creed", "Higher"));

            var notCreed = allSongs.Where(band => band.Artist != "Creed");
            goodSongs.AddRange(notCreed);

            foreach (var item in goodSongs)
            {
                Console.WriteLine($"{item.Artist}: {item.Name}");
            }

        }
    }
}
