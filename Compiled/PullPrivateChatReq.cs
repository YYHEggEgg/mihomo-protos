// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PullPrivateChatReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PullPrivateChatReq.proto</summary>
  public static partial class PullPrivateChatReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PullPrivateChatReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PullPrivateChatReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhQdWxsUHJpdmF0ZUNoYXRSZXEucHJvdG8SDW1pSG9tby5Qcm90b3MitQEK",
            "ElB1bGxQcml2YXRlQ2hhdFJlcRIVCg1mcm9tX3NlcXVlbmNlGAwgASgNEhAK",
            "CHB1bGxfbnVtGAcgASgNEhIKCnRhcmdldF91aWQYBSABKA0iYgoFQ21kSWQS",
            "CAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVM",
            "SUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARILCgZDTURfSUQQ6yYaAhAB",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PullPrivateChatReq), global::MiHomo.Protos.PullPrivateChatReq.Parser, new[]{ "FromSequence", "PullNum", "TargetUid" }, null, new[]{ typeof(global::MiHomo.Protos.PullPrivateChatReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PullPrivateChatReq : pb::IMessage<PullPrivateChatReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PullPrivateChatReq> _parser = new pb::MessageParser<PullPrivateChatReq>(() => new PullPrivateChatReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PullPrivateChatReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PullPrivateChatReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullPrivateChatReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullPrivateChatReq(PullPrivateChatReq other) : this() {
      fromSequence_ = other.fromSequence_;
      pullNum_ = other.pullNum_;
      targetUid_ = other.targetUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PullPrivateChatReq Clone() {
      return new PullPrivateChatReq(this);
    }

    /// <summary>Field number for the "from_sequence" field.</summary>
    public const int FromSequenceFieldNumber = 12;
    private uint fromSequence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FromSequence {
      get { return fromSequence_; }
      set {
        fromSequence_ = value;
      }
    }

    /// <summary>Field number for the "pull_num" field.</summary>
    public const int PullNumFieldNumber = 7;
    private uint pullNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PullNum {
      get { return pullNum_; }
      set {
        pullNum_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 5;
    private uint targetUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetUid {
      get { return targetUid_; }
      set {
        targetUid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PullPrivateChatReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PullPrivateChatReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FromSequence != other.FromSequence) return false;
      if (PullNum != other.PullNum) return false;
      if (TargetUid != other.TargetUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FromSequence != 0) hash ^= FromSequence.GetHashCode();
      if (PullNum != 0) hash ^= PullNum.GetHashCode();
      if (TargetUid != 0) hash ^= TargetUid.GetHashCode();
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
      if (TargetUid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetUid);
      }
      if (PullNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PullNum);
      }
      if (FromSequence != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FromSequence);
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
      if (TargetUid != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetUid);
      }
      if (PullNum != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PullNum);
      }
      if (FromSequence != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FromSequence);
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
      if (FromSequence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FromSequence);
      }
      if (PullNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PullNum);
      }
      if (TargetUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetUid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PullPrivateChatReq other) {
      if (other == null) {
        return;
      }
      if (other.FromSequence != 0) {
        FromSequence = other.FromSequence;
      }
      if (other.PullNum != 0) {
        PullNum = other.PullNum;
      }
      if (other.TargetUid != 0) {
        TargetUid = other.TargetUid;
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
          case 40: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 56: {
            PullNum = input.ReadUInt32();
            break;
          }
          case 96: {
            FromSequence = input.ReadUInt32();
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
          case 40: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 56: {
            PullNum = input.ReadUInt32();
            break;
          }
          case 96: {
            FromSequence = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PullPrivateChatReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4971,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
