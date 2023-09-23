// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RockBoardExploreStageData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RockBoardExploreStageData.proto</summary>
  public static partial class RockBoardExploreStageDataReflection {

    #region Descriptor
    /// <summary>File descriptor for RockBoardExploreStageData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RockBoardExploreStageDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2NrQm9hcmRFeHBsb3JlU3RhZ2VEYXRhLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zImQKGVJvY2tCb2FyZEV4cGxvcmVTdGFnZURhdGESEQoJaXNfZmluaXNo",
            "GAYgASgIEg8KB2lzX29wZW4YBSABKAgSEQoJb3Blbl90aW1lGAcgASgNEhAK",
            "CHN0YWdlX2lkGAMgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RockBoardExploreStageData), global::MiHomo.Protos.RockBoardExploreStageData.Parser, new[]{ "IsFinish", "IsOpen", "OpenTime", "StageId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RockBoardExploreStageData : pb::IMessage<RockBoardExploreStageData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RockBoardExploreStageData> _parser = new pb::MessageParser<RockBoardExploreStageData>(() => new RockBoardExploreStageData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RockBoardExploreStageData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RockBoardExploreStageDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RockBoardExploreStageData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RockBoardExploreStageData(RockBoardExploreStageData other) : this() {
      isFinish_ = other.isFinish_;
      isOpen_ = other.isOpen_;
      openTime_ = other.openTime_;
      stageId_ = other.stageId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RockBoardExploreStageData Clone() {
      return new RockBoardExploreStageData(this);
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 6;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 5;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 7;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "stage_id" field.</summary>
    public const int StageIdFieldNumber = 3;
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
      return Equals(other as RockBoardExploreStageData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RockBoardExploreStageData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinish != other.IsFinish) return false;
      if (IsOpen != other.IsOpen) return false;
      if (OpenTime != other.OpenTime) return false;
      if (StageId != other.StageId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
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
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (IsFinish != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsFinish);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OpenTime);
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
      if (StageId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StageId);
      }
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (IsFinish != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsFinish);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(OpenTime);
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
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
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
    public void MergeFrom(RockBoardExploreStageData other) {
      if (other == null) {
        return;
      }
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
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
          case 24: {
            StageId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 48: {
            IsFinish = input.ReadBool();
            break;
          }
          case 56: {
            OpenTime = input.ReadUInt32();
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
            StageId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 48: {
            IsFinish = input.ReadBool();
            break;
          }
          case 56: {
            OpenTime = input.ReadUInt32();
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
