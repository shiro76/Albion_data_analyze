﻿using StatisticsAnalysisTool.Network.Manager;
using System.Threading.Tasks;
using StatisticsAnalysisTool.Network.Events;

namespace StatisticsAnalysisTool.Network.Handler;

public class UpdateLootChestEventHandler : EventPacketHandler<UpdateLootChestEvent>
{
    private readonly TrackingController _trackingController;

    public UpdateLootChestEventHandler(TrackingController trackingController) : base((int) EventCodes.UpdateLootChest)
    {
        _trackingController = trackingController;
    }

    protected override async Task OnActionAsync(UpdateLootChestEvent value)
    {
        _trackingController.DungeonController?.SetDungeonChestOpen(value.ObjectId, value.PlayerGuid);
        _trackingController?.TreasureController?.UpdateTreasure(value.ObjectId, value.PlayerGuid);
        await Task.CompletedTask;
    }
}