// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CharAmusementInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CharAmusementInfo.proto</summary>
  public static partial class CharAmusementInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CharAmusementInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CharAmusementInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdDaGFyQW11c2VtZW50SW5mby5wcm90bxINbWlIb21vLlByb3RvcxodQ2hh",
            "ckFtdXNlbWVudEF2YXRhckluZm8ucHJvdG8irwEKEUNoYXJBbXVzZW1lbnRJ",
            "bmZvEkAKEGF2YXRhcl9pbmZvX2xpc3QYBSADKAsyJi5taUhvbW8uUHJvdG9z",
            "LkNoYXJBbXVzZW1lbnRBdmF0YXJJbmZvEhAKCGxldmVsX2lkGAwgASgNEhsK",
            "E3ByZXZpZXdfc3RhZ2VfaW5kZXgYASABKA0SEAoIc3RhZ2VfaWQYBCABKA0S",
            "FwoPdG90YWxfY29zdF90aW1lGAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CharAmusementAvatarInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CharAmusementInfo), global::MiHomo.Protos.CharAmusementInfo.Parser, new[]{ "AvatarInfoList", "LevelId", "PreviewStageIndex", "StageId", "TotalCostTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CharAmusementInfo : pb::IMessage<CharAmusementInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CharAmusementInfo> _parser = new pb::MessageParser<CharAmusementInfo>(() => new CharAmusementInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CharAmusementInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CharAmusementInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CharAmusementInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CharAmusementInfo(CharAmusementInfo other) : this() {
      avatarInfoList_ = other.avatarInfoList_.Clone();
      levelId_ = other.levelId_;
      previewStageIndex_ = other.previewStageIndex_;
      stageId_ = other.stageId_;
      totalCostTime_ = other.totalCostTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CharAmusementInfo Clone() {
      return new CharAmusementInfo(this);
    }

    /// <summary>Field number for the "avatar_info_list" field.</summary>
    public const int AvatarInfoListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.CharAmusementAvatarInfo> _repeated_avatarInfoList_codec
        = pb::FieldCodec.ForMessage(42, global::MiHomo.Protos.CharAmusementAvatarInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.CharAmusementAvatarInfo> avatarInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.CharAmusementAvatarInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.CharAmusementAvatarInfo> AvatarInfoList {
      get { return avatarInfoList_; }
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

    /// <summary>Field number for the "preview_stage_index" field.</summary>
    public const int PreviewStageIndexFieldNumber = 1;
    private uint previewStageIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PreviewStageIndex {
      get { return previewStageIndex_; }
      set {
        previewStageIndex_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 4;
    private uint stageId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StageId {
      get { return stageId_; }
      set {
        stageId_ = value;
      }
    }

    /// <summary>Field number for the "total_cost_time" field.</summary>
    public const int TotalCostTimeFieldNumber = 2;
    private uint totalCostTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TotalCostTime {
      get { return totalCostTime_; }
      set {
        totalCostTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CharAmusementInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CharAmusementInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarInfoList_.Equals(other.avatarInfoList_)) return false;
      if (LevelId != other.LevelId) return false;
      if (PreviewStageIndex != other.PreviewStageIndex) return false;
      if (StageId != other.StageId) return false;
      if (TotalCostTime != other.TotalCostTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarInfoList_.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (PreviewStageIndex != 0) hash ^= PreviewStageIndex.GetHashCode();
      if (StageId != 0) hash ^= StageId.GetHashCode();
      if (TotalCostTime != 0) hash ^= TotalCostTime.GetHashCode();
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
      if (PreviewStageIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PreviewStageIndex);
      }
      if (TotalCostTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TotalCostTime);
      }
      if (StageId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StageId);
      }
      avatarInfoList_.WriteTo(output, _repeated_avatarInfoList_codec);
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
      if (PreviewStageIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PreviewStageIndex);
      }
      if (TotalCostTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(TotalCostTime);
      }
      if (StageId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(StageId);
      }
      avatarInfoList_.WriteTo(ref output, _repeated_avatarInfoList_codec);
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
      size += avatarInfoList_.CalculateSize(_repeated_avatarInfoList_codec);
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (PreviewStageIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PreviewStageIndex);
      }
      if (StageId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StageId);
      }
      if (TotalCostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TotalCostTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CharAmusementInfo other) {
      if (other == null) {
        return;
      }
      avatarInfoList_.Add(other.avatarInfoList_);
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.PreviewStageIndex != 0) {
        PreviewStageIndex = other.PreviewStageIndex;
      }
      if (other.StageId != 0) {
        StageId = other.StageId;
      }
      if (other.TotalCostTime != 0) {
        TotalCostTime = other.TotalCostTime;
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
            PreviewStageIndex = input.ReadUInt32();
            break;
          }
          case 16: {
            TotalCostTime = input.ReadUInt32();
            break;
          }
          case 32: {
            StageId = input.ReadUInt32();
            break;
          }
          case 42: {
            avatarInfoList_.AddEntriesFrom(input, _repeated_avatarInfoList_codec);
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
          case 8: {
            PreviewStageIndex = input.ReadUInt32();
            break;
          }
          case 16: {
            TotalCostTime = input.ReadUInt32();
            break;
          }
          case 32: {
            StageId = input.ReadUInt32();
            break;
          }
          case 42: {
            avatarInfoList_.AddEntriesFrom(ref input, _repeated_avatarInfoList_codec);
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

  }

  #endregion

}

#endregion Designer generated code
