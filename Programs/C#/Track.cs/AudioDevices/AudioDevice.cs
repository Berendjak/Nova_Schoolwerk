using System;
using System.Reflection;

namespace AudioDevices.Devices
{
    public abstract class AudioDevice
    {
        protected int serialId;
        protected string model;
        protected string make;
        protected decimal priceExBtw;
        protected DateTime creationDate;
        protected static readonly double btwPercentage = 1.19;

        public int SerialId { get { return serialId; } set { serialId = value; } }

        public string Model { get { return model; } set { model = value; } }
        public string Make { get { return make; } set { make = value; } }
        public decimal PriceExBtw { get { return priceExBtw; } set { priceExBtw = value*Convert.ToDecimal(btwPercentage); } }
        public decimal ConsumerPrice { get { return priceExBtw; } }
        public DateTime CreationDate { get { return creationDate; } set { creationDate = value; } }

        public string DisplayIdentity(bool makeInfo, bool modelInfo)
        {
            string NserialId = Convert.ToString(serialId);
            if (!string.IsNullOrEmpty(NserialId) && makeInfo == true && modelInfo == true)
            {
                return "Serial: " + serialId + "\nMake: " + make + "\nModel: " + model;
            }
            else if (string.IsNullOrEmpty(NserialId) && makeInfo == true && modelInfo == true)
            {
                return "Serial: Unknown\nMake: " + make + "\nModel: " + model;
            }
            else if (!string.IsNullOrEmpty(NserialId) && makeInfo == false && modelInfo == true)
            {
                return "Serial: " + serialId + "\nMake: Unknown\nModel: " + model;
            }
            else if (!string.IsNullOrEmpty(NserialId) && makeInfo == true && modelInfo == false)
            {
                return "Serial: " + serialId + "\nMake: " + make + "\nModel: Unknown";
            }
            else if (!string.IsNullOrEmpty(NserialId) && makeInfo == false && modelInfo == false)
            {
                return "Serial: " + serialId + "\nMake: Unknown\nModel: Unknown";
            }
            else if (string.IsNullOrEmpty(NserialId) && makeInfo == false && modelInfo == true)
            {
                return "Serial: Unknown\nMake: Unknown\nModel: " + model;
            }
            else if (string.IsNullOrEmpty(NserialId) && makeInfo == true && modelInfo == false)
            {
                return "Serial: Unknown" + "\nMake:  " + make + "\nModel: Unknown";
            }
            else
            {
                return "Serial: Unknown\nMake: Unknown\nModel: Unknown";
            }
        }

        public string GetDeviceLifeTime()
        {
            if (creationDate == DateTime.MinValue)
            {
               return "Lifetime unknown";
            }
            else
            {
                TimeSpan diff = DateTime.Now.Subtract(this.creationDate);
                return "Lifetime " + diff.Days + " days";
            }
        }

        public abstract string DisplayStorageCapacity();
    }
}