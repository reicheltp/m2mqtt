using System;

// ReSharper disable once CheckNamespace
namespace uPLibrary.Networking.M2Mqtt
{
    public class MqttNetworkChannel : IMqttNetworkChannel
    {
        public bool DataAvailable
        {
            get
            {
                throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
            }
        }

        public int Receive(byte[] buffer)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public int Receive(byte[] buffer, int timeout)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public int Send(byte[] buffer)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public void Close()
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public void Connect()
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public void Accept()
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }
    }
}
