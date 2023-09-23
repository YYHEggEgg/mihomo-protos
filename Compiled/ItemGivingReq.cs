// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ItemGivingReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ItemGivingReq.proto</summary>
  public static partial class ItemGivingReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ItemGivingReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ItemGivingReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNJdGVtR2l2aW5nUmVxLnByb3RvEg1taUhvbW8uUHJvdG9zGg9JdGVtUGFy",
            "YW0ucHJvdG8iswMKDUl0ZW1HaXZpbmdSZXESEQoJZ2l2aW5nX2lkGA0gASgN",
            "EkUKEGl0ZW1fZ2l2aW5nX3R5cGUYAiABKA4yKy5taUhvbW8uUHJvdG9zLkl0",
            "ZW1HaXZpbmdSZXEuSXRlbUdpdmluZ1R5cGUSMQoPaXRlbV9wYXJhbV9saXN0",
            "GAQgAygLMhgubWlIb21vLlByb3Rvcy5JdGVtUGFyYW0STwoTaXRlbV9ndWlk",
            "X2NvdW50X21hcBgPIAMoCzIyLm1pSG9tby5Qcm90b3MuSXRlbUdpdmluZ1Jl",
            "cS5JdGVtR3VpZENvdW50TWFwRW50cnkaNwoVSXRlbUd1aWRDb3VudE1hcEVu",
            "dHJ5EgsKA2tleRgBIAEoBBINCgV2YWx1ZRgCIAEoDToCOAEiYgoFQ21kSWQS",
            "CAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVM",
            "SUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARILCgZDTURfSUQQjAEaAhAB",
            "IicKDkl0ZW1HaXZpbmdUeXBlEgkKBVFVRVNUEAASCgoGR0FER0VUEAFiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ItemGivingReq), global::MiHomo.Protos.ItemGivingReq.Parser, new[]{ "GivingId", "ItemGivingType", "ItemParamList", "ItemGuidCountMap" }, null, new[]{ typeof(global::MiHomo.Protos.ItemGivingReq.Types.CmdId), typeof(global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ItemGivingReq : pb::IMessage<ItemGivingReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ItemGivingReq> _parser = new pb::MessageParser<ItemGivingReq>(() => new ItemGivingReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ItemGivingReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ItemGivingReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemGivingReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemGivingReq(ItemGivingReq other) : this() {
      givingId_ = other.givingId_;
      itemGivingType_ = other.itemGivingType_;
      itemParamList_ = other.itemParamList_.Clone();
      itemGuidCountMap_ = other.itemGuidCountMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ItemGivingReq Clone() {
      return new ItemGivingReq(this);
    }

    /// <summary>Field number for the "giving_id" field.</summary>
    public const int GivingIdFieldNumber = 13;
    private uint givingId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GivingId {
      get { return givingId_; }
      set {
        givingId_ = value;
      }
    }

    /// <summary>Field number for the "item_giving_type" field.</summary>
    public const int ItemGivingTypeFieldNumber = 2;
    private global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType itemGivingType_ = global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType.Quest;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType ItemGivingType {
      get { return itemGivingType_; }
      set {
        itemGivingType_ = value;
      }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> itemParamList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    /// <summary>Field number for the "item_guid_count_map" field.</summary>
    public const int ItemGuidCountMapFieldNumber = 15;
    private static readonly pbc::MapField<ulong, uint>.Codec _map_itemGuidCountMap_codec
        = new pbc::MapField<ulong, uint>.Codec(pb::FieldCodec.ForUInt64(8, 0UL), pb::FieldCodec.ForUInt32(16, 0), 122);
    private readonly pbc::MapField<ulong, uint> itemGuidCountMap_ = new pbc::MapField<ulong, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<ulong, uint> ItemGuidCountMap {
      get { return itemGuidCountMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ItemGivingReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ItemGivingReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GivingId != other.GivingId) return false;
      if (ItemGivingType != other.ItemGivingType) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      if (!ItemGuidCountMap.Equals(other.ItemGuidCountMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GivingId != 0) hash ^= GivingId.GetHashCode();
      if (ItemGivingType != global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType.Quest) hash ^= ItemGivingType.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
      hash ^= ItemGuidCountMap.GetHashCode();
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
      if (ItemGivingType != global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType.Quest) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ItemGivingType);
      }
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      if (GivingId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GivingId);
      }
      itemGuidCountMap_.WriteTo(output, _map_itemGuidCountMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ItemGivingType != global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType.Quest) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ItemGivingType);
      }
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
      if (GivingId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GivingId);
      }
      itemGuidCountMap_.WriteTo(ref output, _map_itemGuidCountMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GivingId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GivingId);
      }
      if (ItemGivingType != global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType.Quest) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemGivingType);
      }
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      size += itemGuidCountMap_.CalculateSize(_map_itemGuidCountMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ItemGivingReq other) {
      if (other == null) {
        return;
      }
      if (other.GivingId != 0) {
        GivingId = other.GivingId;
      }
      if (other.ItemGivingType != global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType.Quest) {
        ItemGivingType = other.ItemGivingType;
      }
      itemParamList_.Add(other.itemParamList_);
      itemGuidCountMap_.Add(other.itemGuidCountMap_);
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
            ItemGivingType = (global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType) input.ReadEnum();
            break;
          }
          case 34: {
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
            break;
          }
          case 104: {
            GivingId = input.ReadUInt32();
            break;
          }
          case 122: {
            itemGuidCountMap_.AddEntriesFrom(input, _map_itemGuidCountMap_codec);
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
            ItemGivingType = (global::MiHomo.Protos.ItemGivingReq.Types.ItemGivingType) input.ReadEnum();
            break;
          }
          case 34: {
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
          case 104: {
            GivingId = input.ReadUInt32();
            break;
          }
          case 122: {
            itemGuidCountMap_.AddEntriesFrom(ref input, _map_itemGuidCountMap_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ItemGivingReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 140,
      }

      public enum ItemGivingType {
        [pbr::OriginalName("QUEST")] Quest = 0,
        [pbr::OriginalName("GADGET")] Gadget = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
