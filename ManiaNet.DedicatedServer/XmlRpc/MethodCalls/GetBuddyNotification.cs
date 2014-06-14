﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetBuddyNotification method.
    /// </summary>
    public sealed class GetBuddyNotification : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login to set it for. Empty string for global value.
        /// </summary>
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetBuddyNotification"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetBuddyNotification"/> class with the given setting for the given login.
        /// </summary>
        /// <param name="login">The login to get it for. Default empty string for global value.</param>
        public GetBuddyNotification(string login = "")
            : base(login)
        { }
    }
}