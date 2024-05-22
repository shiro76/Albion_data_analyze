﻿using StatisticsAnalysisTool.Network.Manager;
using System.Threading.Tasks;
using StatisticsAnalysisTool.Network.Operations.Responses;

namespace StatisticsAnalysisTool.Network.Handler;

public class UseShrineRequestHandler : RequestPacketHandler<UseShrineRequest>
{
    private readonly TrackingController _trackingController;

    public UseShrineRequestHandler(TrackingController trackingController) : base((int) OperationCodes.UseShrine)
    {
        _trackingController = trackingController;
    }

    protected override async Task OnActionAsync(UseShrineRequest value)
    {
        await Task.CompletedTask;
    }
}