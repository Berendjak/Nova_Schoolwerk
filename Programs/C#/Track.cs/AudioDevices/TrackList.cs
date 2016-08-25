using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class TrackList
    {
        private List<Track> tracks = new List<Track>();
        public TrackList(){ }  

        public TrackList(List<Track> tracks) { }

        public void Add(Track t)
        {
            tracks.Add(t);
        }

        public void Remove(Track t)
        {
            tracks.Remove(t);
        }
        public void Clear()
        {
            tracks.Clear();
        }

        public List<Track> GetAllTracks()
        {
            return tracks;
        }

        public int Count
        {
            get { return tracks.Count; }
        }

        public List<Track> Shuffle()
        {
            var shuff = new Random();
            var shuffle = tracks.OrderBy(a => shuff.Next());
            List<Track> shuffled = shuffle.ToList();
            return shuffled;
        }
        
        private int total;
        public string TotalTime
        {                
            get
            {
                foreach (Track track in tracks)
                {
                    total += track.GetLengthInSeconds();
                }
                Time time = new Time(total);
                string totTime = time.ToString();

                return totTime;
            }
        }
    }
}

