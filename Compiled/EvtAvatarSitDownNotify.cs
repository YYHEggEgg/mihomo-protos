// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAvatarSitDownNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtAvatarSitDownNotify.proto</summary>
  public static partial class EvtAvatarSitDownNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtAvatarSitDownNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtAvatarSitDownNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFdnRBdmF0YXJTaXREb3duTm90aWZ5LnByb3RvEg1taUhvbW8uUHJvdG9z",
            "GgxWZWN0b3IucHJvdG8iygEKFkV2dEF2YXRhclNpdERvd25Ob3RpZnkSEAoI",
            "Y2hhaXJfaWQYBiABKAQSEQoJZW50aXR5X2lkGAQgASgNEicKCHBvc2l0aW9u",
            "GAkgASgLMhUubWlIb21vLlByb3Rvcy5WZWN0b3IiYgoFQ21kSWQSCAoETk9O",
            "RRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQ",
            "ARITCg9JU19BTExPV19DTElFTlQQARILCgZDTURfSUQQxAIaAhABYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtAvatarSitDownNotify), global::MiHomo.Protos.EvtAvatarSitDownNotify.Parser, new[]{ "ChairId", "EntityId", "Position" }, null, new[]{ typeof(global::MiHomo.Protos.EvtAvatarSitDownNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtAvatarSitDownNotify : pb::IMessage<EvtAvatarSitDownNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtAvatarSitDownNotify> _parser = new pb::MessageParser<EvtAvatarSitDownNotify>(() => new EvtAvatarSitDownNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtAvatarSitDownNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtAvatarSitDownNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarSitDownNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarSitDownNotify(EvtAvatarSitDownNotify other) : this() {
      chairId_ = other.chairId_;
      entityId_ = other.entityId_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarSitDownNotify Clone() {
      return new EvtAvatarSitDownNotify(this);
    }

    /// <summary>Field number for the "chair_id" field.</summary>
    public const int ChairIdFieldNumber = 6;
    private ulong chairId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ChairId {
      get { return chairId_; }
      set {
        chairId_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 9;
    private global::MiHomo.Protos.Vector position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtAvatarSitDownNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtAvatarSitDownNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChairId != other.ChairId) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(Position, other.Position)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChairId != 0UL) hash ^= ChairId.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
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
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (ChairId != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ChairId);
      }
      if (position_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Position);
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
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (ChairId != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(ChairId);
      }
      if (position_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(Position);
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
      if (ChairId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ChairId);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtAvatarSitDownNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChairId != 0UL) {
        ChairId = other.ChairId;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::MiHomo.Protos.Vector();
        }
        Position.MergeFrom(other.Position);
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
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            ChairId = input.ReadUInt64();
            break;
          }
          case 74: {
            if (position_ == null) {
              Position = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Position);
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
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            ChairId = input.ReadUInt64();
            break;
          }
          case 74: {
            if (position_ == null) {
              Position = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Position);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EvtAvatarSitDownNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 324,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
