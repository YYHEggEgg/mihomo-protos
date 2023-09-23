// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WindFieldGalleryInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WindFieldGalleryInfoNotify.proto</summary>
  public static partial class WindFieldGalleryInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WindFieldGalleryInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WindFieldGalleryInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBXaW5kRmllbGRHYWxsZXJ5SW5mb05vdGlmeS5wcm90bxINbWlIb21vLlBy",
            "b3RvcyLDAgoaV2luZEZpZWxkR2FsbGVyeUluZm9Ob3RpZnkSIAoYY2hhbGxl",
            "bmdlX2JhbGxfY3VyX2NvdW50GAogASgNEiAKGGNoYWxsZW5nZV9iYWxsX21h",
            "eF9jb3VudBgBIAEoDRIbChNjaGFsbGVuZ2VfdGltZXN0YW1wGAQgASgNEhwK",
            "FGNoYWxsZW5nZV90b3RhbF90aW1lGAUgASgNEhAKCGNvaW5fbnVtGAkgASgN",
            "EhgKEGVsZW1lbnRfYmFsbF9udW0YDiABKA0SGgoSa2lsbGVkX21vbnN0ZXJf",
            "bnVtGAcgASgNEg8KB3Nob3dfaWQYAyABKA0iTQoFQ21kSWQSCAoETk9ORRAA",
            "EhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARIL",
            "CgZDTURfSUQQlisaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WindFieldGalleryInfoNotify), global::MiHomo.Protos.WindFieldGalleryInfoNotify.Parser, new[]{ "ChallengeBallCurCount", "ChallengeBallMaxCount", "ChallengeTimestamp", "ChallengeTotalTime", "CoinNum", "ElementBallNum", "KilledMonsterNum", "ShowId" }, null, new[]{ typeof(global::MiHomo.Protos.WindFieldGalleryInfoNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WindFieldGalleryInfoNotify : pb::IMessage<WindFieldGalleryInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WindFieldGalleryInfoNotify> _parser = new pb::MessageParser<WindFieldGalleryInfoNotify>(() => new WindFieldGalleryInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WindFieldGalleryInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WindFieldGalleryInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryInfoNotify(WindFieldGalleryInfoNotify other) : this() {
      challengeBallCurCount_ = other.challengeBallCurCount_;
      challengeBallMaxCount_ = other.challengeBallMaxCount_;
      challengeTimestamp_ = other.challengeTimestamp_;
      challengeTotalTime_ = other.challengeTotalTime_;
      coinNum_ = other.coinNum_;
      elementBallNum_ = other.elementBallNum_;
      killedMonsterNum_ = other.killedMonsterNum_;
      showId_ = other.showId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryInfoNotify Clone() {
      return new WindFieldGalleryInfoNotify(this);
    }

    /// <summary>Field number for the "challenge_ball_cur_count" field.</summary>
    public const int ChallengeBallCurCountFieldNumber = 10;
    private uint challengeBallCurCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeBallCurCount {
      get { return challengeBallCurCount_; }
      set {
        challengeBallCurCount_ = value;
      }
    }

    /// <summary>Field number for the "challenge_ball_max_count" field.</summary>
    public const int ChallengeBallMaxCountFieldNumber = 1;
    private uint challengeBallMaxCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeBallMaxCount {
      get { return challengeBallMaxCount_; }
      set {
        challengeBallMaxCount_ = value;
      }
    }

    /// <summary>Field number for the "challenge_timestamp" field.</summary>
    public const int ChallengeTimestampFieldNumber = 4;
    private uint challengeTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeTimestamp {
      get { return challengeTimestamp_; }
      set {
        challengeTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "challenge_total_time" field.</summary>
    public const int ChallengeTotalTimeFieldNumber = 5;
    private uint challengeTotalTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeTotalTime {
      get { return challengeTotalTime_; }
      set {
        challengeTotalTime_ = value;
      }
    }

    /// <summary>Field number for the "coin_num" field.</summary>
    public const int CoinNumFieldNumber = 9;
    private uint coinNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinNum {
      get { return coinNum_; }
      set {
        coinNum_ = value;
      }
    }

    /// <summary>Field number for the "element_ball_num" field.</summary>
    public const int ElementBallNumFieldNumber = 14;
    private uint elementBallNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementBallNum {
      get { return elementBallNum_; }
      set {
        elementBallNum_ = value;
      }
    }

    /// <summary>Field number for the "killed_monster_num" field.</summary>
    public const int KilledMonsterNumFieldNumber = 7;
    private uint killedMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KilledMonsterNum {
      get { return killedMonsterNum_; }
      set {
        killedMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "show_id" field.</summary>
    public const int ShowIdFieldNumber = 3;
    private uint showId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShowId {
      get { return showId_; }
      set {
        showId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WindFieldGalleryInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WindFieldGalleryInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeBallCurCount != other.ChallengeBallCurCount) return false;
      if (ChallengeBallMaxCount != other.ChallengeBallMaxCount) return false;
      if (ChallengeTimestamp != other.ChallengeTimestamp) return false;
      if (ChallengeTotalTime != other.ChallengeTotalTime) return false;
      if (CoinNum != other.CoinNum) return false;
      if (ElementBallNum != other.ElementBallNum) return false;
      if (KilledMonsterNum != other.KilledMonsterNum) return false;
      if (ShowId != other.ShowId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeBallCurCount != 0) hash ^= ChallengeBallCurCount.GetHashCode();
      if (ChallengeBallMaxCount != 0) hash ^= ChallengeBallMaxCount.GetHashCode();
      if (ChallengeTimestamp != 0) hash ^= ChallengeTimestamp.GetHashCode();
      if (ChallengeTotalTime != 0) hash ^= ChallengeTotalTime.GetHashCode();
      if (CoinNum != 0) hash ^= CoinNum.GetHashCode();
      if (ElementBallNum != 0) hash ^= ElementBallNum.GetHashCode();
      if (KilledMonsterNum != 0) hash ^= KilledMonsterNum.GetHashCode();
      if (ShowId != 0) hash ^= ShowId.GetHashCode();
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
      if (ChallengeBallMaxCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeBallMaxCount);
      }
      if (ShowId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ShowId);
      }
      if (ChallengeTimestamp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ChallengeTimestamp);
      }
      if (ChallengeTotalTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ChallengeTotalTime);
      }
      if (KilledMonsterNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KilledMonsterNum);
      }
      if (CoinNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CoinNum);
      }
      if (ChallengeBallCurCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeBallCurCount);
      }
      if (ElementBallNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ElementBallNum);
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
      if (ChallengeBallMaxCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeBallMaxCount);
      }
      if (ShowId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ShowId);
      }
      if (ChallengeTimestamp != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ChallengeTimestamp);
      }
      if (ChallengeTotalTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ChallengeTotalTime);
      }
      if (KilledMonsterNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(KilledMonsterNum);
      }
      if (CoinNum != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CoinNum);
      }
      if (ChallengeBallCurCount != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeBallCurCount);
      }
      if (ElementBallNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(ElementBallNum);
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
      if (ChallengeBallCurCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeBallCurCount);
      }
      if (ChallengeBallMaxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeBallMaxCount);
      }
      if (ChallengeTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeTimestamp);
      }
      if (ChallengeTotalTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeTotalTime);
      }
      if (CoinNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinNum);
      }
      if (ElementBallNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementBallNum);
      }
      if (KilledMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KilledMonsterNum);
      }
      if (ShowId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShowId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WindFieldGalleryInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeBallCurCount != 0) {
        ChallengeBallCurCount = other.ChallengeBallCurCount;
      }
      if (other.ChallengeBallMaxCount != 0) {
        ChallengeBallMaxCount = other.ChallengeBallMaxCount;
      }
      if (other.ChallengeTimestamp != 0) {
        ChallengeTimestamp = other.ChallengeTimestamp;
      }
      if (other.ChallengeTotalTime != 0) {
        ChallengeTotalTime = other.ChallengeTotalTime;
      }
      if (other.CoinNum != 0) {
        CoinNum = other.CoinNum;
      }
      if (other.ElementBallNum != 0) {
        ElementBallNum = other.ElementBallNum;
      }
      if (other.KilledMonsterNum != 0) {
        KilledMonsterNum = other.KilledMonsterNum;
      }
      if (other.ShowId != 0) {
        ShowId = other.ShowId;
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
            ChallengeBallMaxCount = input.ReadUInt32();
            break;
          }
          case 24: {
            ShowId = input.ReadUInt32();
            break;
          }
          case 32: {
            ChallengeTimestamp = input.ReadUInt32();
            break;
          }
          case 40: {
            ChallengeTotalTime = input.ReadUInt32();
            break;
          }
          case 56: {
            KilledMonsterNum = input.ReadUInt32();
            break;
          }
          case 72: {
            CoinNum = input.ReadUInt32();
            break;
          }
          case 80: {
            ChallengeBallCurCount = input.ReadUInt32();
            break;
          }
          case 112: {
            ElementBallNum = input.ReadUInt32();
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
            ChallengeBallMaxCount = input.ReadUInt32();
            break;
          }
          case 24: {
            ShowId = input.ReadUInt32();
            break;
          }
          case 32: {
            ChallengeTimestamp = input.ReadUInt32();
            break;
          }
          case 40: {
            ChallengeTotalTime = input.ReadUInt32();
            break;
          }
          case 56: {
            KilledMonsterNum = input.ReadUInt32();
            break;
          }
          case 72: {
            CoinNum = input.ReadUInt32();
            break;
          }
          case 80: {
            ChallengeBallCurCount = input.ReadUInt32();
            break;
          }
          case 112: {
            ElementBallNum = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the WindFieldGalleryInfoNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 5526,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
