// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: QueryCodexMonsterBeKilledNumRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from QueryCodexMonsterBeKilledNumRsp.proto</summary>
  public static partial class QueryCodexMonsterBeKilledNumRspReflection {

    #region Descriptor
    /// <summary>File descriptor for QueryCodexMonsterBeKilledNumRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QueryCodexMonsterBeKilledNumRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVRdWVyeUNvZGV4TW9uc3RlckJlS2lsbGVkTnVtUnNwLnByb3RvEg1taUhv",
            "bW8uUHJvdG9zItIBCh9RdWVyeUNvZGV4TW9uc3RlckJlS2lsbGVkTnVtUnNw",
            "EhwKFGJlX2NhcHR1cmVkX251bV9saXN0GAYgAygNEhoKEmJlX2tpbGxlZF9u",
            "dW1fbGlzdBgMIAMoDRIVCg1jb2RleF9pZF9saXN0GAQgAygNEg8KB3JldGNv",
            "ZGUYBSABKAUiTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9J",
            "RBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURfSUQQ8SAaAhABYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.QueryCodexMonsterBeKilledNumRsp), global::MiHomo.Protos.QueryCodexMonsterBeKilledNumRsp.Parser, new[]{ "BeCapturedNumList", "BeKilledNumList", "CodexIdList", "Retcode" }, null, new[]{ typeof(global::MiHomo.Protos.QueryCodexMonsterBeKilledNumRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QueryCodexMonsterBeKilledNumRsp : pb::IMessage<QueryCodexMonsterBeKilledNumRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<QueryCodexMonsterBeKilledNumRsp> _parser = new pb::MessageParser<QueryCodexMonsterBeKilledNumRsp>(() => new QueryCodexMonsterBeKilledNumRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<QueryCodexMonsterBeKilledNumRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.QueryCodexMonsterBeKilledNumRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp(QueryCodexMonsterBeKilledNumRsp other) : this() {
      beCapturedNumList_ = other.beCapturedNumList_.Clone();
      beKilledNumList_ = other.beKilledNumList_.Clone();
      codexIdList_ = other.codexIdList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public QueryCodexMonsterBeKilledNumRsp Clone() {
      return new QueryCodexMonsterBeKilledNumRsp(this);
    }

    /// <summary>Field number for the "be_captured_num_list" field.</summary>
    public const int BeCapturedNumListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_beCapturedNumList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> beCapturedNumList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BeCapturedNumList {
      get { return beCapturedNumList_; }
    }

    /// <summary>Field number for the "be_killed_num_list" field.</summary>
    public const int BeKilledNumListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_beKilledNumList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> beKilledNumList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BeKilledNumList {
      get { return beKilledNumList_; }
    }

    /// <summary>Field number for the "codex_id_list" field.</summary>
    public const int CodexIdListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_codexIdList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> codexIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CodexIdList {
      get { return codexIdList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 5;
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
      return Equals(other as QueryCodexMonsterBeKilledNumRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(QueryCodexMonsterBeKilledNumRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!beCapturedNumList_.Equals(other.beCapturedNumList_)) return false;
      if(!beKilledNumList_.Equals(other.beKilledNumList_)) return false;
      if(!codexIdList_.Equals(other.codexIdList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= beCapturedNumList_.GetHashCode();
      hash ^= beKilledNumList_.GetHashCode();
      hash ^= codexIdList_.GetHashCode();
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
      codexIdList_.WriteTo(output, _repeated_codexIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      beCapturedNumList_.WriteTo(output, _repeated_beCapturedNumList_codec);
      beKilledNumList_.WriteTo(output, _repeated_beKilledNumList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      codexIdList_.WriteTo(ref output, _repeated_codexIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Retcode);
      }
      beCapturedNumList_.WriteTo(ref output, _repeated_beCapturedNumList_codec);
      beKilledNumList_.WriteTo(ref output, _repeated_beKilledNumList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += beCapturedNumList_.CalculateSize(_repeated_beCapturedNumList_codec);
      size += beKilledNumList_.CalculateSize(_repeated_beKilledNumList_codec);
      size += codexIdList_.CalculateSize(_repeated_codexIdList_codec);
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
    public void MergeFrom(QueryCodexMonsterBeKilledNumRsp other) {
      if (other == null) {
        return;
      }
      beCapturedNumList_.Add(other.beCapturedNumList_);
      beKilledNumList_.Add(other.beKilledNumList_);
      codexIdList_.Add(other.codexIdList_);
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
          case 34:
          case 32: {
            codexIdList_.AddEntriesFrom(input, _repeated_codexIdList_codec);
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 50:
          case 48: {
            beCapturedNumList_.AddEntriesFrom(input, _repeated_beCapturedNumList_codec);
            break;
          }
          case 98:
          case 96: {
            beKilledNumList_.AddEntriesFrom(input, _repeated_beKilledNumList_codec);
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
          case 34:
          case 32: {
            codexIdList_.AddEntriesFrom(ref input, _repeated_codexIdList_codec);
            break;
          }
          case 40: {
            Retcode = input.ReadInt32();
            break;
          }
          case 50:
          case 48: {
            beCapturedNumList_.AddEntriesFrom(ref input, _repeated_beCapturedNumList_codec);
            break;
          }
          case 98:
          case 96: {
            beKilledNumList_.AddEntriesFrom(ref input, _repeated_beKilledNumList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the QueryCodexMonsterBeKilledNumRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4209,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
