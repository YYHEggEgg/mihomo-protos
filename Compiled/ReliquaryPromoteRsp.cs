// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryPromoteRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ReliquaryPromoteRsp.proto</summary>
  public static partial class ReliquaryPromoteRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ReliquaryPromoteRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReliquaryPromoteRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlSZWxpcXVhcnlQcm9tb3RlUnNwLnByb3RvEg1taUhvbW8uUHJvdG9zIoYC",
            "ChNSZWxpcXVhcnlQcm9tb3RlUnNwEhwKFGN1cl9hcHBlbmRfcHJvcF9saXN0",
            "GAkgAygNEhkKEWN1cl9wcm9tb3RlX2xldmVsGAIgASgNEhwKFG9sZF9hcHBl",
            "bmRfcHJvcF9saXN0GAggAygNEhkKEW9sZF9wcm9tb3RlX2xldmVsGAogASgN",
            "Eg8KB3JldGNvZGUYDCABKAUSHQoVdGFyZ2V0X3JlbGlxdWFyeV9ndWlkGAYg",
            "ASgEIk0KBUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIU",
            "ChBFTkVUX0lTX1JFTElBQkxFEAESCwoGQ01EX0lEELYFGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ReliquaryPromoteRsp), global::MiHomo.Protos.ReliquaryPromoteRsp.Parser, new[]{ "CurAppendPropList", "CurPromoteLevel", "OldAppendPropList", "OldPromoteLevel", "Retcode", "TargetReliquaryGuid" }, null, new[]{ typeof(global::MiHomo.Protos.ReliquaryPromoteRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReliquaryPromoteRsp : pb::IMessage<ReliquaryPromoteRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReliquaryPromoteRsp> _parser = new pb::MessageParser<ReliquaryPromoteRsp>(() => new ReliquaryPromoteRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReliquaryPromoteRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ReliquaryPromoteRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReliquaryPromoteRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReliquaryPromoteRsp(ReliquaryPromoteRsp other) : this() {
      curAppendPropList_ = other.curAppendPropList_.Clone();
      curPromoteLevel_ = other.curPromoteLevel_;
      oldAppendPropList_ = other.oldAppendPropList_.Clone();
      oldPromoteLevel_ = other.oldPromoteLevel_;
      retcode_ = other.retcode_;
      targetReliquaryGuid_ = other.targetReliquaryGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReliquaryPromoteRsp Clone() {
      return new ReliquaryPromoteRsp(this);
    }

    /// <summary>Field number for the "cur_append_prop_list" field.</summary>
    public const int CurAppendPropListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_curAppendPropList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> curAppendPropList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CurAppendPropList {
      get { return curAppendPropList_; }
    }

    /// <summary>Field number for the "cur_promote_level" field.</summary>
    public const int CurPromoteLevelFieldNumber = 2;
    private uint curPromoteLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurPromoteLevel {
      get { return curPromoteLevel_; }
      set {
        curPromoteLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_append_prop_list" field.</summary>
    public const int OldAppendPropListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_oldAppendPropList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> oldAppendPropList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> OldAppendPropList {
      get { return oldAppendPropList_; }
    }

    /// <summary>Field number for the "old_promote_level" field.</summary>
    public const int OldPromoteLevelFieldNumber = 10;
    private uint oldPromoteLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldPromoteLevel {
      get { return oldPromoteLevel_; }
      set {
        oldPromoteLevel_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "target_reliquary_guid" field.</summary>
    public const int TargetReliquaryGuidFieldNumber = 6;
    private ulong targetReliquaryGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetReliquaryGuid {
      get { return targetReliquaryGuid_; }
      set {
        targetReliquaryGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReliquaryPromoteRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReliquaryPromoteRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!curAppendPropList_.Equals(other.curAppendPropList_)) return false;
      if (CurPromoteLevel != other.CurPromoteLevel) return false;
      if(!oldAppendPropList_.Equals(other.oldAppendPropList_)) return false;
      if (OldPromoteLevel != other.OldPromoteLevel) return false;
      if (Retcode != other.Retcode) return false;
      if (TargetReliquaryGuid != other.TargetReliquaryGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= curAppendPropList_.GetHashCode();
      if (CurPromoteLevel != 0) hash ^= CurPromoteLevel.GetHashCode();
      hash ^= oldAppendPropList_.GetHashCode();
      if (OldPromoteLevel != 0) hash ^= OldPromoteLevel.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (TargetReliquaryGuid != 0UL) hash ^= TargetReliquaryGuid.GetHashCode();
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
      if (CurPromoteLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurPromoteLevel);
      }
      if (TargetReliquaryGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(TargetReliquaryGuid);
      }
      oldAppendPropList_.WriteTo(output, _repeated_oldAppendPropList_codec);
      curAppendPropList_.WriteTo(output, _repeated_curAppendPropList_codec);
      if (OldPromoteLevel != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OldPromoteLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
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
      if (CurPromoteLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CurPromoteLevel);
      }
      if (TargetReliquaryGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(TargetReliquaryGuid);
      }
      oldAppendPropList_.WriteTo(ref output, _repeated_oldAppendPropList_codec);
      curAppendPropList_.WriteTo(ref output, _repeated_curAppendPropList_codec);
      if (OldPromoteLevel != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(OldPromoteLevel);
      }
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
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
      size += curAppendPropList_.CalculateSize(_repeated_curAppendPropList_codec);
      if (CurPromoteLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurPromoteLevel);
      }
      size += oldAppendPropList_.CalculateSize(_repeated_oldAppendPropList_codec);
      if (OldPromoteLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldPromoteLevel);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (TargetReliquaryGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetReliquaryGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReliquaryPromoteRsp other) {
      if (other == null) {
        return;
      }
      curAppendPropList_.Add(other.curAppendPropList_);
      if (other.CurPromoteLevel != 0) {
        CurPromoteLevel = other.CurPromoteLevel;
      }
      oldAppendPropList_.Add(other.oldAppendPropList_);
      if (other.OldPromoteLevel != 0) {
        OldPromoteLevel = other.OldPromoteLevel;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.TargetReliquaryGuid != 0UL) {
        TargetReliquaryGuid = other.TargetReliquaryGuid;
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
          case 16: {
            CurPromoteLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            TargetReliquaryGuid = input.ReadUInt64();
            break;
          }
          case 66:
          case 64: {
            oldAppendPropList_.AddEntriesFrom(input, _repeated_oldAppendPropList_codec);
            break;
          }
          case 74:
          case 72: {
            curAppendPropList_.AddEntriesFrom(input, _repeated_curAppendPropList_codec);
            break;
          }
          case 80: {
            OldPromoteLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
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
          case 16: {
            CurPromoteLevel = input.ReadUInt32();
            break;
          }
          case 48: {
            TargetReliquaryGuid = input.ReadUInt64();
            break;
          }
          case 66:
          case 64: {
            oldAppendPropList_.AddEntriesFrom(ref input, _repeated_oldAppendPropList_codec);
            break;
          }
          case 74:
          case 72: {
            curAppendPropList_.AddEntriesFrom(ref input, _repeated_curAppendPropList_codec);
            break;
          }
          case 80: {
            OldPromoteLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ReliquaryPromoteRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 694,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
