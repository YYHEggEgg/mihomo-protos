// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGDuelExtra.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGDuelExtra.proto</summary>
  public static partial class GCGDuelExtraReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGDuelExtra.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGDuelExtraReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHQ0dEdWVsRXh0cmEucHJvdG8SDW1pSG9tby5Qcm90b3MaFkdDR0NoYWxs",
            "ZW5nZURhdGEucHJvdG8imAMKDEdDR0R1ZWxFeHRyYRISCgphaV9kZWNrX2lk",
            "GAggASgNEhQKDGNhcmRfYmFja19pZBgDIAEoDRIUCgxjYXJkX2lkX2xpc3QY",
            "ASADKA0SNwoOY2hhbGxlbmdlX2xpc3QYBSADKAsyHy5taUhvbW8uUHJvdG9z",
            "LkdDR0NoYWxsZW5nZURhdGESFgoOY2xpZW50X3ZlcnNpb24YDCABKA0SEAoI",
            "ZmllbGRfaWQYAiABKA0SJAocZm9yYmlkX2ZpbmlzaF9jaGFsbGVuZ2VfbGlz",
            "dBgKIAMoDRITCgtpc19pbnRlcm5hbBgJIAEoCBITCgtpc19tYXRjaF9haRgH",
            "IAEoCBINCgVsZXZlbBgLIAEoDRINCgVzY29yZRgGIAEoDRJDCg1jYXJkX2Zh",
            "Y2VfbWFwGAQgAygLMiwubWlIb21vLlByb3Rvcy5HQ0dEdWVsRXh0cmEuQ2Fy",
            "ZEZhY2VNYXBFbnRyeRoyChBDYXJkRmFjZU1hcEVudHJ5EgsKA2tleRgBIAEo",
            "DRINCgV2YWx1ZRgCIAEoDToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GCGChallengeDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GCGDuelExtra), global::MiHomo.Protos.GCGDuelExtra.Parser, new[]{ "AiDeckId", "CardBackId", "CardIdList", "ChallengeList", "ClientVersion", "FieldId", "ForbidFinishChallengeList", "IsInternal", "IsMatchAi", "Level", "Score", "CardFaceMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGDuelExtra : pb::IMessage<GCGDuelExtra>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGDuelExtra> _parser = new pb::MessageParser<GCGDuelExtra>(() => new GCGDuelExtra());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGDuelExtra> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GCGDuelExtraReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuelExtra() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuelExtra(GCGDuelExtra other) : this() {
      aiDeckId_ = other.aiDeckId_;
      cardBackId_ = other.cardBackId_;
      cardIdList_ = other.cardIdList_.Clone();
      challengeList_ = other.challengeList_.Clone();
      clientVersion_ = other.clientVersion_;
      fieldId_ = other.fieldId_;
      forbidFinishChallengeList_ = other.forbidFinishChallengeList_.Clone();
      isInternal_ = other.isInternal_;
      isMatchAi_ = other.isMatchAi_;
      level_ = other.level_;
      score_ = other.score_;
      cardFaceMap_ = other.cardFaceMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGDuelExtra Clone() {
      return new GCGDuelExtra(this);
    }

    /// <summary>Field number for the "ai_deck_id" field.</summary>
    public const int AiDeckIdFieldNumber = 8;
    private uint aiDeckId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AiDeckId {
      get { return aiDeckId_; }
      set {
        aiDeckId_ = value;
      }
    }

    /// <summary>Field number for the "card_back_id" field.</summary>
    public const int CardBackIdFieldNumber = 3;
    private uint cardBackId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardBackId {
      get { return cardBackId_; }
      set {
        cardBackId_ = value;
      }
    }

    /// <summary>Field number for the "card_id_list" field.</summary>
    public const int CardIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_cardIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> cardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardIdList {
      get { return cardIdList_; }
    }

    /// <summary>Field number for the "challenge_list" field.</summary>
    public const int ChallengeListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.GCGChallengeData> _repeated_challengeList_codec
        = pb::FieldCodec.ForMessage(42, global::MiHomo.Protos.GCGChallengeData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.GCGChallengeData> challengeList_ = new pbc::RepeatedField<global::MiHomo.Protos.GCGChallengeData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.GCGChallengeData> ChallengeList {
      get { return challengeList_; }
    }

    /// <summary>Field number for the "client_version" field.</summary>
    public const int ClientVersionFieldNumber = 12;
    private uint clientVersion_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ClientVersion {
      get { return clientVersion_; }
      set {
        clientVersion_ = value;
      }
    }

    /// <summary>Field number for the "field_id" field.</summary>
    public const int FieldIdFieldNumber = 2;
    private uint fieldId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FieldId {
      get { return fieldId_; }
      set {
        fieldId_ = value;
      }
    }

    /// <summary>Field number for the "forbid_finish_challenge_list" field.</summary>
    public const int ForbidFinishChallengeListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_forbidFinishChallengeList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> forbidFinishChallengeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ForbidFinishChallengeList {
      get { return forbidFinishChallengeList_; }
    }

    /// <summary>Field number for the "is_internal" field.</summary>
    public const int IsInternalFieldNumber = 9;
    private bool isInternal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInternal {
      get { return isInternal_; }
      set {
        isInternal_ = value;
      }
    }

    /// <summary>Field number for the "is_match_ai" field.</summary>
    public const int IsMatchAiFieldNumber = 7;
    private bool isMatchAi_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMatchAi {
      get { return isMatchAi_; }
      set {
        isMatchAi_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 11;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 6;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "card_face_map" field.</summary>
    public const int CardFaceMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, uint>.Codec _map_cardFaceMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 34);
    private readonly pbc::MapField<uint, uint> cardFaceMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> CardFaceMap {
      get { return cardFaceMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGDuelExtra);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGDuelExtra other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AiDeckId != other.AiDeckId) return false;
      if (CardBackId != other.CardBackId) return false;
      if(!cardIdList_.Equals(other.cardIdList_)) return false;
      if(!challengeList_.Equals(other.challengeList_)) return false;
      if (ClientVersion != other.ClientVersion) return false;
      if (FieldId != other.FieldId) return false;
      if(!forbidFinishChallengeList_.Equals(other.forbidFinishChallengeList_)) return false;
      if (IsInternal != other.IsInternal) return false;
      if (IsMatchAi != other.IsMatchAi) return false;
      if (Level != other.Level) return false;
      if (Score != other.Score) return false;
      if (!CardFaceMap.Equals(other.CardFaceMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AiDeckId != 0) hash ^= AiDeckId.GetHashCode();
      if (CardBackId != 0) hash ^= CardBackId.GetHashCode();
      hash ^= cardIdList_.GetHashCode();
      hash ^= challengeList_.GetHashCode();
      if (ClientVersion != 0) hash ^= ClientVersion.GetHashCode();
      if (FieldId != 0) hash ^= FieldId.GetHashCode();
      hash ^= forbidFinishChallengeList_.GetHashCode();
      if (IsInternal != false) hash ^= IsInternal.GetHashCode();
      if (IsMatchAi != false) hash ^= IsMatchAi.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      hash ^= CardFaceMap.GetHashCode();
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
      cardIdList_.WriteTo(output, _repeated_cardIdList_codec);
      if (FieldId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FieldId);
      }
      if (CardBackId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CardBackId);
      }
      cardFaceMap_.WriteTo(output, _map_cardFaceMap_codec);
      challengeList_.WriteTo(output, _repeated_challengeList_codec);
      if (Score != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Score);
      }
      if (IsMatchAi != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMatchAi);
      }
      if (AiDeckId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AiDeckId);
      }
      if (IsInternal != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsInternal);
      }
      forbidFinishChallengeList_.WriteTo(output, _repeated_forbidFinishChallengeList_codec);
      if (Level != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Level);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ClientVersion);
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
      cardIdList_.WriteTo(ref output, _repeated_cardIdList_codec);
      if (FieldId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FieldId);
      }
      if (CardBackId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(CardBackId);
      }
      cardFaceMap_.WriteTo(ref output, _map_cardFaceMap_codec);
      challengeList_.WriteTo(ref output, _repeated_challengeList_codec);
      if (Score != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Score);
      }
      if (IsMatchAi != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsMatchAi);
      }
      if (AiDeckId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(AiDeckId);
      }
      if (IsInternal != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsInternal);
      }
      forbidFinishChallengeList_.WriteTo(ref output, _repeated_forbidFinishChallengeList_codec);
      if (Level != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Level);
      }
      if (ClientVersion != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ClientVersion);
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
      if (AiDeckId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AiDeckId);
      }
      if (CardBackId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardBackId);
      }
      size += cardIdList_.CalculateSize(_repeated_cardIdList_codec);
      size += challengeList_.CalculateSize(_repeated_challengeList_codec);
      if (ClientVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ClientVersion);
      }
      if (FieldId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FieldId);
      }
      size += forbidFinishChallengeList_.CalculateSize(_repeated_forbidFinishChallengeList_codec);
      if (IsInternal != false) {
        size += 1 + 1;
      }
      if (IsMatchAi != false) {
        size += 1 + 1;
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      size += cardFaceMap_.CalculateSize(_map_cardFaceMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGDuelExtra other) {
      if (other == null) {
        return;
      }
      if (other.AiDeckId != 0) {
        AiDeckId = other.AiDeckId;
      }
      if (other.CardBackId != 0) {
        CardBackId = other.CardBackId;
      }
      cardIdList_.Add(other.cardIdList_);
      challengeList_.Add(other.challengeList_);
      if (other.ClientVersion != 0) {
        ClientVersion = other.ClientVersion;
      }
      if (other.FieldId != 0) {
        FieldId = other.FieldId;
      }
      forbidFinishChallengeList_.Add(other.forbidFinishChallengeList_);
      if (other.IsInternal != false) {
        IsInternal = other.IsInternal;
      }
      if (other.IsMatchAi != false) {
        IsMatchAi = other.IsMatchAi;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      cardFaceMap_.Add(other.cardFaceMap_);
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
          case 10:
          case 8: {
            cardIdList_.AddEntriesFrom(input, _repeated_cardIdList_codec);
            break;
          }
          case 16: {
            FieldId = input.ReadUInt32();
            break;
          }
          case 24: {
            CardBackId = input.ReadUInt32();
            break;
          }
          case 34: {
            cardFaceMap_.AddEntriesFrom(input, _map_cardFaceMap_codec);
            break;
          }
          case 42: {
            challengeList_.AddEntriesFrom(input, _repeated_challengeList_codec);
            break;
          }
          case 48: {
            Score = input.ReadUInt32();
            break;
          }
          case 56: {
            IsMatchAi = input.ReadBool();
            break;
          }
          case 64: {
            AiDeckId = input.ReadUInt32();
            break;
          }
          case 72: {
            IsInternal = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            forbidFinishChallengeList_.AddEntriesFrom(input, _repeated_forbidFinishChallengeList_codec);
            break;
          }
          case 88: {
            Level = input.ReadUInt32();
            break;
          }
          case 96: {
            ClientVersion = input.ReadUInt32();
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
          case 10:
          case 8: {
            cardIdList_.AddEntriesFrom(ref input, _repeated_cardIdList_codec);
            break;
          }
          case 16: {
            FieldId = input.ReadUInt32();
            break;
          }
          case 24: {
            CardBackId = input.ReadUInt32();
            break;
          }
          case 34: {
            cardFaceMap_.AddEntriesFrom(ref input, _map_cardFaceMap_codec);
            break;
          }
          case 42: {
            challengeList_.AddEntriesFrom(ref input, _repeated_challengeList_codec);
            break;
          }
          case 48: {
            Score = input.ReadUInt32();
            break;
          }
          case 56: {
            IsMatchAi = input.ReadBool();
            break;
          }
          case 64: {
            AiDeckId = input.ReadUInt32();
            break;
          }
          case 72: {
            IsInternal = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            forbidFinishChallengeList_.AddEntriesFrom(ref input, _repeated_forbidFinishChallengeList_codec);
            break;
          }
          case 88: {
            Level = input.ReadUInt32();
            break;
          }
          case 96: {
            ClientVersion = input.ReadUInt32();
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
