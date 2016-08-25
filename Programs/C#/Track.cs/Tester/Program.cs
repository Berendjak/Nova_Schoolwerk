using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices.Tracks;
using AudioDevices.Devices;
using AudioDevices.Interfaces;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //OPDRACHT 1    

            //Track t1 = new Track(1, "Nelly Furtado", "Maneater");
            //t1.AlbumSource = "Loose";
            //t1.Length = new Time(4, 31);
            //t1.Style = Category.Pop;

            //Console.WriteLine(t1.DisplayName);
            //Console.WriteLine(t1.DisplayLength);
            //Console.WriteLine("Tijd in seconden: {0}", t1.GetLengthInSeconds());
            //Console.WriteLine("Category: {0}", t1.Style.ToString());
            //Console.ReadLine();

            //OPDRACHT 2

            //Track t1 = new Track(1, "Prince", "Guitar");
            //t1.Length = new Time(1, 4, 12);

            //Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            //t2.Length = new Time(4, 41);

            //Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            //t3.Length = new Time(3, 50);


            //TrackList trackList = new TrackList();
            //trackList.Add(t1);
            //trackList.Add(t2);
            //trackList.Add(t3);
            //Console.WriteLine("Aantal tracks: {0}", trackList.Count);

            //trackList.Remove(t3);
            //Console.WriteLine("Aantal tracks: {0}", trackList.Count);

            //trackList.Add(t3);
            //Console.WriteLine("Totale tijd tracklist: {0}", trackList.TotalTime);

            //Console.WriteLine();
            //Console.WriteLine("Random lijst:");
            //List<Track> shuffled = trackList.Shuffle();
            //foreach (Track t in shuffled)
            //    Console.WriteLine(t.Id + " " + t.DisplayName);

            //Console.ReadLine();

            //OPDRACHT 3/4

            //MemoRecorder memo = new MemoRecorder(1000);
            //memo.MaxCartridgeType = MemoCartridgeType.C90;
            //memo.Make = "Sony";
            //memo.Model = "FE190";
            //memo.PriceExBtw = 129.95M;
            //memo.CreationDate = DateTime.Now.AddMonths(-6);

            //Console.WriteLine(memo.DisplayIdentity(true, true));
            //Console.WriteLine(memo.DisplayStorageCapacity());
            //Console.WriteLine("Consumer price: {0:f2}", memo.ConsumerPrice);
            //Console.WriteLine(memo.GetDeviceLifeTime());
            //Console.ReadLine();

            //OPDRACHT 5

            //CdDiscMan discman = new CdDiscMan(1000);
            //discman.Make = "JVC";
            //discman.Model = "HG-410";
            //discman.PriceExBtw = 149.00M;
            //discman.DisplayWidth = 320;
            //discman.DisplayHeight = 160;
            //discman.CreationDate = DateTime.Parse("12-2-2006");

            //Console.WriteLine(discman.DisplayIdentity(true, true));
            //Console.WriteLine("Opslag capacity {0}", discman.DisplayStorageCapacity());
            //Console.WriteLine("Display resolution {0} pixels", discman.TotalPixels);
            //Console.WriteLine(discman.GetResolutionInfo());
            //Console.WriteLine("Consumer price: {0:f2}", discman.ConsumerPrice);
            //Console.WriteLine(discman.GetDeviceLifeTime());
            //Console.WriteLine("Eject status: {0}", discman.IsEjected);
            //discman.Eject();
            //Console.WriteLine("Eject status: {0}", discman.IsEjected);

            //Console.ReadLine();

            //OPDRACHT 6 

            Mp3Player player = new Mp3Player(1000);
            player.Make = "Creative";
            player.Model = "Alpha";
            player.PriceExBtw = 99.00M;
            player.DisplayWidth = 120;
            player.DisplayHeight = 80;
            player.CreationDate = DateTime.Parse("1-1-2007");
            player.MbSize = 1024;

            Track t1 = new Track(1, "Prince", "Guitar");
            t1.Length = new Time(4, 12);

            Track t2 = new Track(2, "Nelly Furtado", "Say it Right");
            t2.Length = new Time(4, 41);

            Track t3 = new Track(3, "David Guetta & Chris Willis", "Love is gone");
            t3.Length = new Time(3, 50);

            TrackList trackList = new TrackList();
            trackList.Add(t1);
            trackList.Add(t2);
            trackList.Add(t3);

            player.AddTrackList(trackList);

            Console.WriteLine(player.DisplayIdentity(true, true));
            Console.WriteLine("Capacity {0}", player.DisplayStorageCapacity());
            Console.WriteLine("Display resolution {0} pixels", player.TotalPixels);
            Console.WriteLine("Consumer price: {0:f2}", player.ConsumerPrice);
            Console.WriteLine(player.GetDeviceLifeTime());

            if (player.HasTracks())
            {
                Console.WriteLine("The TrackList of this player has {0} tracks", player.TrackList.Count);

                foreach (Track t in player.TrackList.GetAllTracks())
                    Console.WriteLine(t.DisplayName);

                player.RemoveTrackList();
                Console.WriteLine("The TrackList of this player has now {0} tracks",
                player.TrackList.Count);
            }
            Console.ReadLine();

        }
    }
}
