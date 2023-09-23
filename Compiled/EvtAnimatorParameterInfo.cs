// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAnimatorParameterInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtAnimatorParameterInfo.proto</summary>
  public static partial class EvtAnimatorParameterInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtAnimatorParameterInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtAnimatorParameterInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5FdnRBbmltYXRvclBhcmFtZXRlckluZm8ucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaIEFuaW1hdG9yUGFyYW1ldGVyVmFsdWVJbmZvLnByb3RvIpEBChhFdnRB",
            "bmltYXRvclBhcmFtZXRlckluZm8SEQoJZW50aXR5X2lkGAQgASgNEhcKD2lz",
            "X3NlcnZlcl9jYWNoZRgFIAEoCBIPCgduYW1lX2lkGA8gASgFEjgKBXZhbHVl",
            "GAcgASgLMikubWlIb21vLlByb3Rvcy5BbmltYXRvclBhcmFtZXRlclZhbHVl",
            "SW5mb2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.AnimatorParameterValueInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtAnimatorParameterInfo), global::MiHomo.Protos.EvtAnimatorParameterInfo.Parser, new[]{ "EntityId", "IsServerCache", "NameId", "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtAnimatorParameterInfo : pb::IMessage<EvtAnimatorParameterInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtAnimatorParameterInfo> _parser = new pb::MessageParser<EvtAnimatorParameterInfo>(() => new EvtAnimatorParameterInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtAnimatorParameterInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtAnimatorParameterInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorParameterInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorParameterInfo(EvtAnimatorParameterInfo other) : this() {
      entityId_ = other.entityId_;
      isServerCache_ = other.isServerCache_;
      nameId_ = other.nameId_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorParameterInfo Clone() {
      return new EvtAnimatorParameterInfo(this);
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

    /// <summary>Field number for the "is_server_cache" field.</summary>
    public const int IsServerCacheFieldNumber = 5;
    private bool isServerCache_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsServerCache {
      get { return isServerCache_; }
      set {
        isServerCache_ = value;
      }
    }

    /// <summary>Field number for the "name_id" field.</summary>
    public const int NameIdFieldNumber = 15;
    private int nameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int NameId {
      get { return nameId_; }
      set {
        nameId_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 7;
    private global::MiHomo.Protos.AnimatorParameterValueInfo value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.AnimatorParameterValueInfo Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtAnimatorParameterInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtAnimatorParameterInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (IsServerCache != other.IsServerCache) return false;
      if (NameId != other.NameId) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (IsServerCache != false) hash ^= IsServerCache.GetHashCode();
      if (NameId != 0) hash ^= NameId.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (IsServerCache != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsServerCache);
      }
      if (value_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Value);
      }
      if (NameId != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(NameId);
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
      if (IsServerCache != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsServerCache);
      }
      if (value_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Value);
      }
      if (NameId != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(NameId);
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
      if (IsServerCache != false) {
        size += 1 + 1;
      }
      if (NameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NameId);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtAnimatorParameterInfo other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.IsServerCache != false) {
        IsServerCache = other.IsServerCache;
      }
      if (other.NameId != 0) {
        NameId = other.NameId;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::MiHomo.Protos.AnimatorParameterValueInfo();
        }
        Value.MergeFrom(other.Value);
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
          case 40: {
            IsServerCache = input.ReadBool();
            break;
          }
          case 58: {
            if (value_ == null) {
              Value = new global::MiHomo.Protos.AnimatorParameterValueInfo();
            }
            input.ReadMessage(Value);
            break;
          }
          case 120: {
            NameId = input.ReadInt32();
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
          case 40: {
            IsServerCache = input.ReadBool();
            break;
          }
          case 58: {
            if (value_ == null) {
              Value = new global::MiHomo.Protos.AnimatorParameterValueInfo();
            }
            input.ReadMessage(Value);
            break;
          }
          case 120: {
            NameId = input.ReadInt32();
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
