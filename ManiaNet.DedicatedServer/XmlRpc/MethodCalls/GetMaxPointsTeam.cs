﻿using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetMaxPointsTeam method.
    /// </summary>
    public sealed class GetMaxPointsTeam : MethodCall<XmlRpcStruct<CurrentAndNextValueStruct<XmlRpcI4, int>>, CurrentAndNextValueStruct<XmlRpcI4, int>>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetMaxPointsTeam"; }
        }
    }
}