// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerCompoundMaterialBoostRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlayerCompoundMaterialBoostRsp.proto</summary>
  public static partial class PlayerCompoundMaterialBoostRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerCompoundMaterialBoostRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerCompoundMaterialBoostRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRQbGF5ZXJDb21wb3VuZE1hdGVyaWFsQm9vc3RSc3AucHJvdG8SDW1pSG9t",
            "by5Qcm90b3MaIUNvbXBvdW5kQm9vc3RUYWtlU3RhdHVzVHlwZS5wcm90bxoX",
            "Q29tcG91bmRRdWV1ZURhdGEucHJvdG8aD0l0ZW1QYXJhbS5wcm90byLoAQoe",
            "UGxheWVyQ29tcG91bmRNYXRlcmlhbEJvb3N0UnNwEkIKGGNvbXBvdW5kX3F1",
            "ZXVlX2RhdGFfbGlzdBgKIAMoCzIgLm1pSG9tby5Qcm90b3MuQ29tcG91bmRR",
            "dWV1ZURhdGESDwoHcmV0Y29kZRgNIAEoBRIwCg50YWtlX2l0ZW1fbGlzdBgD",
            "IAMoCzIYLm1pSG9tby5Qcm90b3MuSXRlbVBhcmFtEj8KC3Rha2Vfc3RhdHVz",
            "GAQgASgOMioubWlIb21vLlByb3Rvcy5Db21wb3VuZEJvb3N0VGFrZVN0YXR1",
            "c1R5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CompoundBoostTakeStatusTypeReflection.Descriptor, global::MiHomo.Protos.CompoundQueueDataReflection.Descriptor, global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlayerCompoundMaterialBoostRsp), global::MiHomo.Protos.PlayerCompoundMaterialBoostRsp.Parser, new[]{ "CompoundQueueDataList", "Retcode", "TakeItemList", "TakeStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerCompoundMaterialBoostRsp : pb::IMessage<PlayerCompoundMaterialBoostRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerCompoundMaterialBoostRsp> _parser = new pb::MessageParser<PlayerCompoundMaterialBoostRsp>(() => new PlayerCompoundMaterialBoostRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerCompoundMaterialBoostRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlayerCompoundMaterialBoostRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCompoundMaterialBoostRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCompoundMaterialBoostRsp(PlayerCompoundMaterialBoostRsp other) : this() {
      compoundQueueDataList_ = other.compoundQueueDataList_.Clone();
      retcode_ = other.retcode_;
      takeItemList_ = other.takeItemList_.Clone();
      takeStatus_ = other.takeStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCompoundMaterialBoostRsp Clone() {
      return new PlayerCompoundMaterialBoostRsp(this);
    }

    /// <summary>Field number for the "compound_queue_data_list" field.</summary>
    public const int CompoundQueueDataListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.CompoundQueueData> _repeated_compoundQueueDataList_codec
        = pb::FieldCodec.ForMessage(82, global::MiHomo.Protos.CompoundQueueData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.CompoundQueueData> compoundQueueDataList_ = new pbc::RepeatedField<global::MiHomo.Protos.CompoundQueueData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.CompoundQueueData> CompoundQueueDataList {
      get { return compoundQueueDataList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "take_item_list" field.</summary>
    public const int TakeItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_takeItemList_codec
        = pb::FieldCodec.ForMessage(26, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> takeItemList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> TakeItemList {
      get { return takeItemList_; }
    }

    /// <summary>Field number for the "take_status" field.</summary>
    public const int TakeStatusFieldNumber = 4;
    private global::MiHomo.Protos.CompoundBoostTakeStatusType takeStatus_ = global::MiHomo.Protos.CompoundBoostTakeStatusType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CompoundBoostTakeStatusType TakeStatus {
      get { return takeStatus_; }
      set {
        takeStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerCompoundMaterialBoostRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerCompoundMaterialBoostRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!compoundQueueDataList_.Equals(other.compoundQueueDataList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!takeItemList_.Equals(other.takeItemList_)) return false;
      if (TakeStatus != other.TakeStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= compoundQueueDataList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= takeItemList_.GetHashCode();
      if (TakeStatus != global::MiHomo.Protos.CompoundBoostTakeStatusType.None) hash ^= TakeStatus.GetHashCode();
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
      takeItemList_.WriteTo(output, _repeated_takeItemList_codec);
      if (TakeStatus != global::MiHomo.Protos.CompoundBoostTakeStatusType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) TakeStatus);
      }
      compoundQueueDataList_.WriteTo(output, _repeated_compoundQueueDataList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      takeItemList_.WriteTo(ref output, _repeated_takeItemList_codec);
      if (TakeStatus != global::MiHomo.Protos.CompoundBoostTakeStatusType.None) {
        output.WriteRawTag(32);
        output.WriteEnum((int) TakeStatus);
      }
      compoundQueueDataList_.WriteTo(ref output, _repeated_compoundQueueDataList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      size += compoundQueueDataList_.CalculateSize(_repeated_compoundQueueDataList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += takeItemList_.CalculateSize(_repeated_takeItemList_codec);
      if (TakeStatus != global::MiHomo.Protos.CompoundBoostTakeStatusType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TakeStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerCompoundMaterialBoostRsp other) {
      if (other == null) {
        return;
      }
      compoundQueueDataList_.Add(other.compoundQueueDataList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      takeItemList_.Add(other.takeItemList_);
      if (other.TakeStatus != global::MiHomo.Protos.CompoundBoostTakeStatusType.None) {
        TakeStatus = other.TakeStatus;
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
          case 26: {
            takeItemList_.AddEntriesFrom(input, _repeated_takeItemList_codec);
            break;
          }
          case 32: {
            TakeStatus = (global::MiHomo.Protos.CompoundBoostTakeStatusType) input.ReadEnum();
            break;
          }
          case 82: {
            compoundQueueDataList_.AddEntriesFrom(input, _repeated_compoundQueueDataList_codec);
            break;
          }
          case 104: {
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
          case 26: {
            takeItemList_.AddEntriesFrom(ref input, _repeated_takeItemList_codec);
            break;
          }
          case 32: {
            TakeStatus = (global::MiHomo.Protos.CompoundBoostTakeStatusType) input.ReadEnum();
            break;
          }
          case 82: {
            compoundQueueDataList_.AddEntriesFrom(ref input, _repeated_compoundQueueDataList_codec);
            break;
          }
          case 104: {
            Retcode = input.ReadInt32();
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
