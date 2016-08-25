using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Systen.Threading.Tasks;

namespace AudioDevices.Tracks
{
    public class TrackList
    {
        private List<Track> tracks = new List<Track>();
        public TrackList{ }  

        public TrackList(List<Track> tracks)
        {
            
        }

        public void Add(Track t)
        {
            t.Add(new Track());
        }

        public void Remove(Track t)
        {
            t.Remove(Track(t));
        }
    }
}

