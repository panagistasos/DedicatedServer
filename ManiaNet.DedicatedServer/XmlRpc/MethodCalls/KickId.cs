﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the KickId method.
    /// </summary>
    public sealed class KickId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id of the player that will be kicked.
        /// </summary>
        public int Íd
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the kick message. May be null.
        /// </summary>
        public string Message
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "KickId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.KickId"/> class with the given Id and optional message.
        /// </summary>
        /// <param name="id">The Id that will be kicked.</param>
        /// <param name="message">The optional kick message.</param>
        public KickId(int id, string message = null)
            : base(id, message)
        { }

        /// <summary>
        /// Generates Xml containing the parameter data. Removes the last param element if there's no value for the message.
        /// </summary>
        /// <returns>An XElement containing the parameter data.</returns>
        protected override XElement generateCallParamsXml()
        {
            XElement paramsElement = base.generateCallParamsXml();

            if (string.IsNullOrWhiteSpace(Message))
                paramsElement.LastNode.Remove();

            return paramsElement;
        }
    }
}