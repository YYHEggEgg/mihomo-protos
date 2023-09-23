// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrialAvatarInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TrialAvatarInfo.proto</summary>
  public static partial class TrialAvatarInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TrialAvatarInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrialAvatarInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVUcmlhbEF2YXRhckluZm8ucHJvdG8SDW1pSG9tby5Qcm90b3MaCkl0ZW0u",
            "cHJvdG8aHFRyaWFsQXZhdGFyR3JhbnRSZWNvcmQucHJvdG8ilgEKD1RyaWFs",
            "QXZhdGFySW5mbxI7CgxncmFudF9yZWNvcmQYAyABKAsyJS5taUhvbW8uUHJv",
            "dG9zLlRyaWFsQXZhdGFyR3JhbnRSZWNvcmQSFwoPdHJpYWxfYXZhdGFyX2lk",
            "GAEgASgNEi0KEHRyaWFsX2VxdWlwX2xpc3QYAiADKAsyEy5taUhvbW8uUHJv",
            "dG9zLkl0ZW1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ItemReflection.Descriptor, global::MiHomo.Protos.TrialAvatarGrantRecordReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TrialAvatarInfo), global::MiHomo.Protos.TrialAvatarInfo.Parser, new[]{ "GrantRecord", "TrialAvatarId", "TrialEquipList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrialAvatarInfo : pb::IMessage<TrialAvatarInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrialAvatarInfo> _parser = new pb::MessageParser<TrialAvatarInfo>(() => new TrialAvatarInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrialAvatarInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TrialAvatarInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarInfo(TrialAvatarInfo other) : this() {
      grantRecord_ = other.grantRecord_ != null ? other.grantRecord_.Clone() : null;
      trialAvatarId_ = other.trialAvatarId_;
      trialEquipList_ = other.trialEquipList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrialAvatarInfo Clone() {
      return new TrialAvatarInfo(this);
    }

    /// <summary>Field number for the "grant_record" field.</summary>
    public const int GrantRecordFieldNumber = 3;
    private global::MiHomo.Protos.TrialAvatarGrantRecord grantRecord_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.TrialAvatarGrantRecord GrantRecord {
      get { return grantRecord_; }
      set {
        grantRecord_ = value;
      }
    }

    /// <summary>Field number for the "trial_avatar_id" field.</summary>
    public const int TrialAvatarIdFieldNumber = 1;
    private uint trialAvatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TrialAvatarId {
      get { return trialAvatarId_; }
      set {
        trialAvatarId_ = value;
      }
    }

    /// <summary>Field number for the "trial_equip_list" field.</summary>
    public const int TrialEquipListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.Item> _repeated_trialEquipList_codec
        = pb::FieldCodec.ForMessage(18, global::MiHomo.Protos.Item.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.Item> trialEquipList_ = new pbc::RepeatedField<global::MiHomo.Protos.Item>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.Item> TrialEquipList {
      get { return trialEquipList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrialAvatarInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrialAvatarInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(GrantRecord, other.GrantRecord)) return false;
      if (TrialAvatarId != other.TrialAvatarId) return false;
      if(!trialEquipList_.Equals(other.trialEquipList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (grantRecord_ != null) hash ^= GrantRecord.GetHashCode();
      if (TrialAvatarId != 0) hash ^= TrialAvatarId.GetHashCode();
      hash ^= trialEquipList_.GetHashCode();
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
      if (TrialAvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TrialAvatarId);
      }
      trialEquipList_.WriteTo(output, _repeated_trialEquipList_codec);
      if (grantRecord_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GrantRecord);
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
      if (TrialAvatarId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(TrialAvatarId);
      }
      trialEquipList_.WriteTo(ref output, _repeated_trialEquipList_codec);
      if (grantRecord_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(GrantRecord);
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
      if (grantRecord_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GrantRecord);
      }
      if (TrialAvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TrialAvatarId);
      }
      size += trialEquipList_.CalculateSize(_repeated_trialEquipList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrialAvatarInfo other) {
      if (other == null) {
        return;
      }
      if (other.grantRecord_ != null) {
        if (grantRecord_ == null) {
          GrantRecord = new global::MiHomo.Protos.TrialAvatarGrantRecord();
        }
        GrantRecord.MergeFrom(other.GrantRecord);
      }
      if (other.TrialAvatarId != 0) {
        TrialAvatarId = other.TrialAvatarId;
      }
      trialEquipList_.Add(other.trialEquipList_);
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
            TrialAvatarId = input.ReadUInt32();
            break;
          }
          case 18: {
            trialEquipList_.AddEntriesFrom(input, _repeated_trialEquipList_codec);
            break;
          }
          case 26: {
            if (grantRecord_ == null) {
              GrantRecord = new global::MiHomo.Protos.TrialAvatarGrantRecord();
            }
            input.ReadMessage(GrantRecord);
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
            TrialAvatarId = input.ReadUInt32();
            break;
          }
          case 18: {
            trialEquipList_.AddEntriesFrom(ref input, _repeated_trialEquipList_codec);
            break;
          }
          case 26: {
            if (grantRecord_ == null) {
              GrantRecord = new global::MiHomo.Protos.TrialAvatarGrantRecord();
            }
            input.ReadMessage(GrantRecord);
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
