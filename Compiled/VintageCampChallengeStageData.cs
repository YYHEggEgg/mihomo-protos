// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageCampChallengeStageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from VintageCampChallengeStageData.proto</summary>
  public static partial class VintageCampChallengeStageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageCampChallengeStageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageCampChallengeStageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNWaW50YWdlQ2FtcENoYWxsZW5nZVN0YWdlRGF0YS5wcm90bxINbWlIb21v",
            "LlByb3RvcxojVmludGFnZUNhbXBDaGFsbGVuZ2VMZXZlbERhdGEucHJvdG8i",
            "vwIKHVZpbnRhZ2VDYW1wQ2hhbGxlbmdlU3RhZ2VEYXRhEhEKCWlzX2Zpbmlz",
            "aBgOIAEoCBIPCgdpc19vcGVuGAIgASgIEhoKEm1heF9maW5pc2hlZF9sZXZl",
            "bBgEIAEoDRIRCglvcGVuX3RpbWUYByABKA0SEAoIc3RhZ2VfaWQYDSABKA0S",
            "VgoOY2FtcF9sZXZlbF9tYXAYBiADKAsyPi5taUhvbW8uUHJvdG9zLlZpbnRh",
            "Z2VDYW1wQ2hhbGxlbmdlU3RhZ2VEYXRhLkNhbXBMZXZlbE1hcEVudHJ5GmEK",
            "EUNhbXBMZXZlbE1hcEVudHJ5EgsKA2tleRgBIAEoDRI7CgV2YWx1ZRgCIAEo",
            "CzIsLm1pSG9tby5Qcm90b3MuVmludGFnZUNhbXBDaGFsbGVuZ2VMZXZlbERh",
            "dGE6AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VintageCampChallengeLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.VintageCampChallengeStageData), global::MiHomo.Protos.VintageCampChallengeStageData.Parser, new[]{ "IsFinish", "IsOpen", "MaxFinishedLevel", "OpenTime", "StageId", "CampLevelMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageCampChallengeStageData : pb::IMessage<VintageCampChallengeStageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageCampChallengeStageData> _parser = new pb::MessageParser<VintageCampChallengeStageData>(() => new VintageCampChallengeStageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageCampChallengeStageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.VintageCampChallengeStageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageCampChallengeStageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageCampChallengeStageData(VintageCampChallengeStageData other) : this() {
      isFinish_ = other.isFinish_;
      isOpen_ = other.isOpen_;
      maxFinishedLevel_ = other.maxFinishedLevel_;
      openTime_ = other.openTime_;
      stageId_ = other.stageId_;
      campLevelMap_ = other.campLevelMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageCampChallengeStageData Clone() {
      return new VintageCampChallengeStageData(this);
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 14;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 2;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "max_finished_level" field.</summary>
    public const int MaxFinishedLevelFieldNumber = 4;
    private uint maxFinishedLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxFinishedLevel {
      get { return maxFinishedLevel_; }
      set {
        maxFinishedLevel_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 7;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 13;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "camp_level_map" field.</summary>
    public const int CampLevelMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, global::MiHomo.Protos.VintageCampChallengeLevelData>.Codec _map_campLevelMap_codec
        = new pbc::MapField<uint, global::MiHomo.Protos.VintageCampChallengeLevelData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::MiHomo.Protos.VintageCampChallengeLevelData.Parser), 50);
    private readonly pbc::MapField<uint, global::MiHomo.Protos.VintageCampChallengeLevelData> campLevelMap_ = new pbc::MapField<uint, global::MiHomo.Protos.VintageCampChallengeLevelData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::MiHomo.Protos.VintageCampChallengeLevelData> CampLevelMap {
      get { return campLevelMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageCampChallengeStageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageCampChallengeStageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinish != other.IsFinish) return false;
      if (IsOpen != other.IsOpen) return false;
      if (MaxFinishedLevel != other.MaxFinishedLevel) return false;
      if (OpenTime != other.OpenTime) return false;
      if (StageId != other.StageId) return false;
      if (!CampLevelMap.Equals(other.CampLevelMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (MaxFinishedLevel != 0) hash ^= MaxFinishedLevel.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      hash ^= CampLevelMap.GetHashCode();
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
      if (IsOpen != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsOpen);
      }
      if (MaxFinishedLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxFinishedLevel);
      }
      campLevelMap_.WriteTo(output, _map_campLevelMap_codec);
      if (OpenTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OpenTime);
      }
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
      }
      if (IsFinish != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinish);
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
      if (IsOpen != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsOpen);
      }
      if (MaxFinishedLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxFinishedLevel);
      }
      campLevelMap_.WriteTo(ref output, _map_campLevelMap_codec);
      if (OpenTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OpenTime);
      }
      if (StageId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(StageId);
      }
      if (IsFinish != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsFinish);
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
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (MaxFinishedLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxFinishedLevel);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      size += campLevelMap_.CalculateSize(_map_campLevelMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageCampChallengeStageData other) {
      if (other == null) {
        return;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.MaxFinishedLevel != 0) {
        MaxFinishedLevel = other.MaxFinishedLevel;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      campLevelMap_.Add(other.campLevelMap_);
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
            IsOpen = input.ReadBool();
            break;
          }
          case 32: {
            MaxFinishedLevel = input.ReadUInt32();
            break;
          }
          case 50: {
            campLevelMap_.AddEntriesFrom(input, _map_campLevelMap_codec);
            break;
          }
          case 56: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinish = input.ReadBool();
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
            IsOpen = input.ReadBool();
            break;
          }
          case 32: {
            MaxFinishedLevel = input.ReadUInt32();
            break;
          }
          case 50: {
            campLevelMap_.AddEntriesFrom(ref input, _map_campLevelMap_codec);
            break;
          }
          case 56: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 104: {
            StageId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsFinish = input.ReadBool();
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
