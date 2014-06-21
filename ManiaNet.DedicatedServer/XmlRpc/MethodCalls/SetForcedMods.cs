﻿using ManiaNet.DedicatedServer.XmlRpc.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.MethodCalls;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.MethodCalls
{
    /// <summary>
    /// Represents a call to the SetForcedMods method.
    /// </summary>
    public sealed class SetForcedMods : MethodCall<XmlRpcBoolean, bool, XmlRpcArray<XmlRpcStruct<ForcedModStruct>, ForcedModStruct>, XmlRpcStruct<ForcedModStruct>[], XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the forced mods.
        /// </summary>
        public IEnumerable<ForcedModStruct> ForcedMods
        {
            get { return param2.Value.Select(strct => strct.Value); }
            set { param2.Value = value.Select(forcedModStruct => new XmlRpcStruct<ForcedModStruct>(forcedModStruct)).ToArray(); }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SetForcedMods"; }
        }

        /// <summary>
        /// Gets or sets whether existing mods on maps will be overridden or not.
        /// </summary>
        public bool Override
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.MethodCalls.SetForcedMods"/> class for the given forced mods and override setting.
        /// </summary>
        /// <param name="override">Whether existing mods on maps will be overridden or not.</param>
        /// <param name="forcedMods">The forced mods.</param>
        public SetForcedMods(bool @override, params ForcedModStruct[] forcedMods)
            : base(@override, forcedMods.Select(forcedModStruct => new XmlRpcStruct<ForcedModStruct>(forcedModStruct)).ToArray())
        { }
    }
}