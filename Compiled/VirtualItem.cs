// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VirtualItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from VirtualItem.proto</summary>
  public static partial class VirtualItemReflection {

    #region Descriptor
    /// <summary>File descriptor for VirtualItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VirtualItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFWaXJ0dWFsSXRlbS5wcm90bxINbWlIb21vLlByb3RvcyqpEQoLVmlydHVh",
            "bEl0ZW0SFQoRSVRFTV9WSVJUVUFMX05PTkUQABIbChdJVEVNX1ZJUlRVQUxf",
            "QVZBVEFSX0VYUBBlEhsKF0lURU1fVklSVFVBTF9QTEFZRVJfRVhQEGYSGwoX",
            "SVRFTV9WSVJUVUFMX0ZFVFRFUl9FWFAQaRIWChJJVEVNX1ZJUlRVQUxfUkVT",
            "SU4QahIeChpJVEVNX1ZJUlRVQUxfTEVHRU5EQVJZX0tFWRBrEh8KG0lURU1f",
            "VklSVFVBTF9BU1RFUl9QUk9HUkVTUxBsEh0KGUlURU1fVklSVFVBTF9BU1RF",
            "Ul9DUkVESVQQbRIcChhJVEVNX1ZJUlRVQUxfQVNURVJfVE9LRU4QbhIjCh9J",
            "VEVNX1ZJUlRVQUxfU0hJTU1FUklOR19FU1NFTkNFEG8SHQoZSVRFTV9WSVJU",
            "VUFMX1dBUk1fRVNTRU5DRRBwEiEKHUlURU1fVklSVFVBTF9XT05EUk9VU19F",
            "U1NFTkNFEHESIwofSVRFTV9WSVJUVUFMX1RSRUFTVVJFX01BUF9UT0tFThBy",
            "Eh4KGklURU1fVklSVFVBTF9TRUFfTEFNUF9DT0lOEHMSJAogSVRFTV9WSVJU",
            "VUFMX1NFQV9MQU1QX1BPUFVMQVJJVFkQdBIgChxJVEVNX1ZJUlRVQUxfTUVD",
            "SEFOSUNVU19DT0lOEHUSIgoeSVRFTV9WSVJUVUFMX0ZMRVVSX0ZBSVJfQ1JF",
            "RElUEHYSIQodSVRFTV9WSVJUVUFMX0ZMRVVSX0ZBSVJfVE9LRU4QdxIiCh5J",
            "VEVNX1ZJUlRVQUxfV0FURVJfU1BJUklUX0NPSU4QeBIZChVJVEVNX1ZJUlRV",
            "QUxfSE9NRV9FWFAQeRImCiJJVEVNX1ZJUlRVQUxfQ0hBTk5FTExFUl9TTEFC",
            "X1RPS0VOEHoSIwofSVRFTV9WSVJUVUFMX0hJREVfQU5EX1NFRUtfQ09JThB7",
            "EicKI0lURU1fVklSVFVBTF9TVU1NRVJfVElNRV9EUkFGVF9XT09EEHwSKwon",
            "SVRFTV9WSVJUVUFMX1NVTU1FUl9USU1FX01JTklfSEFSUEFTVFVNEH0SJgoi",
            "SVRFTV9WSVJUVUFMX0JPVU5DRV9DT05KVVJJTkdfQ09JThB+EiIKHklURU1f",
            "VklSVFVBTF9CTElUWl9SVVNIX0NPSU5fQRB/EiMKHklURU1fVklSVFVBTF9C",
            "TElUWl9SVVNIX0NPSU5fQhCAARIbChZJVEVNX1ZJUlRVQUxfQ0hFU1NfRVhQ",
            "EIEBEhwKF0lURU1fVklSVFVBTF9DSEVTU19DT0lOEIIBEiYKIUlURU1fVklS",
            "VFVBTF9MVU5BX1JJVEVfQVRNT1NQSEVSRRCDARIiCh1JVEVNX1ZJUlRVQUxf",
            "Uk9HVUVMSUtFX0NPSU5fQRCEARIiCh1JVEVNX1ZJUlRVQUxfUk9HVUVMSUtF",
            "X0NPSU5fQhCFARIiCh1JVEVNX1ZJUlRVQUxfUk9HVUVMSUtFX0NPSU5fQxCG",
            "ARIkCh9JVEVNX1ZJUlRVQUxfV0lOVEVSX0NBTVBfQ09JTl9BEIcBEiQKH0lU",
            "RU1fVklSVFVBTF9XSU5URVJfQ0FNUF9DT0lOX0IQiAESJQogSVRFTV9WSVJU",
            "VUFMX0xBTlRFUk5fUklURV9DT0lOX0EQiQESJQogSVRFTV9WSVJUVUFMX0xB",
            "TlRFUk5fUklURV9DT0lOX0IQigESJQogSVRFTV9WSVJUVUFMX0xBTlRFUk5f",
            "UklURV9DT0lOX0MQiwESIgodSVRFTV9WSVJUVUFMX1JPR1VFX0RJQVJZX0NP",
            "SU4QjAESJQogSVRFTV9WSVJUVUFMX1NVTU1FUl9USU1FX1YyX0NPSU4QjQES",
            "KgolSVRFTV9WSVJUVUFMX1JPR1VFX0RJQVJZX0RVTkdFT05fQ09JThCOARIp",
            "CiRJVEVNX1ZJUlRVQUxfR1JBVkVOX0lOTk9DRU5DRV9DT0lOX0EQjwESKQok",
            "SVRFTV9WSVJUVUFMX0dSQVZFTl9JTk5PQ0VOQ0VfQ09JTl9CEJABEiYKIUlU",
            "RU1fVklSVFVBTF9UUkVBU1VSRV9TRUVMSUVfQ09JThCRARIZChRJVEVNX1ZJ",
            "UlRVQUxfR0NHX0VYUBCSARIkCh9JVEVNX1ZJUlRVQUxfVklOVEFHRV9QT1BV",
            "TEFSSVRZEJMBEicKIklURU1fVklSVFVBTF9WSU5UQUdFX01BUktFVF9DT0lO",
            "X0EQlAESJwoiSVRFTV9WSVJUVUFMX1ZJTlRBR0VfTUFSS0VUX0NPSU5fQhCV",
            "ARInCiJJVEVNX1ZJUlRVQUxfVklOVEFHRV9NQVJLRVRfQ09JTl9DEJYBEi0K",
            "KElURU1fVklSVFVBTF9GVU5HVVNfRklHSFRFUl9DQVBUVVJFX0NPSU4QlwES",
            "LgopSVRFTV9WSVJUVUFMX0ZVTkdVU19GSUdIVEVSX1RSQUlOSU5HX0NPSU4Q",
            "mAESKgolSVRFTV9WSVJUVUFMX0VGRklHWV9DSEFMTEVOR0VfVjJfQ09JThCZ",
            "ARIkCh9JVEVNX1ZJUlRVQUxfQlJJQ0tfQlJFQUtFUl9DT0lOEJsBEhcKEklU",
            "RU1fVklSVFVBTF9IQ09JThDJARIXChJJVEVNX1ZJUlRVQUxfU0NPSU4QygES",
            "FwoSSVRFTV9WSVJUVUFMX01DT0lOEMsBEhsKFklURU1fVklSVFVBTF9IT01F",
            "X0NPSU4QzAESGgoVSVRFTV9WSVJUVUFMX0dDR19DT0lOEM0BEiQKH0lURU1f",
            "VklSVFVBTF9JTkFaVU1BX1JFUFVUQVRJT04QugISIwoeSVRFTV9WSVJUVUFM",
            "X01FTkdERV9SRVBVVEFUSU9OELsCEiMKHklURU1fVklSVFVBTF9TVU1FUlVf",
            "UkVQVVRBVElPThC8AhIiCh1JVEVNX1ZJUlRVQUxfTElZVUVfUkVQVVRBVElP",
            "ThC9AmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.VirtualItem), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum VirtualItem {
    [pbr::OriginalName("ITEM_VIRTUAL_NONE")] ItemVirtualNone = 0,
    [pbr::OriginalName("ITEM_VIRTUAL_AVATAR_EXP")] ItemVirtualAvatarExp = 101,
    [pbr::OriginalName("ITEM_VIRTUAL_PLAYER_EXP")] ItemVirtualPlayerExp = 102,
    [pbr::OriginalName("ITEM_VIRTUAL_FETTER_EXP")] ItemVirtualFetterExp = 105,
    [pbr::OriginalName("ITEM_VIRTUAL_RESIN")] ItemVirtualResin = 106,
    [pbr::OriginalName("ITEM_VIRTUAL_LEGENDARY_KEY")] ItemVirtualLegendaryKey = 107,
    [pbr::OriginalName("ITEM_VIRTUAL_ASTER_PROGRESS")] ItemVirtualAsterProgress = 108,
    [pbr::OriginalName("ITEM_VIRTUAL_ASTER_CREDIT")] ItemVirtualAsterCredit = 109,
    [pbr::OriginalName("ITEM_VIRTUAL_ASTER_TOKEN")] ItemVirtualAsterToken = 110,
    [pbr::OriginalName("ITEM_VIRTUAL_SHIMMERING_ESSENCE")] ItemVirtualShimmeringEssence = 111,
    [pbr::OriginalName("ITEM_VIRTUAL_WARM_ESSENCE")] ItemVirtualWarmEssence = 112,
    [pbr::OriginalName("ITEM_VIRTUAL_WONDROUS_ESSENCE")] ItemVirtualWondrousEssence = 113,
    [pbr::OriginalName("ITEM_VIRTUAL_TREASURE_MAP_TOKEN")] ItemVirtualTreasureMapToken = 114,
    [pbr::OriginalName("ITEM_VIRTUAL_SEA_LAMP_COIN")] ItemVirtualSeaLampCoin = 115,
    [pbr::OriginalName("ITEM_VIRTUAL_SEA_LAMP_POPULARITY")] ItemVirtualSeaLampPopularity = 116,
    [pbr::OriginalName("ITEM_VIRTUAL_MECHANICUS_COIN")] ItemVirtualMechanicusCoin = 117,
    [pbr::OriginalName("ITEM_VIRTUAL_FLEUR_FAIR_CREDIT")] ItemVirtualFleurFairCredit = 118,
    [pbr::OriginalName("ITEM_VIRTUAL_FLEUR_FAIR_TOKEN")] ItemVirtualFleurFairToken = 119,
    [pbr::OriginalName("ITEM_VIRTUAL_WATER_SPIRIT_COIN")] ItemVirtualWaterSpiritCoin = 120,
    [pbr::OriginalName("ITEM_VIRTUAL_HOME_EXP")] ItemVirtualHomeExp = 121,
    [pbr::OriginalName("ITEM_VIRTUAL_CHANNELLER_SLAB_TOKEN")] ItemVirtualChannellerSlabToken = 122,
    [pbr::OriginalName("ITEM_VIRTUAL_HIDE_AND_SEEK_COIN")] ItemVirtualHideAndSeekCoin = 123,
    [pbr::OriginalName("ITEM_VIRTUAL_SUMMER_TIME_DRAFT_WOOD")] ItemVirtualSummerTimeDraftWood = 124,
    [pbr::OriginalName("ITEM_VIRTUAL_SUMMER_TIME_MINI_HARPASTUM")] ItemVirtualSummerTimeMiniHarpastum = 125,
    [pbr::OriginalName("ITEM_VIRTUAL_BOUNCE_CONJURING_COIN")] ItemVirtualBounceConjuringCoin = 126,
    [pbr::OriginalName("ITEM_VIRTUAL_BLITZ_RUSH_COIN_A")] ItemVirtualBlitzRushCoinA = 127,
    [pbr::OriginalName("ITEM_VIRTUAL_BLITZ_RUSH_COIN_B")] ItemVirtualBlitzRushCoinB = 128,
    [pbr::OriginalName("ITEM_VIRTUAL_CHESS_EXP")] ItemVirtualChessExp = 129,
    [pbr::OriginalName("ITEM_VIRTUAL_CHESS_COIN")] ItemVirtualChessCoin = 130,
    [pbr::OriginalName("ITEM_VIRTUAL_LUNA_RITE_ATMOSPHERE")] ItemVirtualLunaRiteAtmosphere = 131,
    [pbr::OriginalName("ITEM_VIRTUAL_ROGUELIKE_COIN_A")] ItemVirtualRoguelikeCoinA = 132,
    [pbr::OriginalName("ITEM_VIRTUAL_ROGUELIKE_COIN_B")] ItemVirtualRoguelikeCoinB = 133,
    [pbr::OriginalName("ITEM_VIRTUAL_ROGUELIKE_COIN_C")] ItemVirtualRoguelikeCoinC = 134,
    [pbr::OriginalName("ITEM_VIRTUAL_WINTER_CAMP_COIN_A")] ItemVirtualWinterCampCoinA = 135,
    [pbr::OriginalName("ITEM_VIRTUAL_WINTER_CAMP_COIN_B")] ItemVirtualWinterCampCoinB = 136,
    [pbr::OriginalName("ITEM_VIRTUAL_LANTERN_RITE_COIN_A")] ItemVirtualLanternRiteCoinA = 137,
    [pbr::OriginalName("ITEM_VIRTUAL_LANTERN_RITE_COIN_B")] ItemVirtualLanternRiteCoinB = 138,
    [pbr::OriginalName("ITEM_VIRTUAL_LANTERN_RITE_COIN_C")] ItemVirtualLanternRiteCoinC = 139,
    [pbr::OriginalName("ITEM_VIRTUAL_ROGUE_DIARY_COIN")] ItemVirtualRogueDiaryCoin = 140,
    [pbr::OriginalName("ITEM_VIRTUAL_SUMMER_TIME_V2_COIN")] ItemVirtualSummerTimeV2Coin = 141,
    [pbr::OriginalName("ITEM_VIRTUAL_ROGUE_DIARY_DUNGEON_COIN")] ItemVirtualRogueDiaryDungeonCoin = 142,
    [pbr::OriginalName("ITEM_VIRTUAL_GRAVEN_INNOCENCE_COIN_A")] ItemVirtualGravenInnocenceCoinA = 143,
    [pbr::OriginalName("ITEM_VIRTUAL_GRAVEN_INNOCENCE_COIN_B")] ItemVirtualGravenInnocenceCoinB = 144,
    [pbr::OriginalName("ITEM_VIRTUAL_TREASURE_SEELIE_COIN")] ItemVirtualTreasureSeelieCoin = 145,
    [pbr::OriginalName("ITEM_VIRTUAL_GCG_EXP")] ItemVirtualGcgExp = 146,
    [pbr::OriginalName("ITEM_VIRTUAL_VINTAGE_POPULARITY")] ItemVirtualVintagePopularity = 147,
    [pbr::OriginalName("ITEM_VIRTUAL_VINTAGE_MARKET_COIN_A")] ItemVirtualVintageMarketCoinA = 148,
    [pbr::OriginalName("ITEM_VIRTUAL_VINTAGE_MARKET_COIN_B")] ItemVirtualVintageMarketCoinB = 149,
    [pbr::OriginalName("ITEM_VIRTUAL_VINTAGE_MARKET_COIN_C")] ItemVirtualVintageMarketCoinC = 150,
    [pbr::OriginalName("ITEM_VIRTUAL_FUNGUS_FIGHTER_CAPTURE_COIN")] ItemVirtualFungusFighterCaptureCoin = 151,
    [pbr::OriginalName("ITEM_VIRTUAL_FUNGUS_FIGHTER_TRAINING_COIN")] ItemVirtualFungusFighterTrainingCoin = 152,
    [pbr::OriginalName("ITEM_VIRTUAL_EFFIGY_CHALLENGE_V2_COIN")] ItemVirtualEffigyChallengeV2Coin = 153,
    [pbr::OriginalName("ITEM_VIRTUAL_BRICK_BREAKER_COIN")] ItemVirtualBrickBreakerCoin = 155,
    [pbr::OriginalName("ITEM_VIRTUAL_HCOIN")] ItemVirtualHcoin = 201,
    [pbr::OriginalName("ITEM_VIRTUAL_SCOIN")] ItemVirtualScoin = 202,
    [pbr::OriginalName("ITEM_VIRTUAL_MCOIN")] ItemVirtualMcoin = 203,
    [pbr::OriginalName("ITEM_VIRTUAL_HOME_COIN")] ItemVirtualHomeCoin = 204,
    [pbr::OriginalName("ITEM_VIRTUAL_GCG_COIN")] ItemVirtualGcgCoin = 205,
    [pbr::OriginalName("ITEM_VIRTUAL_INAZUMA_REPUTATION")] ItemVirtualInazumaReputation = 314,
    [pbr::OriginalName("ITEM_VIRTUAL_MENGDE_REPUTATION")] ItemVirtualMengdeReputation = 315,
    [pbr::OriginalName("ITEM_VIRTUAL_SUMERU_REPUTATION")] ItemVirtualSumeruReputation = 316,
    [pbr::OriginalName("ITEM_VIRTUAL_LIYUE_REPUTATION")] ItemVirtualLiyueReputation = 317,
  }

  #endregion

}

#endregion Designer generated code
