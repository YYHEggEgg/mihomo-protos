// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonCandidateTeamDismissNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DungeonCandidateTeamDismissNotify.proto</summary>
  public static partial class DungeonCandidateTeamDismissNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonCandidateTeamDismissNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonCandidateTeamDismissNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidEdW5nZW9uQ2FuZGlkYXRlVGVhbURpc21pc3NOb3RpZnkucHJvdG8SDW1p",
            "SG9tby5Qcm90b3MaJ0R1bmdlb25DYW5kaWRhdGVUZWFtRGlzbWlzc1JlYXNv",
            "bi5wcm90byLIAQohRHVuZ2VvbkNhbmRpZGF0ZVRlYW1EaXNtaXNzTm90aWZ5",
            "EhIKCnBsYXllcl91aWQYDCABKA0SQAoGcmVhc29uGAkgASgOMjAubWlIb21v",
            "LlByb3Rvcy5EdW5nZW9uQ2FuZGlkYXRlVGVhbURpc21pc3NSZWFzb24iTQoF",
            "Q21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRf",
            "SVNfUkVMSUFCTEUQARILCgZDTURfSUQQwwcaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.DungeonCandidateTeamDismissReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DungeonCandidateTeamDismissNotify), global::MiHomo.Protos.DungeonCandidateTeamDismissNotify.Parser, new[]{ "PlayerUid", "Reason" }, null, new[]{ typeof(global::MiHomo.Protos.DungeonCandidateTeamDismissNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonCandidateTeamDismissNotify : pb::IMessage<DungeonCandidateTeamDismissNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonCandidateTeamDismissNotify> _parser = new pb::MessageParser<DungeonCandidateTeamDismissNotify>(() => new DungeonCandidateTeamDismissNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonCandidateTeamDismissNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DungeonCandidateTeamDismissNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamDismissNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamDismissNotify(DungeonCandidateTeamDismissNotify other) : this() {
      playerUid_ = other.playerUid_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamDismissNotify Clone() {
      return new DungeonCandidateTeamDismissNotify(this);
    }

    /// <summary>Field number for the "player_uid" field.</summary>
    public const int PlayerUidFieldNumber = 12;
    private uint playerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerUid {
      get { return playerUid_; }
      set {
        playerUid_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 9;
    private global::MiHomo.Protos.DungeonCandidateTeamDismissReason reason_ = global::MiHomo.Protos.DungeonCandidateTeamDismissReason.DungeonCandidateTpdrNormal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.DungeonCandidateTeamDismissReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonCandidateTeamDismissNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonCandidateTeamDismissNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerUid != other.PlayerUid) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerUid != 0) hash ^= PlayerUid.GetHashCode();
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamDismissReason.DungeonCandidateTpdrNormal) hash ^= Reason.GetHashCode();
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
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamDismissReason.DungeonCandidateTpdrNormal) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Reason);
      }
      if (PlayerUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PlayerUid);
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
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamDismissReason.DungeonCandidateTpdrNormal) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Reason);
      }
      if (PlayerUid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(PlayerUid);
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
      if (PlayerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerUid);
      }
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamDismissReason.DungeonCandidateTpdrNormal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonCandidateTeamDismissNotify other) {
      if (other == null) {
        return;
      }
      if (other.PlayerUid != 0) {
        PlayerUid = other.PlayerUid;
      }
      if (other.Reason != global::MiHomo.Protos.DungeonCandidateTeamDismissReason.DungeonCandidateTpdrNormal) {
        Reason = other.Reason;
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
            Reason = (global::MiHomo.Protos.DungeonCandidateTeamDismissReason) input.ReadEnum();
            break;
          }
          case 96: {
            PlayerUid = input.ReadUInt32();
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
            Reason = (global::MiHomo.Protos.DungeonCandidateTeamDismissReason) input.ReadEnum();
            break;
          }
          case 96: {
            PlayerUid = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DungeonCandidateTeamDismissNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 963,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
