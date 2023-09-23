// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlatformStartRouteNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlatformStartRouteNotify.proto</summary>
  public static partial class PlatformStartRouteNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlatformStartRouteNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlatformStartRouteNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5QbGF0Zm9ybVN0YXJ0Um91dGVOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaElBsYXRmb3JtSW5mby5wcm90byK/AQoYUGxhdGZvcm1TdGFydFJvdXRl",
            "Tm90aWZ5EhEKCWVudGl0eV9pZBgIIAEoDRItCghwbGF0Zm9ybRgPIAEoCzIb",
            "Lm1pSG9tby5Qcm90b3MuUGxhdGZvcm1JbmZvEhIKCnNjZW5lX3RpbWUYDCAB",
            "KA0iTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQK",
            "EEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURfSUQQ2gEaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.PlatformInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlatformStartRouteNotify), global::MiHomo.Protos.PlatformStartRouteNotify.Parser, new[]{ "EntityId", "Platform", "SceneTime" }, null, new[]{ typeof(global::MiHomo.Protos.PlatformStartRouteNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlatformStartRouteNotify : pb::IMessage<PlatformStartRouteNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlatformStartRouteNotify> _parser = new pb::MessageParser<PlatformStartRouteNotify>(() => new PlatformStartRouteNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlatformStartRouteNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlatformStartRouteNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlatformStartRouteNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlatformStartRouteNotify(PlatformStartRouteNotify other) : this() {
      entityId_ = other.entityId_;
      platform_ = other.platform_ != null ? other.platform_.Clone() : null;
      sceneTime_ = other.sceneTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlatformStartRouteNotify Clone() {
      return new PlatformStartRouteNotify(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 8;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 15;
    private global::MiHomo.Protos.PlatformInfo platform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.PlatformInfo Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    /// <summary>Field number for the "scene_time" field.</summary>
    public const int SceneTimeFieldNumber = 12;
    private uint sceneTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneTime {
      get { return sceneTime_; }
      set {
        sceneTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlatformStartRouteNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlatformStartRouteNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(Platform, other.Platform)) return false;
      if (SceneTime != other.SceneTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (platform_ != null) hash ^= Platform.GetHashCode();
      if (SceneTime != 0) hash ^= SceneTime.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntityId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneTime);
      }
      if (platform_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Platform);
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
      if (EntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(EntityId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SceneTime);
      }
      if (platform_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(Platform);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (platform_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Platform);
      }
      if (SceneTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlatformStartRouteNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.platform_ != null) {
        if (platform_ == null) {
          Platform = new global::MiHomo.Protos.PlatformInfo();
        }
        Platform.MergeFrom(other.Platform);
      }
      if (other.SceneTime != 0) {
        SceneTime = other.SceneTime;
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
          case 64: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 122: {
            if (platform_ == null) {
              Platform = new global::MiHomo.Protos.PlatformInfo();
            }
            input.ReadMessage(Platform);
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
          case 64: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 122: {
            if (platform_ == null) {
              Platform = new global::MiHomo.Protos.PlatformInfo();
            }
            input.ReadMessage(Platform);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlatformStartRouteNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 218,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
