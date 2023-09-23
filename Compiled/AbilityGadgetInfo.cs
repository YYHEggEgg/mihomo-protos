// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityGadgetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityGadgetInfo.proto</summary>
  public static partial class AbilityGadgetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityGadgetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityGadgetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdBYmlsaXR5R2FkZ2V0SW5mby5wcm90bxINbWlIb21vLlByb3RvcyJYChFB",
            "YmlsaXR5R2FkZ2V0SW5mbxIPCgdjYW1wX2lkGAEgASgNEhgKEGNhbXBfdGFy",
            "Z2V0X3R5cGUYAiABKA0SGAoQdGFyZ2V0X2VudGl0eV9pZBgDIAEoDWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityGadgetInfo), global::MiHomo.Protos.AbilityGadgetInfo.Parser, new[]{ "CampId", "CampTargetType", "TargetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityGadgetInfo : pb::IMessage<AbilityGadgetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityGadgetInfo> _parser = new pb::MessageParser<AbilityGadgetInfo>(() => new AbilityGadgetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityGadgetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityGadgetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityGadgetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityGadgetInfo(AbilityGadgetInfo other) : this() {
      campId_ = other.campId_;
      campTargetType_ = other.campTargetType_;
      targetEntityId_ = other.targetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityGadgetInfo Clone() {
      return new AbilityGadgetInfo(this);
    }

    /// <summary>Field number for the "camp_id" field.</summary>
    public const int CampIdFieldNumber = 1;
    private uint campId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampId {
      get { return campId_; }
      set {
        campId_ = value;
      }
    }

    /// <summary>Field number for the "camp_target_type" field.</summary>
    public const int CampTargetTypeFieldNumber = 2;
    private uint campTargetType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampTargetType {
      get { return campTargetType_; }
      set {
        campTargetType_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 3;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityGadgetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityGadgetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CampId != other.CampId) return false;
      if (CampTargetType != other.CampTargetType) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CampId != 0) hash ^= CampId.GetHashCode();
      if (CampTargetType != 0) hash ^= CampTargetType.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
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
      if (CampId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CampId);
      }
      if (CampTargetType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CampTargetType);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetEntityId);
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
      if (CampId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CampId);
      }
      if (CampTargetType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CampTargetType);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TargetEntityId);
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
      if (CampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampId);
      }
      if (CampTargetType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampTargetType);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityGadgetInfo other) {
      if (other == null) {
        return;
      }
      if (other.CampId != 0) {
        CampId = other.CampId;
      }
      if (other.CampTargetType != 0) {
        CampTargetType = other.CampTargetType;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
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
            CampId = input.ReadUInt32();
            break;
          }
          case 16: {
            CampTargetType = input.ReadUInt32();
            break;
          }
          case 24: {
            TargetEntityId = input.ReadUInt32();
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
            CampId = input.ReadUInt32();
            break;
          }
          case 16: {
            CampTargetType = input.ReadUInt32();
            break;
          }
          case 24: {
            TargetEntityId = input.ReadUInt32();
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
