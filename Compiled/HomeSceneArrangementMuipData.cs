// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeSceneArrangementMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeSceneArrangementMuipData.proto</summary>
  public static partial class HomeSceneArrangementMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeSceneArrangementMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeSceneArrangementMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJIb21lU2NlbmVBcnJhbmdlbWVudE11aXBEYXRhLnByb3RvEg1taUhvbW8u",
            "UHJvdG9zGiJIb21lQmxvY2tBcnJhbmdlbWVudE11aXBEYXRhLnByb3RvIpoB",
            "ChxIb21lU2NlbmVBcnJhbmdlbWVudE11aXBEYXRhEkQKD2Jsb2NrX2RhdGFf",
            "bGlzdBgEIAMoCzIrLm1pSG9tby5Qcm90b3MuSG9tZUJsb2NrQXJyYW5nZW1l",
            "bnRNdWlwRGF0YRIPCgdpc19yb29tGAMgASgIEhEKCW1vZHVsZV9pZBgBIAEo",
            "DRIQCghzY2VuZV9pZBgCIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeBlockArrangementMuipDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeSceneArrangementMuipData), global::MiHomo.Protos.HomeSceneArrangementMuipData.Parser, new[]{ "BlockDataList", "IsRoom", "ModuleId", "SceneId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeSceneArrangementMuipData : pb::IMessage<HomeSceneArrangementMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeSceneArrangementMuipData> _parser = new pb::MessageParser<HomeSceneArrangementMuipData>(() => new HomeSceneArrangementMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeSceneArrangementMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeSceneArrangementMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementMuipData(HomeSceneArrangementMuipData other) : this() {
      blockDataList_ = other.blockDataList_.Clone();
      isRoom_ = other.isRoom_;
      moduleId_ = other.moduleId_;
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeSceneArrangementMuipData Clone() {
      return new HomeSceneArrangementMuipData(this);
    }

    /// <summary>Field number for the "block_data_list" field.</summary>
    public const int BlockDataListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.HomeBlockArrangementMuipData> _repeated_blockDataList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.HomeBlockArrangementMuipData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.HomeBlockArrangementMuipData> blockDataList_ = new pbc::RepeatedField<global::MiHomo.Protos.HomeBlockArrangementMuipData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.HomeBlockArrangementMuipData> BlockDataList {
      get { return blockDataList_; }
    }

    /// <summary>Field number for the "is_room" field.</summary>
    public const int IsRoomFieldNumber = 3;
    private bool isRoom_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRoom {
      get { return isRoom_; }
      set {
        isRoom_ = value;
      }
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 1;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 2;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeSceneArrangementMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeSceneArrangementMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!blockDataList_.Equals(other.blockDataList_)) return false;
      if (IsRoom != other.IsRoom) return false;
      if (ModuleId != other.ModuleId) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= blockDataList_.GetHashCode();
      if (IsRoom != false) hash ^= IsRoom.GetHashCode();
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
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
      if (ModuleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ModuleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (IsRoom != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsRoom);
      }
      blockDataList_.WriteTo(output, _repeated_blockDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ModuleId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ModuleId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (IsRoom != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsRoom);
      }
      blockDataList_.WriteTo(ref output, _repeated_blockDataList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += blockDataList_.CalculateSize(_repeated_blockDataList_codec);
      if (IsRoom != false) {
        size += 1 + 1;
      }
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeSceneArrangementMuipData other) {
      if (other == null) {
        return;
      }
      blockDataList_.Add(other.blockDataList_);
      if (other.IsRoom != false) {
        IsRoom = other.IsRoom;
      }
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
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
            ModuleId = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsRoom = input.ReadBool();
            break;
          }
          case 34: {
            blockDataList_.AddEntriesFrom(input, _repeated_blockDataList_codec);
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
            ModuleId = input.ReadUInt32();
            break;
          }
          case 16: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 24: {
            IsRoom = input.ReadBool();
            break;
          }
          case 34: {
            blockDataList_.AddEntriesFrom(ref input, _repeated_blockDataList_codec);
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
