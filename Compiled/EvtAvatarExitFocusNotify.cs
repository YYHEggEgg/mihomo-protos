// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAvatarExitFocusNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtAvatarExitFocusNotify.proto</summary>
  public static partial class EvtAvatarExitFocusNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtAvatarExitFocusNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtAvatarExitFocusNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5FdnRBdmF0YXJFeGl0Rm9jdXNOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaEUZvcndhcmRUeXBlLnByb3RvGgxWZWN0b3IucHJvdG8i8gEKGEV2dEF2",
            "YXRhckV4aXRGb2N1c05vdGlmeRIRCgllbnRpdHlfaWQYDiABKA0SLQoOZmlu",
            "aXNoX2ZvcndhcmQYDCABKAsyFS5taUhvbW8uUHJvdG9zLlZlY3RvchIwCgxm",
            "b3J3YXJkX3R5cGUYCyABKA4yGi5taUhvbW8uUHJvdG9zLkZvcndhcmRUeXBl",
            "ImIKBUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBF",
            "TkVUX0lTX1JFTElBQkxFEAESEwoPSVNfQUxMT1dfQ0xJRU5UEAESCwoGQ01E",
            "X0lEEIkDGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ForwardTypeReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtAvatarExitFocusNotify), global::MiHomo.Protos.EvtAvatarExitFocusNotify.Parser, new[]{ "EntityId", "FinishForward", "ForwardType" }, null, new[]{ typeof(global::MiHomo.Protos.EvtAvatarExitFocusNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtAvatarExitFocusNotify : pb::IMessage<EvtAvatarExitFocusNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtAvatarExitFocusNotify> _parser = new pb::MessageParser<EvtAvatarExitFocusNotify>(() => new EvtAvatarExitFocusNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtAvatarExitFocusNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtAvatarExitFocusNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarExitFocusNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarExitFocusNotify(EvtAvatarExitFocusNotify other) : this() {
      entityId_ = other.entityId_;
      finishForward_ = other.finishForward_ != null ? other.finishForward_.Clone() : null;
      forwardType_ = other.forwardType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarExitFocusNotify Clone() {
      return new EvtAvatarExitFocusNotify(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 14;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "finish_forward" field.</summary>
    public const int FinishForwardFieldNumber = 12;
    private global::MiHomo.Protos.Vector finishForward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector FinishForward {
      get { return finishForward_; }
      set {
        finishForward_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 11;
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
      return Equals(other as EvtAvatarExitFocusNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtAvatarExitFocusNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(FinishForward, other.FinishForward)) return false;
      if (ForwardType != other.ForwardType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (finishForward_ != null) hash ^= FinishForward.GetHashCode();
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
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ForwardType);
      }
      if (finishForward_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FinishForward);
      }
      if (EntityId != 0) {
        output.WriteRawTag(112);
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
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(88);
        output.WriteEnum((int) ForwardType);
      }
      if (finishForward_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(FinishForward);
      }
      if (EntityId != 0) {
        output.WriteRawTag(112);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (finishForward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinishForward);
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
    public void MergeFrom(EvtAvatarExitFocusNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.finishForward_ != null) {
        if (finishForward_ == null) {
          FinishForward = new global::MiHomo.Protos.Vector();
        }
        FinishForward.MergeFrom(other.FinishForward);
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
          case 88: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 98: {
            if (finishForward_ == null) {
              FinishForward = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(FinishForward);
            break;
          }
          case 112: {
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
          case 88: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 98: {
            if (finishForward_ == null) {
              FinishForward = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(FinishForward);
            break;
          }
          case 112: {
            EntityId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EvtAvatarExitFocusNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 393,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
