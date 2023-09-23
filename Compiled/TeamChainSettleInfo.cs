// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TeamChainSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TeamChainSettleInfo.proto</summary>
  public static partial class TeamChainSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TeamChainSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TeamChainSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlUZWFtQ2hhaW5TZXR0bGVJbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zInsK",
            "E1RlYW1DaGFpblNldHRsZUluZm8SEgoKZGlmZmljdWx0eRgPIAEoDRIVCg1p",
            "c19uZXdfcmVjb3JkGAQgASgIEhIKCnNjb3JlX2xpc3QYCSADKA0SEAoIc3Rh",
            "Z2VfaWQYDCABKA0SEwoLdG90YWxfc2NvcmUYASABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TeamChainSettleInfo), global::MiHomo.Protos.TeamChainSettleInfo.Parser, new[]{ "Difficulty", "IsNewRecord", "ScoreList", "StageId", "TotalScore" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TeamChainSettleInfo : pb::IMessage<TeamChainSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TeamChainSettleInfo> _parser = new pb::MessageParser<TeamChainSettleInfo>(() => new TeamChainSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TeamChainSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TeamChainSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamChainSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamChainSettleInfo(TeamChainSettleInfo other) : this() {
      difficulty_ = other.difficulty_;
      isNewRecord_ = other.isNewRecord_;
      scoreList_ = other.scoreList_.Clone();
      stageId_ = other.stageId_;
      totalScore_ = other.totalScore_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TeamChainSettleInfo Clone() {
      return new TeamChainSettleInfo(this);
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 15;
    private uint difficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 4;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "score_list" field.</summary>
    public const int ScoreListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_scoreList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> scoreList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ScoreList {
      get { return scoreList_; }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 12;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "total_score" field.</summary>
    public const int TotalScoreFieldNumber = 1;
    private uint totalScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalScore {
      get { return totalScore_; }
      set {
        totalScore_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TeamChainSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TeamChainSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Difficulty != other.Difficulty) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if(!scoreList_.Equals(other.scoreList_)) return false;
      if (StageId != other.StageId) return false;
      if (TotalScore != other.TotalScore) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      hash ^= scoreList_.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (TotalScore != 0) hash ^= TotalScore.GetHashCode();
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
      if (TotalScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TotalScore);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewRecord);
      }
      scoreList_.WriteTo(output, _repeated_scoreList_codec);
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Difficulty);
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
      if (TotalScore != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TotalScore);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsNewRecord);
      }
      scoreList_.WriteTo(ref output, _repeated_scoreList_codec);
      if (StageId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(StageId);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Difficulty);
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
      if (Difficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      size += scoreList_.CalculateSize(_repeated_scoreList_codec);
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (TotalScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalScore);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TeamChainSettleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Difficulty != 0) {
        Difficulty = other.Difficulty;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      scoreList_.Add(other.scoreList_);
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.TotalScore != 0) {
        TotalScore = other.TotalScore;
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
            TotalScore = input.ReadUInt32();
            break;
          }
          case 32: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            scoreList_.AddEntriesFrom(input, _repeated_scoreList_codec);
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 120: {
            Difficulty = input.ReadUInt32();
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
            TotalScore = input.ReadUInt32();
            break;
          }
          case 32: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 74:
          case 72: {
            scoreList_.AddEntriesFrom(ref input, _repeated_scoreList_codec);
            break;
          }
          case 96: {
            StageId = input.ReadUInt32();
            break;
          }
          case 120: {
            Difficulty = input.ReadUInt32();
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
