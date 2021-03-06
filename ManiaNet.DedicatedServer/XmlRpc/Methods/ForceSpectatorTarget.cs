﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ForceSpectatorTarget method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ForceSpectatorTarget : XmlRpcMethodCall<XmlRpcString, string, XmlRpcString, string, XmlRpcInt, int, XmlRpcBoolean, bool>
    {
        /// <summary>
        /// Gets or sets the camera type that the spectator(s) will have. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorCameraTypes"/>.
        /// </summary>
        [UsedImplicitly]
        public int CameraType
        {
            get { return param3.Value; }
            set { param3.Value = value; }
        }

        /// <summary>
        /// Gets the name of the method this call is for.
        /// </summary>
        public override string MethodName
        {
            get { return "ForceSpectatorTarget"; }
        }

        /// <summary>
        /// Gets or sets the login of the player who will be the target. Empty string for automatic.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string PlayerLogin
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the login of the spectator whose target will be forced. Empty string for all spectators.
        /// </summary>
        [NotNull, UsedImplicitly]
        public string SpectatorLogin
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ForceSpectatorTarget"/> class with the given target informations.
        /// </summary>
        /// <param name="spectatorLogin">The login of the spectator whose target will be forced. Empty string for all spectators.</param>
        /// <param name="playerLogin">The login of the player who will be the target. Empty string for automatic.</param>
        /// <param name="cameraType">The camera type that the spectator(s) will have. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorCameraTypes"/>.</param>
        public ForceSpectatorTarget([NotNull] string spectatorLogin, [NotNull] string playerLogin, int cameraType)
            : base(spectatorLogin, playerLogin, cameraType)
        { }
    }
}