// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DeshretObeliskChestInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DeshretObeliskChestInfo.proto</summary>
  public static partial class DeshretObeliskChestInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DeshretObeliskChestInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeshretObeliskChestInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EZXNocmV0T2JlbGlza0NoZXN0SW5mby5wcm90bxINbWlIb21vLlByb3Rv",
            "cxoMVmVjdG9yLnByb3RvInQKF0Rlc2hyZXRPYmVsaXNrQ2hlc3RJbmZvEhEK",
            "CWNvbmZpZ19pZBgDIAEoDRIQCghncm91cF9pZBgHIAEoDRIiCgNwb3MYCSAB",
            "KAsyFS5taUhvbW8uUHJvdG9zLlZlY3RvchIQCghzY2VuZV9pZBgFIAEoDWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DeshretObeliskChestInfo), global::MiHomo.Protos.DeshretObeliskChestInfo.Parser, new[]{ "ConfigId", "GroupId", "Pos", "SceneId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeshretObeliskChestInfo : pb::IMessage<DeshretObeliskChestInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DeshretObeliskChestInfo> _parser = new pb::MessageParser<DeshretObeliskChestInfo>(() => new DeshretObeliskChestInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DeshretObeliskChestInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DeshretObeliskChestInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeshretObeliskChestInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeshretObeliskChestInfo(DeshretObeliskChestInfo other) : this() {
      configId_ = other.configId_;
      groupId_ = other.groupId_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DeshretObeliskChestInfo Clone() {
      return new DeshretObeliskChestInfo(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 3;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 7;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 9;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 5;
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
      return Equals(other as DeshretObeliskChestInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DeshretObeliskChestInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (GroupId != other.GroupId) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
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
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GroupId);
      }
      if (pos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Pos);
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
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(GroupId);
      }
      if (pos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Pos);
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
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
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
    public void MergeFrom(DeshretObeliskChestInfo other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
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
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 40: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 56: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
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
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 40: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 56: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
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
