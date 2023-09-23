// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureMapActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TreasureMapActivityDetailInfo.proto</summary>
  public static partial class TreasureMapActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureMapActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureMapActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNUcmVhc3VyZU1hcEFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxINbWlIb21v",
            "LlByb3RvcxojVHJlYXN1cmVNYXBCb251c0NoYWxsZW5nZUluZm8ucHJvdG8a",
            "G1RyZWFzdXJlTWFwUmVnaW9uSW5mby5wcm90byLxAgodVHJlYXN1cmVNYXBB",
            "Y3Rpdml0eURldGFpbEluZm8SGwoTYWN0aXZlX3JlZ2lvbl9pbmRleBgBIAEo",
            "DRJKChRib251c19jaGFsbGVuZ2VfbGlzdBgFIAMoCzIsLm1pSG9tby5Qcm90",
            "b3MuVHJlYXN1cmVNYXBCb251c0NoYWxsZW5nZUluZm8SFAoMY3VycmVuY3lf",
            "bnVtGAIgASgNEh8KF2lzX21wX2NoYWxsZW5nZV90b3VjaGVkGAcgASgIEh0K",
            "FW1pbl9vcGVuX3BsYXllcl9sZXZlbBgIIAEoDRIZChFwcmV2aWV3X3Jld2Fy",
            "ZF9pZBgOIAEoDRI+ChByZWdpb25faW5mb19saXN0GAYgAygLMiQubWlIb21v",
            "LlByb3Rvcy5UcmVhc3VyZU1hcFJlZ2lvbkluZm8SGQoRdG90YWxfbXBfc3Bv",
            "dF9udW0YDSABKA0SGwoTdHJlYXN1cmVfY2xvc2VfdGltZRgKIAEoDWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.TreasureMapBonusChallengeInfoReflection.Descriptor, global::MiHomo.Protos.TreasureMapRegionInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TreasureMapActivityDetailInfo), global::MiHomo.Protos.TreasureMapActivityDetailInfo.Parser, new[]{ "ActiveRegionIndex", "BonusChallengeList", "CurrencyNum", "IsMpChallengeTouched", "MinOpenPlayerLevel", "PreviewRewardId", "RegionInfoList", "TotalMpSpotNum", "TreasureCloseTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TreasureMapActivityDetailInfo : pb::IMessage<TreasureMapActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureMapActivityDetailInfo> _parser = new pb::MessageParser<TreasureMapActivityDetailInfo>(() => new TreasureMapActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureMapActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TreasureMapActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapActivityDetailInfo(TreasureMapActivityDetailInfo other) : this() {
      activeRegionIndex_ = other.activeRegionIndex_;
      bonusChallengeList_ = other.bonusChallengeList_.Clone();
      currencyNum_ = other.currencyNum_;
      isMpChallengeTouched_ = other.isMpChallengeTouched_;
      minOpenPlayerLevel_ = other.minOpenPlayerLevel_;
      previewRewardId_ = other.previewRewardId_;
      regionInfoList_ = other.regionInfoList_.Clone();
      totalMpSpotNum_ = other.totalMpSpotNum_;
      treasureCloseTime_ = other.treasureCloseTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapActivityDetailInfo Clone() {
      return new TreasureMapActivityDetailInfo(this);
    }

    /// <summary>Field number for the "active_region_index" field.</summary>
    public const int ActiveRegionIndexFieldNumber = 1;
    private uint activeRegionIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActiveRegionIndex {
      get { return activeRegionIndex_; }
      set {
        activeRegionIndex_ = value;
      }
    }

    /// <summary>Field number for the "bonus_challenge_list" field.</summary>
    public const int BonusChallengeListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.TreasureMapBonusChallengeInfo> _repeated_bonusChallengeList_codec
        = pb::FieldCodec.ForMessage(42, global::MiHomo.Protos.TreasureMapBonusChallengeInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.TreasureMapBonusChallengeInfo> bonusChallengeList_ = new pbc::RepeatedField<global::MiHomo.Protos.TreasureMapBonusChallengeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.TreasureMapBonusChallengeInfo> BonusChallengeList {
      get { return bonusChallengeList_; }
    }

    /// <summary>Field number for the "currency_num" field.</summary>
    public const int CurrencyNumFieldNumber = 2;
    private uint currencyNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurrencyNum {
      get { return currencyNum_; }
      set {
        currencyNum_ = value;
      }
    }

    /// <summary>Field number for the "is_mp_challenge_touched" field.</summary>
    public const int IsMpChallengeTouchedFieldNumber = 7;
    private bool isMpChallengeTouched_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMpChallengeTouched {
      get { return isMpChallengeTouched_; }
      set {
        isMpChallengeTouched_ = value;
      }
    }

    /// <summary>Field number for the "min_open_player_level" field.</summary>
    public const int MinOpenPlayerLevelFieldNumber = 8;
    private uint minOpenPlayerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinOpenPlayerLevel {
      get { return minOpenPlayerLevel_; }
      set {
        minOpenPlayerLevel_ = value;
      }
    }

    /// <summary>Field number for the "preview_reward_id" field.</summary>
    public const int PreviewRewardIdFieldNumber = 14;
    private uint previewRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PreviewRewardId {
      get { return previewRewardId_; }
      set {
        previewRewardId_ = value;
      }
    }

    /// <summary>Field number for the "region_info_list" field.</summary>
    public const int RegionInfoListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.TreasureMapRegionInfo> _repeated_regionInfoList_codec
        = pb::FieldCodec.ForMessage(50, global::MiHomo.Protos.TreasureMapRegionInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.TreasureMapRegionInfo> regionInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.TreasureMapRegionInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.TreasureMapRegionInfo> RegionInfoList {
      get { return regionInfoList_; }
    }

    /// <summary>Field number for the "total_mp_spot_num" field.</summary>
    public const int TotalMpSpotNumFieldNumber = 13;
    private uint totalMpSpotNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalMpSpotNum {
      get { return totalMpSpotNum_; }
      set {
        totalMpSpotNum_ = value;
      }
    }

    /// <summary>Field number for the "treasure_close_time" field.</summary>
    public const int TreasureCloseTimeFieldNumber = 10;
    private uint treasureCloseTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TreasureCloseTime {
      get { return treasureCloseTime_; }
      set {
        treasureCloseTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureMapActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureMapActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActiveRegionIndex != other.ActiveRegionIndex) return false;
      if(!bonusChallengeList_.Equals(other.bonusChallengeList_)) return false;
      if (CurrencyNum != other.CurrencyNum) return false;
      if (IsMpChallengeTouched != other.IsMpChallengeTouched) return false;
      if (MinOpenPlayerLevel != other.MinOpenPlayerLevel) return false;
      if (PreviewRewardId != other.PreviewRewardId) return false;
      if(!regionInfoList_.Equals(other.regionInfoList_)) return false;
      if (TotalMpSpotNum != other.TotalMpSpotNum) return false;
      if (TreasureCloseTime != other.TreasureCloseTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActiveRegionIndex != 0) hash ^= ActiveRegionIndex.GetHashCode();
      hash ^= bonusChallengeList_.GetHashCode();
      if (CurrencyNum != 0) hash ^= CurrencyNum.GetHashCode();
      if (IsMpChallengeTouched != false) hash ^= IsMpChallengeTouched.GetHashCode();
      if (MinOpenPlayerLevel != 0) hash ^= MinOpenPlayerLevel.GetHashCode();
      if (PreviewRewardId != 0) hash ^= PreviewRewardId.GetHashCode();
      hash ^= regionInfoList_.GetHashCode();
      if (TotalMpSpotNum != 0) hash ^= TotalMpSpotNum.GetHashCode();
      if (TreasureCloseTime != 0) hash ^= TreasureCloseTime.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ActiveRegionIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ActiveRegionIndex);
      }
      if (CurrencyNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurrencyNum);
      }
      bonusChallengeList_.WriteTo(output, _repeated_bonusChallengeList_codec);
      regionInfoList_.WriteTo(output, _repeated_regionInfoList_codec);
      if (IsMpChallengeTouched != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMpChallengeTouched);
      }
      if (MinOpenPlayerLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MinOpenPlayerLevel);
      }
      if (TreasureCloseTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TreasureCloseTime);
      }
      if (TotalMpSpotNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalMpSpotNum);
      }
      if (PreviewRewardId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PreviewRewardId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ActiveRegionIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ActiveRegionIndex);
      }
      if (CurrencyNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurrencyNum);
      }
      bonusChallengeList_.WriteTo(ref output, _repeated_bonusChallengeList_codec);
      regionInfoList_.WriteTo(ref output, _repeated_regionInfoList_codec);
      if (IsMpChallengeTouched != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMpChallengeTouched);
      }
      if (MinOpenPlayerLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MinOpenPlayerLevel);
      }
      if (TreasureCloseTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(TreasureCloseTime);
      }
      if (TotalMpSpotNum != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalMpSpotNum);
      }
      if (PreviewRewardId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(PreviewRewardId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ActiveRegionIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActiveRegionIndex);
      }
      size += bonusChallengeList_.CalculateSize(_repeated_bonusChallengeList_codec);
      if (CurrencyNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurrencyNum);
      }
      if (IsMpChallengeTouched != false) {
        size += 1 + 1;
      }
      if (MinOpenPlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinOpenPlayerLevel);
      }
      if (PreviewRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PreviewRewardId);
      }
      size += regionInfoList_.CalculateSize(_repeated_regionInfoList_codec);
      if (TotalMpSpotNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalMpSpotNum);
      }
      if (TreasureCloseTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TreasureCloseTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureMapActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.ActiveRegionIndex != 0) {
        ActiveRegionIndex = other.ActiveRegionIndex;
      }
      bonusChallengeList_.Add(other.bonusChallengeList_);
      if (other.CurrencyNum != 0) {
        CurrencyNum = other.CurrencyNum;
      }
      if (other.IsMpChallengeTouched != false) {
        IsMpChallengeTouched = other.IsMpChallengeTouched;
      }
      if (other.MinOpenPlayerLevel != 0) {
        MinOpenPlayerLevel = other.MinOpenPlayerLevel;
      }
      if (other.PreviewRewardId != 0) {
        PreviewRewardId = other.PreviewRewardId;
      }
      regionInfoList_.Add(other.regionInfoList_);
      if (other.TotalMpSpotNum != 0) {
        TotalMpSpotNum = other.TotalMpSpotNum;
      }
      if (other.TreasureCloseTime != 0) {
        TreasureCloseTime = other.TreasureCloseTime;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ActiveRegionIndex = input.ReadUInt32();
            break;
          }
          case 16: {
            CurrencyNum = input.ReadUInt32();
            break;
          }
          case 42: {
            bonusChallengeList_.AddEntriesFrom(input, _repeated_bonusChallengeList_codec);
            break;
          }
          case 50: {
            regionInfoList_.AddEntriesFrom(input, _repeated_regionInfoList_codec);
            break;
          }
          case 56: {
            IsMpChallengeTouched = input.ReadBool();
            break;
          }
          case 64: {
            MinOpenPlayerLevel = input.ReadUInt32();
            break;
          }
          case 80: {
            TreasureCloseTime = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalMpSpotNum = input.ReadUInt32();
            break;
          }
          case 112: {
            PreviewRewardId = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ActiveRegionIndex = input.ReadUInt32();
            break;
          }
          case 16: {
            CurrencyNum = input.ReadUInt32();
            break;
          }
          case 42: {
            bonusChallengeList_.AddEntriesFrom(ref input, _repeated_bonusChallengeList_codec);
            break;
          }
          case 50: {
            regionInfoList_.AddEntriesFrom(ref input, _repeated_regionInfoList_codec);
            break;
          }
          case 56: {
            IsMpChallengeTouched = input.ReadBool();
            break;
          }
          case 64: {
            MinOpenPlayerLevel = input.ReadUInt32();
            break;
          }
          case 80: {
            TreasureCloseTime = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalMpSpotNum = input.ReadUInt32();
            break;
          }
          case 112: {
            PreviewRewardId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
