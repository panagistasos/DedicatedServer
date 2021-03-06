﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct returned by the GetForcedMods method call.
    /// </summary>
    public sealed class ForcedModsStruct : BaseStruct
    {
        /// <summary>
        /// Backing field for the Override property.
        /// </summary>
        private readonly XmlRpcBoolean @override = new XmlRpcBoolean();

        /// <summary>
        /// Backing field for the Mods property.
        /// </summary>
        private readonly XmlRpcArray<XmlRpcStruct<ForcedModStruct>, ForcedModStruct> mods = new XmlRpcArray<XmlRpcStruct<ForcedModStruct>, ForcedModStruct>();

        /// <summary>
        /// Gets the forced mods.
        /// </summary>
        [NotNull, UsedImplicitly]
        public IEnumerable<ForcedModStruct> Mods
        {
            get { return mods.Value.Select(xmlRpcStruct => xmlRpcStruct.Value); }
        }

        /// <summary>
        /// Gets whether the mods override those in challenges that already have one or not.
        /// </summary>
        [UsedImplicitly]
        public bool Override
        {
            get { return @override.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(XmlRpcElements.StructElement),
                makeMemberElement("Override", @override),
                makeMemberElement("Mods", mods));
        }

        /// <summary>
        /// Fills the property of this struct that has the correct name with the information contained in the member-XElement.
        /// </summary>
        /// <param name="member">The member element storing the information.</param>
        /// <returns>Whether it was successful or not.</returns>
        protected override bool parseXml(XElement member)
        {
            var value = getMemberValueElement(member);

            switch (getMemberName(member))
            {
                case "Override":
                    if (!@override.ParseXml(value))
                        return false;
                    break;

                case "Mods":
                    if (!mods.ParseXml(value))
                        return false;
                    break;

                default:
                    return false;
            }

            return true;
        }
    }
}