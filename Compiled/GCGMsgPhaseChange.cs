// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgPhaseChange.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGMsgPhaseChange.proto</summary>
  public static partial class GCGMsgPhaseChangeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgPhaseChange.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgPhaseChangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHQ0dNc2dQaGFzZUNoYW5nZS5wcm90bxINbWlIb21vLlByb3RvcxoSR0NH",
            "UGhhc2VUeXBlLnByb3RvGhBVaW50MzJQYWlyLnByb3RvIrEBChFHQ0dNc2dQ",
            "aGFzZUNoYW5nZRIwCgthZnRlcl9waGFzZRgDIAEoDjIbLm1pSG9tby5Qcm90",
            "b3MuR0NHUGhhc2VUeXBlEjcKFGFsbG93X2NvbnRyb2xsZXJfbWFwGAsgAygL",
            "MhkubWlIb21vLlByb3Rvcy5VaW50MzJQYWlyEjEKDGJlZm9yZV9waGFzZRgP",
            "IAEoDjIbLm1pSG9tby5Qcm90b3MuR0NHUGhhc2VUeXBlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GCGPhaseTypeReflection.Descriptor, global::MiHomo.Protos.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GCGMsgPhaseChange), global::MiHomo.Protos.GCGMsgPhaseChange.Parser, new[]{ "AfterPhase", "AllowControllerMap", "BeforePhase" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgPhaseChange : pb::IMessage<GCGMsgPhaseChange>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgPhaseChange> _parser = new pb::MessageParser<GCGMsgPhaseChange>(() => new GCGMsgPhaseChange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgPhaseChange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GCGMsgPhaseChangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgPhaseChange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgPhaseChange(GCGMsgPhaseChange other) : this() {
      afterPhase_ = other.afterPhase_;
      allowControllerMap_ = other.allowControllerMap_.Clone();
      beforePhase_ = other.beforePhase_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgPhaseChange Clone() {
      return new GCGMsgPhaseChange(this);
    }

    /// <summary>Field number for the "after_phase" field.</summary>
    public const int AfterPhaseFieldNumber = 3;
    private global::MiHomo.Protos.GCGPhaseType afterPhase_ = global::MiHomo.Protos.GCGPhaseType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GCGPhaseType AfterPhase {
      get { return afterPhase_; }
      set {
        afterPhase_ = value;
      }
    }

    /// <summary>Field number for the "allow_controller_map" field.</summary>
    public const int AllowControllerMapFieldNumber = 11;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.Uint32Pair> _repeated_allowControllerMap_codec
        = pb::FieldCodec.ForMessage(90, global::MiHomo.Protos.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair> allowControllerMap_ = new pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair> AllowControllerMap {
      get { return allowControllerMap_; }
    }

    /// <summary>Field number for the "before_phase" field.</summary>
    public const int BeforePhaseFieldNumber = 15;
    private global::MiHomo.Protos.GCGPhaseType beforePhase_ = global::MiHomo.Protos.GCGPhaseType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GCGPhaseType BeforePhase {
      get { return beforePhase_; }
      set {
        beforePhase_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgPhaseChange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgPhaseChange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AfterPhase != other.AfterPhase) return false;
      if(!allowControllerMap_.Equals(other.allowControllerMap_)) return false;
      if (BeforePhase != other.BeforePhase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AfterPhase != global::MiHomo.Protos.GCGPhaseType.Invalid) hash ^= AfterPhase.GetHashCode();
      hash ^= allowControllerMap_.GetHashCode();
      if (BeforePhase != global::MiHomo.Protos.GCGPhaseType.Invalid) hash ^= BeforePhase.GetHashCode();
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
      if (AfterPhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AfterPhase);
      }
      allowControllerMap_.WriteTo(output, _repeated_allowControllerMap_codec);
      if (BeforePhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        output.WriteRawTag(120);
        output.WriteEnum((int) BeforePhase);
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
      if (AfterPhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AfterPhase);
      }
      allowControllerMap_.WriteTo(ref output, _repeated_allowControllerMap_codec);
      if (BeforePhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        output.WriteRawTag(120);
        output.WriteEnum((int) BeforePhase);
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
      if (AfterPhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AfterPhase);
      }
      size += allowControllerMap_.CalculateSize(_repeated_allowControllerMap_codec);
      if (BeforePhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BeforePhase);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgPhaseChange other) {
      if (other == null) {
        return;
      }
      if (other.AfterPhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        AfterPhase = other.AfterPhase;
      }
      allowControllerMap_.Add(other.allowControllerMap_);
      if (other.BeforePhase != global::MiHomo.Protos.GCGPhaseType.Invalid) {
        BeforePhase = other.BeforePhase;
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
          case 24: {
            AfterPhase = (global::MiHomo.Protos.GCGPhaseType) input.ReadEnum();
            break;
          }
          case 90: {
            allowControllerMap_.AddEntriesFrom(input, _repeated_allowControllerMap_codec);
            break;
          }
          case 120: {
            BeforePhase = (global::MiHomo.Protos.GCGPhaseType) input.ReadEnum();
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
          case 24: {
            AfterPhase = (global::MiHomo.Protos.GCGPhaseType) input.ReadEnum();
            break;
          }
          case 90: {
            allowControllerMap_.AddEntriesFrom(ref input, _repeated_allowControllerMap_codec);
            break;
          }
          case 120: {
            BeforePhase = (global::MiHomo.Protos.GCGPhaseType) input.ReadEnum();
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
