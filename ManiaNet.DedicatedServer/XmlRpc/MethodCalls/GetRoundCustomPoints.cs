﻿using ManiaNet.DedicatedServer.XmlRpc.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetRoundCustomPoints method.
    /// </summary>
    public sealed class GetRoundCustomPoints : MethodCall<XmlRpcArray<XmlRpcI4, int>, XmlRpcI4[]>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetRoundCustomPoints"; }
        }
    }
}