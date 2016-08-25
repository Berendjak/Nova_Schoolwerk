using System;
using AudioDevices.Interfaces;

namespace AudioDevices.Devices
{
    public class CdDiscMan : AudioDevice, IDisplay
    {
        private int mBSize = 700;
        private int displayWidth = 0;
        private int displayHeight = 0;
        private bool isEjected = false;

        public CdDiscMan(int serialId)
        {
            base.SerialId = serialId;
        }

        public string GetResolutionInfo()
        {
            return string.Format("Resolution: {0}px", TotalPixels);
        }

        public override string DisplayStorageCapacity()
        {
            return string.Format("{0} mB", mBSize);
        }

        public void Eject()
        {
            isEjected = !isEjected;
        }

        public int MbSize { get { return mBSize; } }
        public int DisplayWidth { get { return displayWidth; } set { displayWidth = value; } }
        public int DisplayHeight { get { return displayHeight; } set { displayHeight = value; } }
        public int TotalPixels {get { return displayHeight*displayWidth; } }
        public bool IsEjected { get; }
    }
}