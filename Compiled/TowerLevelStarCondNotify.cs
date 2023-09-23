// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TowerLevelStarCondNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TowerLevelStarCondNotify.proto</summary>
  public static partial class TowerLevelStarCondNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TowerLevelStarCondNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TowerLevelStarCondNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ub3dlckxldmVsU3RhckNvbmROb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaHFRvd2VyTGV2ZWxTdGFyQ29uZERhdGEucHJvdG8izwEKGFRvd2VyTGV2",
            "ZWxTdGFyQ29uZE5vdGlmeRI9Cg5jb25kX2RhdGFfbGlzdBgJIAMoCzIlLm1p",
            "SG9tby5Qcm90b3MuVG93ZXJMZXZlbFN0YXJDb25kRGF0YRIQCghmbG9vcl9p",
            "ZBgLIAEoDRITCgtsZXZlbF9pbmRleBgOIAEoDSJNCgVDbWRJZBIICgROT05F",
            "EAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRAB",
            "EgsKBkNNRF9JRBDmEhoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.TowerLevelStarCondDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TowerLevelStarCondNotify), global::MiHomo.Protos.TowerLevelStarCondNotify.Parser, new[]{ "CondDataList", "FloorId", "LevelIndex" }, null, new[]{ typeof(global::MiHomo.Protos.TowerLevelStarCondNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TowerLevelStarCondNotify : pb::IMessage<TowerLevelStarCondNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TowerLevelStarCondNotify> _parser = new pb::MessageParser<TowerLevelStarCondNotify>(() => new TowerLevelStarCondNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TowerLevelStarCondNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TowerLevelStarCondNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondNotify(TowerLevelStarCondNotify other) : this() {
      condDataList_ = other.condDataList_.Clone();
      floorId_ = other.floorId_;
      levelIndex_ = other.levelIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TowerLevelStarCondNotify Clone() {
      return new TowerLevelStarCondNotify(this);
    }

    /// <summary>Field number for the "cond_data_list" field.</summary>
    public const int CondDataListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.TowerLevelStarCondData> _repeated_condDataList_codec
        = pb::FieldCodec.ForMessage(74, global::MiHomo.Protos.TowerLevelStarCondData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.TowerLevelStarCondData> condDataList_ = new pbc::RepeatedField<global::MiHomo.Protos.TowerLevelStarCondData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.TowerLevelStarCondData> CondDataList {
      get { return condDataList_; }
    }

    /// <summary>Field number for the "floor_id" field.</summary>
    public const int FloorIdFieldNumber = 11;
    private uint floorId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FloorId {
      get { return floorId_; }
      set {
        floorId_ = value;
      }
    }

    /// <summary>Field number for the "level_index" field.</summary>
    public const int LevelIndexFieldNumber = 14;
    private uint levelIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelIndex {
      get { return levelIndex_; }
      set {
        levelIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TowerLevelStarCondNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TowerLevelStarCondNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!condDataList_.Equals(other.condDataList_)) return false;
      if (FloorId != other.FloorId) return false;
      if (LevelIndex != other.LevelIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= condDataList_.GetHashCode();
      if (FloorId != 0) hash ^= FloorId.GetHashCode();
      if (LevelIndex != 0) hash ^= LevelIndex.GetHashCode();
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
      condDataList_.WriteTo(output, _repeated_condDataList_codec);
      if (FloorId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FloorId);
      }
      if (LevelIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelIndex);
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
      condDataList_.WriteTo(ref output, _repeated_condDataList_codec);
      if (FloorId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(FloorId);
      }
      if (LevelIndex != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelIndex);
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
      size += condDataList_.CalculateSize(_repeated_condDataList_codec);
      if (FloorId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FloorId);
      }
      if (LevelIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TowerLevelStarCondNotify other) {
      if (other == null) {
        return;
      }
      condDataList_.Add(other.condDataList_);
      if (other.FloorId != 0) {
        FloorId = other.FloorId;
      }
      if (other.LevelIndex != 0) {
        LevelIndex = other.LevelIndex;
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
          case 74: {
            condDataList_.AddEntriesFrom(input, _repeated_condDataList_codec);
            break;
          }
          case 88: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 112: {
            LevelIndex = input.ReadUInt32();
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
          case 74: {
            condDataList_.AddEntriesFrom(ref input, _repeated_condDataList_codec);
            break;
          }
          case 88: {
            FloorId = input.ReadUInt32();
            break;
          }
          case 112: {
            LevelIndex = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TowerLevelStarCondNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2406,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
