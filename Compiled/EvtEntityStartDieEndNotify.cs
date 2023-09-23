// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtEntityStartDieEndNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtEntityStartDieEndNotify.proto</summary>
  public static partial class EvtEntityStartDieEndNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtEntityStartDieEndNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtEntityStartDieEndNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFdnRFbnRpdHlTdGFydERpZUVuZE5vdGlmeS5wcm90bxINbWlIb21vLlBy",
            "b3RvcxoRRm9yd2FyZFR5cGUucHJvdG8ijgEKGkV2dEVudGl0eVN0YXJ0RGll",
            "RW5kTm90aWZ5EhYKDmRpZV9zdGF0ZV9mbGFnGAQgASgNEhEKCWVudGl0eV9p",
            "ZBgGIAEoDRIwCgxmb3J3YXJkX3R5cGUYAiABKA4yGi5taUhvbW8uUHJvdG9z",
            "LkZvcndhcmRUeXBlEhMKC2ltbWVkaWF0ZWx5GAkgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtEntityStartDieEndNotify), global::MiHomo.Protos.EvtEntityStartDieEndNotify.Parser, new[]{ "DieStateFlag", "EntityId", "ForwardType", "Immediately" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtEntityStartDieEndNotify : pb::IMessage<EvtEntityStartDieEndNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtEntityStartDieEndNotify> _parser = new pb::MessageParser<EvtEntityStartDieEndNotify>(() => new EvtEntityStartDieEndNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtEntityStartDieEndNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtEntityStartDieEndNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtEntityStartDieEndNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtEntityStartDieEndNotify(EvtEntityStartDieEndNotify other) : this() {
      dieStateFlag_ = other.dieStateFlag_;
      entityId_ = other.entityId_;
      forwardType_ = other.forwardType_;
      immediately_ = other.immediately_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtEntityStartDieEndNotify Clone() {
      return new EvtEntityStartDieEndNotify(this);
    }

    /// <summary>Field number for the "die_state_flag" field.</summary>
    public const int DieStateFlagFieldNumber = 4;
    private uint dieStateFlag_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DieStateFlag {
      get { return dieStateFlag_; }
      set {
        dieStateFlag_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 6;
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
    public const int ForwardTypeFieldNumber = 2;
    private global::MiHomo.Protos.ForwardType forwardType_ = global::MiHomo.Protos.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "immediately" field.</summary>
    public const int ImmediatelyFieldNumber = 9;
    private bool immediately_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Immediately {
      get { return immediately_; }
      set {
        immediately_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtEntityStartDieEndNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtEntityStartDieEndNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DieStateFlag != other.DieStateFlag) return false;
      if (EntityId != other.EntityId) return false;
      if (ForwardType != other.ForwardType) return false;
      if (Immediately != other.Immediately) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DieStateFlag != 0) hash ^= DieStateFlag.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (ForwardType != global::MiHomo.Protos.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (Immediately != false) hash ^= Immediately.GetHashCode();
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
      if (ForwardType != global::MiHomo.Protos.ForwardType.Local) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ForwardType);
      }
      if (DieStateFlag != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DieStateFlag);
      }
      if (EntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EntityId);
      }
      if (Immediately != false) {
        output.WriteRawTag(72);
        output.WriteBool(Immediately);
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
      if (ForwardType != global::MiHomo.Protos.ForwardType.Local) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ForwardType);
      }
      if (DieStateFlag != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DieStateFlag);
      }
      if (EntityId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(EntityId);
      }
      if (Immediately != false) {
        output.WriteRawTag(72);
        output.WriteBool(Immediately);
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
      if (DieStateFlag != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DieStateFlag);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (Immediately != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtEntityStartDieEndNotify other) {
      if (other == null) {
        return;
      }
      if (other.DieStateFlag != 0) {
        DieStateFlag = other.DieStateFlag;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.ForwardType != global::MiHomo.Protos.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.Immediately != false) {
        Immediately = other.Immediately;
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
          case 16: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 32: {
            DieStateFlag = input.ReadUInt32();
            break;
          }
          case 48: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            Immediately = input.ReadBool();
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
          case 16: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 32: {
            DieStateFlag = input.ReadUInt32();
            break;
          }
          case 48: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            Immediately = input.ReadBool();
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
