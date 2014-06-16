﻿using ManiaNet.DedicatedServer.XmlRpc.Types.Structs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the GetCurrentRanking method.
    /// </summary>
    internal class GetCurrentRanking : GetList<RankingStruct>
    {
        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "GetCurrentRanking"; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.GetCurrentRanking"/> class with the given limit and starting index.
        /// </summary>
        /// <param name="limit">The maximum number of results that will be returned.</param>
        /// <param name="startingIndex">The starting index from which results will be returned.</param>
        protected GetCurrentRanking(int limit, int startingIndex)
            : base(limit, startingIndex)
        { }
    }
}