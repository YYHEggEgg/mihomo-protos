// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VehicleInteractReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from VehicleInteractReq.proto</summary>
  public static partial class VehicleInteractReqReflection {

    #region Descriptor
    /// <summary>File descriptor for VehicleInteractReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VehicleInteractReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhWZWhpY2xlSW50ZXJhY3RSZXEucHJvdG8SDW1pSG9tby5Qcm90b3MaGVZl",
            "aGljbGVJbnRlcmFjdFR5cGUucHJvdG8i0wEKElZlaGljbGVJbnRlcmFjdFJl",
            "cRIRCgllbnRpdHlfaWQYDyABKA0SOQoNaW50ZXJhY3RfdHlwZRgIIAEoDjIi",
            "Lm1pSG9tby5Qcm90b3MuVmVoaWNsZUludGVyYWN0VHlwZRILCgNwb3MYDCAB",
            "KA0iYgoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQK",
            "EEVORVRfSVNfUkVMSUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARILCgZD",
            "TURfSUQQ4QYaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VehicleInteractTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.VehicleInteractReq), global::MiHomo.Protos.VehicleInteractReq.Parser, new[]{ "EntityId", "InteractType", "Pos" }, null, new[]{ typeof(global::MiHomo.Protos.VehicleInteractReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VehicleInteractReq : pb::IMessage<VehicleInteractReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VehicleInteractReq> _parser = new pb::MessageParser<VehicleInteractReq>(() => new VehicleInteractReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VehicleInteractReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.VehicleInteractReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleInteractReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleInteractReq(VehicleInteractReq other) : this() {
      entityId_ = other.entityId_;
      interactType_ = other.interactType_;
      pos_ = other.pos_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VehicleInteractReq Clone() {
      return new VehicleInteractReq(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 15;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "interact_type" field.</summary>
    public const int InteractTypeFieldNumber = 8;
    private global::MiHomo.Protos.VehicleInteractType interactType_ = global::MiHomo.Protos.VehicleInteractType.VehicleInteractNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.VehicleInteractType InteractType {
      get { return interactType_; }
      set {
        interactType_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 12;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VehicleInteractReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VehicleInteractReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (InteractType != other.InteractType) return false;
      if (Pos != other.Pos) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (InteractType != global::MiHomo.Protos.VehicleInteractType.VehicleInteractNone) hash ^= InteractType.GetHashCode();
      if (Pos != 0) hash ^= Pos.GetHashCode();
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
      if (InteractType != global::MiHomo.Protos.VehicleInteractType.VehicleInteractNone) {
        output.WriteRawTag(64);
        output.WriteEnum((int) InteractType);
      }
      if (Pos != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Pos);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
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
      if (InteractType != global::MiHomo.Protos.VehicleInteractType.VehicleInteractNone) {
        output.WriteRawTag(64);
        output.WriteEnum((int) InteractType);
      }
      if (Pos != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Pos);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
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
      if (InteractType != global::MiHomo.Protos.VehicleInteractType.VehicleInteractNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InteractType);
      }
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VehicleInteractReq other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.InteractType != global::MiHomo.Protos.VehicleInteractType.VehicleInteractNone) {
        InteractType = other.InteractType;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
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
            InteractType = (global::MiHomo.Protos.VehicleInteractType) input.ReadEnum();
            break;
          }
          case 96: {
            Pos = input.ReadUInt32();
            break;
          }
          case 120: {
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
          case 64: {
            InteractType = (global::MiHomo.Protos.VehicleInteractType) input.ReadEnum();
            break;
          }
          case 96: {
            Pos = input.ReadUInt32();
            break;
          }
          case 120: {
            EntityId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the VehicleInteractReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 865,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
