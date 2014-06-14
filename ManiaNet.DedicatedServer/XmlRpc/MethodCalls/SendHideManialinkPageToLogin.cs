﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SendHideManialinkPageToLogin method.
    /// </summary>
    public sealed class SendHideManialinkPageToLogin : MethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Login for which the manialink page will be hidden.
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
            get { return "SendHideManialinkPageToLogin"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SendHideManialinkPageToLogin"/> class wit the given login.
        /// </summary>
        /// <param name="login">The Login for which the manialink page will be hidden.</param>
        public SendHideManialinkPageToLogin(string login)
            : base(login)
        { }
    }
}