﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the AllowMapDownload method.
    /// </summary>
    [UsedImplicitly]
    public sealed class AllowMapDownload : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether to allow map downloads or not.
        /// </summary>
        [UsedImplicitly]
        public bool Allow
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "AllowMapDownload"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.AllowMapDownload"/> class with the given value for whether to allow it or not.
        /// </summary>
        /// <param name="allow">Whether to allow map downloads or not.</param>
        public AllowMapDownload(bool allow)
            : base(allow)
        { }
    }
}