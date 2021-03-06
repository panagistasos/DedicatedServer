﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ChangeAuthPassword method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ChangeAuthPassword : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the login of which to change the password.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string Login
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ChangeAuthPassword"; }
        }

        /// <summary>
        /// Gets or sets the password that it's changed to.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string NewPassword
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ChangeAuthPassword"/> class with the given login and password.
        /// </summary>
        /// <param name="login">The login of which to change the password.</param>
        /// <param name="newPassword">The password that it's changed to.</param>
        public ChangeAuthPassword([NotNull] string login, [NotNull] string newPassword)
            : base(login, newPassword)
        { }
    }
}