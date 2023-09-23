// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ToTheMoonObstaclesModifyNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ToTheMoonObstaclesModifyNotify.proto</summary>
  public static partial class ToTheMoonObstaclesModifyNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ToTheMoonObstaclesModifyNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ToTheMoonObstaclesModifyNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRUb1RoZU1vb25PYnN0YWNsZXNNb2RpZnlOb3RpZnkucHJvdG8SDW1pSG9t",
            "by5Qcm90b3MaG1RvVGhlTW9vbk9ic3RhY2xlSW5mby5wcm90byKeAQoeVG9U",
            "aGVNb29uT2JzdGFjbGVzTW9kaWZ5Tm90aWZ5EjsKDWFkZF9vYnN0YWNsZXMY",
            "AyADKAsyJC5taUhvbW8uUHJvdG9zLlRvVGhlTW9vbk9ic3RhY2xlSW5mbxIb",
            "ChNyZW1vdmVfb2JzdGFjbGVfaWRzGAUgAygFEhAKCHNjZW5lX2lkGAQgASgN",
            "EhAKCHVzZV9lZGdlGAcgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ToTheMoonObstacleInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ToTheMoonObstaclesModifyNotify), global::MiHomo.Protos.ToTheMoonObstaclesModifyNotify.Parser, new[]{ "AddObstacles", "RemoveObstacleIds", "SceneId", "UseEdge" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ToTheMoonObstaclesModifyNotify : pb::IMessage<ToTheMoonObstaclesModifyNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ToTheMoonObstaclesModifyNotify> _parser = new pb::MessageParser<ToTheMoonObstaclesModifyNotify>(() => new ToTheMoonObstaclesModifyNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ToTheMoonObstaclesModifyNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ToTheMoonObstaclesModifyNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonObstaclesModifyNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonObstaclesModifyNotify(ToTheMoonObstaclesModifyNotify other) : this() {
      addObstacles_ = other.addObstacles_.Clone();
      removeObstacleIds_ = other.removeObstacleIds_.Clone();
      sceneId_ = other.sceneId_;
      useEdge_ = other.useEdge_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonObstaclesModifyNotify Clone() {
      return new ToTheMoonObstaclesModifyNotify(this);
    }

    /// <summary>Field number for the "add_obstacles" field.</summary>
    public const int AddObstaclesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ToTheMoonObstacleInfo> _repeated_addObstacles_codec
        = pb::FieldCodec.ForMessage(26, global::MiHomo.Protos.ToTheMoonObstacleInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ToTheMoonObstacleInfo> addObstacles_ = new pbc::RepeatedField<global::MiHomo.Protos.ToTheMoonObstacleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ToTheMoonObstacleInfo> AddObstacles {
      get { return addObstacles_; }
    }

    /// <summary>Field number for the "remove_obstacle_ids" field.</summary>
    public const int RemoveObstacleIdsFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_removeObstacleIds_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> removeObstacleIds_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<int> RemoveObstacleIds {
      get { return removeObstacleIds_; }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 4;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "use_edge" field.</summary>
    public const int UseEdgeFieldNumber = 7;
    private bool useEdge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseEdge {
      get { return useEdge_; }
      set {
        useEdge_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ToTheMoonObstaclesModifyNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ToTheMoonObstaclesModifyNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!addObstacles_.Equals(other.addObstacles_)) return false;
      if(!removeObstacleIds_.Equals(other.removeObstacleIds_)) return false;
      if (SceneId != other.SceneId) return false;
      if (UseEdge != other.UseEdge) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= addObstacles_.GetHashCode();
      hash ^= removeObstacleIds_.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (UseEdge != false) hash ^= UseEdge.GetHashCode();
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
      addObstacles_.WriteTo(output, _repeated_addObstacles_codec);
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      removeObstacleIds_.WriteTo(output, _repeated_removeObstacleIds_codec);
      if (UseEdge != false) {
        output.WriteRawTag(56);
        output.WriteBool(UseEdge);
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
      addObstacles_.WriteTo(ref output, _repeated_addObstacles_codec);
      if (SceneId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SceneId);
      }
      removeObstacleIds_.WriteTo(ref output, _repeated_removeObstacleIds_codec);
      if (UseEdge != false) {
        output.WriteRawTag(56);
        output.WriteBool(UseEdge);
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
      size += addObstacles_.CalculateSize(_repeated_addObstacles_codec);
      size += removeObstacleIds_.CalculateSize(_repeated_removeObstacleIds_codec);
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (UseEdge != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ToTheMoonObstaclesModifyNotify other) {
      if (other == null) {
        return;
      }
      addObstacles_.Add(other.addObstacles_);
      removeObstacleIds_.Add(other.removeObstacleIds_);
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.UseEdge != false) {
        UseEdge = other.UseEdge;
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
          case 26: {
            addObstacles_.AddEntriesFrom(input, _repeated_addObstacles_codec);
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            removeObstacleIds_.AddEntriesFrom(input, _repeated_removeObstacleIds_codec);
            break;
          }
          case 56: {
            UseEdge = input.ReadBool();
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
          case 26: {
            addObstacles_.AddEntriesFrom(ref input, _repeated_addObstacles_codec);
            break;
          }
          case 32: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            removeObstacleIds_.AddEntriesFrom(ref input, _repeated_removeObstacleIds_codec);
            break;
          }
          case 56: {
            UseEdge = input.ReadBool();
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
