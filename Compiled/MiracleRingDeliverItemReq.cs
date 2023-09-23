// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MiracleRingDeliverItemReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MiracleRingDeliverItemReq.proto</summary>
  public static partial class MiracleRingDeliverItemReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MiracleRingDeliverItemReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MiracleRingDeliverItemReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9NaXJhY2xlUmluZ0RlbGl2ZXJJdGVtUmVxLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zGhFJbnRlck9wVHlwZS5wcm90bxoPSXRlbVBhcmFtLnByb3RvIqsCChlN",
            "aXJhY2xlUmluZ0RlbGl2ZXJJdGVtUmVxEh0KFWZvb2Rfd2VhcG9uX2d1aWRf",
            "bGlzdBgEIAMoBBIYChBnYWRnZXRfZW50aXR5X2lkGAUgASgNEhEKCWdhZGdl",
            "dF9pZBgOIAEoDRIxCg9pdGVtX3BhcmFtX2xpc3QYASADKAsyGC5taUhvbW8u",
            "UHJvdG9zLkl0ZW1QYXJhbRIrCgdvcF90eXBlGAkgASgOMhoubWlIb21vLlBy",
            "b3Rvcy5JbnRlck9wVHlwZSJiCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9D",
            "SEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9X",
            "X0NMSUVOVBABEgsKBkNNRF9JRBDtKBoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.InterOpTypeReflection.Descriptor, global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MiracleRingDeliverItemReq), global::MiHomo.Protos.MiracleRingDeliverItemReq.Parser, new[]{ "FoodWeaponGuidList", "GadgetEntityId", "GadgetId", "ItemParamList", "OpType" }, null, new[]{ typeof(global::MiHomo.Protos.MiracleRingDeliverItemReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MiracleRingDeliverItemReq : pb::IMessage<MiracleRingDeliverItemReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MiracleRingDeliverItemReq> _parser = new pb::MessageParser<MiracleRingDeliverItemReq>(() => new MiracleRingDeliverItemReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MiracleRingDeliverItemReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MiracleRingDeliverItemReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MiracleRingDeliverItemReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MiracleRingDeliverItemReq(MiracleRingDeliverItemReq other) : this() {
      foodWeaponGuidList_ = other.foodWeaponGuidList_.Clone();
      gadgetEntityId_ = other.gadgetEntityId_;
      gadgetId_ = other.gadgetId_;
      itemParamList_ = other.itemParamList_.Clone();
      opType_ = other.opType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MiracleRingDeliverItemReq Clone() {
      return new MiracleRingDeliverItemReq(this);
    }

    /// <summary>Field number for the "food_weapon_guid_list" field.</summary>
    public const int FoodWeaponGuidListFieldNumber = 4;
    private static readonly pb::FieldCodec<ulong> _repeated_foodWeaponGuidList_codec
        = pb::FieldCodec.ForUInt64(34);
    private readonly pbc::RepeatedField<ulong> foodWeaponGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> FoodWeaponGuidList {
      get { return foodWeaponGuidList_; }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 5;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 14;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(10, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> itemParamList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    /// <summary>Field number for the "op_type" field.</summary>
    public const int OpTypeFieldNumber = 9;
    private global::MiHomo.Protos.InterOpType opType_ = global::MiHomo.Protos.InterOpType.InterOpFinish;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.InterOpType OpType {
      get { return opType_; }
      set {
        opType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MiracleRingDeliverItemReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MiracleRingDeliverItemReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!foodWeaponGuidList_.Equals(other.foodWeaponGuidList_)) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      if (GadgetId != other.GadgetId) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      if (OpType != other.OpType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= foodWeaponGuidList_.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
      if (OpType != global::MiHomo.Protos.InterOpType.InterOpFinish) hash ^= OpType.GetHashCode();
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
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      foodWeaponGuidList_.WriteTo(output, _repeated_foodWeaponGuidList_codec);
      if (GadgetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::MiHomo.Protos.InterOpType.InterOpFinish) {
        output.WriteRawTag(72);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GadgetId);
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
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
      foodWeaponGuidList_.WriteTo(ref output, _repeated_foodWeaponGuidList_codec);
      if (GadgetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GadgetEntityId);
      }
      if (OpType != global::MiHomo.Protos.InterOpType.InterOpFinish) {
        output.WriteRawTag(72);
        output.WriteEnum((int) OpType);
      }
      if (GadgetId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(GadgetId);
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
      size += foodWeaponGuidList_.CalculateSize(_repeated_foodWeaponGuidList_codec);
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      if (OpType != global::MiHomo.Protos.InterOpType.InterOpFinish) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MiracleRingDeliverItemReq other) {
      if (other == null) {
        return;
      }
      foodWeaponGuidList_.Add(other.foodWeaponGuidList_);
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      itemParamList_.Add(other.itemParamList_);
      if (other.OpType != global::MiHomo.Protos.InterOpType.InterOpFinish) {
        OpType = other.OpType;
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
          case 10: {
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
            break;
          }
          case 34:
          case 32: {
            foodWeaponGuidList_.AddEntriesFrom(input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 40: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            OpType = (global::MiHomo.Protos.InterOpType) input.ReadEnum();
            break;
          }
          case 112: {
            GadgetId = input.ReadUInt32();
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
          case 10: {
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
          case 34:
          case 32: {
            foodWeaponGuidList_.AddEntriesFrom(ref input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 40: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 72: {
            OpType = (global::MiHomo.Protos.InterOpType) input.ReadEnum();
            break;
          }
          case 112: {
            GadgetId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MiracleRingDeliverItemReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 5229,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
