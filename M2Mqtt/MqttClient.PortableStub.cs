using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
// ReSharper disable UnusedParameter.Local

// ReSharper disable UnassignedGetOnlyAutoProperty

namespace uPLibrary.Networking.M2Mqtt
{
    public class MqttClient : IMqttClient
    {
        public event MqttMsgPublishEventHandler MqttMsgPublishReceived;
        public event MqttMsgPublishedEventHandler MqttMsgPublished;
        public event MqttMsgSubscribedEventHandler MqttMsgSubscribed;
        public event MqttMsgUnsubscribedEventHandler MqttMsgUnsubscribed;
        public bool IsConnected { get; }
        public string ClientId { get; }
        public bool CleanSession { get; }
        public bool WillFlag { get; }
        public byte WillQosLevel { get; }
        public string WillTopic { get; }
        public string WillMessage { get; }
        public MqttProtocolVersion ProtocolVersion { get; set; }
        public MqttSettings Settings { get; }

        public MqttClient(string brokerHostName)
        {
        }

        public MqttClient(string brokerHostName, int brokerPort, bool secure, X509Certificate caCert,
            MqttSslProtocols sslProtocol)
        {
        }

        public MqttClient(string brokerHostName, int brokerPort, bool secure, X509Certificate caCert, MqttSslProtocols sslProtocol,
            RemoteCertificateValidationCallback userCertificateValidationCallback)
        {
        }


        public byte Connect(string clientId)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public byte Connect(string clientId, string username, string password)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public byte Connect(string clientId, string username, string password, bool cleanSession, ushort keepAlivePeriod)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public byte Connect(string clientId, string username, string password, bool willRetain, byte willQosLevel, bool willFlag,
            string willTopic, string willMessage, bool cleanSession, ushort keepAlivePeriod)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public void Disconnect()
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public ushort Subscribe(string[] topics, byte[] qosLevels)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public ushort Unsubscribe(string[] topics)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public ushort Publish(string topic, byte[] message)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }

        public ushort Publish(string topic, byte[] message, byte qosLevel, bool retain)
        {
            throw new Exception("You are referencing the Portable version of M2Mqtt in an App. Reference the platform-specific version.");
        }
    }
}
