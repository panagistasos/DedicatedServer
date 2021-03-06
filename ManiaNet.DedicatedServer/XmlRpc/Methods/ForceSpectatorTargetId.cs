﻿using ManiaNet.DedicatedServer.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlRpc.Methods;
using XmlRpc.Types;

namespace ManiaNet.DedicatedServer.XmlRpc.Methods
{
    /// <summary>
    /// Represents a call to the ForceSpectatorTargetId method.
    /// </summary>
    [UsedImplicitly]
    public sealed class ForceSpectatorTargetId : XmlRpcMethodCall<XmlRpcInt, int, XmlRpcInt, int, XmlRpcInt, int, XmlRpcBoolean, bool>
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
            get { return "ForceSpectatorTargetId"; }
        }

        /// <summary>
        /// Gets or sets the Id of the player who will be the target. Empty int for automatic.
        /// </summary>
        [UsedImplicitly]
        public int PlayerId
        {
            get { return param2.Value; }
            set { param2.Value = value; }
        }

        /// <summary>
        /// Gets or sets the Id of the spectator whose target will be forced. Empty int for all spectators.
        /// </summary>
        [UsedImplicitly]
        public int SpectatorId
        {
            get { return param1.Value; }
            set { param1.Value = value; }
        }

        /// <summary>
        /// Creates a new instance of the <see cref="ManiaNet.DedicatedServer.XmlRpc.Methods.ForceSpectatorTargetId"/> class with the given target informations.
        /// </summary>
        /// <param name="spectatorId">The Id of the spectator whose target will be forced. Empty int for all spectators.</param>
        /// <param name="playerId">The Id of the player who will be the target. Empty int for automatic.</param>
        /// <param name="cameraType">The camera type that the spectator(s) will have. Use values from <see cref="ManiaNet.DedicatedServer.SpectatorCameraTypes"/>.</param>
        public ForceSpectatorTargetId(int spectatorId, int playerId, int cameraType)
            : base(spectatorId, playerId, cameraType)
        { }
    }
}