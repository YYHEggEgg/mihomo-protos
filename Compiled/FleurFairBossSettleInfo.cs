// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairBossSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FleurFairBossSettleInfo.proto</summary>
  public static partial class FleurFairBossSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairBossSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairBossSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1GbGV1ckZhaXJCb3NzU2V0dGxlSW5mby5wcm90bxINbWlIb21vLlByb3Rv",
            "cxodRmxldXJGYWlyUGxheWVyU3RhdEluZm8ucHJvdG8iqgEKF0ZsZXVyRmFp",
            "ckJvc3NTZXR0bGVJbmZvEhEKCWNvc3RfdGltZRgIIAEoDRIOCgZlbmVyZ3kY",
            "DCABKA0SEgoKaXNfc3VjY2VzcxgKIAEoCBIYChByZXdhcmRfdG9rZW5fbnVt",
            "GA8gASgNEj4KDnN0YXRfaW5mb19saXN0GAEgAygLMiYubWlIb21vLlByb3Rv",
            "cy5GbGV1ckZhaXJQbGF5ZXJTdGF0SW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FleurFairPlayerStatInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FleurFairBossSettleInfo), global::MiHomo.Protos.FleurFairBossSettleInfo.Parser, new[]{ "CostTime", "Energy", "IsSuccess", "RewardTokenNum", "StatInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairBossSettleInfo : pb::IMessage<FleurFairBossSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairBossSettleInfo> _parser = new pb::MessageParser<FleurFairBossSettleInfo>(() => new FleurFairBossSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairBossSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FleurFairBossSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairBossSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairBossSettleInfo(FleurFairBossSettleInfo other) : this() {
      costTime_ = other.costTime_;
      energy_ = other.energy_;
      isSuccess_ = other.isSuccess_;
      rewardTokenNum_ = other.rewardTokenNum_;
      statInfoList_ = other.statInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairBossSettleInfo Clone() {
      return new FleurFairBossSettleInfo(this);
    }

    /// <summary>Field number for the "cost_time" field.</summary>
    public const int CostTimeFieldNumber = 8;
    private uint costTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CostTime {
      get { return costTime_; }
      set {
        costTime_ = value;
      }
    }

    /// <summary>Field number for the "energy" field.</summary>
    public const int EnergyFieldNumber = 12;
    private uint energy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Energy {
      get { return energy_; }
      set {
        energy_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 10;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "reward_token_num" field.</summary>
    public const int RewardTokenNumFieldNumber = 15;
    private uint rewardTokenNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RewardTokenNum {
      get { return rewardTokenNum_; }
      set {
        rewardTokenNum_ = value;
      }
    }

    /// <summary>Field number for the "stat_info_list" field.</summary>
    public const int StatInfoListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FleurFairPlayerStatInfo> _repeated_statInfoList_codec
        = pb::FieldCodec.ForMessage(10, global::MiHomo.Protos.FleurFairPlayerStatInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FleurFairPlayerStatInfo> statInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.FleurFairPlayerStatInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FleurFairPlayerStatInfo> StatInfoList {
      get { return statInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairBossSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairBossSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CostTime != other.CostTime) return false;
      if (Energy != other.Energy) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (RewardTokenNum != other.RewardTokenNum) return false;
      if(!statInfoList_.Equals(other.statInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CostTime != 0) hash ^= CostTime.GetHashCode();
      if (Energy != 0) hash ^= Energy.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (RewardTokenNum != 0) hash ^= RewardTokenNum.GetHashCode();
      hash ^= statInfoList_.GetHashCode();
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
      statInfoList_.WriteTo(output, _repeated_statInfoList_codec);
      if (CostTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CostTime);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSuccess);
      }
      if (Energy != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Energy);
      }
      if (RewardTokenNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RewardTokenNum);
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
      statInfoList_.WriteTo(ref output, _repeated_statInfoList_codec);
      if (CostTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(CostTime);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsSuccess);
      }
      if (Energy != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Energy);
      }
      if (RewardTokenNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(RewardTokenNum);
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
      if (CostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CostTime);
      }
      if (Energy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Energy);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (RewardTokenNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardTokenNum);
      }
      size += statInfoList_.CalculateSize(_repeated_statInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairBossSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.CostTime != 0) {
        CostTime = other.CostTime;
      }
      if (other.Energy != 0) {
        Energy = other.Energy;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.RewardTokenNum != 0) {
        RewardTokenNum = other.RewardTokenNum;
      }
      statInfoList_.Add(other.statInfoList_);
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
          case 10: {
            statInfoList_.AddEntriesFrom(input, _repeated_statInfoList_codec);
            break;
          }
          case 64: {
            CostTime = input.ReadUInt32();
            break;
          }
          case 80: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 96: {
            Energy = input.ReadUInt32();
            break;
          }
          case 120: {
            RewardTokenNum = input.ReadUInt32();
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
          case 10: {
            statInfoList_.AddEntriesFrom(ref input, _repeated_statInfoList_codec);
            break;
          }
          case 64: {
            CostTime = input.ReadUInt32();
            break;
          }
          case 80: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 96: {
            Energy = input.ReadUInt32();
            break;
          }
          case 120: {
            RewardTokenNum = input.ReadUInt32();
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
