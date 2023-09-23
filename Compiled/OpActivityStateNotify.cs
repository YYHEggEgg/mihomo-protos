// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OpActivityStateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from OpActivityStateNotify.proto</summary>
  public static partial class OpActivityStateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for OpActivityStateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpActivityStateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtPcEFjdGl2aXR5U3RhdGVOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "HE9wQWN0aXZpdHlUYWdCcmllZkluZm8ucHJvdG8ijQEKFU9wQWN0aXZpdHlT",
            "dGF0ZU5vdGlmeRInCh9maW5pc2hlZF9ib251c19hY3Rpdml0eV9pZF9saXN0",
            "GAYgAygNEksKHG9wZW5lZF9vcF9hY3Rpdml0eV9pbmZvX2xpc3QYCCADKAsy",
            "JS5taUhvbW8uUHJvdG9zLk9wQWN0aXZpdHlUYWdCcmllZkluZm9iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.OpActivityTagBriefInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.OpActivityStateNotify), global::MiHomo.Protos.OpActivityStateNotify.Parser, new[]{ "FinishedBonusActivityIdList", "OpenedOpActivityInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OpActivityStateNotify : pb::IMessage<OpActivityStateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OpActivityStateNotify> _parser = new pb::MessageParser<OpActivityStateNotify>(() => new OpActivityStateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OpActivityStateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.OpActivityStateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpActivityStateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpActivityStateNotify(OpActivityStateNotify other) : this() {
      finishedBonusActivityIdList_ = other.finishedBonusActivityIdList_.Clone();
      openedOpActivityInfoList_ = other.openedOpActivityInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OpActivityStateNotify Clone() {
      return new OpActivityStateNotify(this);
    }

    /// <summary>Field number for the "finished_bonus_activity_id_list" field.</summary>
    public const int FinishedBonusActivityIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_finishedBonusActivityIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> finishedBonusActivityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FinishedBonusActivityIdList {
      get { return finishedBonusActivityIdList_; }
    }

    /// <summary>Field number for the "opened_op_activity_info_list" field.</summary>
    public const int OpenedOpActivityInfoListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.OpActivityTagBriefInfo> _repeated_openedOpActivityInfoList_codec
        = pb::FieldCodec.ForMessage(66, global::MiHomo.Protos.OpActivityTagBriefInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.OpActivityTagBriefInfo> openedOpActivityInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.OpActivityTagBriefInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.OpActivityTagBriefInfo> OpenedOpActivityInfoList {
      get { return openedOpActivityInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OpActivityStateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OpActivityStateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!finishedBonusActivityIdList_.Equals(other.finishedBonusActivityIdList_)) return false;
      if(!openedOpActivityInfoList_.Equals(other.openedOpActivityInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= finishedBonusActivityIdList_.GetHashCode();
      hash ^= openedOpActivityInfoList_.GetHashCode();
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
      finishedBonusActivityIdList_.WriteTo(output, _repeated_finishedBonusActivityIdList_codec);
      openedOpActivityInfoList_.WriteTo(output, _repeated_openedOpActivityInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      finishedBonusActivityIdList_.WriteTo(ref output, _repeated_finishedBonusActivityIdList_codec);
      openedOpActivityInfoList_.WriteTo(ref output, _repeated_openedOpActivityInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += finishedBonusActivityIdList_.CalculateSize(_repeated_finishedBonusActivityIdList_codec);
      size += openedOpActivityInfoList_.CalculateSize(_repeated_openedOpActivityInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OpActivityStateNotify other) {
      if (other == null) {
        return;
      }
      finishedBonusActivityIdList_.Add(other.finishedBonusActivityIdList_);
      openedOpActivityInfoList_.Add(other.openedOpActivityInfoList_);
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
          case 50:
          case 48: {
            finishedBonusActivityIdList_.AddEntriesFrom(input, _repeated_finishedBonusActivityIdList_codec);
            break;
          }
          case 66: {
            openedOpActivityInfoList_.AddEntriesFrom(input, _repeated_openedOpActivityInfoList_codec);
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
          case 50:
          case 48: {
            finishedBonusActivityIdList_.AddEntriesFrom(ref input, _repeated_finishedBonusActivityIdList_codec);
            break;
          }
          case 66: {
            openedOpActivityInfoList_.AddEntriesFrom(ref input, _repeated_openedOpActivityInfoList_codec);
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
