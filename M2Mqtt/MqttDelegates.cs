using System;
using System.Collections.Generic;
using System.Text;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace uPLibrary.Networking.M2Mqtt
{
    /// <summary>
    /// Delagate that defines event handler for PUBLISH message received
    /// </summary>
    public delegate void MqttMsgPublishEventHandler(object sender, MqttMsgPublishEventArgs e);

    /// <summary>
    /// Delegate that defines event handler for published message
    /// </summary>
    public delegate void MqttMsgPublishedEventHandler(object sender, MqttMsgPublishedEventArgs e);

    /// <summary>
    /// Delagate that defines event handler for subscribed topic
    /// </summary>
    public delegate void MqttMsgSubscribedEventHandler(object sender, MqttMsgSubscribedEventArgs e);

    /// <summary>
    /// Delagate that defines event handler for unsubscribed topic
    /// </summary>
    public delegate void MqttMsgUnsubscribedEventHandler(object sender, MqttMsgUnsubscribedEventArgs e);

#if BROKER
        /// <summary>
        /// Delagate that defines event handler for SUBSCRIBE message received
        /// </summary>
        public delegate void MqttMsgSubscribeEventHandler(object sender, MqttMsgSubscribeEventArgs e);

        /// <summary>
        /// Delagate that defines event handler for UNSUBSCRIBE message received
        /// </summary>
        public delegate void MqttMsgUnsubscribeEventHandler(object sender, MqttMsgUnsubscribeEventArgs e);

        /// <summary>
        /// Delagate that defines event handler for CONNECT message received
        /// </summary>
        public delegate void MqttMsgConnectEventHandler(object sender, MqttMsgConnectEventArgs e);

        /// <summary>
        /// Delegate that defines event handler for client disconnection (DISCONNECT message or not)
        /// </summary>
        public delegate void MqttMsgDisconnectEventHandler(object sender, EventArgs e);
#endif

    /// <summary>
    /// Delegate that defines event handler for cliet/peer disconnection
    /// </summary>
    public delegate void ConnectionClosedEventHandler(object sender, EventArgs e);
}
