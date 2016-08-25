using System;
using System.Collections.Generic;
using System.Xml.Schema;
using AudioDevices.Interfaces;
using AudioDevices.Tracks;

namespace AudioDevices.Devices
{
    public class Mp3Player : AudioDevice, IDisplay, ITrackList
    {
        private TrackList trackList;
        private int mBSize = 0;
        private int displayWidth;
        private int displayHeight;

        public Mp3Player(int serialId)
        {
            SerialId = serialId;
        }
        public string GetResolutionInfo()
        {
            return string.Format("Resolution: {0}px", TotalPixels);
        }
        public override string DisplayStorageCapacity()
        {
            if (mBSize <= 0)
            {
                return "Storage capacity unknown";
            }
            else
            {
                return string.Format("{0} mB", mBSize);
            }
        }
        public bool HasTracks()
        {
            return (this.trackList.Count > 0);
        }

        public void AddTrackList(TrackList trackList)
        {
             this.trackList = trackList;
            //TrackList.Add(trackList);
        }

        public void RemoveTrackList()
        {
            this.trackList = new TrackList();
        }


        public int MbSize { get { return mBSize; } set { mBSize = value; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public int TotalPixels { get { return displayWidth*displayHeight; } }
        public TrackList TrackList { get { return trackList; } }
    }
}