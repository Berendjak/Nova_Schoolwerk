using System;
using System.Xml;

namespace AudioDevices.Devices
{
    public enum MemoCartridgeType { C60, C90, C120, Unknown }
    public class MemoRecorder : AudioDevice
    {
        private MemoCartridgeType maxCatridgeType = MemoCartridgeType.Unknown;

        public override string DisplayStorageCapacity()
        {
            switch (maxCatridgeType)
            {
                case MemoCartridgeType.C60:
                    return "Max capacity 60 min";
                case MemoCartridgeType.C90:
                    return "Max capacity 90 min";
                case MemoCartridgeType.C120:
                    return "Max capacity 120 min";
                default:
                    return "Max capacity unknown";
            }
        }
        public MemoCartridgeType MaxCartridgeType
        {
            get { return maxCatridgeType; }
            set { maxCatridgeType = value; }
        }
        public MemoRecorder(int serialId)
        {
            SerialId = serialId;
        }
    }
}