// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAnimatorParameterNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtAnimatorParameterNotify.proto</summary>
  public static partial class EvtAnimatorParameterNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtAnimatorParameterNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtAnimatorParameterNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFdnRBbmltYXRvclBhcmFtZXRlck5vdGlmeS5wcm90bxINbWlIb21vLlBy",
            "b3RvcxoeRXZ0QW5pbWF0b3JQYXJhbWV0ZXJJbmZvLnByb3RvGhFGb3J3YXJk",
            "VHlwZS5wcm90byL4AQoaRXZ0QW5pbWF0b3JQYXJhbWV0ZXJOb3RpZnkSRAoT",
            "YW5pbWF0b3JfcGFyYW1faW5mbxgMIAEoCzInLm1pSG9tby5Qcm90b3MuRXZ0",
            "QW5pbWF0b3JQYXJhbWV0ZXJJbmZvEjAKDGZvcndhcmRfdHlwZRgOIAEoDjIa",
            "Lm1pSG9tby5Qcm90b3MuRm9yd2FyZFR5cGUiYgoFQ21kSWQSCAoETk9ORRAA",
            "EhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARIT",
            "Cg9JU19BTExPV19DTElFTlQQARILCgZDTURfSUQQjgMaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.EvtAnimatorParameterInfoReflection.Descriptor, global::MiHomo.Protos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtAnimatorParameterNotify), global::MiHomo.Protos.EvtAnimatorParameterNotify.Parser, new[]{ "AnimatorParamInfo", "ForwardType" }, null, new[]{ typeof(global::MiHomo.Protos.EvtAnimatorParameterNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtAnimatorParameterNotify : pb::IMessage<EvtAnimatorParameterNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtAnimatorParameterNotify> _parser = new pb::MessageParser<EvtAnimatorParameterNotify>(() => new EvtAnimatorParameterNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtAnimatorParameterNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtAnimatorParameterNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorParameterNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorParameterNotify(EvtAnimatorParameterNotify other) : this() {
      animatorParamInfo_ = other.animatorParamInfo_ != null ? other.animatorParamInfo_.Clone() : null;
      forwardType_ = other.forwardType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAnimatorParameterNotify Clone() {
      return new EvtAnimatorParameterNotify(this);
    }

    /// <summary>Field number for the "animator_param_info" field.</summary>
    public const int AnimatorParamInfoFieldNumber = 12;
    private global::MiHomo.Protos.EvtAnimatorParameterInfo animatorParamInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.EvtAnimatorParameterInfo AnimatorParamInfo {
      get { return animatorParamInfo_; }
      set {
        animatorParamInfo_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 14;
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
      return Equals(other as EvtAnimatorParameterNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtAnimatorParameterNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(AnimatorParamInfo, other.AnimatorParamInfo)) return false;
      if (ForwardType != other.ForwardType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (animatorParamInfo_ != null) hash ^= AnimatorParamInfo.GetHashCode();
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
      if (animatorParamInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AnimatorParamInfo);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(112);
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
      if (animatorParamInfo_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(AnimatorParamInfo);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(112);
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
      if (animatorParamInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AnimatorParamInfo);
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
    public void MergeFrom(EvtAnimatorParameterNotify other) {
      if (other == null) {
        return;
      }
      if (other.animatorParamInfo_ != null) {
        if (animatorParamInfo_ == null) {
          AnimatorParamInfo = new global::MiHomo.Protos.EvtAnimatorParameterInfo();
        }
        AnimatorParamInfo.MergeFrom(other.AnimatorParamInfo);
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
          case 98: {
            if (animatorParamInfo_ == null) {
              AnimatorParamInfo = new global::MiHomo.Protos.EvtAnimatorParameterInfo();
            }
            input.ReadMessage(AnimatorParamInfo);
            break;
          }
          case 112: {
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
          case 98: {
            if (animatorParamInfo_ == null) {
              AnimatorParamInfo = new global::MiHomo.Protos.EvtAnimatorParameterInfo();
            }
            input.ReadMessage(AnimatorParamInfo);
            break;
          }
          case 112: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EvtAnimatorParameterNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 398,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
