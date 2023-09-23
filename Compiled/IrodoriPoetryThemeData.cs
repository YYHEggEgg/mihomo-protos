// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IrodoriPoetryThemeData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from IrodoriPoetryThemeData.proto</summary>
  public static partial class IrodoriPoetryThemeDataReflection {

    #region Descriptor
    /// <summary>File descriptor for IrodoriPoetryThemeData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IrodoriPoetryThemeDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxJcm9kb3JpUG9ldHJ5VGhlbWVEYXRhLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "IrQBChZJcm9kb3JpUG9ldHJ5VGhlbWVEYXRhEhQKDGxpbmVfaWRfbGlzdBgE",
            "IAMoDRIUCgxtYXhfcHJvZ3Jlc3MYAiABKA0SFAoMbWluX3Byb2dyZXNzGAwg",
            "ASgNEhAKCHByb2dyZXNzGAUgASgNEhoKEnNjYW5uZWRfaW5kZXhfbGlzdBgB",
            "IAMoDRIYChBzZWxlY3RlZF9saW5lX2lkGAkgASgNEhAKCHRoZW1lX2lkGA0g",
            "ASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.IrodoriPoetryThemeData), global::MiHomo.Protos.IrodoriPoetryThemeData.Parser, new[]{ "LineIdList", "MaxProgress", "MinProgress", "Progress", "ScannedIndexList", "SelectedLineId", "ThemeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IrodoriPoetryThemeData : pb::IMessage<IrodoriPoetryThemeData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IrodoriPoetryThemeData> _parser = new pb::MessageParser<IrodoriPoetryThemeData>(() => new IrodoriPoetryThemeData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IrodoriPoetryThemeData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.IrodoriPoetryThemeDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriPoetryThemeData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriPoetryThemeData(IrodoriPoetryThemeData other) : this() {
      lineIdList_ = other.lineIdList_.Clone();
      maxProgress_ = other.maxProgress_;
      minProgress_ = other.minProgress_;
      progress_ = other.progress_;
      scannedIndexList_ = other.scannedIndexList_.Clone();
      selectedLineId_ = other.selectedLineId_;
      themeId_ = other.themeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IrodoriPoetryThemeData Clone() {
      return new IrodoriPoetryThemeData(this);
    }

    /// <summary>Field number for the "line_id_list" field.</summary>
    public const int LineIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_lineIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> lineIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> LineIdList {
      get { return lineIdList_; }
    }

    /// <summary>Field number for the "max_progress" field.</summary>
    public const int MaxProgressFieldNumber = 2;
    private uint maxProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxProgress {
      get { return maxProgress_; }
      set {
        maxProgress_ = value;
      }
    }

    /// <summary>Field number for the "min_progress" field.</summary>
    public const int MinProgressFieldNumber = 12;
    private uint minProgress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinProgress {
      get { return minProgress_; }
      set {
        minProgress_ = value;
      }
    }

    /// <summary>Field number for the "progress" field.</summary>
    public const int ProgressFieldNumber = 5;
    private uint progress_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Progress {
      get { return progress_; }
      set {
        progress_ = value;
      }
    }

    /// <summary>Field number for the "scanned_index_list" field.</summary>
    public const int ScannedIndexListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_scannedIndexList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> scannedIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ScannedIndexList {
      get { return scannedIndexList_; }
    }

    /// <summary>Field number for the "selected_line_id" field.</summary>
    public const int SelectedLineIdFieldNumber = 9;
    private uint selectedLineId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelectedLineId {
      get { return selectedLineId_; }
      set {
        selectedLineId_ = value;
      }
    }

    /// <summary>Field number for the "theme_id" field.</summary>
    public const int ThemeIdFieldNumber = 13;
    private uint themeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ThemeId {
      get { return themeId_; }
      set {
        themeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IrodoriPoetryThemeData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IrodoriPoetryThemeData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!lineIdList_.Equals(other.lineIdList_)) return false;
      if (MaxProgress != other.MaxProgress) return false;
      if (MinProgress != other.MinProgress) return false;
      if (Progress != other.Progress) return false;
      if(!scannedIndexList_.Equals(other.scannedIndexList_)) return false;
      if (SelectedLineId != other.SelectedLineId) return false;
      if (ThemeId != other.ThemeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= lineIdList_.GetHashCode();
      if (MaxProgress != 0) hash ^= MaxProgress.GetHashCode();
      if (MinProgress != 0) hash ^= MinProgress.GetHashCode();
      if (Progress != 0) hash ^= Progress.GetHashCode();
      hash ^= scannedIndexList_.GetHashCode();
      if (SelectedLineId != 0) hash ^= SelectedLineId.GetHashCode();
      if (ThemeId != 0) hash ^= ThemeId.GetHashCode();
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
      scannedIndexList_.WriteTo(output, _repeated_scannedIndexList_codec);
      if (MaxProgress != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaxProgress);
      }
      lineIdList_.WriteTo(output, _repeated_lineIdList_codec);
      if (Progress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Progress);
      }
      if (SelectedLineId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SelectedLineId);
      }
      if (MinProgress != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MinProgress);
      }
      if (ThemeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ThemeId);
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
      scannedIndexList_.WriteTo(ref output, _repeated_scannedIndexList_codec);
      if (MaxProgress != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(MaxProgress);
      }
      lineIdList_.WriteTo(ref output, _repeated_lineIdList_codec);
      if (Progress != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Progress);
      }
      if (SelectedLineId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(SelectedLineId);
      }
      if (MinProgress != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(MinProgress);
      }
      if (ThemeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ThemeId);
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
      size += lineIdList_.CalculateSize(_repeated_lineIdList_codec);
      if (MaxProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxProgress);
      }
      if (MinProgress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinProgress);
      }
      if (Progress != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Progress);
      }
      size += scannedIndexList_.CalculateSize(_repeated_scannedIndexList_codec);
      if (SelectedLineId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelectedLineId);
      }
      if (ThemeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ThemeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IrodoriPoetryThemeData other) {
      if (other == null) {
        return;
      }
      lineIdList_.Add(other.lineIdList_);
      if (other.MaxProgress != 0) {
        MaxProgress = other.MaxProgress;
      }
      if (other.MinProgress != 0) {
        MinProgress = other.MinProgress;
      }
      if (other.Progress != 0) {
        Progress = other.Progress;
      }
      scannedIndexList_.Add(other.scannedIndexList_);
      if (other.SelectedLineId != 0) {
        SelectedLineId = other.SelectedLineId;
      }
      if (other.ThemeId != 0) {
        ThemeId = other.ThemeId;
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
          case 10:
          case 8: {
            scannedIndexList_.AddEntriesFrom(input, _repeated_scannedIndexList_codec);
            break;
          }
          case 16: {
            MaxProgress = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            lineIdList_.AddEntriesFrom(input, _repeated_lineIdList_codec);
            break;
          }
          case 40: {
            Progress = input.ReadUInt32();
            break;
          }
          case 72: {
            SelectedLineId = input.ReadUInt32();
            break;
          }
          case 96: {
            MinProgress = input.ReadUInt32();
            break;
          }
          case 104: {
            ThemeId = input.ReadUInt32();
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
            scannedIndexList_.AddEntriesFrom(ref input, _repeated_scannedIndexList_codec);
            break;
          }
          case 16: {
            MaxProgress = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            lineIdList_.AddEntriesFrom(ref input, _repeated_lineIdList_codec);
            break;
          }
          case 40: {
            Progress = input.ReadUInt32();
            break;
          }
          case 72: {
            SelectedLineId = input.ReadUInt32();
            break;
          }
          case 96: {
            MinProgress = input.ReadUInt32();
            break;
          }
          case 104: {
            ThemeId = input.ReadUInt32();
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
