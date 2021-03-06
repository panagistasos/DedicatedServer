﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the EnableP2PDownload method.
    /// </summary>
    [UsedImplicitly]
    public sealed class EnableP2PDownload : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to enable P2P download or not.
        /// </summary>
        [UsedImplicitly]
        public bool Enable
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "EnableP2PDownload"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.EnableP2PDownload"/> class with the given value for whether or not to enable it.
        /// </summary>
        /// <param name="enable">Whether to enable P2P download or not.</param>
        public EnableP2PDownload(bool enable)
            : base(enable)
        { }
    }
}