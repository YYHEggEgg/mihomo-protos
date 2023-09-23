// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeMarkPointSceneData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeMarkPointSceneData.proto</summary>
  public static partial class HomeMarkPointSceneDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeMarkPointSceneData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeMarkPointSceneDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxIb21lTWFya1BvaW50U2NlbmVEYXRhLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "GiBIb21lTWFya1BvaW50RnVybml0dXJlRGF0YS5wcm90bxoMVmVjdG9yLnBy",
            "b3RvIuEBChZIb21lTWFya1BvaW50U2NlbmVEYXRhEkEKDmZ1cm5pdHVyZV9s",
            "aXN0GAYgAygLMikubWlIb21vLlByb3Rvcy5Ib21lTWFya1BvaW50RnVybml0",
            "dXJlRGF0YRIRCgltb2R1bGVfaWQYBSABKA0SLQoOc2FmZV9wb2ludF9wb3MY",
            "CyABKAsyFS5taUhvbW8uUHJvdG9zLlZlY3RvchIQCghzY2VuZV9pZBgCIAEo",
            "DRIwChF0ZWFwb3Rfc3Bpcml0X3BvcxgEIAEoCzIVLm1pSG9tby5Qcm90b3Mu",
            "VmVjdG9yYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeMarkPointFurnitureDataReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeMarkPointSceneData), global::MiHomo.Protos.HomeMarkPointSceneData.Parser, new[]{ "FurnitureList", "ModuleId", "SafePointPos", "SceneId", "TeapotSpiritPos" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeMarkPointSceneData : pb::IMessage<HomeMarkPointSceneData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeMarkPointSceneData> _parser = new pb::MessageParser<HomeMarkPointSceneData>(() => new HomeMarkPointSceneData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeMarkPointSceneData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeMarkPointSceneDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointSceneData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointSceneData(HomeMarkPointSceneData other) : this() {
      furnitureList_ = other.furnitureList_.Clone();
      moduleId_ = other.moduleId_;
      safePointPos_ = other.safePointPos_ != null ? other.safePointPos_.Clone() : null;
      sceneId_ = other.sceneId_;
      teapotSpiritPos_ = other.teapotSpiritPos_ != null ? other.teapotSpiritPos_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointSceneData Clone() {
      return new HomeMarkPointSceneData(this);
    }

    /// <summary>Field number for the "furniture_list" field.</summary>
    public const int FurnitureListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.HomeMarkPointFurnitureData> _repeated_furnitureList_codec
        = pb::FieldCodec.ForMessage(50, global::MiHomo.Protos.HomeMarkPointFurnitureData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.HomeMarkPointFurnitureData> furnitureList_ = new pbc::RepeatedField<global::MiHomo.Protos.HomeMarkPointFurnitureData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.HomeMarkPointFurnitureData> FurnitureList {
      get { return furnitureList_; }
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 5;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "safe_point_pos" field.</summary>
    public const int SafePointPosFieldNumber = 11;
    private global::MiHomo.Protos.Vector safePointPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector SafePointPos {
      get { return safePointPos_; }
      set {
        safePointPos_ = value;
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

    /// <summary>Field number for the "teapot_spirit_pos" field.</summary>
    public const int TeapotSpiritPosFieldNumber = 4;
    private global::MiHomo.Protos.Vector teapotSpiritPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector TeapotSpiritPos {
      get { return teapotSpiritPos_; }
      set {
        teapotSpiritPos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeMarkPointSceneData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeMarkPointSceneData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!furnitureList_.Equals(other.furnitureList_)) return false;
      if (ModuleId != other.ModuleId) return false;
      if (!object.Equals(SafePointPos, other.SafePointPos)) return false;
      if (SceneId != other.SceneId) return false;
      if (!object.Equals(TeapotSpiritPos, other.TeapotSpiritPos)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= furnitureList_.GetHashCode();
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (safePointPos_ != null) hash ^= SafePointPos.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (teapotSpiritPos_ != null) hash ^= TeapotSpiritPos.GetHashCode();
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
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (teapotSpiritPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TeapotSpiritPos);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ModuleId);
      }
      furnitureList_.WriteTo(output, _repeated_furnitureList_codec);
      if (safePointPos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SafePointPos);
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
      if (SceneId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(SceneId);
      }
      if (teapotSpiritPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TeapotSpiritPos);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ModuleId);
      }
      furnitureList_.WriteTo(ref output, _repeated_furnitureList_codec);
      if (safePointPos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SafePointPos);
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
      size += furnitureList_.CalculateSize(_repeated_furnitureList_codec);
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (safePointPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SafePointPos);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (teapotSpiritPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TeapotSpiritPos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeMarkPointSceneData other) {
      if (other == null) {
        return;
      }
      furnitureList_.Add(other.furnitureList_);
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.safePointPos_ != null) {
        if (safePointPos_ == null) {
          SafePointPos = new global::MiHomo.Protos.Vector();
        }
        SafePointPos.MergeFrom(other.SafePointPos);
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.teapotSpiritPos_ != null) {
        if (teapotSpiritPos_ == null) {
          TeapotSpiritPos = new global::MiHomo.Protos.Vector();
        }
        TeapotSpiritPos.MergeFrom(other.TeapotSpiritPos);
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
            SceneId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (teapotSpiritPos_ == null) {
              TeapotSpiritPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(TeapotSpiritPos);
            break;
          }
          case 40: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 50: {
            furnitureList_.AddEntriesFrom(input, _repeated_furnitureList_codec);
            break;
          }
          case 90: {
            if (safePointPos_ == null) {
              SafePointPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(SafePointPos);
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
            SceneId = input.ReadUInt32();
            break;
          }
          case 34: {
            if (teapotSpiritPos_ == null) {
              TeapotSpiritPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(TeapotSpiritPos);
            break;
          }
          case 40: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 50: {
            furnitureList_.AddEntriesFrom(ref input, _repeated_furnitureList_codec);
            break;
          }
          case 90: {
            if (safePointPos_ == null) {
              SafePointPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(SafePointPos);
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
