// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AskAddFriendNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AskAddFriendNotify.proto</summary>
  public static partial class AskAddFriendNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AskAddFriendNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AskAddFriendNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBc2tBZGRGcmllbmROb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3MaEUZy",
            "aWVuZEJyaWVmLnByb3RvIrABChJBc2tBZGRGcmllbmROb3RpZnkSNwoTdGFy",
            "Z2V0X2ZyaWVuZF9icmllZhgPIAEoCzIaLm1pSG9tby5Qcm90b3MuRnJpZW5k",
            "QnJpZWYSEgoKdGFyZ2V0X3VpZBgJIAEoDSJNCgVDbWRJZBIICgROT05FEAAS",
            "EwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEgsK",
            "BkNNRF9JRBDhHxoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FriendBriefReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AskAddFriendNotify), global::MiHomo.Protos.AskAddFriendNotify.Parser, new[]{ "TargetFriendBrief", "TargetUid" }, null, new[]{ typeof(global::MiHomo.Protos.AskAddFriendNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AskAddFriendNotify : pb::IMessage<AskAddFriendNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AskAddFriendNotify> _parser = new pb::MessageParser<AskAddFriendNotify>(() => new AskAddFriendNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AskAddFriendNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AskAddFriendNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AskAddFriendNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AskAddFriendNotify(AskAddFriendNotify other) : this() {
      targetFriendBrief_ = other.targetFriendBrief_ != null ? other.targetFriendBrief_.Clone() : null;
      targetUid_ = other.targetUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AskAddFriendNotify Clone() {
      return new AskAddFriendNotify(this);
    }

    /// <summary>Field number for the "target_friend_brief" field.</summary>
    public const int TargetFriendBriefFieldNumber = 15;
    private global::MiHomo.Protos.FriendBrief targetFriendBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.FriendBrief TargetFriendBrief {
      get { return targetFriendBrief_; }
      set {
        targetFriendBrief_ = value;
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 9;
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
      return Equals(other as AskAddFriendNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AskAddFriendNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TargetFriendBrief, other.TargetFriendBrief)) return false;
      if (TargetUid != other.TargetUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (targetFriendBrief_ != null) hash ^= TargetFriendBrief.GetHashCode();
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
        output.WriteRawTag(72);
        output.WriteUInt32(TargetUid);
      }
      if (targetFriendBrief_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TargetFriendBrief);
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
        output.WriteRawTag(72);
        output.WriteUInt32(TargetUid);
      }
      if (targetFriendBrief_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(TargetFriendBrief);
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
      if (targetFriendBrief_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetFriendBrief);
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
    public void MergeFrom(AskAddFriendNotify other) {
      if (other == null) {
        return;
      }
      if (other.targetFriendBrief_ != null) {
        if (targetFriendBrief_ == null) {
          TargetFriendBrief = new global::MiHomo.Protos.FriendBrief();
        }
        TargetFriendBrief.MergeFrom(other.TargetFriendBrief);
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
          case 72: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 122: {
            if (targetFriendBrief_ == null) {
              TargetFriendBrief = new global::MiHomo.Protos.FriendBrief();
            }
            input.ReadMessage(TargetFriendBrief);
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
          case 72: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 122: {
            if (targetFriendBrief_ == null) {
              TargetFriendBrief = new global::MiHomo.Protos.FriendBrief();
            }
            input.ReadMessage(TargetFriendBrief);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AskAddFriendNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4065,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
