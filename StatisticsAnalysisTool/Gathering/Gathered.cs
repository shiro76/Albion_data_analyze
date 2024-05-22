﻿using StatisticsAnalysisTool.Cluster;
using StatisticsAnalysisTool.Common;
using StatisticsAnalysisTool.Localization;
using StatisticsAnalysisTool.Models;
using StatisticsAnalysisTool.Models.ItemsJsonModel;
using StatisticsAnalysisTool.ViewModels;
using System;
using System.Globalization;

namespace StatisticsAnalysisTool.Gathering;

public class Gathered : BaseViewModel
{
    private int _gainedStandardAmount;
    private int _gainedBonusAmount;
    private int _gainedPremiumBonusAmount;
    private int _gainedFame;
    private bool _isClosed;
    private string _uniqueName;
    private int _miningProcesses;
    private int _gainedTotalAmount;
    private bool _isSelectedForDeletion;
    private FixPoint _estimatedMarketValue;
    private long _totalMarketValueWithCulture;
    private Item _item;
    private readonly bool _hasBeenFished;

    public Gathered()
    {
        Guid = Guid.NewGuid();
    }

    public Guid Guid { get; init; }
    public long Timestamp { get; init; }
    public DateTime TimestampDateTime => new(Timestamp);
    public long ObjectId { get; init; }
    public long UserObjectId { get; init; }

    public string UniqueName
    {
        get => _uniqueName;
        set
        {
            _uniqueName = value;
            Item = ItemController.GetItemByUniqueName(_uniqueName);
            if (Item?.FullItemInformation is SimpleItem simpleItem && int.TryParse(simpleItem.FameValue, NumberStyles.Any, CultureInfo.CurrentCulture, out var gainedFame))
            {
                GainedFame = gainedFame;
            }
        }
    }

    public Item Item
    {
        get => _item;
        set
        {
            _item = value;
            OnPropertyChanged();
        }
    }

    public int GainedStandardAmount
    {
        get => _gainedStandardAmount;
        set
        {
            _gainedStandardAmount = value;
            GainedTotalAmount = GetTotalAmountResources();
            OnPropertyChanged();
        }
    }

    public int GainedBonusAmount
    {
        get => _gainedBonusAmount;
        set
        {
            _gainedBonusAmount = value;
            GainedTotalAmount = GetTotalAmountResources();
            OnPropertyChanged();
        }
    }

    public int GainedPremiumBonusAmount
    {
        get => _gainedPremiumBonusAmount;
        set
        {
            _gainedPremiumBonusAmount = value;
            GainedTotalAmount = GetTotalAmountResources();
            OnPropertyChanged();
        }
    }

    public int GainedTotalAmount
    {
        get => _gainedTotalAmount;
        set
        {
            _gainedTotalAmount = value;

            TotalMarketValueWithCulture = FixPoint.FromFloatingPointValue(_gainedTotalAmount * EstimatedMarketValue.IntegerValue).IntegerValue;
            OnPropertyChanged();
        }
    }

    public int GainedFame
    {
        get => _gainedFame;
        set
        {
            _gainedFame = value;
            OnPropertyChanged();
        }
    }

    public int MiningProcesses
    {
        get => _miningProcesses;
        set
        {
            _miningProcesses = value;
            OnPropertyChanged();
        }
    }

    public FixPoint EstimatedMarketValue
    {
        get => _estimatedMarketValue;
        set
        {
            _estimatedMarketValue = value;
            OnPropertyChanged();
        }
    }

    public FixPoint TotalMarketValue
    {
        get => FixPoint.FromFloatingPointValue(GainedTotalAmount * EstimatedMarketValue.IntegerValue);
    }

    public long TotalMarketValueWithCulture
    {
        get => _totalMarketValueWithCulture;
        set
        {
            _totalMarketValueWithCulture = value;
            OnPropertyChanged();
        }
    }

    public bool HasBeenFished
    {
        get => _hasBeenFished;
        init
        {
            _hasBeenFished = value;
            OnPropertyChanged();
        }
    }

    public string ClusterIndex { get; init; }
    public MapType MapType { get; init; }
    public string InstanceName { get; init; }

    public int GetTotalAmountResources()
    {
        return GainedStandardAmount + GainedBonusAmount + GainedPremiumBonusAmount;
    }

    public string ClusterUniqueName => ClusterController.ComposingMapInfoString(ClusterIndex, MapType, InstanceName);

    public static string TranslationIn => LanguageController.Translation("IN");
    public static string TranslationAmountOfMiningProcesses => LanguageController.Translation("AMOUNT_OF_MINING_PROCESSES");
    public static string TranslationStandard => LanguageController.Translation("STANDARD");
    public static string TranslationBonus => LanguageController.Translation("BONUS");
    public static string TranslationPremium => LanguageController.Translation("PREMIUM");
    public static string TranslationTotal => LanguageController.Translation("TOTAL");
    public static string TranslationSelectToDelete => LanguageController.Translation("SELECTED_TO_DELETE");
    public static string TranslationTotalMarketValue => LanguageController.Translation("TOTAL_MARKET_VALUE");

    public bool IsClosed
    {
        get => _isClosed;
        set
        {
            _isClosed = value;
            OnPropertyChanged();
        }
    }

    public bool IsSelectedForDeletion
    {
        get => _isSelectedForDeletion;
        set
        {
            _isSelectedForDeletion = value;
            OnPropertyChanged();
        }
    }
}