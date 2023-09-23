// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanternRiteEndFireworksReformRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from LanternRiteEndFireworksReformRsp.proto</summary>
  public static partial class LanternRiteEndFireworksReformRspReflection {

    #region Descriptor
    /// <summary>File descriptor for LanternRiteEndFireworksReformRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanternRiteEndFireworksReformRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZMYW50ZXJuUml0ZUVuZEZpcmV3b3Jrc1JlZm9ybVJzcC5wcm90bxINbWlI",
            "b21vLlByb3RvcyK+AgogTGFudGVyblJpdGVFbmRGaXJld29ya3NSZWZvcm1S",
            "c3ASFAoMY2hhbGxlbmdlX2lkGAUgASgNEhMKC2ZpbmFsX3Njb3JlGA0gASgN",
            "EhUKDWlzX2Z1bGxfc2NvcmUYCiABKAgSFQoNaXNfbmV3X3JlY29yZBgJIAEo",
            "CBIVCg1pc19zdGFtaW5hX3VwGAQgASgIEhsKE2lzX3VubG9ja19maXJld29y",
            "a3MYBiABKAgSGwoTaXNfdW5sb2NrX25ld19za2lsbBgMIAEoCBIPCgdyZXRj",
            "b2RlGAEgASgFEhAKCHN0YWdlX2lkGA8gASgNIk0KBUNtZElkEggKBE5PTkUQ",
            "ABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAES",
            "CwoGQ01EX0lEEOVFGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.LanternRiteEndFireworksReformRsp), global::MiHomo.Protos.LanternRiteEndFireworksReformRsp.Parser, new[]{ "ChallengeId", "FinalScore", "IsFullScore", "IsNewRecord", "IsStaminaUp", "IsUnlockFireworks", "IsUnlockNewSkill", "Retcode", "StageId" }, null, new[]{ typeof(global::MiHomo.Protos.LanternRiteEndFireworksReformRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanternRiteEndFireworksReformRsp : pb::IMessage<LanternRiteEndFireworksReformRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanternRiteEndFireworksReformRsp> _parser = new pb::MessageParser<LanternRiteEndFireworksReformRsp>(() => new LanternRiteEndFireworksReformRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanternRiteEndFireworksReformRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.LanternRiteEndFireworksReformRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteEndFireworksReformRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteEndFireworksReformRsp(LanternRiteEndFireworksReformRsp other) : this() {
      challengeId_ = other.challengeId_;
      finalScore_ = other.finalScore_;
      isFullScore_ = other.isFullScore_;
      isNewRecord_ = other.isNewRecord_;
      isStaminaUp_ = other.isStaminaUp_;
      isUnlockFireworks_ = other.isUnlockFireworks_;
      isUnlockNewSkill_ = other.isUnlockNewSkill_;
      retcode_ = other.retcode_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanternRiteEndFireworksReformRsp Clone() {
      return new LanternRiteEndFireworksReformRsp(this);
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 5;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "final_score" field.</summary>
    public const int FinalScoreFieldNumber = 13;
    private uint finalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinalScore {
      get { return finalScore_; }
      set {
        finalScore_ = value;
      }
    }

    /// <summary>Field number for the "is_full_score" field.</summary>
    public const int IsFullScoreFieldNumber = 10;
    private bool isFullScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFullScore {
      get { return isFullScore_; }
      set {
        isFullScore_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 9;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "is_stamina_up" field.</summary>
    public const int IsStaminaUpFieldNumber = 4;
    private bool isStaminaUp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStaminaUp {
      get { return isStaminaUp_; }
      set {
        isStaminaUp_ = value;
      }
    }

    /// <summary>Field number for the "is_unlock_fireworks" field.</summary>
    public const int IsUnlockFireworksFieldNumber = 6;
    private bool isUnlockFireworks_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlockFireworks {
      get { return isUnlockFireworks_; }
      set {
        isUnlockFireworks_ = value;
      }
    }

    /// <summary>Field number for the "is_unlock_new_skill" field.</summary>
    public const int IsUnlockNewSkillFieldNumber = 12;
    private bool isUnlockNewSkill_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsUnlockNewSkill {
      get { return isUnlockNewSkill_; }
      set {
        isUnlockNewSkill_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 1;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 15;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanternRiteEndFireworksReformRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanternRiteEndFireworksReformRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeId != other.ChallengeId) return false;
      if (FinalScore != other.FinalScore) return false;
      if (IsFullScore != other.IsFullScore) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (IsStaminaUp != other.IsStaminaUp) return false;
      if (IsUnlockFireworks != other.IsUnlockFireworks) return false;
      if (IsUnlockNewSkill != other.IsUnlockNewSkill) return false;
      if (Retcode != other.Retcode) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      if (FinalScore != 0) hash ^= FinalScore.GetHashCode();
      if (IsFullScore != false) hash ^= IsFullScore.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (IsStaminaUp != false) hash ^= IsStaminaUp.GetHashCode();
      if (IsUnlockFireworks != false) hash ^= IsUnlockFireworks.GetHashCode();
      if (IsUnlockNewSkill != false) hash ^= IsUnlockNewSkill.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (IsStaminaUp != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsStaminaUp);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ChallengeId);
      }
      if (IsUnlockFireworks != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsUnlockFireworks);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsNewRecord);
      }
      if (IsFullScore != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsFullScore);
      }
      if (IsUnlockNewSkill != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsUnlockNewSkill);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FinalScore);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
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
      if (Retcode != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Retcode);
      }
      if (IsStaminaUp != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsStaminaUp);
      }
      if (ChallengeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(ChallengeId);
      }
      if (IsUnlockFireworks != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsUnlockFireworks);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsNewRecord);
      }
      if (IsFullScore != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsFullScore);
      }
      if (IsUnlockNewSkill != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsUnlockNewSkill);
      }
      if (FinalScore != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(FinalScore);
      }
      if (StageId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(StageId);
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
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      if (FinalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinalScore);
      }
      if (IsFullScore != false) {
        size += 1 + 1;
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (IsStaminaUp != false) {
        size += 1 + 1;
      }
      if (IsUnlockFireworks != false) {
        size += 1 + 1;
      }
      if (IsUnlockNewSkill != false) {
        size += 1 + 1;
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanternRiteEndFireworksReformRsp other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      if (other.FinalScore != 0) {
        FinalScore = other.FinalScore;
      }
      if (other.IsFullScore != false) {
        IsFullScore = other.IsFullScore;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.IsStaminaUp != false) {
        IsStaminaUp = other.IsStaminaUp;
      }
      if (other.IsUnlockFireworks != false) {
        IsUnlockFireworks = other.IsUnlockFireworks;
      }
      if (other.IsUnlockNewSkill != false) {
        IsUnlockNewSkill = other.IsUnlockNewSkill;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
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
            Retcode = input.ReadInt32();
            break;
          }
          case 32: {
            IsStaminaUp = input.ReadBool();
            break;
          }
          case 40: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsUnlockFireworks = input.ReadBool();
            break;
          }
          case 72: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 80: {
            IsFullScore = input.ReadBool();
            break;
          }
          case 96: {
            IsUnlockNewSkill = input.ReadBool();
            break;
          }
          case 104: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
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
            Retcode = input.ReadInt32();
            break;
          }
          case 32: {
            IsStaminaUp = input.ReadBool();
            break;
          }
          case 40: {
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 48: {
            IsUnlockFireworks = input.ReadBool();
            break;
          }
          case 72: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 80: {
            IsFullScore = input.ReadBool();
            break;
          }
          case 96: {
            IsUnlockNewSkill = input.ReadBool();
            break;
          }
          case 104: {
            FinalScore = input.ReadUInt32();
            break;
          }
          case 120: {
            StageId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the LanternRiteEndFireworksReformRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 8933,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
