// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerApplyEnterMpResultNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlayerApplyEnterMpResultNotify.proto</summary>
  public static partial class PlayerApplyEnterMpResultNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerApplyEnterMpResultNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerApplyEnterMpResultNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQbGF5ZXJBcHBseUVudGVyTXBSZXN1bHROb3RpZnkucHJvdG8SDW1pSG9t",
            "by5Qcm90b3Mi6AQKHlBsYXllckFwcGx5RW50ZXJNcFJlc3VsdE5vdGlmeRIR",
            "Cglpc19hZ3JlZWQYAiABKAgSRAoGcmVhc29uGA0gASgOMjQubWlIb21vLlBy",
            "b3Rvcy5QbGF5ZXJBcHBseUVudGVyTXBSZXN1bHROb3RpZnkuUmVhc29uEhcK",
            "D3RhcmdldF9uaWNrbmFtZRgMIAEoCRISCgp0YXJnZXRfdWlkGAEgASgNIk0K",
            "BUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVU",
            "X0lTX1JFTElBQkxFEAESCwoGQ01EX0lEEI8OGgIQASLwAgoGUmVhc29uEhAK",
            "DFBMQVlFUl9KVURHRRAAEhYKElNDRU5FX0NBTk5PVF9FTlRFUhABEhoKFlBM",
            "QVlFUl9DQU5OT1RfRU5URVJfTVAQAhIQCgxTWVNURU1fSlVER0UQAxIbChdB",
            "TExPV19FTlRFUl9QTEFZRVJfRlVMTBAEEh8KG1dPUkxEX0xFVkVMX0xPV0VS",
            "X1RIQU5fSE9TVBAFEhEKDUhPU1RfSU5fTUFUQ0gQBhIXChNQTEFZRVJfSU5f",
            "QkxBQ0tMSVNUEAcSHwobUFNfUExBWUVSX05PVF9BQ0NFUFRfT1RIRVJTEAgS",
            "EwoPSE9TVF9JU19CTE9DS0VEEAkSIQodT1RIRVJfREFUQV9WRVJTSU9OX05P",
            "VF9MQVRFU1QQChIbChdEQVRBX1ZFUlNJT05fTk9UX0xBVEVTVBALEh4KGlBM",
            "QVlFUl9OT1RfSU5fUExBWUVSX1dPUkxEEAwSDgoKTUFYX1BMQVlFUhANYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlayerApplyEnterMpResultNotify), global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Parser, new[]{ "IsAgreed", "Reason", "TargetNickname", "TargetUid" }, null, new[]{ typeof(global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.CmdId), typeof(global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerApplyEnterMpResultNotify : pb::IMessage<PlayerApplyEnterMpResultNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerApplyEnterMpResultNotify> _parser = new pb::MessageParser<PlayerApplyEnterMpResultNotify>(() => new PlayerApplyEnterMpResultNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerApplyEnterMpResultNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlayerApplyEnterMpResultNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpResultNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpResultNotify(PlayerApplyEnterMpResultNotify other) : this() {
      isAgreed_ = other.isAgreed_;
      reason_ = other.reason_;
      targetNickname_ = other.targetNickname_;
      targetUid_ = other.targetUid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerApplyEnterMpResultNotify Clone() {
      return new PlayerApplyEnterMpResultNotify(this);
    }

    /// <summary>Field number for the "is_agreed" field.</summary>
    public const int IsAgreedFieldNumber = 2;
    private bool isAgreed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAgreed {
      get { return isAgreed_; }
      set {
        isAgreed_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 13;
    private global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason reason_ = global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason.PlayerJudge;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "target_nickname" field.</summary>
    public const int TargetNicknameFieldNumber = 12;
    private string targetNickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TargetNickname {
      get { return targetNickname_; }
      set {
        targetNickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_uid" field.</summary>
    public const int TargetUidFieldNumber = 1;
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
      return Equals(other as PlayerApplyEnterMpResultNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerApplyEnterMpResultNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAgreed != other.IsAgreed) return false;
      if (Reason != other.Reason) return false;
      if (TargetNickname != other.TargetNickname) return false;
      if (TargetUid != other.TargetUid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAgreed != false) hash ^= IsAgreed.GetHashCode();
      if (Reason != global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason.PlayerJudge) hash ^= Reason.GetHashCode();
      if (TargetNickname.Length != 0) hash ^= TargetNickname.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(TargetUid);
      }
      if (IsAgreed != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsAgreed);
      }
      if (TargetNickname.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(TargetNickname);
      }
      if (Reason != global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason.PlayerJudge) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Reason);
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
        output.WriteRawTag(8);
        output.WriteUInt32(TargetUid);
      }
      if (IsAgreed != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsAgreed);
      }
      if (TargetNickname.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(TargetNickname);
      }
      if (Reason != global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason.PlayerJudge) {
        output.WriteRawTag(104);
        output.WriteEnum((int) Reason);
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
      if (IsAgreed != false) {
        size += 1 + 1;
      }
      if (Reason != global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason.PlayerJudge) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (TargetNickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TargetNickname);
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
    public void MergeFrom(PlayerApplyEnterMpResultNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsAgreed != false) {
        IsAgreed = other.IsAgreed;
      }
      if (other.Reason != global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason.PlayerJudge) {
        Reason = other.Reason;
      }
      if (other.TargetNickname.Length != 0) {
        TargetNickname = other.TargetNickname;
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
          case 8: {
            TargetUid = input.ReadUInt32();
            break;
          }
          case 16: {
            IsAgreed = input.ReadBool();
            break;
          }
          case 98: {
            TargetNickname = input.ReadString();
            break;
          }
          case 104: {
            Reason = (global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason) input.ReadEnum();
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
            TargetUid = input.ReadUInt32();
            break;
          }
          case 16: {
            IsAgreed = input.ReadBool();
            break;
          }
          case 98: {
            TargetNickname = input.ReadString();
            break;
          }
          case 104: {
            Reason = (global::MiHomo.Protos.PlayerApplyEnterMpResultNotify.Types.Reason) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PlayerApplyEnterMpResultNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1807,
      }

      public enum Reason {
        [pbr::OriginalName("PLAYER_JUDGE")] PlayerJudge = 0,
        [pbr::OriginalName("SCENE_CANNOT_ENTER")] SceneCannotEnter = 1,
        [pbr::OriginalName("PLAYER_CANNOT_ENTER_MP")] PlayerCannotEnterMp = 2,
        [pbr::OriginalName("SYSTEM_JUDGE")] SystemJudge = 3,
        [pbr::OriginalName("ALLOW_ENTER_PLAYER_FULL")] AllowEnterPlayerFull = 4,
        [pbr::OriginalName("WORLD_LEVEL_LOWER_THAN_HOST")] WorldLevelLowerThanHost = 5,
        [pbr::OriginalName("HOST_IN_MATCH")] HostInMatch = 6,
        [pbr::OriginalName("PLAYER_IN_BLACKLIST")] PlayerInBlacklist = 7,
        [pbr::OriginalName("PS_PLAYER_NOT_ACCEPT_OTHERS")] PsPlayerNotAcceptOthers = 8,
        [pbr::OriginalName("HOST_IS_BLOCKED")] HostIsBlocked = 9,
        [pbr::OriginalName("OTHER_DATA_VERSION_NOT_LATEST")] OtherDataVersionNotLatest = 10,
        [pbr::OriginalName("DATA_VERSION_NOT_LATEST")] DataVersionNotLatest = 11,
        [pbr::OriginalName("PLAYER_NOT_IN_PLAYER_WORLD")] PlayerNotInPlayerWorld = 12,
        [pbr::OriginalName("MAX_PLAYER")] MaxPlayer = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
