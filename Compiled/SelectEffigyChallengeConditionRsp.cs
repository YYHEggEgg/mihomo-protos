// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SelectEffigyChallengeConditionRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SelectEffigyChallengeConditionRsp.proto</summary>
  public static partial class SelectEffigyChallengeConditionRspReflection {

    #region Descriptor
    /// <summary>File descriptor for SelectEffigyChallengeConditionRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SelectEffigyChallengeConditionRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidTZWxlY3RFZmZpZ3lDaGFsbGVuZ2VDb25kaXRpb25Sc3AucHJvdG8SDW1p",
            "SG9tby5Qcm90b3MifAohU2VsZWN0RWZmaWd5Q2hhbGxlbmdlQ29uZGl0aW9u",
            "UnNwEhQKDGNoYWxsZW5nZV9pZBgHIAEoDRIZChFjb25kaXRpb25faWRfbGlz",
            "dBgLIAMoDRIVCg1kaWZmaWN1bHR5X2lkGAogASgNEg8KB3JldGNvZGUYCSAB",
            "KAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SelectEffigyChallengeConditionRsp), global::MiHomo.Protos.SelectEffigyChallengeConditionRsp.Parser, new[]{ "ChallengeId", "ConditionIdList", "DifficultyId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SelectEffigyChallengeConditionRsp : pb::IMessage<SelectEffigyChallengeConditionRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SelectEffigyChallengeConditionRsp> _parser = new pb::MessageParser<SelectEffigyChallengeConditionRsp>(() => new SelectEffigyChallengeConditionRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SelectEffigyChallengeConditionRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SelectEffigyChallengeConditionRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectEffigyChallengeConditionRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectEffigyChallengeConditionRsp(SelectEffigyChallengeConditionRsp other) : this() {
      challengeId_ = other.challengeId_;
      conditionIdList_ = other.conditionIdList_.Clone();
      difficultyId_ = other.difficultyId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SelectEffigyChallengeConditionRsp Clone() {
      return new SelectEffigyChallengeConditionRsp(this);
    }

    /// <summary>Field number for the "challenge_id" field.</summary>
    public const int ChallengeIdFieldNumber = 7;
    private uint challengeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeId {
      get { return challengeId_; }
      set {
        challengeId_ = value;
      }
    }

    /// <summary>Field number for the "condition_id_list" field.</summary>
    public const int ConditionIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_conditionIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> conditionIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ConditionIdList {
      get { return conditionIdList_; }
    }

    /// <summary>Field number for the "difficulty_id" field.</summary>
    public const int DifficultyIdFieldNumber = 10;
    private uint difficultyId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DifficultyId {
      get { return difficultyId_; }
      set {
        difficultyId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SelectEffigyChallengeConditionRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SelectEffigyChallengeConditionRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeId != other.ChallengeId) return false;
      if(!conditionIdList_.Equals(other.conditionIdList_)) return false;
      if (DifficultyId != other.DifficultyId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeId != 0) hash ^= ChallengeId.GetHashCode();
      hash ^= conditionIdList_.GetHashCode();
      if (DifficultyId != 0) hash ^= DifficultyId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (ChallengeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DifficultyId);
      }
      conditionIdList_.WriteTo(output, _repeated_conditionIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChallengeId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ChallengeId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      if (DifficultyId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(DifficultyId);
      }
      conditionIdList_.WriteTo(ref output, _repeated_conditionIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ChallengeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeId);
      }
      size += conditionIdList_.CalculateSize(_repeated_conditionIdList_codec);
      if (DifficultyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DifficultyId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SelectEffigyChallengeConditionRsp other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeId != 0) {
        ChallengeId = other.ChallengeId;
      }
      conditionIdList_.Add(other.conditionIdList_);
      if (other.DifficultyId != 0) {
        DifficultyId = other.DifficultyId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            conditionIdList_.AddEntriesFrom(input, _repeated_conditionIdList_codec);
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
            ChallengeId = input.ReadUInt32();
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 80: {
            DifficultyId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            conditionIdList_.AddEntriesFrom(ref input, _repeated_conditionIdList_codec);
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
