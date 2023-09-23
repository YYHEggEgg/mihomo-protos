// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EffigyChallengeV2LevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EffigyChallengeV2LevelData.proto</summary>
  public static partial class EffigyChallengeV2LevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for EffigyChallengeV2LevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EffigyChallengeV2LevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBFZmZpZ3lDaGFsbGVuZ2VWMkxldmVsRGF0YS5wcm90bxINbWlIb21vLlBy",
            "b3RvcyLaAQoaRWZmaWd5Q2hhbGxlbmdlVjJMZXZlbERhdGESFgoOYmVzdF9j",
            "b3N0X3RpbWUYDCABKA0SJgoeY2hhbGxlbmdlX21vZGVfZGlmZmljdWx0eV9v",
            "cGVuGA0gASgNEiYKHmNoYWxsZW5nZV9tb2RlX2RpZmZpY3VsdHlfcGFzcxgB",
            "IAEoDRIrCiNjaGFsbGVuZ2VfbW9kZV9sYXN0X2Nob29zZV9za2lsbF9ubxgK",
            "IAEoDRIVCg1pc19sZXZlbF9vcGVuGAcgASgIEhAKCGxldmVsX2lkGAUgASgN",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EffigyChallengeV2LevelData), global::MiHomo.Protos.EffigyChallengeV2LevelData.Parser, new[]{ "BestCostTime", "ChallengeModeDifficultyOpen", "ChallengeModeDifficultyPass", "ChallengeModeLastChooseSkillNo", "IsLevelOpen", "LevelId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EffigyChallengeV2LevelData : pb::IMessage<EffigyChallengeV2LevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EffigyChallengeV2LevelData> _parser = new pb::MessageParser<EffigyChallengeV2LevelData>(() => new EffigyChallengeV2LevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EffigyChallengeV2LevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EffigyChallengeV2LevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2LevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2LevelData(EffigyChallengeV2LevelData other) : this() {
      bestCostTime_ = other.bestCostTime_;
      challengeModeDifficultyOpen_ = other.challengeModeDifficultyOpen_;
      challengeModeDifficultyPass_ = other.challengeModeDifficultyPass_;
      challengeModeLastChooseSkillNo_ = other.challengeModeLastChooseSkillNo_;
      isLevelOpen_ = other.isLevelOpen_;
      levelId_ = other.levelId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EffigyChallengeV2LevelData Clone() {
      return new EffigyChallengeV2LevelData(this);
    }

    /// <summary>Field number for the "best_cost_time" field.</summary>
    public const int BestCostTimeFieldNumber = 12;
    private uint bestCostTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BestCostTime {
      get { return bestCostTime_; }
      set {
        bestCostTime_ = value;
      }
    }

    /// <summary>Field number for the "challenge_mode_difficulty_open" field.</summary>
    public const int ChallengeModeDifficultyOpenFieldNumber = 13;
    private uint challengeModeDifficultyOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeModeDifficultyOpen {
      get { return challengeModeDifficultyOpen_; }
      set {
        challengeModeDifficultyOpen_ = value;
      }
    }

    /// <summary>Field number for the "challenge_mode_difficulty_pass" field.</summary>
    public const int ChallengeModeDifficultyPassFieldNumber = 1;
    private uint challengeModeDifficultyPass_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeModeDifficultyPass {
      get { return challengeModeDifficultyPass_; }
      set {
        challengeModeDifficultyPass_ = value;
      }
    }

    /// <summary>Field number for the "challenge_mode_last_choose_skill_no" field.</summary>
    public const int ChallengeModeLastChooseSkillNoFieldNumber = 10;
    private uint challengeModeLastChooseSkillNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeModeLastChooseSkillNo {
      get { return challengeModeLastChooseSkillNo_; }
      set {
        challengeModeLastChooseSkillNo_ = value;
      }
    }

    /// <summary>Field number for the "is_level_open" field.</summary>
    public const int IsLevelOpenFieldNumber = 7;
    private bool isLevelOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsLevelOpen {
      get { return isLevelOpen_; }
      set {
        isLevelOpen_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 5;
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
      return Equals(other as EffigyChallengeV2LevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EffigyChallengeV2LevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BestCostTime != other.BestCostTime) return false;
      if (ChallengeModeDifficultyOpen != other.ChallengeModeDifficultyOpen) return false;
      if (ChallengeModeDifficultyPass != other.ChallengeModeDifficultyPass) return false;
      if (ChallengeModeLastChooseSkillNo != other.ChallengeModeLastChooseSkillNo) return false;
      if (IsLevelOpen != other.IsLevelOpen) return false;
      if (LevelId != other.LevelId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BestCostTime != 0) hash ^= BestCostTime.GetHashCode();
      if (ChallengeModeDifficultyOpen != 0) hash ^= ChallengeModeDifficultyOpen.GetHashCode();
      if (ChallengeModeDifficultyPass != 0) hash ^= ChallengeModeDifficultyPass.GetHashCode();
      if (ChallengeModeLastChooseSkillNo != 0) hash ^= ChallengeModeLastChooseSkillNo.GetHashCode();
      if (IsLevelOpen != false) hash ^= IsLevelOpen.GetHashCode();
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
      if (ChallengeModeDifficultyPass != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeModeDifficultyPass);
      }
      if (LevelId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LevelId);
      }
      if (IsLevelOpen != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsLevelOpen);
      }
      if (ChallengeModeLastChooseSkillNo != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeModeLastChooseSkillNo);
      }
      if (BestCostTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BestCostTime);
      }
      if (ChallengeModeDifficultyOpen != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeModeDifficultyOpen);
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
      if (ChallengeModeDifficultyPass != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeModeDifficultyPass);
      }
      if (LevelId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(LevelId);
      }
      if (IsLevelOpen != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsLevelOpen);
      }
      if (ChallengeModeLastChooseSkillNo != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ChallengeModeLastChooseSkillNo);
      }
      if (BestCostTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BestCostTime);
      }
      if (ChallengeModeDifficultyOpen != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeModeDifficultyOpen);
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
      if (BestCostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BestCostTime);
      }
      if (ChallengeModeDifficultyOpen != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeDifficultyOpen);
      }
      if (ChallengeModeDifficultyPass != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeDifficultyPass);
      }
      if (ChallengeModeLastChooseSkillNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeModeLastChooseSkillNo);
      }
      if (IsLevelOpen != false) {
        size += 1 + 1;
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
    public void MergeFrom(EffigyChallengeV2LevelData other) {
      if (other == null) {
        return;
      }
      if (other.BestCostTime != 0) {
        BestCostTime = other.BestCostTime;
      }
      if (other.ChallengeModeDifficultyOpen != 0) {
        ChallengeModeDifficultyOpen = other.ChallengeModeDifficultyOpen;
      }
      if (other.ChallengeModeDifficultyPass != 0) {
        ChallengeModeDifficultyPass = other.ChallengeModeDifficultyPass;
      }
      if (other.ChallengeModeLastChooseSkillNo != 0) {
        ChallengeModeLastChooseSkillNo = other.ChallengeModeLastChooseSkillNo;
      }
      if (other.IsLevelOpen != false) {
        IsLevelOpen = other.IsLevelOpen;
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
          case 8: {
            ChallengeModeDifficultyPass = input.ReadUInt32();
            break;
          }
          case 40: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsLevelOpen = input.ReadBool();
            break;
          }
          case 80: {
            ChallengeModeLastChooseSkillNo = input.ReadUInt32();
            break;
          }
          case 96: {
            BestCostTime = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeModeDifficultyOpen = input.ReadUInt32();
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
            ChallengeModeDifficultyPass = input.ReadUInt32();
            break;
          }
          case 40: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsLevelOpen = input.ReadBool();
            break;
          }
          case 80: {
            ChallengeModeLastChooseSkillNo = input.ReadUInt32();
            break;
          }
          case 96: {
            BestCostTime = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeModeDifficultyOpen = input.ReadUInt32();
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
