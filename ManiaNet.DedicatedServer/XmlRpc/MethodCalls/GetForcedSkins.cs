﻿using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetForcedSkins method.
    /// </summary>
    public sealed class GetForcedSkins : XmlRpcMethodCall<XmlRpcArray<XmlRpcStruct<ForcedSkinStruct>, ForcedSkinStruct>, XmlRpcStruct<ForcedSkinStruct>[]>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetForcedSkins"; }
        }
    }
}