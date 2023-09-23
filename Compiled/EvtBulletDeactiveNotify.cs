// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtBulletDeactiveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtBulletDeactiveNotify.proto</summary>
  public static partial class EvtBulletDeactiveNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtBulletDeactiveNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtBulletDeactiveNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1FdnRCdWxsZXREZWFjdGl2ZU5vdGlmeS5wcm90bxINbWlIb21vLlByb3Rv",
            "cxoRRm9yd2FyZFR5cGUucHJvdG8aDFZlY3Rvci5wcm90byLwAQoXRXZ0QnVs",
            "bGV0RGVhY3RpdmVOb3RpZnkSLAoNZGlzYXBwZWFyX3BvcxgEIAEoCzIVLm1p",
            "SG9tby5Qcm90b3MuVmVjdG9yEhEKCWVudGl0eV9pZBgJIAEoDRIwCgxmb3J3",
            "YXJkX3R5cGUYBiABKA4yGi5taUhvbW8uUHJvdG9zLkZvcndhcmRUeXBlImIK",
            "BUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVU",
            "X0lTX1JFTElBQkxFEAESEwoPSVNfQUxMT1dfQ0xJRU5UEAESCwoGQ01EX0lE",
            "EI0DGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ForwardTypeReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtBulletDeactiveNotify), global::MiHomo.Protos.EvtBulletDeactiveNotify.Parser, new[]{ "DisappearPos", "EntityId", "ForwardType" }, null, new[]{ typeof(global::MiHomo.Protos.EvtBulletDeactiveNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtBulletDeactiveNotify : pb::IMessage<EvtBulletDeactiveNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtBulletDeactiveNotify> _parser = new pb::MessageParser<EvtBulletDeactiveNotify>(() => new EvtBulletDeactiveNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtBulletDeactiveNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtBulletDeactiveNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBulletDeactiveNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBulletDeactiveNotify(EvtBulletDeactiveNotify other) : this() {
      disappearPos_ = other.disappearPos_ != null ? other.disappearPos_.Clone() : null;
      entityId_ = other.entityId_;
      forwardType_ = other.forwardType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtBulletDeactiveNotify Clone() {
      return new EvtBulletDeactiveNotify(this);
    }

    /// <summary>Field number for the "disappear_pos" field.</summary>
    public const int DisappearPosFieldNumber = 4;
    private global::MiHomo.Protos.Vector disappearPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector DisappearPos {
      get { return disappearPos_; }
      set {
        disappearPos_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 9;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 6;
    private global::MiHomo.Protos.ForwardType forwardType_ = global::MiHomo.Protos.ForwardType.ForwardLocal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtBulletDeactiveNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtBulletDeactiveNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DisappearPos, other.DisappearPos)) return false;
      if (EntityId != other.EntityId) return false;
      if (ForwardType != other.ForwardType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (disappearPos_ != null) hash ^= DisappearPos.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) hash ^= ForwardType.GetHashCode();
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
      if (disappearPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(DisappearPos);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ForwardType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntityId);
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
      if (disappearPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(DisappearPos);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ForwardType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntityId);
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
      if (disappearPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DisappearPos);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtBulletDeactiveNotify other) {
      if (other == null) {
        return;
      }
      if (other.disappearPos_ != null) {
        if (disappearPos_ == null) {
          DisappearPos = new global::MiHomo.Protos.Vector();
        }
        DisappearPos.MergeFrom(other.DisappearPos);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        ForwardType = other.ForwardType;
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
          case 34: {
            if (disappearPos_ == null) {
              DisappearPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(DisappearPos);
            break;
          }
          case 48: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 72: {
            EntityId = input.ReadUInt32();
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
          case 34: {
            if (disappearPos_ == null) {
              DisappearPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(DisappearPos);
            break;
          }
          case 48: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 72: {
            EntityId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EvtBulletDeactiveNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 397,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
