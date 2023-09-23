// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SalvageScoreChallengeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SalvageScoreChallengeInfo.proto</summary>
  public static partial class SalvageScoreChallengeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SalvageScoreChallengeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SalvageScoreChallengeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9TYWx2YWdlU2NvcmVDaGFsbGVuZ2VJbmZvLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zIkwKGVNhbHZhZ2VTY29yZUNoYWxsZW5nZUluZm8SEQoJbWF4X3Njb3Jl",
            "GAcgASgNEhwKFHNhbHZhZ2VfY2hhbGxlbmdlX2lkGA0gASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SalvageScoreChallengeInfo), global::MiHomo.Protos.SalvageScoreChallengeInfo.Parser, new[]{ "MaxScore", "SalvageChallengeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SalvageScoreChallengeInfo : pb::IMessage<SalvageScoreChallengeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SalvageScoreChallengeInfo> _parser = new pb::MessageParser<SalvageScoreChallengeInfo>(() => new SalvageScoreChallengeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SalvageScoreChallengeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SalvageScoreChallengeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalvageScoreChallengeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalvageScoreChallengeInfo(SalvageScoreChallengeInfo other) : this() {
      maxScore_ = other.maxScore_;
      salvageChallengeId_ = other.salvageChallengeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SalvageScoreChallengeInfo Clone() {
      return new SalvageScoreChallengeInfo(this);
    }

    /// <summary>Field number for the "max_score" field.</summary>
    public const int MaxScoreFieldNumber = 7;
    private uint maxScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxScore {
      get { return maxScore_; }
      set {
        maxScore_ = value;
      }
    }

    /// <summary>Field number for the "salvage_challenge_id" field.</summary>
    public const int SalvageChallengeIdFieldNumber = 13;
    private uint salvageChallengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SalvageChallengeId {
      get { return salvageChallengeId_; }
      set {
        salvageChallengeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SalvageScoreChallengeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SalvageScoreChallengeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxScore != other.MaxScore) return false;
      if (SalvageChallengeId != other.SalvageChallengeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MaxScore != 0) hash ^= MaxScore.GetHashCode();
      if (SalvageChallengeId != 0) hash ^= SalvageChallengeId.GetHashCode();
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
      if (MaxScore != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaxScore);
      }
      if (SalvageChallengeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SalvageChallengeId);
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
      if (MaxScore != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MaxScore);
      }
      if (SalvageChallengeId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SalvageChallengeId);
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
      if (MaxScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxScore);
      }
      if (SalvageChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SalvageChallengeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SalvageScoreChallengeInfo other) {
      if (other == null) {
        return;
      }
      if (other.MaxScore != 0) {
        MaxScore = other.MaxScore;
      }
      if (other.SalvageChallengeId != 0) {
        SalvageChallengeId = other.SalvageChallengeId;
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
          case 56: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 104: {
            SalvageChallengeId = input.ReadUInt32();
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
          case 56: {
            MaxScore = input.ReadUInt32();
            break;
          }
          case 104: {
            SalvageChallengeId = input.ReadUInt32();
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
