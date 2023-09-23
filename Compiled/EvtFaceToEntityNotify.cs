// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtFaceToEntityNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtFaceToEntityNotify.proto</summary>
  public static partial class EvtFaceToEntityNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtFaceToEntityNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtFaceToEntityNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFdnRGYWNlVG9FbnRpdHlOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "EUZvcndhcmRUeXBlLnByb3RvItgBChVFdnRGYWNlVG9FbnRpdHlOb3RpZnkS",
            "EQoJZW50aXR5X2lkGAEgASgNEhYKDmZhY2VfZW50aXR5X2lkGAUgASgNEjAK",
            "DGZvcndhcmRfdHlwZRgJIAEoDjIaLm1pSG9tby5Qcm90b3MuRm9yd2FyZFR5",
            "cGUiYgoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQK",
            "EEVORVRfSVNfUkVMSUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARILCgZD",
            "TURfSUQQrwIaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtFaceToEntityNotify), global::MiHomo.Protos.EvtFaceToEntityNotify.Parser, new[]{ "EntityId", "FaceEntityId", "ForwardType" }, null, new[]{ typeof(global::MiHomo.Protos.EvtFaceToEntityNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtFaceToEntityNotify : pb::IMessage<EvtFaceToEntityNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtFaceToEntityNotify> _parser = new pb::MessageParser<EvtFaceToEntityNotify>(() => new EvtFaceToEntityNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtFaceToEntityNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtFaceToEntityNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtFaceToEntityNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtFaceToEntityNotify(EvtFaceToEntityNotify other) : this() {
      entityId_ = other.entityId_;
      faceEntityId_ = other.faceEntityId_;
      forwardType_ = other.forwardType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtFaceToEntityNotify Clone() {
      return new EvtFaceToEntityNotify(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "face_entity_id" field.</summary>
    public const int FaceEntityIdFieldNumber = 5;
    private uint faceEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FaceEntityId {
      get { return faceEntityId_; }
      set {
        faceEntityId_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 9;
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
      return Equals(other as EvtFaceToEntityNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtFaceToEntityNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (FaceEntityId != other.FaceEntityId) return false;
      if (ForwardType != other.ForwardType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (FaceEntityId != 0) hash ^= FaceEntityId.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (FaceEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FaceEntityId);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ForwardType);
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
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (FaceEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(FaceEntityId);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(72);
        output.WriteEnum((int) ForwardType);
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
      if (FaceEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FaceEntityId);
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
    public void MergeFrom(EvtFaceToEntityNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.FaceEntityId != 0) {
        FaceEntityId = other.FaceEntityId;
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
          case 8: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            FaceEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            FaceEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EvtFaceToEntityNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 303,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
