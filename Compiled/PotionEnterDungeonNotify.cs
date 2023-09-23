// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PotionEnterDungeonNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PotionEnterDungeonNotify.proto</summary>
  public static partial class PotionEnterDungeonNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PotionEnterDungeonNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PotionEnterDungeonNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Qb3Rpb25FbnRlckR1bmdlb25Ob3RpZnkucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaGVBvdGlvbkR1bmdlb25BdmF0YXIucHJvdG8iqgEKGFBvdGlvbkVudGVy",
            "RHVuZ2Vvbk5vdGlmeRIYChBkaWZmaWN1bHR5X2xldmVsGA4gASgNEj8KE2R1",
            "bmdlb25fYXZhdGFyX2xpc3QYASADKAsyIi5taUhvbW8uUHJvdG9zLlBvdGlv",
            "bkR1bmdlb25BdmF0YXISEAoIbGV2ZWxfaWQYAyABKA0SDwoHbW9kZV9pZBgL",
            "IAEoDRIQCghzdGFnZV9pZBgKIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.PotionDungeonAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PotionEnterDungeonNotify), global::MiHomo.Protos.PotionEnterDungeonNotify.Parser, new[]{ "DifficultyLevel", "DungeonAvatarList", "LevelId", "ModeId", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PotionEnterDungeonNotify : pb::IMessage<PotionEnterDungeonNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PotionEnterDungeonNotify> _parser = new pb::MessageParser<PotionEnterDungeonNotify>(() => new PotionEnterDungeonNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PotionEnterDungeonNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PotionEnterDungeonNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionEnterDungeonNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionEnterDungeonNotify(PotionEnterDungeonNotify other) : this() {
      difficultyLevel_ = other.difficultyLevel_;
      dungeonAvatarList_ = other.dungeonAvatarList_.Clone();
      levelId_ = other.levelId_;
      modeId_ = other.modeId_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PotionEnterDungeonNotify Clone() {
      return new PotionEnterDungeonNotify(this);
    }

    /// <summary>Field number for the "difficulty_level" field.</summary>
    public const int DifficultyLevelFieldNumber = 14;
    private uint difficultyLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyLevel {
      get { return difficultyLevel_; }
      set {
        difficultyLevel_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_avatar_list" field.</summary>
    public const int DungeonAvatarListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.PotionDungeonAvatar> _repeated_dungeonAvatarList_codec
        = pb::FieldCodec.ForMessage(10, global::MiHomo.Protos.PotionDungeonAvatar.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.PotionDungeonAvatar> dungeonAvatarList_ = new pbc::RepeatedField<global::MiHomo.Protos.PotionDungeonAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.PotionDungeonAvatar> DungeonAvatarList {
      get { return dungeonAvatarList_; }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 3;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "mode_id" field.</summary>
    public const int ModeIdFieldNumber = 11;
    private uint modeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModeId {
      get { return modeId_; }
      set {
        modeId_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 10;
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
      return Equals(other as PotionEnterDungeonNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PotionEnterDungeonNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DifficultyLevel != other.DifficultyLevel) return false;
      if(!dungeonAvatarList_.Equals(other.dungeonAvatarList_)) return false;
      if (LevelId != other.LevelId) return false;
      if (ModeId != other.ModeId) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DifficultyLevel != 0) hash ^= DifficultyLevel.GetHashCode();
      hash ^= dungeonAvatarList_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (ModeId != 0) hash ^= ModeId.GetHashCode();
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
      dungeonAvatarList_.WriteTo(output, _repeated_dungeonAvatarList_codec);
      if (LevelId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LevelId);
      }
      if (StageId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageId);
      }
      if (ModeId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ModeId);
      }
      if (DifficultyLevel != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DifficultyLevel);
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
      dungeonAvatarList_.WriteTo(ref output, _repeated_dungeonAvatarList_codec);
      if (LevelId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LevelId);
      }
      if (StageId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(StageId);
      }
      if (ModeId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ModeId);
      }
      if (DifficultyLevel != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DifficultyLevel);
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
      if (DifficultyLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyLevel);
      }
      size += dungeonAvatarList_.CalculateSize(_repeated_dungeonAvatarList_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (ModeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModeId);
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
    public void MergeFrom(PotionEnterDungeonNotify other) {
      if (other == null) {
        return;
      }
      if (other.DifficultyLevel != 0) {
        DifficultyLevel = other.DifficultyLevel;
      }
      dungeonAvatarList_.Add(other.dungeonAvatarList_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.ModeId != 0) {
        ModeId = other.ModeId;
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
          case 10: {
            dungeonAvatarList_.AddEntriesFrom(input, _repeated_dungeonAvatarList_codec);
            break;
          }
          case 24: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 80: {
            StageId = input.ReadUInt32();
            break;
          }
          case 88: {
            ModeId = input.ReadUInt32();
            break;
          }
          case 112: {
            DifficultyLevel = input.ReadUInt32();
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
          case 10: {
            dungeonAvatarList_.AddEntriesFrom(ref input, _repeated_dungeonAvatarList_codec);
            break;
          }
          case 24: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 80: {
            StageId = input.ReadUInt32();
            break;
          }
          case 88: {
            ModeId = input.ReadUInt32();
            break;
          }
          case 112: {
            DifficultyLevel = input.ReadUInt32();
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
