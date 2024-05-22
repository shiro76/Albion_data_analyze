namespace StatisticsAnalysisTool.Network;

public enum EventCodes
{
    Unused = 0,
    Leave,
    JoinFinished, // <- UserInfo,
    Move,
    Teleport,
    ChangeEquipment,
    HealthUpdate = 6,
    EnergyUpdate,
    DamageShieldUpdate,
    CraftingFocusUpdate,
    ActiveSpellEffectsUpdate = 10,
    ResetCooldowns,
    Attack,
    CastStart,
    ChannelingUpdate,
    CastCancel,
    CastTimeUpdate,
    CastFinished,
    CastSpell,
    CastHit,
    CastHits,
    ChannelingEnded,
    AttackBuilding,
    InventoryPutItem = 25, //  map[0:652 1:6 2:[118 -97 114 112 -46 84 -60 75 -103 -93 -3 -29 118 -125 -50 96] 3:17 252:23] (0: ObjectId, 1: Inventory slot (no value is slot 0), 2: InteractGuid)
    InventoryDeleteItem = 26, // map[0:754 1:48 252:24] (0: ObjectId) 
    NewCharacter = 27,
    NewEquipmentItem = 28, //  map[0:657 1:2036 2:1 4:28169331 5:Apolo540 6:3 7:90000000 8:[] 9:[0] 252:27] (0: ObjectId, 1: ItemId, 2: Amount, 4: Est. market value, 5: CrafterName)
    NewSiegeBannerItem = 29,
    NewSimpleItem = 30, //  map[0:505 1:7006 2:1 3:true 4:29033970 252:27] (0: ObjectId, 1: ItemId, 2: Amount, 4: Est. market value)
    NewFurnitureItem = 31,
    NewKillTrophyItem = 32,
    NewJournalItem = 33,
    NewLaborerItem = 34, // [0:513 1:7996 2:4 4:522947156 5: 6:10000 7:72000000 252:32]
    NewSimpleHarvestableObject,
    NewSimpleHarvestableObjectList,
    NewHarvestableObject, // map[0:[3405 3468] 1:[6 6] 2:[3 2] 3:[182 -383 176 -369 183 -371] 4:[3 3] 252:35] - 0: ObjectId 2: Max charges, 4: Current charges
    NewSilverObject,
    NewBuilding,
    HarvestableChangeState,
    MobChangeState,
    FactionBuildingInfo,
    CraftBuildingInfo = 43,
    RepairBuildingInfo,
    MeldBuildingInfo,
    ConstructionSiteInfo,
    PlayerBuildingInfo,
    FarmBuildingInfo,
    TutorialBuildingInfo,
    LaborerObjectInfo,
    LaborerObjectJobInfo,
    MarketPlaceBuildingInfo,
    HarvestStart, // map[0:5270 1:637926215956544319 2:637926215956544319 3:4250 4:16 5:1.6169999 6:5287 7:2195 252:52] - 0 = UserId, 3 = ObjectId, 5: Abbauzeit 7: Abbau-Tool (T8_2H_TOOL_SICKLE), 
    HarvestCancel,
    HarvestFinished = 59, // map[0:5270 1:637926215956544319 2:637926215972723131 3:4250 4:1 5:1 7:28 8:[] 9:[] 252:54] - 0: UserId, 3: ObjectId, 4:ItemId 5: Res Standard Quantity 6: Sammelbonus Res, 6: Premium Bonus Res, 8: Inhalt in der Ressource
    TakeSilver = 60, // map[0:-57 1:2178162 2:-57 3:10000000 8:10000 252:55]
    ActionOnBuildingStart,
    ActionOnBuildingCancel,
    ActionOnBuildingFinished = 63, // Repear: [60]evInstallResourceCancel - map[0:1562 1:63802829 282167 2:442 3:454 4:2 252:60] 0: UserObjectId, 2: ActionId, 4: ActionType
    ItemRerollQualityFinished,
    InstallResourceStart,
    InstallResourceCancel,
    InstallResourceFinished,
    CraftItemFinished,
    LogoutCancel,
    ChatMessage,
    ChatSay,
    ChatWhisper,
    ChatMuted,
    PlayEmote,
    StopEmote,
    SystemMessage,
    UtilityTextMessage,
    UpdateMoney = 78, // map[0:4195 1:884995625105 252:71] (0: ObjectId, 1: CurrentSilver)
    UpdateFame = 79, // map[0:4195 1:5811910006347 2:100000000 4:10000 6:1 7:427 252:72] (0: ObjectId, 1: TotalPlayerFame, 2: fameWithZoneMultiplier, 3: GroupSize, 4: Multiplier, 5: IsPremiumBonus, 6: BonusFactor, 8: UsedBagInsightItemIndex, 10: SatchelFame, )
    UpdateLearningPoints,
    UpdateReSpecPoints = 81, // map[0:[0 55814284204 0 0 0] 1:1 2:9948534 3:10000000 252:78] 2: GainedReSpec, 3: PaidSilver
    UpdateCurrency = 82,
    UpdateFactionStanding = 83,
    UpdateMistCityStanding = 84, // map[0:11575080 1:3858360 2:970279167 252:81] 0: StandingPoints
    Respawn,
    ServerDebugLog,
    CharacterEquipmentChanged = 87, // map[0:297 1:26283117 2:[0 1721 0 0 0 2330 2301 2468 0 0] 5:[-1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 -1 3168] 252:85]
    RegenerationHealthChanged,
    RegenerationEnergyChanged,
    RegenerationMountHealthChanged,
    RegenerationCraftingChanged,
    RegenerationHealthEnergyComboChanged,
    RegenerationPlayerComboChanged,
    DurabilityChanged,
    NewLoot = 95, // map[0:1863 2:1853 3:Dicky 4:[236.79169 -185.40233] 5:42.864536 6:true 7:1 10:[[-85 -58 82 55 101 -15 76 79 -103 -113 -21 8 -33 46 -99 -28]] 
    // 12:637993823308929158 18:[] 19:[-63 68 12 104 -29 1 114 78 -91 -75 -21 68 -13 -96 -29 -67] 20:[-23 20 93 -6 73 127 19 78 -65 44 -42 65 -97 105 -82 -16] 21:25900 22:0 23:3 24:-1 252:89]
    AttachItemContainer = 96, //  map[0:78 1:[-99 -50 125 -49 86 0 -115 74 -74 67 9 101 -87 -71 -66 -10] 3:[0 0 0 0 0 0 656 657] 4:8 252:89] (0: ObjectId, 3: ItemId[])
    DetachItemContainer, //  map[0:[-95 72 -77 -75 -70 34 127 73 -114 -96 28 8 75 -107 -106 125] 252:90]
    InvalidateItemContainer,
    LockItemContainer,
    GuildUpdate,
    GuildPlayerUpdated,
    InvitedToGuild,
    GuildMemberWorldUpdate,
    UpdateMatchDetails,
    ObjectEvent,
    NewMonolithObject,
    MonolithHasBannersPlacedUpdate,
    NewSiegeCampObject,
    NewOrbObject,
    NewCastleObject,
    NewSpellEffectArea,
    UpdateSpellEffectArea,
    NewChainSpell,
    UpdateChainSpell,
    NewTreasureChest,
    StartMatch,
    StartTerritoryMatchInfos,
    StartArenaMatchInfos,
    EndTerritoryMatch,
    EndArenaMatch,
    MatchUpdate,
    ActiveMatchUpdate,
    NewMob = 120,
    DebugAggroInfo,
    DebugVariablesInfo,
    DebugReputationInfo,
    DebugDiminishingReturnInfo,
    DebugSmartClusterQueueInfo,
    ClaimOrbStart,
    ClaimOrbFinished,
    ClaimOrbCancel,
    OrbUpdate,
    OrbClaimed,
    OrbReset,
    NewWarCampObject,
    NewMatchLootChestObject,
    NewArenaExit,
    GuildMemberTerritoryUpdate,
    InvitedMercenaryToMatch,
    ClusterInfoUpdate,
    ForcedMovement,
    ForcedMovementCancel,
    CharacterStats,
    CharacterStatsKillHistory,
    CharacterStatsDeathHistory,
    GuildStats,
    KillHistoryDetails,
    FullAchievementInfo,
    FinishedAchievement,
    AchievementProgressInfo,
    FullAchievementProgressInfo,
    FullTrackedAchievementInfo,
    FullAutoLearnAchievementInfo,
    QuestGiverQuestOffered,
    QuestGiverDebugInfo,
    ConsoleEvent,
    TimeSync,
    ChangeAvatar,
    ChangeMountSkin,
    GameEvent,
    KilledPlayer,
    Died = 159,
    KnockedDown,
    Unconcious,
    MatchPlayerJoinedEvent,
    MatchPlayerStatsEvent,
    MatchPlayerStatsCompleteEvent,
    MatchTimeLineEventEvent,
    MatchPlayerMainGearStatsEvent,
    MatchPlayerChangedAvatarEvent,
    InvitationPlayerTrade,
    PlayerTradeStart,
    PlayerTradeCancel,
    PlayerTradeUpdate,
    PlayerTradeFinished,
    PlayerTradeAcceptChange,
    MiniMapPing,
    MarketPlaceNotification,
    DuellingChallengePlayer,
    NewDuellingPost,
    DuelStarted,
    DuelEnded,
    DuelDenied,
    DuelRequestCanceled,
    DuelLeftArea,
    DuelReEnteredArea,
    NewRealEstate,
    MiniMapOwnedBuildingsPositions,
    RealEstateListUpdate,
    GuildLogoUpdate,
    GuildLogoChanged,
    PlaceableObjectPlace,
    PlaceableObjectPlaceCancel,
    FurnitureObjectBuffProviderInfo,
    FurnitureObjectCheatProviderInfo,
    FarmableObjectInfo,
    NewUnreadMails,
    MailOperationPossible,
    GuildLogoObjectUpdate,
    StartLogout,
    NewChatChannels,
    JoinedChatChannel,
    LeftChatChannel,
    RemovedChatChannel,
    AccessStatus,
    Mounted,
    MountStart,
    MountCancel,
    NewTravelpoint,
    NewIslandAccessPoint,
    NewExit,
    UpdateHome,
    UpdateChatSettings,
    ResurrectionOffer,
    ResurrectionReply,
    LootEquipmentChanged,
    UpdateUnlockedGuildLogos,
    UpdateUnlockedAvatars,
    UpdateUnlockedAvatarRings,
    UpdateUnlockedBuildings,
    NewIslandManagement,
    NewTeleportStone,
    Cloak,
    PartyInvitation,
    PartyJoinRequest,
    PartyJoined = 223, // map[0:14368 2:1 3:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 4:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] [-118 61 -70 72 17 -107 121 72 -102 110 20 -25 64 20 106 2]] 5:[Triky313 Bruno313] 6:[0 0] 7:[18 0] 8:[35 0] 9:[-1 -1] 10:[true true] 252:212]
    PartyDisbanded = 224, // map[1:14184 252:213]
    PartyPlayerJoined = 225, // map[0:11925 1:[-63 -19 39 16 26 35 -25 67 -111 60 -87 -58 -31 -100 -124 -44] 2:Mitch77 3:1 4:20 5:12 6:-1 7:true 252:214]
    PartyChangedOrder,
    PartyPlayerLeft = 227, // map[0:14368 1:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 252:216]
    PartyLeaderChanged = 228, // map[0:14595 1:[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101] 252:217]
    PartyLootSettingChangedPlayer = 229, // map[0:14368 1:1 252:218]
    PartySilverGained,
    PartyPlayerUpdated = 231, // map[0:Bruno313 1:true 3:5 252:221]
    PartyInvitationAnswer,
    PartyJoinRequestAnswer,
    PartyMarkedObjectsUpdated,
    PartyOnClusterPartyJoined,
    PartySetRoleFlag, // map[0:8 1:[-118 61 -70 72 17 -107 121 72 -102 110 20 -25 64 20 106 2] 252:225] (0: FlagType, 1: ObjectId)
    PartyInviteOrJoinPlayerEquipmentInfo,
    SpellCooldownUpdate,
    NewHellgateExitPortal,
    NewExpeditionExit,
    NewExpeditionNarrator,
    ExitEnterStart,
    ExitEnterCancel,
    ExitEnterFinished,
    NewQuestGiverObject,
    FullQuestInfo,
    QuestProgressInfo,
    QuestGiverInfoForPlayer,
    FullExpeditionInfo,
    ExpeditionQuestProgressInfo,
    InvitedToExpedition,
    ExpeditionRegistrationInfo,
    EnteringExpeditionStart,
    EnteringExpeditionCancel,
    RewardGranted = 255,
    ArenaRegistrationInfo,
    EnteringArenaStart,
    EnteringArenaCancel,
    EnteringArenaLockStart,
    EnteringArenaLockCancel,
    InvitedToArenaMatch,
    UsingHellgateShrine,
    EnteringHellgateLockStart,
    EnteringHellgateLockCancel,
    PlayerCounts,
    InCombatStateUpdate = 266, // map[0:671362 1:true 2:true 252:257] | 1 = true; player hits enemy | 2 = true; enemy hits player
    OtherGrabbedLoot = 267, // LOOT: map[0:424 1:Triky313 2:Bruno313 4:1841 5:1 252:256] | SILVER: map[0:6436 2:Triky313 3:true 5:1550115 252:256] (0: ObjectId, 1: LootedBody, 2: Looter, 4: ItemId, 5: Quantity) 
    TreasureChestUsingStart = 268,
    TreasureChestUsingFinished,
    TreasureChestUsingCancel,
    TreasureChestUsingOpeningComplete,
    TreasureChestForceCloseInventory,
    LocalTreasuresUpdate,
    LootChestSpawnpointsUpdate,
    PremiumChanged,
    PremiumExtended,
    PremiumLifeTimeRewardGained,
    GoldPurchased,
    LaborerGotUpgraded,
    JournalGotFull,
    JournalFillError,
    FriendRequest,
    FriendRequestInfos,
    FriendInfos,
    FriendRequestAnswered,
    FriendOnlineStatus,
    FriendRequestCanceled,
    FriendRemoved,
    FriendUpdated,
    PartyLootItems,
    PartyLootItemsRemoved,
    ReputationUpdate,
    DefenseUnitAttackBegin,
    DefenseUnitAttackEnd,
    DefenseUnitAttackDamage,
    UnrestrictedPvpZoneUpdate,
    ReputationImplicationUpdate,
    NewMountObject,
    MountHealthUpdate,
    MountCooldownUpdate,
    NewExpeditionAgent,
    NewExpeditionCheckPoint = 302,
    ExpeditionStartEvent,
    VoteEvent,
    RatingEvent,
    NewArenaAgent,
    BoostFarmable,
    UseFunction,
    NewPortalEntrance,
    NewPortalExit,
    NewRandomDungeonExit,
    WaitingQueueUpdate,
    PlayerMovementRateUpdate,
    ObserveStart,
    MinimapZergs,
    MinimapSmartClusterZergs,
    PaymentTransactions,
    PerformanceStatsUpdate,
    OverloadModeUpdate,
    DebugDrawEvent,
    RecordCameraMove,
    RecordStart,
    ClaimPowerCrystalStart,
    ClaimPowerCrystalCancel,
    ClaimPowerCrystalReset,
    ClaimPowerCrystalFinished,
    TerritoryClaimStart,
    TerritoryClaimCancel,
    TerritoryClaimFinished,
    TerritoryScheduleResult,
    TerritoryUpgradeWithPowerCrystalResult,
    ReturningPowerCrystalStart,
    ReturningPowerCrystalFinished,
    UpdateAccountState,
    StartDeterministicRoam,
    GuildFullAccessTagsUpdated,
    GuildAccessTagUpdated,
    GvgSeasonUpdate,
    GvgSeasonCheatCommand,
    SeasonPointsByKillingBooster,
    FishingStart,
    FishingCast,
    FishingCatch,
    FishingFinished,
    FishingCancel,
    NewFloatObject,
    NewFishingZoneObject,
    FishingMiniGame,
    SteamAchievementCompleted,
    UpdatePuppet,
    ChangeFlaggingFinished,
    NewOutpostObject,
    OutpostUpdate,
    OutpostClaimed,
    OverChargeEnd,
    OverChargeStatus,
    PartyFinderFullUpdate,
    PartyFinderUpdate,
    PartyFinderApplicantsUpdate,
    PartyFinderEquipmentSnapshot,
    PartyFinderJoinRequestDeclined,
    NewUnlockedPersonalSeasonRewards,
    PersonalSeasonPointsGained,
    PersonalSeasonPastSeasonDataEvent,
    EasyAntiCheatMessageToClient,
    MatchLootChestOpeningStart,
    MatchLootChestOpeningFinished,
    MatchLootChestOpeningCancel,
    NotifyCrystalMatchReward,
    CrystalRealmFeedback,
    NewLocationMarker,
    NewTutorialBlocker,
    NewTileSwitch,
    NewInformationProvider,
    NewDynamicGuildLogo,
    NewDecoration,
    TutorialUpdate,
    TriggerHintBox,
    RandomDungeonPositionInfo,
    NewLootChest = 380, // map[0:23 1:[20.5 177.5] 2:423 3:KEEPER_SOLO_BOOKCHEST_STANDARD 4:FOREST_GREEN_LOOTCHEST_KEEPER_SOLO_BOOKCHEST_STANDARD 5:4 6:637734315213820408 7:[] 8:[] 13:true 252:367] // map[0:4399 1:[165 -263] 3:TREASURE_SOLO_UNCOMMON 4:SWAMP_DEAD_LOOTCHEST_TREASURE_SOLO_UNCOMMON 5:4 6:637926439332719127 7:[] 8:[] 13:true 14:SWAMP_DEAD_TREASURE_SOLO 16:31ff503a-ded6-53d6-974a-7e32e3126457 252:370]
    UpdateLootChest = 381, // 0=ObjectId, 3=PlayerGuid, 4=PlayerGuid, 7=Free4All map[0:4769 1:5 2:637927794424868192 3:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101]] 4:[[-45 -35 124 14 -23 103 -41 74 -71 66 67 20 -12 60 44 -101]] 6:true 7:true 8:2.6 9:true 252:371]
    LootChestOpened = 382, // map[0:23 252:369]
    UpdateLootProtectedByMobsWithMinimapDisplay,
    NewShrine = 384, // map[0:19 1:[-89 90] 2:180 3:GENERAL_SHRINE_COMBAT_BUFF 4:SHRINE_NON_COMBAT_BUFF 5:1 6:637734312344532502 252:371]
    UpdateShrine = 385, // map[0:19 1:2 2:637734313445294913 252:372]
    UpdateRoom,
    NewMistDungeonRoomMobSoul,
    NewHellgateShrine,
    UpdateHellgateShrine,
    ActivateHellgateExit,
    MutePlayerUpdate,
    ShopTileUpdate,
    ShopUpdate,
    EasyAntiCheatKick,
    BattlEyeServerMessage,
    UnlockVanityUnlock,
    AvatarUnlocked,
    CustomizationChanged,
    BaseVaultInfo,
    GuildVaultInfo,
    BankVaultInfo = 401, // map[0:6 1:6466931c-65a1-4c5d-870b-8724cf2611dc@3007 2:[] 3:[] 4:[] 5:[] 6:[] 7:[] 8:[] 252:390]
    RecoveryVaultPlayerInfo = 402,
    RecoveryVaultGuildInfo,
    UpdateWardrobe,
    CastlePhaseChanged,
    GuildAccountLogEvent,
    NewHideoutObject,
    NewHideoutManagement,
    NewHideoutExit,
    InitHideoutAttackStart,
    InitHideoutAttackCancel,
    InitHideoutAttackFinished,
    HideoutManagementUpdate,
    HideoutUpgradeWithPowerCrystalResult,
    IpChanged,
    SmartClusterQueueUpdateInfo,
    SmartClusterQueueActiveInfo,
    SmartClusterQueueKickWarning,
    SmartClusterQueueInvite,
    ReceivedGvgSeasonPoints,
    TowerPowerPointUpdate,
    OpenWorldAttackScheduleStart,
    OpenWorldAttackScheduleFinished,
    OpenWorldAttackScheduleCancel,
    OpenWorldAttackConquerStart,
    OpenWorldAttackConquerFinished,
    OpenWorldAttackConquerCancel,
    OpenWorldAttackConquerStatus,
    OpenWorldAttackStart,
    OpenWorldAttackEnd,
    NewRandomResourceBlocker,
    NewHomeObject,
    HideoutObjectUpdate,
    UpdateInfamy,
    MinimapPositionMarkers,
    NewTunnelExit,
    CorruptedDungeonUpdate,
    CorruptedDungeonStatus,
    CorruptedDungeonInfamy,
    HellgateRestrictedAreaUpdate,
    HellgateInfamy,
    HellgateStatus,
    HellgateStatusUpdate,
    HellgateSuspense,
    ReplaceSpellSlotWithMultiSpell,
    NewCorruptedShrine,
    UpdateCorruptedShrine,
    CorruptedShrineUsageStart,
    CorruptedShrineUsageCancel,
    ExitUsed,
    LinkedToObject,
    LinkToObjectBroken,
    EstimatedMarketValueUpdate,
    StuckCancel,
    DungonEscapeReady,
    FactionWarfareClusterState,
    FactionWarfareHasUnclaimedWeeklyReportsEvent,
    SimpleFeedback,
    SmartClusterQueueSkipClusterError,
    XignCodeEvent,
    BatchUseItemStart,
    BatchUseItemEnd,
    RedZoneEventClusterStatus,
    RedZonePlayerNotification,
    RedZoneWorldEvent,
    FactionWarfareStats,
    UpdateFactionBalanceFactors,
    FactionEnlistmentChanged,
    UpdateFactionRank,
    FactionWarfareCampaignRewardsUnlocked,
    FeaturedFeatureUpdate,
    NewPowerCrystalObject,
    MinimapCrystalPositionMarker,
    CarryPowerCrystalUpdate,
    PickupPowerCrystalStart,
    PickupPowerCrystalCancel,
    PickupPowerCrystalFinished,
    DoSimpleActionStart,
    DoSimpleActionCancel,
    DoSimpleActionFinished,
    NotifyGuestAccountVerified,
    MightAndFavorReceivedEvent = 482, // map[0:63063 2:21021 3:16617 5:5539 6:349680 8:0 252:470] (0: Might, 2: Premium of might, 3: Favor, 5: Premium of favor, 6: Total favor, 8: ???) 
    WeeklyPvpChallengeRewardStateUpdate,
    NewUnlockedPvpSeasonChallengeRewards,
    StaticDungeonEntrancesDungeonEventStatusUpdates,
    StaticDungeonDungeonValueUpdate,
    StaticDungeonEntranceDungeonEventsAborted,
    InAppPurchaseConfirmedGooglePlay,
    FeatureSwitchInfo,
    PartyJoinRequestAborted,
    PartyInviteAborted,
    PartyStartHuntRequest,
    PartyStartHuntRequested,
    PartyStartHuntRequestAnswer,
    GuildInviteDeclined,
    CancelMultiSpellSlots,
    NewVisualEventObject,
    CastleClaimProgress,
    CastleClaimProgressLogo,
    TownPortalUpdateState,
    TownPortalFailed,
    ConsumableVanityChargesAdded,
    FestivitiesUpdate,
    NewBannerObject,
    NewMistsImmediateReturnExit,
    MistsPlayerJoinedInfo,
    NewMistsStaticEntrance,
    NewMistsOpenWorldExit,
    NewTunnelExitTemp,
    NewMistsWispSpawn,
    MistsWispSpawnStateChange,
    NewMistsCityEntrance,
    NewMistsCityRoadsEntrance,
    MistsCityRoadsEntrancePartyStateUpdate,
    MistsCityRoadsEntranceClearStateForParty,
    MistsEntranceDataChanged,
    NewMistsCagedWisp,
    MistsWispCageOpened,
    MistsEntrancePartyBindingCreated,
    MistsEntrancePartyBindingCleared,
    MistsEntrancePartyBindingInfos,
    NewMistsBorderExit,
    NewMistsDungeonExit,
    LocalQuestInfos,
    LocalQuestStarted,
    LocalQuestActive,
    LocalQuestInactive,
    LocalQuestProgressUpdate,
    NewUnrestrictedPvpZone,
    TemporaryFlaggingStatusUpdate,
    SpellTestPerformanceUpdate,
    Transformation,
    TransformationEnd,
    UpdateTrustlevel,
    RevealHiddenTimeStamps,
    ModifyItemTraitFinished,
    RerollItemTraitValueFinished,
    HuntQuestProgressInfo,
    HuntStarted,
    HuntFinished,
    HuntAborted,
    HuntMissionStepStateUpdate,
    NewHuntTrack,
    HuntMissionUpdate,
    HuntQuestMissionProgressUpdate,
    HuntTrackUsed,
    HuntTrackUseableAgain,
    MinimapHuntTrackMarkers,
    NoTracksFound,
    HuntQuestAborted,
    InteractWithTrackStart,
    InteractWithTrackCancel,
    InteractWithTrackFinished,
    NewDynamicCompound,
    LegendaryItemDestroyed,
    AttunementInfo, //  map[0:T8_MAIN_AXE@4 1:0 2:180810 3:1000000000 252:554] 0: UniqueItemName, 2: GainedAttunement, 3: MaximalAttunementValue
    TerritoryClaimRaidedRawEnergyCrystalResult,
    CarriedObjectExpiryWarning,
    CarriedObjectExpired,
    TerritoryRaidStart,
    TerritoryRaidCancel,
    TerritoryRaidFinished,
    TerritoryRaidResult,
    TerritoryMonolithActiveRaidStatus,
    TerritoryMonolithActiveRaidCancelled,
    MonolithEnergyStorageUpdate,
    MonolithNextScheduledOpenWorldAttackUpdate,
    MonolithProtectedBuildingsDamageReductionUpdate,
    NewBuildingBaseEvent,
    NewFortificationBuilding,
    NewCastleGateBuilding,
    BuildingDurabilityUpdate,
    MonolithFortificationPointsUpdate,
    FortificationBuildingUpgradeInfo,
    FortificationBuildingsDamageStateUpdate,
    SiegeNotificationEvent,
    UpdateEnemyWarBannerActive,
    TerritoryAnnouncePlayerEjection,
    CastleGateSwitchUseStarted,
    CastleGateSwitchUseFinished,
    FortificationBuildingWillDowngrade = 581,
}