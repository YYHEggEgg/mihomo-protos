// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FallSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FallSettleInfo.proto</summary>
  public static partial class FallSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FallSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FallSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGYWxsU2V0dGxlSW5mby5wcm90bxINbWlIb21vLlByb3RvcxoWT25saW5l",
            "UGxheWVySW5mby5wcm90byKzAgoORmFsbFNldHRsZUluZm8SEwoLY2F0Y2hf",
            "Y291bnQYASABKA0SEwoLZmluYWxfc2NvcmUYDiABKA0SNAoLcGxheWVyX2lu",
            "Zm8YCSABKAsyHy5taUhvbW8uUHJvdG9zLk9ubGluZVBsYXllckluZm8SEwoL",
            "cmVtYWluX3RpbWUYBiABKA0SCwoDdWlkGAIgASgNEl8KG2Zsb3dlcl9yaW5n",
            "X2NhdGNoX2NvdW50X21hcBgNIAMoCzI6Lm1pSG9tby5Qcm90b3MuRmFsbFNl",
            "dHRsZUluZm8uRmxvd2VyUmluZ0NhdGNoQ291bnRNYXBFbnRyeRo+ChxGbG93",
            "ZXJSaW5nQ2F0Y2hDb3VudE1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1",
            "ZRgCIAEoDToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FallSettleInfo), global::MiHomo.Protos.FallSettleInfo.Parser, new[]{ "CatchCount", "FinalScore", "PlayerInfo", "RemainTime", "Uid", "FlowerRingCatchCountMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FallSettleInfo : pb::IMessage<FallSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FallSettleInfo> _parser = new pb::MessageParser<FallSettleInfo>(() => new FallSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FallSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FallSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo(FallSettleInfo other) : this() {
      catchCount_ = other.catchCount_;
      finalScore_ = other.finalScore_;
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      remainTime_ = other.remainTime_;
      uid_ = other.uid_;
      flowerRingCatchCountMap_ = other.flowerRingCatchCountMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FallSettleInfo Clone() {
      return new FallSettleInfo(this);
    }

    /// <summary>Field number for the "catch_count" field.</summary>
    public const int CatchCountFieldNumber = 1;
    private uint catchCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CatchCount {
      get { return catchCount_; }
      set {
        catchCount_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 14;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 9;
    private global::MiHomo.Protos.OnlinePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.OnlinePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "remain_time" field.</summary>
    public const int RemainTimeFieldNumber = 6;
    private uint remainTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainTime {
      get { return remainTime_; }
      set {
        remainTime_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "flower_ring_catch_count_map" field.</summary>
    public const int FlowerRingCatchCountMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_flowerRingCatchCountMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> flowerRingCatchCountMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FlowerRingCatchCountMap {
      get { return flowerRingCatchCountMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FallSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FallSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CatchCount != other.CatchCount) return false;
      if (FinalScore != other.FinalScore) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (RemainTime != other.RemainTime) return false;
      if (Uid != other.Uid) return false;
      if (!FlowerRingCatchCountMap.Equals(other.FlowerRingCatchCountMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CatchCount != 0) hash ^= CatchCount.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (RemainTime != 0) hash ^= RemainTime.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= FlowerRingCatchCountMap.GetHashCode();
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
      if (CatchCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CatchCount);
      }
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RemainTime);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PlayerInfo);
      }
      flowerRingCatchCountMap_.WriteTo(output, _map_flowerRingCatchCountMap_codec);
      if (FinalScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinalScore);
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
      if (CatchCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CatchCount);
      }
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      if (RemainTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(RemainTime);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PlayerInfo);
      }
      flowerRingCatchCountMap_.WriteTo(ref output, _map_flowerRingCatchCountMap_codec);
      if (FinalScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(FinalScore);
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
      if (CatchCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CatchCount);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (RemainTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainTime);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += flowerRingCatchCountMap_.CalculateSize(_map_flowerRingCatchCountMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FallSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.CatchCount != 0) {
        CatchCount = other.CatchCount;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::MiHomo.Protos.OnlinePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.RemainTime != 0) {
        RemainTime = other.RemainTime;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      flowerRingCatchCountMap_.Add(other.flowerRingCatchCountMap_);
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
            CatchCount = input.ReadUInt32();
            break;
          }
          case 16: {
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::MiHomo.Protos.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 106: {
            flowerRingCatchCountMap_.AddEntriesFrom(input, _map_flowerRingCatchCountMap_codec);
            break;
          }
          case 112: {
            FinalScore = input.ReadUInt32();
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
            CatchCount = input.ReadUInt32();
            break;
          }
          case 16: {
            Uid = input.ReadUInt32();
            break;
          }
          case 48: {
            RemainTime = input.ReadUInt32();
            break;
          }
          case 74: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::MiHomo.Protos.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 106: {
            flowerRingCatchCountMap_.AddEntriesFrom(ref input, _map_flowerRingCatchCountMap_codec);
            break;
          }
          case 112: {
            FinalScore = input.ReadUInt32();
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
