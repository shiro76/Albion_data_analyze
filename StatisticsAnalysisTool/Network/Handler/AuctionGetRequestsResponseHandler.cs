﻿using StatisticsAnalysisTool.Network.Manager;
using System.Threading.Tasks;
using StatisticsAnalysisTool.Network.Operations.Responses;

namespace StatisticsAnalysisTool.Network.Handler;

public class AuctionGetRequestsResponseHandler : ResponsePacketHandler<AuctionGetRequests>
{
    private readonly TrackingController _trackingController;

    public AuctionGetRequestsResponseHandler(TrackingController trackingController) : base((int) OperationCodes.AuctionGetRequests)
    {
        _trackingController = trackingController;
    }

    protected override async Task OnActionAsync(AuctionGetRequests value)
    {
        _trackingController.MarketController.AddBuyOrders(value.AuctionEntries);
        await Task.CompletedTask;
    }
}