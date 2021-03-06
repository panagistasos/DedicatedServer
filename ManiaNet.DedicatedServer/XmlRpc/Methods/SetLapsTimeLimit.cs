﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SetLapsTimeLimit method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SetLapsTimeLimit : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetLapsTimeLimit"; }
        }

        /// <summary>
        /// Gets or sets the new timelimit for laps mode in seconds.
        /// </summary>
        [UsedImplicitly]
        public int Timelimit
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SetLapsTimeLimit"/> class for the given timelimit.
        /// </summary>
        /// <param name="timelimit">The new timelimit for laps mode in seconds.</param>
        public SetLapsTimeLimit(int timelimit)
            : base(timelimit)
        { }
    }
}