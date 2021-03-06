﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SendDisplayManialinkToId method.
    /// </summary>
    public sealed class SendDisplayManialinkPageToId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets whether the page automatically disappears after the client selects an option.
        /// </summary>
        [UsedImplicitly]
        public bool DisappearOnSelect
        {
            get { return param4.Value; }
            set { param4.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Id that the page will be send to.
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
            get { return "SendDisplayManialinkPageToId"; }
        }

        /// <summary>
        /// Gets or sets the Xml representing the page.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Page
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the timeout in seconds after which the page is automatically hidden. 0 for permanent display.
        /// </summary>
        [UsedImplicitly]
        public int Timeout
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SendDisplayManialinkPageToId"/> class with the given page and settings.
        /// </summary>
        /// <param name="id">The Id that the page will be send to.</param>
        /// <param name="page">The Xml representing the page.</param>
        /// <param name="timeout">The timeout in seconds after which the page is automatically hidden. 0 for permanent display.</param>
        /// <param name="disapperOnSelect">Whether the page automatically disappears after the client selects an option.</param>
        public SendDisplayManialinkPageToId(int id, [NotNull] string page, int timeout, bool disapperOnSelect)
            : base(id, page, timeout, disapperOnSelect)
        { }
    }
}