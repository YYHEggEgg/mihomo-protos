// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GravenInnocenceRaceSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GravenInnocenceRaceSettleNotify.proto</summary>
  public static partial class GravenInnocenceRaceSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GravenInnocenceRaceSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GravenInnocenceRaceSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVHcmF2ZW5Jbm5vY2VuY2VSYWNlU2V0dGxlTm90aWZ5LnByb3RvEg1taUhv",
            "bW8uUHJvdG9zGhdHYWxsZXJ5U3RvcFJlYXNvbi5wcm90byLjAgofR3JhdmVu",
            "SW5ub2NlbmNlUmFjZVNldHRsZU5vdGlmeRIaChJjaGFsbGVuZ2VfcHJvZ3Jl",
            "c3MYASABKA0SEgoKY29pbl9jb3VudBgIIAEoDRISCgpnYWxsZXJ5X2lkGAYg",
            "ASgNEhUKDWlzX25ld19yZWNvcmQYBCABKAgSEgoKaXNfc3VjY2VzcxgHIAEo",
            "CBIQCghsZXZlbF9pZBgLIAEoDRIwCgZyZWFzb24YAiABKA4yIC5taUhvbW8u",
            "UHJvdG9zLkdhbGxlcnlTdG9wUmVhc29uEhMKC3JlbWFpbl90aW1lGAogASgN",
            "Eg0KBXNjb3JlGAUgASgNEhkKEXRvdGFsX2NvaW50X2NvdW50GA0gASgNIk4K",
            "BUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVU",
            "X0lTX1JFTElBQkxFEAESDAoGQ01EX0lEEMmhARoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GalleryStopReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GravenInnocenceRaceSettleNotify), global::MiHomo.Protos.GravenInnocenceRaceSettleNotify.Parser, new[]{ "ChallengeProgress", "CoinCount", "GalleryId", "IsNewRecord", "IsSuccess", "LevelId", "Reason", "RemainTime", "Score", "TotalCointCount" }, null, new[]{ typeof(global::MiHomo.Protos.GravenInnocenceRaceSettleNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GravenInnocenceRaceSettleNotify : pb::IMessage<GravenInnocenceRaceSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GravenInnocenceRaceSettleNotify> _parser = new pb::MessageParser<GravenInnocenceRaceSettleNotify>(() => new GravenInnocenceRaceSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GravenInnocenceRaceSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GravenInnocenceRaceSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GravenInnocenceRaceSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GravenInnocenceRaceSettleNotify(GravenInnocenceRaceSettleNotify other) : this() {
      challengeProgress_ = other.challengeProgress_;
      coinCount_ = other.coinCount_;
      galleryId_ = other.galleryId_;
      isNewRecord_ = other.isNewRecord_;
      isSuccess_ = other.isSuccess_;
      levelId_ = other.levelId_;
      reason_ = other.reason_;
      remainTime_ = other.remainTime_;
      score_ = other.score_;
      totalCointCount_ = other.totalCointCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GravenInnocenceRaceSettleNotify Clone() {
      return new GravenInnocenceRaceSettleNotify(this);
    }

    /// <summary>Field number for the "challenge_progress" field.</summary>
    public const int ChallengeProgressFieldNumber = 1;
    private uint challengeProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeProgress {
      get { return challengeProgress_; }
      set {
        challengeProgress_ = value;
      }
    }

    /// <summary>Field number for the "coin_count" field.</summary>
    public const int CoinCountFieldNumber = 8;
    private uint coinCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinCount {
      get { return coinCount_; }
      set {
        coinCount_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 6;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 4;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 7;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 11;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 2;
    private global::MiHomo.Protos.GalleryStopReason reason_ = global::MiHomo.Protos.GalleryStopReason.GalleryStopNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GalleryStopReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "remain_time" field.</summary>
    public const int RemainTimeFieldNumber = 10;
    private uint remainTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainTime {
      get { return remainTime_; }
      set {
        remainTime_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 5;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "total_coint_count" field.</summary>
    public const int TotalCointCountFieldNumber = 13;
    private uint totalCointCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalCointCount {
      get { return totalCointCount_; }
      set {
        totalCointCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GravenInnocenceRaceSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GravenInnocenceRaceSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeProgress != other.ChallengeProgress) return false;
      if (CoinCount != other.CoinCount) return false;
      if (GalleryId != other.GalleryId) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (LevelId != other.LevelId) return false;
      if (Reason != other.Reason) return false;
      if (RemainTime != other.RemainTime) return false;
      if (Score != other.Score) return false;
      if (TotalCointCount != other.TotalCointCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeProgress != 0) hash ^= ChallengeProgress.GetHashCode();
      if (CoinCount != 0) hash ^= CoinCount.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Reason != global::MiHomo.Protos.GalleryStopReason.GalleryStopNone) hash ^= Reason.GetHashCode();
      if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (TotalCointCount != 0) hash ^= TotalCointCount.GetHashCode();
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
      if (ChallengeProgress != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeProgress);
      }
      if (Reason != global::MiHomo.Protos.GalleryStopReason.GalleryStopNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Reason);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewRecord);
      }
      if (Score != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Score);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GalleryId);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSuccess);
      }
      if (CoinCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CoinCount);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RemainTime);
      }
      if (LevelId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LevelId);
      }
      if (TotalCointCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalCointCount);
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
      if (ChallengeProgress != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeProgress);
      }
      if (Reason != global::MiHomo.Protos.GalleryStopReason.GalleryStopNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Reason);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewRecord);
      }
      if (Score != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Score);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(GalleryId);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSuccess);
      }
      if (CoinCount != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CoinCount);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RemainTime);
      }
      if (LevelId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LevelId);
      }
      if (TotalCointCount != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TotalCointCount);
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
      if (ChallengeProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeProgress);
      }
      if (CoinCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinCount);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (Reason != global::MiHomo.Protos.GalleryStopReason.GalleryStopNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (RemainTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (TotalCointCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalCointCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GravenInnocenceRaceSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeProgress != 0) {
        ChallengeProgress = other.ChallengeProgress;
      }
      if (other.CoinCount != 0) {
        CoinCount = other.CoinCount;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Reason != global::MiHomo.Protos.GalleryStopReason.GalleryStopNone) {
        Reason = other.Reason;
      }
      if (other.RemainTime != 0) {
        RemainTime = other.RemainTime;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.TotalCointCount != 0) {
        TotalCointCount = other.TotalCointCount;
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
            ChallengeProgress = input.ReadUInt32();
            break;
          }
          case 16: {
            Reason = (global::MiHomo.Protos.GalleryStopReason) input.ReadEnum();
            break;
          }
          case 32: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 40: {
            Score = input.ReadUInt32();
            break;
          }
          case 48: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            CoinCount = input.ReadUInt32();
            break;
          }
          case 80: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 88: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalCointCount = input.ReadUInt32();
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
            ChallengeProgress = input.ReadUInt32();
            break;
          }
          case 16: {
            Reason = (global::MiHomo.Protos.GalleryStopReason) input.ReadEnum();
            break;
          }
          case 32: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 40: {
            Score = input.ReadUInt32();
            break;
          }
          case 48: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            CoinCount = input.ReadUInt32();
            break;
          }
          case 80: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 88: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 104: {
            TotalCointCount = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GravenInnocenceRaceSettleNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 20681,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
