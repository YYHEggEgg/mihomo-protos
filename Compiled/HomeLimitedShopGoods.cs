// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopGoods.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeLimitedShopGoods.proto</summary>
  public static partial class HomeLimitedShopGoodsReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeLimitedShopGoods.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeLimitedShopGoodsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpIb21lTGltaXRlZFNob3BHb29kcy5wcm90bxINbWlIb21vLlByb3RvcxoP",
            "SXRlbVBhcmFtLnByb3RvIsUBChRIb21lTGltaXRlZFNob3BHb29kcxISCgpi",
            "b3VnaHRfbnVtGAEgASgNEhEKCWJ1eV9saW1pdBgIIAEoDRIwCg5jb3N0X2l0",
            "ZW1fbGlzdBgPIAMoCzIYLm1pSG9tby5Qcm90b3MuSXRlbVBhcmFtEhQKDGRp",
            "c2FibGVfdHlwZRgDIAEoDRIQCghnb29kc19pZBgNIAEoDRIsCgpnb29kc19p",
            "dGVtGAYgASgLMhgubWlIb21vLlByb3Rvcy5JdGVtUGFyYW1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeLimitedShopGoods), global::MiHomo.Protos.HomeLimitedShopGoods.Parser, new[]{ "BoughtNum", "BuyLimit", "CostItemList", "DisableType", "GoodsId", "GoodsItem" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeLimitedShopGoods : pb::IMessage<HomeLimitedShopGoods>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeLimitedShopGoods> _parser = new pb::MessageParser<HomeLimitedShopGoods>(() => new HomeLimitedShopGoods());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeLimitedShopGoods> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeLimitedShopGoodsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopGoods() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopGoods(HomeLimitedShopGoods other) : this() {
      boughtNum_ = other.boughtNum_;
      buyLimit_ = other.buyLimit_;
      costItemList_ = other.costItemList_.Clone();
      disableType_ = other.disableType_;
      goodsId_ = other.goodsId_;
      goodsItem_ = other.goodsItem_ != null ? other.goodsItem_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopGoods Clone() {
      return new HomeLimitedShopGoods(this);
    }

    /// <summary>Field number for the "bought_num" field.</summary>
    public const int BoughtNumFieldNumber = 1;
    private uint boughtNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BoughtNum {
      get { return boughtNum_; }
      set {
        boughtNum_ = value;
      }
    }

    /// <summary>Field number for the "buy_limit" field.</summary>
    public const int BuyLimitFieldNumber = 8;
    private uint buyLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuyLimit {
      get { return buyLimit_; }
      set {
        buyLimit_ = value;
      }
    }

    /// <summary>Field number for the "cost_item_list" field.</summary>
    public const int CostItemListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_costItemList_codec
        = pb::FieldCodec.ForMessage(122, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> costItemList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> CostItemList {
      get { return costItemList_; }
    }

    /// <summary>Field number for the "disable_type" field.</summary>
    public const int DisableTypeFieldNumber = 3;
    private uint disableType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DisableType {
      get { return disableType_; }
      set {
        disableType_ = value;
      }
    }

    /// <summary>Field number for the "goods_id" field.</summary>
    public const int GoodsIdFieldNumber = 13;
    private uint goodsId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GoodsId {
      get { return goodsId_; }
      set {
        goodsId_ = value;
      }
    }

    /// <summary>Field number for the "goods_item" field.</summary>
    public const int GoodsItemFieldNumber = 6;
    private global::MiHomo.Protos.ItemParam goodsItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ItemParam GoodsItem {
      get { return goodsItem_; }
      set {
        goodsItem_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeLimitedShopGoods);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeLimitedShopGoods other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BoughtNum != other.BoughtNum) return false;
      if (BuyLimit != other.BuyLimit) return false;
      if(!costItemList_.Equals(other.costItemList_)) return false;
      if (DisableType != other.DisableType) return false;
      if (GoodsId != other.GoodsId) return false;
      if (!object.Equals(GoodsItem, other.GoodsItem)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BoughtNum != 0) hash ^= BoughtNum.GetHashCode();
      if (BuyLimit != 0) hash ^= BuyLimit.GetHashCode();
      hash ^= costItemList_.GetHashCode();
      if (DisableType != 0) hash ^= DisableType.GetHashCode();
      if (GoodsId != 0) hash ^= GoodsId.GetHashCode();
      if (goodsItem_ != null) hash ^= GoodsItem.GetHashCode();
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
      if (BoughtNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BoughtNum);
      }
      if (DisableType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DisableType);
      }
      if (goodsItem_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GoodsItem);
      }
      if (BuyLimit != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BuyLimit);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GoodsId);
      }
      costItemList_.WriteTo(output, _repeated_costItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BoughtNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(BoughtNum);
      }
      if (DisableType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DisableType);
      }
      if (goodsItem_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(GoodsItem);
      }
      if (BuyLimit != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(BuyLimit);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GoodsId);
      }
      costItemList_.WriteTo(ref output, _repeated_costItemList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BoughtNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BoughtNum);
      }
      if (BuyLimit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuyLimit);
      }
      size += costItemList_.CalculateSize(_repeated_costItemList_codec);
      if (DisableType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DisableType);
      }
      if (GoodsId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsId);
      }
      if (goodsItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GoodsItem);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeLimitedShopGoods other) {
      if (other == null) {
        return;
      }
      if (other.BoughtNum != 0) {
        BoughtNum = other.BoughtNum;
      }
      if (other.BuyLimit != 0) {
        BuyLimit = other.BuyLimit;
      }
      costItemList_.Add(other.costItemList_);
      if (other.DisableType != 0) {
        DisableType = other.DisableType;
      }
      if (other.GoodsId != 0) {
        GoodsId = other.GoodsId;
      }
      if (other.goodsItem_ != null) {
        if (goodsItem_ == null) {
          GoodsItem = new global::MiHomo.Protos.ItemParam();
        }
        GoodsItem.MergeFrom(other.GoodsItem);
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
          case 8: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 24: {
            DisableType = input.ReadUInt32();
            break;
          }
          case 50: {
            if (goodsItem_ == null) {
              GoodsItem = new global::MiHomo.Protos.ItemParam();
            }
            input.ReadMessage(GoodsItem);
            break;
          }
          case 64: {
            BuyLimit = input.ReadUInt32();
            break;
          }
          case 104: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 122: {
            costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
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
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 24: {
            DisableType = input.ReadUInt32();
            break;
          }
          case 50: {
            if (goodsItem_ == null) {
              GoodsItem = new global::MiHomo.Protos.ItemParam();
            }
            input.ReadMessage(GoodsItem);
            break;
          }
          case 64: {
            BuyLimit = input.ReadUInt32();
            break;
          }
          case 104: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 122: {
            costItemList_.AddEntriesFrom(ref input, _repeated_costItemList_codec);
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
