// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WidgetCreatorInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WidgetCreatorInfo.proto</summary>
  public static partial class WidgetCreatorInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for WidgetCreatorInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WidgetCreatorInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdXaWRnZXRDcmVhdG9ySW5mby5wcm90bxINbWlIb21vLlByb3RvcxoeV2lk",
            "Z2V0Q3JlYXRlTG9jYXRpb25JbmZvLnByb3RvGhlXaWRnZXRDcmVhdG9yT3BU",
            "eXBlLnByb3RvIpsBChFXaWRnZXRDcmVhdG9ySW5mbxIRCgllbnRpdHlfaWQY",
            "ASABKA0SPgoNbG9jYXRpb25faW5mbxgMIAEoCzInLm1pSG9tby5Qcm90b3Mu",
            "V2lkZ2V0Q3JlYXRlTG9jYXRpb25JbmZvEjMKB29wX3R5cGUYCiABKA4yIi5t",
            "aUhvbW8uUHJvdG9zLldpZGdldENyZWF0b3JPcFR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.WidgetCreateLocationInfoReflection.Descriptor, global::MiHomo.Protos.WidgetCreatorOpTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WidgetCreatorInfo), global::MiHomo.Protos.WidgetCreatorInfo.Parser, new[]{ "EntityId", "LocationInfo", "OpType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WidgetCreatorInfo : pb::IMessage<WidgetCreatorInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WidgetCreatorInfo> _parser = new pb::MessageParser<WidgetCreatorInfo>(() => new WidgetCreatorInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WidgetCreatorInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WidgetCreatorInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCreatorInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCreatorInfo(WidgetCreatorInfo other) : this() {
      entityId_ = other.entityId_;
      locationInfo_ = other.locationInfo_ != null ? other.locationInfo_.Clone() : null;
      opType_ = other.opType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WidgetCreatorInfo Clone() {
      return new WidgetCreatorInfo(this);
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

    /// <summary>Field number for the "location_info" field.</summary>
    public const int LocationInfoFieldNumber = 12;
    private global::MiHomo.Protos.WidgetCreateLocationInfo locationInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.WidgetCreateLocationInfo LocationInfo {
      get { return locationInfo_; }
      set {
        locationInfo_ = value;
      }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 10;
    private global::MiHomo.Protos.WidgetCreatorOpType opType_ = global::MiHomo.Protos.WidgetCreatorOpType.WidgetCreatorTypeNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.WidgetCreatorOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WidgetCreatorInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WidgetCreatorInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(LocationInfo, other.LocationInfo)) return false;
      if (OpType != other.OpType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (locationInfo_ != null) hash ^= LocationInfo.GetHashCode();
      if (OpType != global::MiHomo.Protos.WidgetCreatorOpType.WidgetCreatorTypeNone) hash ^= OpType.GetHashCode();
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
      if (OpType != global::MiHomo.Protos.WidgetCreatorOpType.WidgetCreatorTypeNone) {
        output.WriteRawTag(80);
        output.WriteEnum((int) OpType);
      }
      if (locationInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LocationInfo);
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
      if (OpType != global::MiHomo.Protos.WidgetCreatorOpType.WidgetCreatorTypeNone) {
        output.WriteRawTag(80);
        output.WriteEnum((int) OpType);
      }
      if (locationInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(LocationInfo);
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
      if (locationInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocationInfo);
      }
      if (OpType != global::MiHomo.Protos.WidgetCreatorOpType.WidgetCreatorTypeNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WidgetCreatorInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.locationInfo_ != null) {
        if (locationInfo_ == null) {
          LocationInfo = new global::MiHomo.Protos.WidgetCreateLocationInfo();
        }
        LocationInfo.MergeFrom(other.LocationInfo);
      }
      if (other.OpType != global::MiHomo.Protos.WidgetCreatorOpType.WidgetCreatorTypeNone) {
        OpType = other.OpType;
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
          case 80: {
            OpType = (global::MiHomo.Protos.WidgetCreatorOpType) input.ReadEnum();
            break;
          }
          case 98: {
            if (locationInfo_ == null) {
              LocationInfo = new global::MiHomo.Protos.WidgetCreateLocationInfo();
            }
            input.ReadMessage(LocationInfo);
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
          case 80: {
            OpType = (global::MiHomo.Protos.WidgetCreatorOpType) input.ReadEnum();
            break;
          }
          case 98: {
            if (locationInfo_ == null) {
              LocationInfo = new global::MiHomo.Protos.WidgetCreateLocationInfo();
            }
            input.ReadMessage(LocationInfo);
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
