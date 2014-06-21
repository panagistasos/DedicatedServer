﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using XmlRpc.Types;
using XmlRpc.Types.Structs;

namespace ManiaNet.DedicatedServer.XmlRpc.Structs
{
    /// <summary>
    /// Represents the struct returned by various method calls.
    /// </summary>
    public sealed class CurrentAndNextValueStruct<TXmlRpcType, TBase> : BaseStruct<CurrentAndNextValueStruct<TXmlRpcType, TBase>>
        where TXmlRpcType : XmlRpcType<TBase>, new()
    {
        /// <summary>
        /// Backing field for the CurrentValue property.
        /// </summary>
        private TXmlRpcType currentValue = new TXmlRpcType();

        /// <summary>
        /// Backing field for the NextValue property.
        /// </summary>
        private TXmlRpcType nextValue = new TXmlRpcType();

        /// <summary>
        /// Gets the current value.
        /// </summary>
        public TBase CurrentValue
        {
            get { return currentValue.Value; }
        }

        /// <summary>
        /// Gets the next value.
        /// </summary>
        public TBase NextValue
        {
            get { return nextValue.Value; }
        }

        /// <summary>
        /// Generates an XElement storing the information in this struct.
        /// </summary>
        /// <returns>The generated XElement.</returns>
        public override XElement GenerateXml()
        {
            return new XElement(XName.Get(ElementName),
                makeMemberElement("CurrentValue", currentValue.GenerateXml()),
                makeMemberElement("NextValue", nextValue.GenerateXml()));
        }

        /// <summary>
        /// Fills the properties of this struct with the information contained in the element.
        /// </summary>
        /// <param name="xElement">The struct element storing the information.</param>
        /// <returns>Itself, for convenience.</returns>
        public override CurrentAndNextValueStruct<TXmlRpcType, TBase> ParseXml(XElement xElement)
        {
            checkName(xElement);

            foreach (XElement member in xElement.Descendants(XName.Get(MemberElement)))
            {
                checkIsValidMemberElement(member);

                XElement value = getMemberValueElement(member);

                switch (getMemberName(member))
                {
                    case "CurrentValue":
                        currentValue.ParseXml(getValueContent(value, currentValue.ElementName));
                        break;

                    case "NextValue":
                        nextValue.ParseXml(getValueContent(value, nextValue.ElementName));
                        break;

                    default:
                        throw new FormatException("Unexpected member with name " + getMemberName(member));
                }
            }

            return this;
        }
    }
}