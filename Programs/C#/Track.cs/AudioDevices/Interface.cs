using System;
using AudioDevices.Devices;
using AudioDevices.Tracks;

namespace AudioDevices.Interfaces
{
    interface IDisplay
    {
        string GetResolutionInfo();
        int DisplayWidth { get; set; }
        int DisplayHeight { get; set; }
        int TotalPixels { get;  }

    }

    interface ITrackList
    {
        TrackList TrackList { get; }

        bool HasTracks();
        void AddTrackList(TrackList trackList);
        void RemoveTrackList();
    }
}