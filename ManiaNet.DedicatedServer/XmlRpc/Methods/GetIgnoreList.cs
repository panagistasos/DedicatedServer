﻿using ManiaNet.DedicatedServer.Annotations;
using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the GetIgnoreList method.
    /// </summary>
    [UsedImplicitly]
    public sealed class GetIgnoreList : GetList<LoginStruct>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetIgnoreList"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.GetIgnoreList"/> class with the given limit and starting index.
        /// </summary>
        /// <param name="limit">The maximum number of results that will be returned.</param>
        /// <param name="startingIndex">The starting index from which results will be returned.</param>
        public GetIgnoreList(int limit, int startingIndex)
            : base(limit, startingIndex)
        { }
    }
}