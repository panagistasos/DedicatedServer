﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the SendBill method.
    /// </summary>
    [UsedImplicitly]
    public sealed class SendBill : XmlRpcMethodCall<XmlRpcString, string, XmlRpcInt, int, XmlRpcString, string, XmlRpcString, string, XmlRpcI4, int>
    {
        /// <summary>
        /// Gets or sets the label that will be send with the payment.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Label
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "SendBill"; }
        }

        /// <summary>
        /// Gets or sets the login that will receive the planets. Empty string means the server account.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Payee
        {
            get { return param4.Value; }
            set { param4.Value = value; }
        }

        /// <summary>
        /// Gets or sets the login that the bill will be send to.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Payer
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets or sets the amount of planets that the payee will receive.
        /// </summary>
        [UsedImplicitly]
        public int Planets
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.SendBill"/> class with the given bill information.
        /// </summary>
        /// <param name="payer">The login that the bill will be send to.</param>
        /// <param name="planets">The amount of planets that the payee will receive.</param>
        /// <param name="label">The label that will be send with the bill.</param>
        /// <param name="payee">The login that will receive the planets. Defaults to empty string for the server account.</param>
        public SendBill([NotNull] string payer, int planets, [NotNull] string label, [NotNull] string payee = "")
            : base(payee, planets, label, payer)
        { }
    }
}