// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QuestUpdateQuestVarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from QuestUpdateQuestVarReq.proto</summary>
  public static partial class QuestUpdateQuestVarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for QuestUpdateQuestVarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestUpdateQuestVarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxRdWVzdFVwZGF0ZVF1ZXN0VmFyUmVxLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "GhBRdWVzdFZhck9wLnByb3RvIpcBChZRdWVzdFVwZGF0ZVF1ZXN0VmFyUmVx",
            "EhcKD3BhcmVudF9xdWVzdF9pZBgCIAEoDRIcChRwYXJlbnRfcXVlc3RfdmFy",
            "X3NlcRgHIAEoDRIQCghxdWVzdF9pZBgFIAEoDRI0ChFxdWVzdF92YXJfb3Bf",
            "bGlzdBgLIAMoCzIZLm1pSG9tby5Qcm90b3MuUXVlc3RWYXJPcGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.QuestVarOpReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.QuestUpdateQuestVarReq), global::MiHomo.Protos.QuestUpdateQuestVarReq.Parser, new[]{ "ParentQuestId", "ParentQuestVarSeq", "QuestId", "QuestVarOpList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestUpdateQuestVarReq : pb::IMessage<QuestUpdateQuestVarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QuestUpdateQuestVarReq> _parser = new pb::MessageParser<QuestUpdateQuestVarReq>(() => new QuestUpdateQuestVarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QuestUpdateQuestVarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.QuestUpdateQuestVarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarReq(QuestUpdateQuestVarReq other) : this() {
      parentQuestId_ = other.parentQuestId_;
      parentQuestVarSeq_ = other.parentQuestVarSeq_;
      questId_ = other.questId_;
      questVarOpList_ = other.questVarOpList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QuestUpdateQuestVarReq Clone() {
      return new QuestUpdateQuestVarReq(this);
    }

    /// <summary>Field number for the "parent_quest_id" field.</summary>
    public const int ParentQuestIdFieldNumber = 2;
    private uint parentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestId {
      get { return parentQuestId_; }
      set {
        parentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "parent_quest_var_seq" field.</summary>
    public const int ParentQuestVarSeqFieldNumber = 7;
    private uint parentQuestVarSeq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ParentQuestVarSeq {
      get { return parentQuestVarSeq_; }
      set {
        parentQuestVarSeq_ = value;
      }
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 5;
    private uint questId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QuestId {
      get { return questId_; }
      set {
        questId_ = value;
      }
    }

    /// <summary>Field number for the "quest_var_op_list" field.</summary>
    public const int QuestVarOpListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.QuestVarOp> _repeated_questVarOpList_codec
        = pb::FieldCodec.ForMessage(90, global::MiHomo.Protos.QuestVarOp.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.QuestVarOp> questVarOpList_ = new pbc::RepeatedField<global::MiHomo.Protos.QuestVarOp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.QuestVarOp> QuestVarOpList {
      get { return questVarOpList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as QuestUpdateQuestVarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QuestUpdateQuestVarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ParentQuestId != other.ParentQuestId) return false;
      if (ParentQuestVarSeq != other.ParentQuestVarSeq) return false;
      if (QuestId != other.QuestId) return false;
      if(!questVarOpList_.Equals(other.questVarOpList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ParentQuestId != 0) hash ^= ParentQuestId.GetHashCode();
      if (ParentQuestVarSeq != 0) hash ^= ParentQuestVarSeq.GetHashCode();
      if (QuestId != 0) hash ^= QuestId.GetHashCode();
      hash ^= questVarOpList_.GetHashCode();
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
      if (ParentQuestId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QuestId);
      }
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ParentQuestVarSeq);
      }
      questVarOpList_.WriteTo(output, _repeated_questVarOpList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ParentQuestId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ParentQuestId);
      }
      if (QuestId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QuestId);
      }
      if (ParentQuestVarSeq != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ParentQuestVarSeq);
      }
      questVarOpList_.WriteTo(ref output, _repeated_questVarOpList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestId);
      }
      if (ParentQuestVarSeq != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParentQuestVarSeq);
      }
      if (QuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QuestId);
      }
      size += questVarOpList_.CalculateSize(_repeated_questVarOpList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(QuestUpdateQuestVarReq other) {
      if (other == null) {
        return;
      }
      if (other.ParentQuestId != 0) {
        ParentQuestId = other.ParentQuestId;
      }
      if (other.ParentQuestVarSeq != 0) {
        ParentQuestVarSeq = other.ParentQuestVarSeq;
      }
      if (other.QuestId != 0) {
        QuestId = other.QuestId;
      }
      questVarOpList_.Add(other.questVarOpList_);
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
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 40: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 56: {
            ParentQuestVarSeq = input.ReadUInt32();
            break;
          }
          case 90: {
            questVarOpList_.AddEntriesFrom(input, _repeated_questVarOpList_codec);
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
            ParentQuestId = input.ReadUInt32();
            break;
          }
          case 40: {
            QuestId = input.ReadUInt32();
            break;
          }
          case 56: {
            ParentQuestVarSeq = input.ReadUInt32();
            break;
          }
          case 90: {
            questVarOpList_.AddEntriesFrom(ref input, _repeated_questVarOpList_codec);
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
