﻿using StatisticsAnalysisTool.Common;
using System.Collections.Generic;

namespace StatisticsAnalysisTool.Network.Operations;

public class FishingCancelRequest
{
    public FishingCancelRequest(Dictionary<byte, object> parameters)
    {
        ConsoleManager.WriteLineForNetworkHandler(GetType().Name, parameters);
    }
}