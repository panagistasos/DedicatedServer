﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the BanAndBlackList method.
    /// </summary>
    [UsedImplicitly]
    public sealed class BanAndBlackList : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of the player that will be kicked.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the ban message.
        /// </summary>
        [NotNull, UsedImplicitly]
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
            get { return "BanAndBlackList"; }
        }

        /// <summary>
        /// Gets or sets whether the bllacklist will be saved after the addition.
        /// </summary>
        [UsedImplicitly]
        public bool SaveNewList
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.BanAndBlackList"/> class with the given login and optional message.
        /// </summary>
        /// <param name="login">The login that will be kicked.</param>
        /// <param name="message">The ban message.</param>
        /// <param name="saveNewList">Whether the blacklist will be saved after the addition.</param>
        public BanAndBlackList([NotNull] string login, [NotNull] string message, bool saveNewList)
            : base(login, message, saveNewList)
        { }
    }
}