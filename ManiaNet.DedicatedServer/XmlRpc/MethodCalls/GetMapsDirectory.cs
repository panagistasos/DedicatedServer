﻿using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetMapsDirectoy method.
    /// </summary>
    public sealed class GetMapsDirectory : MethodCall<XmlRpcString, string>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetMapsDirectory"; }
        }
    }
}