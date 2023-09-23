// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeV2EnterDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EffigyChallengeV2EnterDungeonReq.proto</summary>
  public static partial class EffigyChallengeV2EnterDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyChallengeV2EnterDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyChallengeV2EnterDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZFZmZpZ3lDaGFsbGVuZ2VWMkVudGVyRHVuZ2VvblJlcS5wcm90bxINbWlI",
            "b21vLlByb3RvcyLdAQogRWZmaWd5Q2hhbGxlbmdlVjJFbnRlckR1bmdlb25S",
            "ZXESIQoZY2hhbGxlbmdlX21vZGVfZGlmZmljdWx0eRgHIAEoDRIfChdjaGFs",
            "bGVuZ2VfbW9kZV9za2lsbF9ubxgLIAEoDRIQCghsZXZlbF9pZBgMIAEoDSJj",
            "CgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5F",
            "VF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVOVBABEgwKBkNNRF9J",
            "RBDBtwEaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EffigyChallengeV2EnterDungeonReq), global::MiHomo.Protos.EffigyChallengeV2EnterDungeonReq.Parser, new[]{ "ChallengeModeDifficulty", "ChallengeModeSkillNo", "LevelId" }, null, new[]{ typeof(global::MiHomo.Protos.EffigyChallengeV2EnterDungeonReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyChallengeV2EnterDungeonReq : pb::IMessage<EffigyChallengeV2EnterDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyChallengeV2EnterDungeonReq> _parser = new pb::MessageParser<EffigyChallengeV2EnterDungeonReq>(() => new EffigyChallengeV2EnterDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyChallengeV2EnterDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EffigyChallengeV2EnterDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2EnterDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2EnterDungeonReq(EffigyChallengeV2EnterDungeonReq other) : this() {
      challengeModeDifficulty_ = other.challengeModeDifficulty_;
      challengeModeSkillNo_ = other.challengeModeSkillNo_;
      levelId_ = other.levelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2EnterDungeonReq Clone() {
      return new EffigyChallengeV2EnterDungeonReq(this);
    }

    /// <summary>Field number for the "challenge_mode_difficulty" field.</summary>
    public const int ChallengeModeDifficultyFieldNumber = 7;
    private uint challengeModeDifficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeModeDifficulty {
      get { return challengeModeDifficulty_; }
      set {
        challengeModeDifficulty_ = value;
      }
    }

    /// <summary>Field number for the "challenge_mode_skill_no" field.</summary>
    public const int ChallengeModeSkillNoFieldNumber = 11;
    private uint challengeModeSkillNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeModeSkillNo {
      get { return challengeModeSkillNo_; }
      set {
        challengeModeSkillNo_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 12;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EffigyChallengeV2EnterDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyChallengeV2EnterDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeModeDifficulty != other.ChallengeModeDifficulty) return false;
      if (ChallengeModeSkillNo != other.ChallengeModeSkillNo) return false;
      if (LevelId != other.LevelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeModeDifficulty != 0) hash ^= ChallengeModeDifficulty.GetHashCode();
      if (ChallengeModeSkillNo != 0) hash ^= ChallengeModeSkillNo.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
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
      if (ChallengeModeDifficulty != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeModeDifficulty);
      }
      if (ChallengeModeSkillNo != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ChallengeModeSkillNo);
      }
      if (LevelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LevelId);
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
      if (ChallengeModeDifficulty != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeModeDifficulty);
      }
      if (ChallengeModeSkillNo != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ChallengeModeSkillNo);
      }
      if (LevelId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LevelId);
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
      if (ChallengeModeDifficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeDifficulty);
      }
      if (ChallengeModeSkillNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeSkillNo);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EffigyChallengeV2EnterDungeonReq other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeModeDifficulty != 0) {
        ChallengeModeDifficulty = other.ChallengeModeDifficulty;
      }
      if (other.ChallengeModeSkillNo != 0) {
        ChallengeModeSkillNo = other.ChallengeModeSkillNo;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
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
          case 56: {
            ChallengeModeDifficulty = input.ReadUInt32();
            break;
          }
          case 88: {
            ChallengeModeSkillNo = input.ReadUInt32();
            break;
          }
          case 96: {
            LevelId = input.ReadUInt32();
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
          case 56: {
            ChallengeModeDifficulty = input.ReadUInt32();
            break;
          }
          case 88: {
            ChallengeModeSkillNo = input.ReadUInt32();
            break;
          }
          case 96: {
            LevelId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EffigyChallengeV2EnterDungeonReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 23489,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
