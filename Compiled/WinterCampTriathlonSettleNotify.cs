// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampTriathlonSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WinterCampTriathlonSettleNotify.proto</summary>
  public static partial class WinterCampTriathlonSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WinterCampTriathlonSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinterCampTriathlonSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVXaW50ZXJDYW1wVHJpYXRobG9uU2V0dGxlTm90aWZ5LnByb3RvEg1taUhv",
            "bW8uUHJvdG9zIo8CCh9XaW50ZXJDYW1wVHJpYXRobG9uU2V0dGxlTm90aWZ5",
            "EhIKCmdhbGxlcnlfaWQYDSABKA0SFQoNaXNfbmV3X3JlY29yZBgHIAEoCBIS",
            "Cgppc19zdWNjZXNzGAMgASgIEhQKDGxpbWl0ZWRfY29pbhgJIAEoDRITCgtu",
            "b3JtYWxfY29pbhgCIAEoDRIPCgdyYWNlX2lkGA8gASgNEhMKC3JlbWFpbl90",
            "aW1lGAQgASgNEg0KBXNjb3JlGAsgASgNIk0KBUNtZElkEggKBE5PTkUQABIT",
            "Cg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAESCwoG",
            "Q01EX0lEEJZBGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WinterCampTriathlonSettleNotify), global::MiHomo.Protos.WinterCampTriathlonSettleNotify.Parser, new[]{ "GalleryId", "IsNewRecord", "IsSuccess", "LimitedCoin", "NormalCoin", "RaceId", "RemainTime", "Score" }, null, new[]{ typeof(global::MiHomo.Protos.WinterCampTriathlonSettleNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WinterCampTriathlonSettleNotify : pb::IMessage<WinterCampTriathlonSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WinterCampTriathlonSettleNotify> _parser = new pb::MessageParser<WinterCampTriathlonSettleNotify>(() => new WinterCampTriathlonSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WinterCampTriathlonSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WinterCampTriathlonSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampTriathlonSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampTriathlonSettleNotify(WinterCampTriathlonSettleNotify other) : this() {
      galleryId_ = other.galleryId_;
      isNewRecord_ = other.isNewRecord_;
      isSuccess_ = other.isSuccess_;
      limitedCoin_ = other.limitedCoin_;
      normalCoin_ = other.normalCoin_;
      raceId_ = other.raceId_;
      remainTime_ = other.remainTime_;
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampTriathlonSettleNotify Clone() {
      return new WinterCampTriathlonSettleNotify(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 13;
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
    public const int IsNewRecordFieldNumber = 7;
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
    public const int IsSuccessFieldNumber = 3;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "limited_coin" field.</summary>
    public const int LimitedCoinFieldNumber = 9;
    private uint limitedCoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LimitedCoin {
      get { return limitedCoin_; }
      set {
        limitedCoin_ = value;
      }
    }

    /// <summary>Field number for the "normal_coin" field.</summary>
    public const int NormalCoinFieldNumber = 2;
    private uint normalCoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NormalCoin {
      get { return normalCoin_; }
      set {
        normalCoin_ = value;
      }
    }

    /// <summary>Field number for the "race_id" field.</summary>
    public const int RaceIdFieldNumber = 15;
    private uint raceId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RaceId {
      get { return raceId_; }
      set {
        raceId_ = value;
      }
    }

    /// <summary>Field number for the "remain_time" field.</summary>
    public const int RemainTimeFieldNumber = 4;
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
    public const int ScoreFieldNumber = 11;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WinterCampTriathlonSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WinterCampTriathlonSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (LimitedCoin != other.LimitedCoin) return false;
      if (NormalCoin != other.NormalCoin) return false;
      if (RaceId != other.RaceId) return false;
      if (RemainTime != other.RemainTime) return false;
      if (Score != other.Score) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (LimitedCoin != 0) hash ^= LimitedCoin.GetHashCode();
      if (NormalCoin != 0) hash ^= NormalCoin.GetHashCode();
      if (RaceId != 0) hash ^= RaceId.GetHashCode();
      if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
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
      if (NormalCoin != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NormalCoin);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSuccess);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(RemainTime);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNewRecord);
      }
      if (LimitedCoin != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LimitedCoin);
      }
      if (Score != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Score);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (RaceId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RaceId);
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
      if (NormalCoin != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(NormalCoin);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsSuccess);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(RemainTime);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsNewRecord);
      }
      if (LimitedCoin != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(LimitedCoin);
      }
      if (Score != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Score);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (RaceId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RaceId);
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
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (LimitedCoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LimitedCoin);
      }
      if (NormalCoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NormalCoin);
      }
      if (RaceId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RaceId);
      }
      if (RemainTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WinterCampTriathlonSettleNotify other) {
      if (other == null) {
        return;
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
      if (other.LimitedCoin != 0) {
        LimitedCoin = other.LimitedCoin;
      }
      if (other.NormalCoin != 0) {
        NormalCoin = other.NormalCoin;
      }
      if (other.RaceId != 0) {
        RaceId = other.RaceId;
      }
      if (other.RemainTime != 0) {
        RemainTime = other.RemainTime;
      }
      if (other.Score != 0) {
        Score = other.Score;
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
          case 16: {
            NormalCoin = input.ReadUInt32();
            break;
          }
          case 24: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 32: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 56: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 72: {
            LimitedCoin = input.ReadUInt32();
            break;
          }
          case 88: {
            Score = input.ReadUInt32();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 120: {
            RaceId = input.ReadUInt32();
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
          case 16: {
            NormalCoin = input.ReadUInt32();
            break;
          }
          case 24: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 32: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 56: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 72: {
            LimitedCoin = input.ReadUInt32();
            break;
          }
          case 88: {
            Score = input.ReadUInt32();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 120: {
            RaceId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the WinterCampTriathlonSettleNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 8342,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
