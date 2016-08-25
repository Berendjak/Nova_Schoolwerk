using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace AudioDevices.Tracks
{
    public class Track
    {
        private int id;
        private string name;
        private string artist;
        private string albumSoure;
        private Time length;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Artist
        {
            get { return this.artist; }
            set { this.artist = value; }
        }

        public string DisplayLength
        {
            get
            {
                string Hours = Convert.ToString(length.hours);
                string Minutes = Convert.ToString(length.minutes);
                string Seconds = Convert.ToString(length.seconds);
                return Hours + " Hours " + Minutes + " Minutes " + Seconds + " Seconds";
            }
        }

        public Time Length
        {
            set
            {
                this.length = value;
            }
        }

        public Category Style { get; set; }
        
        public string AlbumSource
        {
            get { return AlbumSource; }
            set { albumSoure = value; }
        }

        public string DisplayName
        {
            get
            {
                string Set;
                if (Name == null || Artist == null)
                {
                    Set = "Unknown";
                }else
                {
                    Set = "- " + Name + " - " + Artist;
                }
                return Set;
            }
        }



        public Track()
        {
        }

        public Track(int id)
        {
            this.id = id;
            this.name = "Unknown";
            this.artist = "Unknown";
        }

        public Track(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.artist = "Unknown";
        }

        public Track(int id, string artist, string name)
        {
            this.id = id;
            this.name = name;
            this.artist = artist;
        }

        public string GetLength()
        {
            return length.hours + ":" + length.minutes + ":" + length.seconds;
        }
        public int GetLengthInSeconds()
        {
            return length.seconds = (length.hours * 60 * 60) + (length.minutes * 60) + length.seconds;
        }
        
    }
    public enum Category
    {
        Ambient, Blues, Country, Disco, Electro, Hardcore,
        HardRock, HeavyMetal, Hiphop, Jazz, Jumpstyle,
        Klassiek, Latin, Other, Pop, Punk, Reggae, Rock, Soul,
        Trance, Techno
    }
    public struct Time
    {
        public int hours;
        public int minutes;
        public int seconds;

        public Time(int seconds)
        {
            if (seconds < 60)
            {
                this.hours = 0;
                this.minutes = 0;
                this.seconds = seconds;
            }
            else
            {
                this.hours = 0;
                this.minutes = seconds / 60;
                this.seconds = seconds % 60;
                new Time(this.minutes, this.seconds);
            }
        }
        public Time(int minutes, int seconds)
        {
            if (minutes < 60)
            {
                this.hours = 0;
                this.minutes = minutes;
                this.seconds = seconds;
            }
            else
            {
                this.hours = minutes / 60;
                this.minutes = minutes % 60;
                this.seconds = seconds;
                new Time(this.hours, this.minutes, this.seconds);
            }
        }
        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }

        public override string ToString()
        {
            if (minutes > 60)
            {
                this.hours = minutes / 60;
                this.minutes = minutes % 60;
                return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
            }
            return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        }
    }
}
