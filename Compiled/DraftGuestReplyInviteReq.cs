// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DraftGuestReplyInviteReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DraftGuestReplyInviteReq.proto</summary>
  public static partial class DraftGuestReplyInviteReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DraftGuestReplyInviteReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DraftGuestReplyInviteReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5EcmFmdEd1ZXN0UmVwbHlJbnZpdGVSZXEucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MiogEKGERyYWZ0R3Vlc3RSZXBseUludml0ZVJlcRIQCghkcmFmdF9pZBgK",
            "IAEoDRIQCghpc19hZ3JlZRgDIAEoCCJiCgVDbWRJZBIICgROT05FEAASEwoP",
            "RU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lT",
            "X0FMTE9XX0NMSUVOVBABEgsKBkNNRF9JRBCtKhoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DraftGuestReplyInviteReq), global::MiHomo.Protos.DraftGuestReplyInviteReq.Parser, new[]{ "DraftId", "IsAgree" }, null, new[]{ typeof(global::MiHomo.Protos.DraftGuestReplyInviteReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DraftGuestReplyInviteReq : pb::IMessage<DraftGuestReplyInviteReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DraftGuestReplyInviteReq> _parser = new pb::MessageParser<DraftGuestReplyInviteReq>(() => new DraftGuestReplyInviteReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DraftGuestReplyInviteReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DraftGuestReplyInviteReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyInviteReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyInviteReq(DraftGuestReplyInviteReq other) : this() {
      draftId_ = other.draftId_;
      isAgree_ = other.isAgree_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DraftGuestReplyInviteReq Clone() {
      return new DraftGuestReplyInviteReq(this);
    }

    /// <summary>Field number for the "draft_id" field.</summary>
    public const int DraftIdFieldNumber = 10;
    private uint draftId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DraftId {
      get { return draftId_; }
      set {
        draftId_ = value;
      }
    }

    /// <summary>Field number for the "is_agree" field.</summary>
    public const int IsAgreeFieldNumber = 3;
    private bool isAgree_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAgree {
      get { return isAgree_; }
      set {
        isAgree_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DraftGuestReplyInviteReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DraftGuestReplyInviteReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DraftId != other.DraftId) return false;
      if (IsAgree != other.IsAgree) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DraftId != 0) hash ^= DraftId.GetHashCode();
      if (IsAgree != false) hash ^= IsAgree.GetHashCode();
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
      if (IsAgree != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAgree);
      }
      if (DraftId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DraftId);
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
      if (IsAgree != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsAgree);
      }
      if (DraftId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DraftId);
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
      if (DraftId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DraftId);
      }
      if (IsAgree != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DraftGuestReplyInviteReq other) {
      if (other == null) {
        return;
      }
      if (other.DraftId != 0) {
        DraftId = other.DraftId;
      }
      if (other.IsAgree != false) {
        IsAgree = other.IsAgree;
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
            IsAgree = input.ReadBool();
            break;
          }
          case 80: {
            DraftId = input.ReadUInt32();
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
            IsAgree = input.ReadBool();
            break;
          }
          case 80: {
            DraftId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DraftGuestReplyInviteReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 5421,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
