﻿using Rocket.API.Eventing;
using Rocket.Core.Player.Events;
using SDG.Unturned;
using Steamworks;

namespace Rocket.Unturned.Player.Events
{
    public class UnturnedPlayerPreConnectEvent : PlayerPreConnectEvent
    {
        public ValidateAuthTicketResponse_t SteamworksAuthResponse { get; }

        public SteamPending PendingPlayer { get; }

        public ESteamRejection? UnturnedRejectionReason { get; set; }

        public override string RejectionReason => UnturnedRejectionReason?.ToString();

        public UnturnedPlayerPreConnectEvent(PreConnectUnturnedPlayer player, ValidateAuthTicketResponse_t steamworksAuthResponse) : base(player)
        {
            SteamworksAuthResponse = steamworksAuthResponse;
            PendingPlayer = player.PendingPlayer;
        }
        public UnturnedPlayerPreConnectEvent(PreConnectUnturnedPlayer player, ValidateAuthTicketResponse_t steamworksAuthResponse, bool global = true) : base(player, global)
        {
            SteamworksAuthResponse = steamworksAuthResponse;
            PendingPlayer = player.PendingPlayer;
        }
        public UnturnedPlayerPreConnectEvent(PreConnectUnturnedPlayer player, ValidateAuthTicketResponse_t steamworksAuthResponse, EventExecutionTargetContext executionTarget = EventExecutionTargetContext.Sync, bool global = true) : base(player, executionTarget, global)
        {
            SteamworksAuthResponse = steamworksAuthResponse;
            PendingPlayer = player.PendingPlayer;
        }
    }
}