// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayGuestReplyNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ScenePlayGuestReplyNotify.proto</summary>
  public static partial class ScenePlayGuestReplyNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ScenePlayGuestReplyNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenePlayGuestReplyNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TY2VuZVBsYXlHdWVzdFJlcGx5Tm90aWZ5LnByb3RvEg1taUhvbW8uUHJv",
            "dG9zIqABChlTY2VuZVBsYXlHdWVzdFJlcGx5Tm90aWZ5EhEKCWd1ZXN0X3Vp",
            "ZBgMIAEoDRIQCghpc19hZ3JlZRgDIAEoCBIPCgdwbGF5X2lkGA0gASgNIk0K",
            "BUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVU",
            "X0lTX1JFTElBQkxFEAESCwoGQ01EX0lEEMciGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ScenePlayGuestReplyNotify), global::MiHomo.Protos.ScenePlayGuestReplyNotify.Parser, new[]{ "GuestUid", "IsAgree", "PlayId" }, null, new[]{ typeof(global::MiHomo.Protos.ScenePlayGuestReplyNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScenePlayGuestReplyNotify : pb::IMessage<ScenePlayGuestReplyNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScenePlayGuestReplyNotify> _parser = new pb::MessageParser<ScenePlayGuestReplyNotify>(() => new ScenePlayGuestReplyNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScenePlayGuestReplyNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ScenePlayGuestReplyNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayGuestReplyNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayGuestReplyNotify(ScenePlayGuestReplyNotify other) : this() {
      guestUid_ = other.guestUid_;
      isAgree_ = other.isAgree_;
      playId_ = other.playId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScenePlayGuestReplyNotify Clone() {
      return new ScenePlayGuestReplyNotify(this);
    }

    /// <summary>Field number for the "guest_uid" field.</summary>
    public const int GuestUidFieldNumber = 12;
    private uint guestUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GuestUid {
      get { return guestUid_; }
      set {
        guestUid_ = value;
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

    /// <summary>Field number for the "play_id" field.</summary>
    public const int PlayIdFieldNumber = 13;
    private uint playId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayId {
      get { return playId_; }
      set {
        playId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScenePlayGuestReplyNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScenePlayGuestReplyNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GuestUid != other.GuestUid) return false;
      if (IsAgree != other.IsAgree) return false;
      if (PlayId != other.PlayId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GuestUid != 0) hash ^= GuestUid.GetHashCode();
      if (IsAgree != false) hash ^= IsAgree.GetHashCode();
      if (PlayId != 0) hash ^= PlayId.GetHashCode();
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
      if (GuestUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GuestUid);
      }
      if (PlayId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PlayId);
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
      if (GuestUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(GuestUid);
      }
      if (PlayId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(PlayId);
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
      if (GuestUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GuestUid);
      }
      if (IsAgree != false) {
        size += 1 + 1;
      }
      if (PlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScenePlayGuestReplyNotify other) {
      if (other == null) {
        return;
      }
      if (other.GuestUid != 0) {
        GuestUid = other.GuestUid;
      }
      if (other.IsAgree != false) {
        IsAgree = other.IsAgree;
      }
      if (other.PlayId != 0) {
        PlayId = other.PlayId;
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
          case 96: {
            GuestUid = input.ReadUInt32();
            break;
          }
          case 104: {
            PlayId = input.ReadUInt32();
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
          case 96: {
            GuestUid = input.ReadUInt32();
            break;
          }
          case 104: {
            PlayId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ScenePlayGuestReplyNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4423,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
