﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the CallVote method.
    /// </summary>
    [UsedImplicitly]
    public sealed class CallVote : XmlRpcMethodCall<XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the command to be executed when the call vote is successful.
        /// <para/>
        /// Has to correspond to an Xml Rpc method call.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Command
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "CallVote"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.CallVote"/> class with the given command to be executed when the call vote is successful.
        /// </summary>
        /// <param name="command">The method to be executed when the call vote is successful. Has to correspond to an Xml Rpc method call.</param>
        public CallVote([NotNull] string command)
            : base(command)
        { }
    }
}