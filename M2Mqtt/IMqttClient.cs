namespace uPLibrary.Networking.M2Mqtt
{
    public interface IMqttClient
    {
        //ctor obs IPAddress brokerIpAddress
        //ctor obs IPAddress brokerIpAddress, int brokerPort, bool secure, X509Certificate caCert, MqttSslProtocols sslProtocol
        //ctor string brokerHostName
        //ctor string brokerHostName, int brokerPort, bool secure, X509Certificate caCert, MqttSslProtocols sslProtocol
        //ctor string brokerHostName, int brokerPort, bool secure, X509Certificate caCert, MqttSslProtocols sslProtocol, RemoteCertificateValidationCallback userCertificateValidationCallback
        //ctor string brokerHostName, int brokerPort, bool secure, MqttSslProtocols sslProtocol, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback
        //ctor string brokerHostName, int brokerPort, bool secure, X509Certificate caCert, MqttSslProtocols sslProtocol, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback

        event MqttMsgPublishEventHandler MqttMsgPublishReceived;
        event MqttMsgPublishedEventHandler MqttMsgPublished;
        event MqttMsgSubscribedEventHandler MqttMsgSubscribed;
        event MqttMsgUnsubscribedEventHandler MqttMsgUnsubscribed;

        bool IsConnected { get; }

        string ClientId { get; }

        bool CleanSession { get; }

        bool WillFlag { get; }

        byte WillQosLevel { get; }

        string WillTopic { get; }

        string WillMessage { get; }

        MqttProtocolVersion ProtocolVersion { get; set; }

        MqttSettings Settings { get; }

        byte Connect(string clientId);
        byte Connect(string clientId, string username, string password);

        byte Connect(string clientId, string username, string password, bool cleanSession, ushort keepAlivePeriod);

        byte Connect(string clientId, string username, string password, bool willRetain, byte willQosLevel,
            bool willFlag, string willTopic, string willMessage, bool cleanSession, ushort keepAlivePeriod);

        void Disconnect();

        ushort Subscribe(string[] topics, byte[] qosLevels);

        ushort Unsubscribe(string[] topics);

        ushort Publish(string topic, byte[] message);

        ushort Publish(string topic, byte[] message, byte qosLevel, bool retain);
    }

#if BROKER
    public interface IMqttBroker
    {
        //ctor IMqttNetworkChannel channel

        event MqttMsgSubscribeEventHandler MqttMsgSubscribeReceived;
        event MqttMsgUnsubscribeEventHandler MqttMsgUnsubscribeReceived;
        event MqttMsgConnectEventHandler MqttMsgConnected;
        event MqttMsgDisconnectEventHandler MqttMsgDisconnected;

        MqttClientSession Session { get; set; }

        void Open();

        void Close();
    }
#endif
}
