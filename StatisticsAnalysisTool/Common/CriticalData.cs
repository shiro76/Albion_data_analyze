﻿using System;
using StatisticsAnalysisTool.Common.UserSettings;
using StatisticsAnalysisTool.Enumerations;
using StatisticsAnalysisTool.Network.Manager;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reflection;
using Serilog;

namespace StatisticsAnalysisTool.Common;

public class CriticalData
{
    private static SaveOnClosing _saveOnClosing;

    public static void Save()
    {
        Task.Run(SaveAsync).GetAwaiter().GetResult();
    }

    public static async Task SaveAsync()
    {
        if (_saveOnClosing is SaveOnClosing.IsRunning or SaveOnClosing.Done)
        {
            return;
        }

        _saveOnClosing = SaveOnClosing.IsRunning;

        try
        {
            var trackingController = ServiceLocator.Resolve<TrackingController>();

            var tasks = new List<Task>
            {
                Task.Run(SettingsController.SaveSettings),
                Task.Run(async () => { await trackingController?.SaveDataAsync()!; })
            };

            await Task.WhenAll(tasks);
        }
        catch (KeyNotFoundException e)
        {
            Log.Error(e, "{message}", MethodBase.GetCurrentMethod()?.DeclaringType);
        }
        finally
        {
            _saveOnClosing = SaveOnClosing.Done;
        }
    }

    public static SaveOnClosing GetStatus()
    {
        return _saveOnClosing;
    }
}