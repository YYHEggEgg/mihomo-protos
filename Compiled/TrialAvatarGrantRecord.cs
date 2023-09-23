// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrialAvatarGrantRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TrialAvatarGrantRecord.proto</summary>
  public static partial class TrialAvatarGrantRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for TrialAvatarGrantRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrialAvatarGrantRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxUcmlhbEF2YXRhckdyYW50UmVjb3JkLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "Iv4DChZUcmlhbEF2YXRhckdyYW50UmVjb3JkEhwKFGZyb21fcGFyZW50X3F1",
            "ZXN0X2lkGAIgASgNEhQKDGdyYW50X3JlYXNvbhgBIAEoDSKvAwoLR3JhbnRS",
            "ZWFzb24SCwoHSU5WQUxJRBAAEhIKDkdSQU5UX0JZX1FVRVNUEAESIgoeR1JB",
            "TlRfQllfVFJJQUxfQVZBVEFSX0FDVElWSVRZEAISJgoiR1JBTlRfQllfRFVO",
            "R0VPTl9FTEVNRU5UX0NIQUxMRU5HRRADEiAKHEdSQU5UX0JZX01JU1RfVFJJ",
            "QUxfQUNUSVZJVFkQBBIaChZHUkFOVF9CWV9TVU1PX0FDVElWSVRZEAUSHAoY",
            "R1JBTlRfQllfUE9USU9OX0FDVElWSVRZEAYSIgoeR1JBTlRfQllfQ1JZU1RB",
            "TF9MSU5LX0FDVElWSVRZEAcSGwoXR1JBTlRfQllfSVJPRE9SSV9NQVNURVIQ",
            "CBIPCgtHUkFOVF9CWV9HTRAJEiQKIEdSQU5UX0JZX0lOU1RBQkxFX1NQUkFZ",
            "X0FDVElWSVRZEAoSJAogR1JBTlRfQllfTVVRQURBU19QT1RJT05fQUNUSVZJ",
            "VFkQCxIcChhHUkFOVF9CWV9WSU5UQUdFX0hVTlRJTkcQDBIbChdHUkFOVF9C",
            "WV9DSEFSX0FNVVNFTUVOVBANYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TrialAvatarGrantRecord), global::MiHomo.Protos.TrialAvatarGrantRecord.Parser, new[]{ "FromParentQuestId", "GrantReason" }, null, new[]{ typeof(global::MiHomo.Protos.TrialAvatarGrantRecord.Types.GrantReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrialAvatarGrantRecord : pb::IMessage<TrialAvatarGrantRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrialAvatarGrantRecord> _parser = new pb::MessageParser<TrialAvatarGrantRecord>(() => new TrialAvatarGrantRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrialAvatarGrantRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TrialAvatarGrantRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarGrantRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarGrantRecord(TrialAvatarGrantRecord other) : this() {
      fromParentQuestId_ = other.fromParentQuestId_;
      grantReason_ = other.grantReason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarGrantRecord Clone() {
      return new TrialAvatarGrantRecord(this);
    }

    /// <summary>Field number for the "from_parent_quest_id" field.</summary>
    public const int FromParentQuestIdFieldNumber = 2;
    private uint fromParentQuestId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FromParentQuestId {
      get { return fromParentQuestId_; }
      set {
        fromParentQuestId_ = value;
      }
    }

    /// <summary>Field number for the "grant_reason" field.</summary>
    public const int GrantReasonFieldNumber = 1;
    private uint grantReason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GrantReason {
      get { return grantReason_; }
      set {
        grantReason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrialAvatarGrantRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrialAvatarGrantRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FromParentQuestId != other.FromParentQuestId) return false;
      if (GrantReason != other.GrantReason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FromParentQuestId != 0) hash ^= FromParentQuestId.GetHashCode();
      if (GrantReason != 0) hash ^= GrantReason.GetHashCode();
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
      if (GrantReason != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GrantReason);
      }
      if (FromParentQuestId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FromParentQuestId);
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
      if (GrantReason != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GrantReason);
      }
      if (FromParentQuestId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FromParentQuestId);
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
      if (FromParentQuestId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FromParentQuestId);
      }
      if (GrantReason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GrantReason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrialAvatarGrantRecord other) {
      if (other == null) {
        return;
      }
      if (other.FromParentQuestId != 0) {
        FromParentQuestId = other.FromParentQuestId;
      }
      if (other.GrantReason != 0) {
        GrantReason = other.GrantReason;
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
            GrantReason = input.ReadUInt32();
            break;
          }
          case 16: {
            FromParentQuestId = input.ReadUInt32();
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
            GrantReason = input.ReadUInt32();
            break;
          }
          case 16: {
            FromParentQuestId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TrialAvatarGrantRecord message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum GrantReason {
        [pbr::OriginalName("INVALID")] Invalid = 0,
        [pbr::OriginalName("GRANT_BY_QUEST")] GrantByQuest = 1,
        [pbr::OriginalName("GRANT_BY_TRIAL_AVATAR_ACTIVITY")] GrantByTrialAvatarActivity = 2,
        [pbr::OriginalName("GRANT_BY_DUNGEON_ELEMENT_CHALLENGE")] GrantByDungeonElementChallenge = 3,
        [pbr::OriginalName("GRANT_BY_MIST_TRIAL_ACTIVITY")] GrantByMistTrialActivity = 4,
        [pbr::OriginalName("GRANT_BY_SUMO_ACTIVITY")] GrantBySumoActivity = 5,
        [pbr::OriginalName("GRANT_BY_POTION_ACTIVITY")] GrantByPotionActivity = 6,
        [pbr::OriginalName("GRANT_BY_CRYSTAL_LINK_ACTIVITY")] GrantByCrystalLinkActivity = 7,
        [pbr::OriginalName("GRANT_BY_IRODORI_MASTER")] GrantByIrodoriMaster = 8,
        [pbr::OriginalName("GRANT_BY_GM")] GrantByGm = 9,
        [pbr::OriginalName("GRANT_BY_INSTABLE_SPRAY_ACTIVITY")] GrantByInstableSprayActivity = 10,
        [pbr::OriginalName("GRANT_BY_MUQADAS_POTION_ACTIVITY")] GrantByMuqadasPotionActivity = 11,
        [pbr::OriginalName("GRANT_BY_VINTAGE_HUNTING")] GrantByVintageHunting = 12,
        [pbr::OriginalName("GRANT_BY_CHAR_AMUSEMENT")] GrantByCharAmusement = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
