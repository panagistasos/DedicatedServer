﻿using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetClientInputsMaxLatency method. Only used by ShootMania.
    /// </summary>
    public sealed class GetClientInputsMaxLatency : XmlRpcMethodCall<XmlRpcI4, int>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetClientInputsMaxLatency"; }
        }
    }
}