﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetDisableRespawn method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetDisableRespawn : XmlRpcMethodCall<XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether respawns will be disabled.
        /// </summary>
        [UsedImplicitly]
        public bool Disable
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetDisableRespawn"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetDisableRespawn"/> class with the given value for whether to disable them.
        /// </summary>
        /// <param name="disable">Whether respawns will be disabled.</param>
        public SetDisableRespawn(bool disable)
            : base(disable)
        { }
    }
}