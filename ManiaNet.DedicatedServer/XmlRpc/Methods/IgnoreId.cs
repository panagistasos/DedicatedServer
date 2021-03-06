﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the IgnoreIdId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class IgnoreId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the Id that will be IgnoreIdd.
        /// </summary>
        [UsedImplicitly]
        public int Id
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "IgnoreId"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.IgnoreId"/> class for the given Id.
        /// </summary>
        /// <param name="id">The Id that will be IgnoreIdd.</param>
        public IgnoreId(int id)
            : base(id)
        { }
    }
}