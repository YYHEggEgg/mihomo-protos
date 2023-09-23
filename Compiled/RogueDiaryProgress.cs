// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryProgress.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RogueDiaryProgress.proto</summary>
  public static partial class RogueDiaryProgressReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryProgress.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryProgressReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZURpYXJ5UHJvZ3Jlc3MucHJvdG8SDW1pSG9tby5Qcm90b3MigwEK",
            "ElJvZ3VlRGlhcnlQcm9ncmVzcxIRCgljdXJfcm91bmQYBCABKA0SEgoKZGlm",
            "ZmljdWx0eRgKIAEoDRIYChBpc19lbnRlcl9kdW5nZW9uGAMgASgIEhoKEm9w",
            "dGlvbmFsX2NhcmRfbGlzdBgFIAMoDRIQCghzdGFnZV9pZBgGIAEoDWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RogueDiaryProgress), global::MiHomo.Protos.RogueDiaryProgress.Parser, new[]{ "CurRound", "Difficulty", "IsEnterDungeon", "OptionalCardList", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueDiaryProgress : pb::IMessage<RogueDiaryProgress>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryProgress> _parser = new pb::MessageParser<RogueDiaryProgress>(() => new RogueDiaryProgress());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryProgress> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RogueDiaryProgressReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryProgress() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryProgress(RogueDiaryProgress other) : this() {
      curRound_ = other.curRound_;
      difficulty_ = other.difficulty_;
      isEnterDungeon_ = other.isEnterDungeon_;
      optionalCardList_ = other.optionalCardList_.Clone();
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryProgress Clone() {
      return new RogueDiaryProgress(this);
    }

    /// <summary>Field number for the "cur_round" field.</summary>
    public const int CurRoundFieldNumber = 4;
    private uint curRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurRound {
      get { return curRound_; }
      set {
        curRound_ = value;
      }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 10;
    private uint difficulty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    /// <summary>Field number for the "is_enter_dungeon" field.</summary>
    public const int IsEnterDungeonFieldNumber = 3;
    private bool isEnterDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEnterDungeon {
      get { return isEnterDungeon_; }
      set {
        isEnterDungeon_ = value;
      }
    }

    /// <summary>Field number for the "optional_card_list" field.</summary>
    public const int OptionalCardListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_optionalCardList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> optionalCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OptionalCardList {
      get { return optionalCardList_; }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 6;
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
      return Equals(other as RogueDiaryProgress);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryProgress other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurRound != other.CurRound) return false;
      if (Difficulty != other.Difficulty) return false;
      if (IsEnterDungeon != other.IsEnterDungeon) return false;
      if(!optionalCardList_.Equals(other.optionalCardList_)) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurRound != 0) hash ^= CurRound.GetHashCode();
      if (Difficulty != 0) hash ^= Difficulty.GetHashCode();
      if (IsEnterDungeon != false) hash ^= IsEnterDungeon.GetHashCode();
      hash ^= optionalCardList_.GetHashCode();
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
      if (IsEnterDungeon != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsEnterDungeon);
      }
      if (CurRound != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CurRound);
      }
      optionalCardList_.WriteTo(output, _repeated_optionalCardList_codec);
      if (StageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StageId);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(80);
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
      if (IsEnterDungeon != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsEnterDungeon);
      }
      if (CurRound != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CurRound);
      }
      optionalCardList_.WriteTo(ref output, _repeated_optionalCardList_codec);
      if (StageId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(StageId);
      }
      if (Difficulty != 0) {
        output.WriteRawTag(80);
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
      if (CurRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurRound);
      }
      if (Difficulty != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Difficulty);
      }
      if (IsEnterDungeon != false) {
        size += 1 + 1;
      }
      size += optionalCardList_.CalculateSize(_repeated_optionalCardList_codec);
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
    public void MergeFrom(RogueDiaryProgress other) {
      if (other == null) {
        return;
      }
      if (other.CurRound != 0) {
        CurRound = other.CurRound;
      }
      if (other.Difficulty != 0) {
        Difficulty = other.Difficulty;
      }
      if (other.IsEnterDungeon != false) {
        IsEnterDungeon = other.IsEnterDungeon;
      }
      optionalCardList_.Add(other.optionalCardList_);
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
          case 24: {
            IsEnterDungeon = input.ReadBool();
            break;
          }
          case 32: {
            CurRound = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            optionalCardList_.AddEntriesFrom(input, _repeated_optionalCardList_codec);
            break;
          }
          case 48: {
            StageId = input.ReadUInt32();
            break;
          }
          case 80: {
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
          case 24: {
            IsEnterDungeon = input.ReadBool();
            break;
          }
          case 32: {
            CurRound = input.ReadUInt32();
            break;
          }
          case 42:
          case 40: {
            optionalCardList_.AddEntriesFrom(ref input, _repeated_optionalCardList_codec);
            break;
          }
          case 48: {
            StageId = input.ReadUInt32();
            break;
          }
          case 80: {
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
