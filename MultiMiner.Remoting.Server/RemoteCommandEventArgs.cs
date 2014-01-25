using MultiMiner.Engine;
using System;
using System.Collections.Generic;

namespace MultiMiner.Remoting.Server
{
    public class RemoteCommandEventArgs : EventArgs
    {
        public string IpAddress { get; set; }
        public string Signature { get; set; }
    }

    public class ModelRequestEventArgs : RemoteCommandEventArgs
    {
        public ModelRequestEventArgs()
        {
            Devices = new List<Data.Transfer.Device>();
            ConfiguredCoins = new List<CryptoCoin>();
        }

        public List<Data.Transfer.Device> Devices { get; set; }
        public List<CryptoCoin> ConfiguredCoins { get; set; }
        public bool Mining { get; set; }
        public bool HasChanges { get; set; }
        public bool DynamicIntensity { get; set; }
    }

    public class ConfigurationRequestEventArgs : RemoteCommandEventArgs
    {
        public ConfigurationRequestEventArgs()
        {
            Application = new Data.Transfer.Configuration.Application();
            Engine = new Data.Transfer.Configuration.Engine();
            Path = new Data.Transfer.Configuration.Path();
            Perks = new Data.Transfer.Configuration.Perks();
        }

        public Data.Transfer.Configuration.Application Application { get; set; }
        public Data.Transfer.Configuration.Engine Engine { get; set; }
        public Data.Transfer.Configuration.Path Path { get; set; }
        public Data.Transfer.Configuration.Perks Perks { get; set; }
    }
}
