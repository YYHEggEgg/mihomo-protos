// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtSetAttackTargetNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtSetAttackTargetNotify.proto</summary>
  public static partial class EvtSetAttackTargetNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtSetAttackTargetNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtSetAttackTargetNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5FdnRTZXRBdHRhY2tUYXJnZXROb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaHEV2dFNldEF0dGFja1RhcmdldEluZm8ucHJvdG8aEUZvcndhcmRUeXBl",
            "LnByb3RvIpcBChhFdnRTZXRBdHRhY2tUYXJnZXROb3RpZnkSSQoaZXZ0X3Nl",
            "dF9hdHRhY2tfdGFyZ2V0X2luZm8YDSABKAsyJS5taUhvbW8uUHJvdG9zLkV2",
            "dFNldEF0dGFja1RhcmdldEluZm8SMAoMZm9yd2FyZF90eXBlGAYgASgOMhou",
            "bWlIb21vLlByb3Rvcy5Gb3J3YXJkVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.EvtSetAttackTargetInfoReflection.Descriptor, global::MiHomo.Protos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtSetAttackTargetNotify), global::MiHomo.Protos.EvtSetAttackTargetNotify.Parser, new[]{ "EvtSetAttackTargetInfo", "ForwardType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtSetAttackTargetNotify : pb::IMessage<EvtSetAttackTargetNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtSetAttackTargetNotify> _parser = new pb::MessageParser<EvtSetAttackTargetNotify>(() => new EvtSetAttackTargetNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtSetAttackTargetNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtSetAttackTargetNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSetAttackTargetNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSetAttackTargetNotify(EvtSetAttackTargetNotify other) : this() {
      evtSetAttackTargetInfo_ = other.evtSetAttackTargetInfo_ != null ? other.evtSetAttackTargetInfo_.Clone() : null;
      forwardType_ = other.forwardType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtSetAttackTargetNotify Clone() {
      return new EvtSetAttackTargetNotify(this);
    }

    /// <summary>Field number for the "evt_set_attack_target_info" field.</summary>
    public const int EvtSetAttackTargetInfoFieldNumber = 13;
    private global::MiHomo.Protos.EvtSetAttackTargetInfo evtSetAttackTargetInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.EvtSetAttackTargetInfo EvtSetAttackTargetInfo {
      get { return evtSetAttackTargetInfo_; }
      set {
        evtSetAttackTargetInfo_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 6;
    private global::MiHomo.Protos.ForwardType forwardType_ = global::MiHomo.Protos.ForwardType.Local;
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
      return Equals(other as EvtSetAttackTargetNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtSetAttackTargetNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EvtSetAttackTargetInfo, other.EvtSetAttackTargetInfo)) return false;
      if (ForwardType != other.ForwardType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (evtSetAttackTargetInfo_ != null) hash ^= EvtSetAttackTargetInfo.GetHashCode();
      if (ForwardType != global::MiHomo.Protos.ForwardType.Local) hash ^= ForwardType.GetHashCode();
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
        output.WriteRawTag(48);
        output.WriteEnum((int) ForwardType);
      }
      if (evtSetAttackTargetInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(EvtSetAttackTargetInfo);
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
        output.WriteRawTag(48);
        output.WriteEnum((int) ForwardType);
      }
      if (evtSetAttackTargetInfo_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(EvtSetAttackTargetInfo);
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
      if (evtSetAttackTargetInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EvtSetAttackTargetInfo);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtSetAttackTargetNotify other) {
      if (other == null) {
        return;
      }
      if (other.evtSetAttackTargetInfo_ != null) {
        if (evtSetAttackTargetInfo_ == null) {
          EvtSetAttackTargetInfo = new global::MiHomo.Protos.EvtSetAttackTargetInfo();
        }
        EvtSetAttackTargetInfo.MergeFrom(other.EvtSetAttackTargetInfo);
      }
      if (other.ForwardType != global::MiHomo.Protos.ForwardType.Local) {
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
          case 48: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 106: {
            if (evtSetAttackTargetInfo_ == null) {
              EvtSetAttackTargetInfo = new global::MiHomo.Protos.EvtSetAttackTargetInfo();
            }
            input.ReadMessage(EvtSetAttackTargetInfo);
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
          case 48: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 106: {
            if (evtSetAttackTargetInfo_ == null) {
              EvtSetAttackTargetInfo = new global::MiHomo.Protos.EvtSetAttackTargetInfo();
            }
            input.ReadMessage(EvtSetAttackTargetInfo);
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
