﻿using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetCallVoteRatio method.
    /// </summary>
    public sealed class GetCallVoteRatio : XmlRpcMethodCall<XmlRpcDouble, double>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetCallVoteRatio"; }
        }
    }
}