// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BrickBreakerSettleNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from BrickBreakerSettleNotify.proto</summary>
  public static partial class BrickBreakerSettleNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BrickBreakerSettleNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrickBreakerSettleNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ccmlja0JyZWFrZXJTZXR0bGVOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaEFVpbnQzMlBhaXIucHJvdG8isQMKGEJyaWNrQnJlYWtlclNldHRsZU5v",
            "dGlmeRINCgVjb21ibxgMIAEoDRISCgpnYWxsZXJ5X2lkGA0gASgNEhIKCmlz",
            "X2R1bmdlb24YAiABKAgSFQoNaXNfbmV3X3JlY29yZBgDIAEoCBIWCg5pc19z",
            "aW5nbGVfbW9kZRgPIAEoCBIQCghsZXZlbF9pZBgLIAEoDRJECgZyZWFzb24Y",
            "ASABKA4yNC5taUhvbW8uUHJvdG9zLkJyaWNrQnJlYWtlclNldHRsZU5vdGlm",
            "eS5TZXR0bGVSZWFzb24SDQoFc2NvcmUYByABKA0SDAoEdGltZRgFIAEoDRI0",
            "ChF1cGRhdGVfc2tpbGxfbGlzdBgEIAMoCzIZLm1pSG9tby5Qcm90b3MuVWlu",
            "dDMyUGFpciKDAQoMU2V0dGxlUmVhc29uEhoKFlNFVFRMRV9SRUFTT05fVElN",
            "RV9PVVQQABIaChZTRVRUTEVfUkVBU09OX1BMQVlfRU5EEAESHQoZU0VUVExF",
            "X1JFQVNPTl9QTEFZRVJfUVVJVBACEhwKGFNFVFRMRV9SRUFTT05fTElGRV9D",
            "T1VOVBADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.BrickBreakerSettleNotify), global::MiHomo.Protos.BrickBreakerSettleNotify.Parser, new[]{ "Combo", "GalleryId", "IsDungeon", "IsNewRecord", "IsSingleMode", "LevelId", "Reason", "Score", "Time", "UpdateSkillList" }, null, new[]{ typeof(global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BrickBreakerSettleNotify : pb::IMessage<BrickBreakerSettleNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BrickBreakerSettleNotify> _parser = new pb::MessageParser<BrickBreakerSettleNotify>(() => new BrickBreakerSettleNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BrickBreakerSettleNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.BrickBreakerSettleNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrickBreakerSettleNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrickBreakerSettleNotify(BrickBreakerSettleNotify other) : this() {
      combo_ = other.combo_;
      galleryId_ = other.galleryId_;
      isDungeon_ = other.isDungeon_;
      isNewRecord_ = other.isNewRecord_;
      isSingleMode_ = other.isSingleMode_;
      levelId_ = other.levelId_;
      reason_ = other.reason_;
      score_ = other.score_;
      time_ = other.time_;
      updateSkillList_ = other.updateSkillList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrickBreakerSettleNotify Clone() {
      return new BrickBreakerSettleNotify(this);
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 12;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 13;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "is_dungeon" field.</summary>
    public const int IsDungeonFieldNumber = 2;
    private bool isDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDungeon {
      get { return isDungeon_; }
      set {
        isDungeon_ = value;
      }
    }

    /// <summary>Field number for the "is_new_record" field.</summary>
    public const int IsNewRecordFieldNumber = 3;
    private bool isNewRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsNewRecord {
      get { return isNewRecord_; }
      set {
        isNewRecord_ = value;
      }
    }

    /// <summary>Field number for the "is_single_mode" field.</summary>
    public const int IsSingleModeFieldNumber = 15;
    private bool isSingleMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSingleMode {
      get { return isSingleMode_; }
      set {
        isSingleMode_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 11;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 1;
    private global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason reason_ = global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason.TimeOut;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 7;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 5;
    private uint time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "update_skill_list" field.</summary>
    public const int UpdateSkillListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.Uint32Pair> _repeated_updateSkillList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair> updateSkillList_ = new pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair> UpdateSkillList {
      get { return updateSkillList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BrickBreakerSettleNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BrickBreakerSettleNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Combo != other.Combo) return false;
      if (GalleryId != other.GalleryId) return false;
      if (IsDungeon != other.IsDungeon) return false;
      if (IsNewRecord != other.IsNewRecord) return false;
      if (IsSingleMode != other.IsSingleMode) return false;
      if (LevelId != other.LevelId) return false;
      if (Reason != other.Reason) return false;
      if (Score != other.Score) return false;
      if (Time != other.Time) return false;
      if(!updateSkillList_.Equals(other.updateSkillList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Combo != 0) hash ^= Combo.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (IsDungeon != false) hash ^= IsDungeon.GetHashCode();
      if (IsNewRecord != false) hash ^= IsNewRecord.GetHashCode();
      if (IsSingleMode != false) hash ^= IsSingleMode.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (Reason != global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason.TimeOut) hash ^= Reason.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Time != 0) hash ^= Time.GetHashCode();
      hash ^= updateSkillList_.GetHashCode();
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
      if (Reason != global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason.TimeOut) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      if (IsDungeon != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsDungeon);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsNewRecord);
      }
      updateSkillList_.WriteTo(output, _repeated_updateSkillList_codec);
      if (Time != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Time);
      }
      if (Score != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Score);
      }
      if (LevelId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LevelId);
      }
      if (Combo != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Combo);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (IsSingleMode != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsSingleMode);
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
      if (Reason != global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason.TimeOut) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Reason);
      }
      if (IsDungeon != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsDungeon);
      }
      if (IsNewRecord != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsNewRecord);
      }
      updateSkillList_.WriteTo(ref output, _repeated_updateSkillList_codec);
      if (Time != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Time);
      }
      if (Score != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Score);
      }
      if (LevelId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LevelId);
      }
      if (Combo != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Combo);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (IsSingleMode != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsSingleMode);
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
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (IsDungeon != false) {
        size += 1 + 1;
      }
      if (IsNewRecord != false) {
        size += 1 + 1;
      }
      if (IsSingleMode != false) {
        size += 1 + 1;
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (Reason != global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason.TimeOut) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Time);
      }
      size += updateSkillList_.CalculateSize(_repeated_updateSkillList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BrickBreakerSettleNotify other) {
      if (other == null) {
        return;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.IsDungeon != false) {
        IsDungeon = other.IsDungeon;
      }
      if (other.IsNewRecord != false) {
        IsNewRecord = other.IsNewRecord;
      }
      if (other.IsSingleMode != false) {
        IsSingleMode = other.IsSingleMode;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.Reason != global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason.TimeOut) {
        Reason = other.Reason;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Time != 0) {
        Time = other.Time;
      }
      updateSkillList_.Add(other.updateSkillList_);
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
            Reason = (global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason) input.ReadEnum();
            break;
          }
          case 16: {
            IsDungeon = input.ReadBool();
            break;
          }
          case 24: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 34: {
            updateSkillList_.AddEntriesFrom(input, _repeated_updateSkillList_codec);
            break;
          }
          case 40: {
            Time = input.ReadUInt32();
            break;
          }
          case 56: {
            Score = input.ReadUInt32();
            break;
          }
          case 88: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 96: {
            Combo = input.ReadUInt32();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsSingleMode = input.ReadBool();
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
            Reason = (global::MiHomo.Protos.BrickBreakerSettleNotify.Types.SettleReason) input.ReadEnum();
            break;
          }
          case 16: {
            IsDungeon = input.ReadBool();
            break;
          }
          case 24: {
            IsNewRecord = input.ReadBool();
            break;
          }
          case 34: {
            updateSkillList_.AddEntriesFrom(ref input, _repeated_updateSkillList_codec);
            break;
          }
          case 40: {
            Time = input.ReadUInt32();
            break;
          }
          case 56: {
            Score = input.ReadUInt32();
            break;
          }
          case 88: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 96: {
            Combo = input.ReadUInt32();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 120: {
            IsSingleMode = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BrickBreakerSettleNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum SettleReason {
        [pbr::OriginalName("SETTLE_REASON_TIME_OUT")] TimeOut = 0,
        [pbr::OriginalName("SETTLE_REASON_PLAY_END")] PlayEnd = 1,
        [pbr::OriginalName("SETTLE_REASON_PLAYER_QUIT")] PlayerQuit = 2,
        [pbr::OriginalName("SETTLE_REASON_LIFE_COUNT")] LifeCount = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
