// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonCandidateTeamPlayerLeaveNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DungeonCandidateTeamPlayerLeaveNotify.proto</summary>
  public static partial class DungeonCandidateTeamPlayerLeaveNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonCandidateTeamPlayerLeaveNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonCandidateTeamPlayerLeaveNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitEdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXllckxlYXZlTm90aWZ5LnByb3Rv",
            "Eg1taUhvbW8uUHJvdG9zGitEdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXllckxl",
            "YXZlUmVhc29uLnByb3RvIoEBCiVEdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXll",
            "ckxlYXZlTm90aWZ5EhIKCnBsYXllcl91aWQYByABKA0SRAoGcmVhc29uGAEg",
            "ASgOMjQubWlIb21vLlByb3Rvcy5EdW5nZW9uQ2FuZGlkYXRlVGVhbVBsYXll",
            "ckxlYXZlUmVhc29uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveNotify), global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveNotify.Parser, new[]{ "PlayerUid", "Reason" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonCandidateTeamPlayerLeaveNotify : pb::IMessage<DungeonCandidateTeamPlayerLeaveNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonCandidateTeamPlayerLeaveNotify> _parser = new pb::MessageParser<DungeonCandidateTeamPlayerLeaveNotify>(() => new DungeonCandidateTeamPlayerLeaveNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonCandidateTeamPlayerLeaveNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamPlayerLeaveNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamPlayerLeaveNotify(DungeonCandidateTeamPlayerLeaveNotify other) : this() {
      playerUid_ = other.playerUid_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonCandidateTeamPlayerLeaveNotify Clone() {
      return new DungeonCandidateTeamPlayerLeaveNotify(this);
    }

    /// <summary>Field number for the "player_uid" field.</summary>
    public const int PlayerUidFieldNumber = 7;
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
    public const int ReasonFieldNumber = 1;
    private global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason reason_ = global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason.TplrNormal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonCandidateTeamPlayerLeaveNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonCandidateTeamPlayerLeaveNotify other) {
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
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason.TplrNormal) hash ^= Reason.GetHashCode();
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
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason.TplrNormal) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      if (PlayerUid != 0) {
        output.WriteRawTag(56);
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
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason.TplrNormal) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      if (PlayerUid != 0) {
        output.WriteRawTag(56);
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
      if (Reason != global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason.TplrNormal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonCandidateTeamPlayerLeaveNotify other) {
      if (other == null) {
        return;
      }
      if (other.PlayerUid != 0) {
        PlayerUid = other.PlayerUid;
      }
      if (other.Reason != global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason.TplrNormal) {
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
          case 8: {
            Reason = (global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason) input.ReadEnum();
            break;
          }
          case 56: {
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
          case 8: {
            Reason = (global::MiHomo.Protos.DungeonCandidateTeamPlayerLeaveReason) input.ReadEnum();
            break;
          }
          case 56: {
            PlayerUid = input.ReadUInt32();
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
