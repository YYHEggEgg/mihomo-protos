// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestCreateEntityRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from QuestCreateEntityRsp.proto</summary>
  public static partial class QuestCreateEntityRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestCreateEntityRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestCreateEntityRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpRdWVzdENyZWF0ZUVudGl0eVJzcC5wcm90bxINbWlIb21vLlByb3RvcxoW",
            "Q3JlYXRlRW50aXR5SW5mby5wcm90byL4AQoUUXVlc3RDcmVhdGVFbnRpdHlS",
            "c3ASLwoGZW50aXR5GAsgASgLMh8ubWlIb21vLlByb3Rvcy5DcmVhdGVFbnRp",
            "dHlJbmZvEhEKCWVudGl0eV9pZBgHIAEoDRIRCglpc19yZXdpbmQYDiABKAgS",
            "FwoPcGFyZW50X3F1ZXN0X2lkGAEgASgNEhAKCHF1ZXN0X2lkGA0gASgNEg8K",
            "B3JldGNvZGUYCCABKAUiTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hB",
            "Tk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURfSUQQrwMa",
            "AhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CreateEntityInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.QuestCreateEntityRsp), global::MiHomo.Protos.QuestCreateEntityRsp.Parser, new[]{ "Entity", "EntityId", "IsRewind", "ParentQuestId", "QuestId", "Retcode" }, null, new[]{ typeof(global::MiHomo.Protos.QuestCreateEntityRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestCreateEntityRsp : pb::IMessage<QuestCreateEntityRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestCreateEntityRsp> _parser = new pb::MessageParser<QuestCreateEntityRsp>(() => new QuestCreateEntityRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestCreateEntityRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.QuestCreateEntityRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestCreateEntityRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestCreateEntityRsp(QuestCreateEntityRsp other) : this() {
      entity_ = other.entity_ != null ? other.entity_.Clone() : null;
      entityId_ = other.entityId_;
      isRewind_ = other.isRewind_;
      parentQuestId_ = other.parentQuestId_;
      questId_ = other.questId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestCreateEntityRsp Clone() {
      return new QuestCreateEntityRsp(this);
    }

    /// <summary>Field number for the "entity" field.</summary>
    public const int EntityFieldNumber = 11;
    private global::MiHomo.Protos.CreateEntityInfo entity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CreateEntityInfo Entity {
      get { return entity_; }
      set {
        entity_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 7;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "is_rewind" field.</summary>
    public const int IsRewindFieldNumber = 14;
    private bool isRewind_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRewind {
      get { return isRewind_; }
      set {
        isRewind_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 1;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 13;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestCreateEntityRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestCreateEntityRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Entity, other.Entity)) return false;
      if (EntityId != other.EntityId) return false;
      if (IsRewind != other.IsRewind) return false;
      if (ParentQuestId != other.ParentQuestId) return false;
      if (QuestId != other.QuestId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (entity_ != null) hash ^= Entity.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (IsRewind != false) hash ^= IsRewind.GetHashCode();
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (ParentQuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntityId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (entity_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Entity);
      }
      if (QuestId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(QuestId);
      }
      if (IsRewind != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsRewind);
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
      if (ParentQuestId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ParentQuestId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(EntityId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (entity_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Entity);
      }
      if (QuestId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(QuestId);
      }
      if (IsRewind != false) {
        output.WriteRawTag(112);
        output.WriteBool(IsRewind);
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
      if (entity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Entity);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (IsRewind != false) {
        size += 1 + 1;
      }
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestCreateEntityRsp other) {
      if (other == null) {
        return;
      }
      if (other.entity_ != null) {
        if (entity_ == null) {
          Entity = new global::MiHomo.Protos.CreateEntityInfo();
        }
        Entity.MergeFrom(other.Entity);
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.IsRewind != false) {
        IsRewind = other.IsRewind;
      }
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 56: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 90: {
            if (entity_ == null) {
              Entity = new global::MiHomo.Protos.CreateEntityInfo();
            }
            input.ReadMessage(Entity);
            break;
          }
          case 104: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsRewind = input.ReadBool();
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
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 56: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 90: {
            if (entity_ == null) {
              Entity = new global::MiHomo.Protos.CreateEntityInfo();
            }
            input.ReadMessage(Entity);
            break;
          }
          case 104: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 112: {
            IsRewind = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the QuestCreateEntityRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 431,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
