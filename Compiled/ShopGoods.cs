// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ShopGoods.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ShopGoods.proto</summary>
  public static partial class ShopGoodsReflection {

    #region Descriptor
    /// <summary>File descriptor for ShopGoods.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShopGoodsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TaG9wR29vZHMucHJvdG8SDW1pSG9tby5Qcm90b3MaD0l0ZW1QYXJhbS5w",
            "cm90byLtAwoJU2hvcEdvb2RzEhIKCmJlZ2luX3RpbWUYBSABKA0SEgoKYm91",
            "Z2h0X251bRgKIAEoDRIRCglidXlfbGltaXQYDCABKA0SMAoOY29zdF9pdGVt",
            "X2xpc3QYAyADKAsyGC5taUhvbW8uUHJvdG9zLkl0ZW1QYXJhbRIUCgxkaXNh",
            "YmxlX3R5cGUYBiABKA0SHAoTZGlzY291bnRfYmVnaW5fdGltZRi+BCABKA0S",
            "GgoRZGlzY291bnRfZW5kX3RpbWUYggIgASgNEhQKC2Rpc2NvdW50X2lkGM4P",
            "IAEoDRIQCghlbmRfdGltZRgLIAEoDRIQCghnb29kc19pZBgNIAEoDRIsCgpn",
            "b29kc19pdGVtGAkgASgLMhgubWlIb21vLlByb3Rvcy5JdGVtUGFyYW0SDQoF",
            "aGNvaW4YASABKA0SEQoJbWF4X2xldmVsGAQgASgNEg0KBW1jb2luGA4gASgN",
            "EhEKCW1pbl9sZXZlbBgIIAEoDRIZChFuZXh0X3JlZnJlc2hfdGltZRgHIAEo",
            "DRIZChFwcmVfZ29vZHNfaWRfbGlzdBgCIAMoDRINCgVzY29pbhgPIAEoDRIb",
            "ChJzZWNvbmRhcnlfc2hlZXRfaWQYvgIgASgNEhUKDHNpbmdsZV9saW1pdBj3",
            "ASABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ShopGoods), global::MiHomo.Protos.ShopGoods.Parser, new[]{ "BeginTime", "BoughtNum", "BuyLimit", "CostItemList", "DisableType", "DiscountBeginTime", "DiscountEndTime", "DiscountId", "EndTime", "GoodsId", "GoodsItem", "Hcoin", "MaxLevel", "Mcoin", "MinLevel", "NextRefreshTime", "PreGoodsIdList", "Scoin", "SecondarySheetId", "SingleLimit" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ShopGoods : pb::IMessage<ShopGoods>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ShopGoods> _parser = new pb::MessageParser<ShopGoods>(() => new ShopGoods());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ShopGoods> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ShopGoodsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShopGoods() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShopGoods(ShopGoods other) : this() {
      beginTime_ = other.beginTime_;
      boughtNum_ = other.boughtNum_;
      buyLimit_ = other.buyLimit_;
      costItemList_ = other.costItemList_.Clone();
      disableType_ = other.disableType_;
      discountBeginTime_ = other.discountBeginTime_;
      discountEndTime_ = other.discountEndTime_;
      discountId_ = other.discountId_;
      endTime_ = other.endTime_;
      goodsId_ = other.goodsId_;
      goodsItem_ = other.goodsItem_ != null ? other.goodsItem_.Clone() : null;
      hcoin_ = other.hcoin_;
      maxLevel_ = other.maxLevel_;
      mcoin_ = other.mcoin_;
      minLevel_ = other.minLevel_;
      nextRefreshTime_ = other.nextRefreshTime_;
      preGoodsIdList_ = other.preGoodsIdList_.Clone();
      scoin_ = other.scoin_;
      secondarySheetId_ = other.secondarySheetId_;
      singleLimit_ = other.singleLimit_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShopGoods Clone() {
      return new ShopGoods(this);
    }

    /// <summary>Field number for the "begin_time" field.</summary>
    public const int BeginTimeFieldNumber = 5;
    private uint beginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BeginTime {
      get { return beginTime_; }
      set {
        beginTime_ = value;
      }
    }

    /// <summary>Field number for the "bought_num" field.</summary>
    public const int BoughtNumFieldNumber = 10;
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
    public const int BuyLimitFieldNumber = 12;
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
    public const int CostItemListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_costItemList_codec
        = pb::FieldCodec.ForMessage(26, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> costItemList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> CostItemList {
      get { return costItemList_; }
    }

    /// <summary>Field number for the "disable_type" field.</summary>
    public const int DisableTypeFieldNumber = 6;
    private uint disableType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DisableType {
      get { return disableType_; }
      set {
        disableType_ = value;
      }
    }

    /// <summary>Field number for the "discount_begin_time" field.</summary>
    public const int DiscountBeginTimeFieldNumber = 574;
    private uint discountBeginTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiscountBeginTime {
      get { return discountBeginTime_; }
      set {
        discountBeginTime_ = value;
      }
    }

    /// <summary>Field number for the "discount_end_time" field.</summary>
    public const int DiscountEndTimeFieldNumber = 258;
    private uint discountEndTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiscountEndTime {
      get { return discountEndTime_; }
      set {
        discountEndTime_ = value;
      }
    }

    /// <summary>Field number for the "discount_id" field.</summary>
    public const int DiscountIdFieldNumber = 1998;
    private uint discountId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DiscountId {
      get { return discountId_; }
      set {
        discountId_ = value;
      }
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 11;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
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
    public const int GoodsItemFieldNumber = 9;
    private global::MiHomo.Protos.ItemParam goodsItem_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ItemParam GoodsItem {
      get { return goodsItem_; }
      set {
        goodsItem_ = value;
      }
    }

    /// <summary>Field number for the "hcoin" field.</summary>
    public const int HcoinFieldNumber = 1;
    private uint hcoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Hcoin {
      get { return hcoin_; }
      set {
        hcoin_ = value;
      }
    }

    /// <summary>Field number for the "max_level" field.</summary>
    public const int MaxLevelFieldNumber = 4;
    private uint maxLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxLevel {
      get { return maxLevel_; }
      set {
        maxLevel_ = value;
      }
    }

    /// <summary>Field number for the "mcoin" field.</summary>
    public const int McoinFieldNumber = 14;
    private uint mcoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Mcoin {
      get { return mcoin_; }
      set {
        mcoin_ = value;
      }
    }

    /// <summary>Field number for the "min_level" field.</summary>
    public const int MinLevelFieldNumber = 8;
    private uint minLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinLevel {
      get { return minLevel_; }
      set {
        minLevel_ = value;
      }
    }

    /// <summary>Field number for the "next_refresh_time" field.</summary>
    public const int NextRefreshTimeFieldNumber = 7;
    private uint nextRefreshTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NextRefreshTime {
      get { return nextRefreshTime_; }
      set {
        nextRefreshTime_ = value;
      }
    }

    /// <summary>Field number for the "pre_goods_id_list" field.</summary>
    public const int PreGoodsIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_preGoodsIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> preGoodsIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PreGoodsIdList {
      get { return preGoodsIdList_; }
    }

    /// <summary>Field number for the "scoin" field.</summary>
    public const int ScoinFieldNumber = 15;
    private uint scoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Scoin {
      get { return scoin_; }
      set {
        scoin_ = value;
      }
    }

    /// <summary>Field number for the "secondary_sheet_id" field.</summary>
    public const int SecondarySheetIdFieldNumber = 318;
    private uint secondarySheetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SecondarySheetId {
      get { return secondarySheetId_; }
      set {
        secondarySheetId_ = value;
      }
    }

    /// <summary>Field number for the "single_limit" field.</summary>
    public const int SingleLimitFieldNumber = 247;
    private uint singleLimit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SingleLimit {
      get { return singleLimit_; }
      set {
        singleLimit_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ShopGoods);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ShopGoods other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BeginTime != other.BeginTime) return false;
      if (BoughtNum != other.BoughtNum) return false;
      if (BuyLimit != other.BuyLimit) return false;
      if(!costItemList_.Equals(other.costItemList_)) return false;
      if (DisableType != other.DisableType) return false;
      if (DiscountBeginTime != other.DiscountBeginTime) return false;
      if (DiscountEndTime != other.DiscountEndTime) return false;
      if (DiscountId != other.DiscountId) return false;
      if (EndTime != other.EndTime) return false;
      if (GoodsId != other.GoodsId) return false;
      if (!object.Equals(GoodsItem, other.GoodsItem)) return false;
      if (Hcoin != other.Hcoin) return false;
      if (MaxLevel != other.MaxLevel) return false;
      if (Mcoin != other.Mcoin) return false;
      if (MinLevel != other.MinLevel) return false;
      if (NextRefreshTime != other.NextRefreshTime) return false;
      if(!preGoodsIdList_.Equals(other.preGoodsIdList_)) return false;
      if (Scoin != other.Scoin) return false;
      if (SecondarySheetId != other.SecondarySheetId) return false;
      if (SingleLimit != other.SingleLimit) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BeginTime != 0) hash ^= BeginTime.GetHashCode();
      if (BoughtNum != 0) hash ^= BoughtNum.GetHashCode();
      if (BuyLimit != 0) hash ^= BuyLimit.GetHashCode();
      hash ^= costItemList_.GetHashCode();
      if (DisableType != 0) hash ^= DisableType.GetHashCode();
      if (DiscountBeginTime != 0) hash ^= DiscountBeginTime.GetHashCode();
      if (DiscountEndTime != 0) hash ^= DiscountEndTime.GetHashCode();
      if (DiscountId != 0) hash ^= DiscountId.GetHashCode();
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (GoodsId != 0) hash ^= GoodsId.GetHashCode();
      if (goodsItem_ != null) hash ^= GoodsItem.GetHashCode();
      if (Hcoin != 0) hash ^= Hcoin.GetHashCode();
      if (MaxLevel != 0) hash ^= MaxLevel.GetHashCode();
      if (Mcoin != 0) hash ^= Mcoin.GetHashCode();
      if (MinLevel != 0) hash ^= MinLevel.GetHashCode();
      if (NextRefreshTime != 0) hash ^= NextRefreshTime.GetHashCode();
      hash ^= preGoodsIdList_.GetHashCode();
      if (Scoin != 0) hash ^= Scoin.GetHashCode();
      if (SecondarySheetId != 0) hash ^= SecondarySheetId.GetHashCode();
      if (SingleLimit != 0) hash ^= SingleLimit.GetHashCode();
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
      if (Hcoin != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Hcoin);
      }
      preGoodsIdList_.WriteTo(output, _repeated_preGoodsIdList_codec);
      costItemList_.WriteTo(output, _repeated_costItemList_codec);
      if (MaxLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxLevel);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BeginTime);
      }
      if (DisableType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DisableType);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NextRefreshTime);
      }
      if (MinLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MinLevel);
      }
      if (goodsItem_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(GoodsItem);
      }
      if (BoughtNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BoughtNum);
      }
      if (EndTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EndTime);
      }
      if (BuyLimit != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BuyLimit);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GoodsId);
      }
      if (Mcoin != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Mcoin);
      }
      if (Scoin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Scoin);
      }
      if (SingleLimit != 0) {
        output.WriteRawTag(184, 15);
        output.WriteUInt32(SingleLimit);
      }
      if (DiscountEndTime != 0) {
        output.WriteRawTag(144, 16);
        output.WriteUInt32(DiscountEndTime);
      }
      if (SecondarySheetId != 0) {
        output.WriteRawTag(240, 19);
        output.WriteUInt32(SecondarySheetId);
      }
      if (DiscountBeginTime != 0) {
        output.WriteRawTag(240, 35);
        output.WriteUInt32(DiscountBeginTime);
      }
      if (DiscountId != 0) {
        output.WriteRawTag(240, 124);
        output.WriteUInt32(DiscountId);
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
      if (Hcoin != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Hcoin);
      }
      preGoodsIdList_.WriteTo(ref output, _repeated_preGoodsIdList_codec);
      costItemList_.WriteTo(ref output, _repeated_costItemList_codec);
      if (MaxLevel != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MaxLevel);
      }
      if (BeginTime != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(BeginTime);
      }
      if (DisableType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DisableType);
      }
      if (NextRefreshTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(NextRefreshTime);
      }
      if (MinLevel != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(MinLevel);
      }
      if (goodsItem_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(GoodsItem);
      }
      if (BoughtNum != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(BoughtNum);
      }
      if (EndTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EndTime);
      }
      if (BuyLimit != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BuyLimit);
      }
      if (GoodsId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GoodsId);
      }
      if (Mcoin != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Mcoin);
      }
      if (Scoin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Scoin);
      }
      if (SingleLimit != 0) {
        output.WriteRawTag(184, 15);
        output.WriteUInt32(SingleLimit);
      }
      if (DiscountEndTime != 0) {
        output.WriteRawTag(144, 16);
        output.WriteUInt32(DiscountEndTime);
      }
      if (SecondarySheetId != 0) {
        output.WriteRawTag(240, 19);
        output.WriteUInt32(SecondarySheetId);
      }
      if (DiscountBeginTime != 0) {
        output.WriteRawTag(240, 35);
        output.WriteUInt32(DiscountBeginTime);
      }
      if (DiscountId != 0) {
        output.WriteRawTag(240, 124);
        output.WriteUInt32(DiscountId);
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
      if (BeginTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BeginTime);
      }
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
      if (DiscountBeginTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DiscountBeginTime);
      }
      if (DiscountEndTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DiscountEndTime);
      }
      if (DiscountId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DiscountId);
      }
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (GoodsId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GoodsId);
      }
      if (goodsItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GoodsItem);
      }
      if (Hcoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hcoin);
      }
      if (MaxLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxLevel);
      }
      if (Mcoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Mcoin);
      }
      if (MinLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinLevel);
      }
      if (NextRefreshTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NextRefreshTime);
      }
      size += preGoodsIdList_.CalculateSize(_repeated_preGoodsIdList_codec);
      if (Scoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Scoin);
      }
      if (SecondarySheetId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SecondarySheetId);
      }
      if (SingleLimit != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SingleLimit);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ShopGoods other) {
      if (other == null) {
        return;
      }
      if (other.BeginTime != 0) {
        BeginTime = other.BeginTime;
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
      if (other.DiscountBeginTime != 0) {
        DiscountBeginTime = other.DiscountBeginTime;
      }
      if (other.DiscountEndTime != 0) {
        DiscountEndTime = other.DiscountEndTime;
      }
      if (other.DiscountId != 0) {
        DiscountId = other.DiscountId;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
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
      if (other.Hcoin != 0) {
        Hcoin = other.Hcoin;
      }
      if (other.MaxLevel != 0) {
        MaxLevel = other.MaxLevel;
      }
      if (other.Mcoin != 0) {
        Mcoin = other.Mcoin;
      }
      if (other.MinLevel != 0) {
        MinLevel = other.MinLevel;
      }
      if (other.NextRefreshTime != 0) {
        NextRefreshTime = other.NextRefreshTime;
      }
      preGoodsIdList_.Add(other.preGoodsIdList_);
      if (other.Scoin != 0) {
        Scoin = other.Scoin;
      }
      if (other.SecondarySheetId != 0) {
        SecondarySheetId = other.SecondarySheetId;
      }
      if (other.SingleLimit != 0) {
        SingleLimit = other.SingleLimit;
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
            Hcoin = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            preGoodsIdList_.AddEntriesFrom(input, _repeated_preGoodsIdList_codec);
            break;
          }
          case 26: {
            costItemList_.AddEntriesFrom(input, _repeated_costItemList_codec);
            break;
          }
          case 32: {
            MaxLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            BeginTime = input.ReadUInt32();
            break;
          }
          case 48: {
            DisableType = input.ReadUInt32();
            break;
          }
          case 56: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 64: {
            MinLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            if (goodsItem_ == null) {
              GoodsItem = new global::MiHomo.Protos.ItemParam();
            }
            input.ReadMessage(GoodsItem);
            break;
          }
          case 80: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 88: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 96: {
            BuyLimit = input.ReadUInt32();
            break;
          }
          case 104: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 112: {
            Mcoin = input.ReadUInt32();
            break;
          }
          case 120: {
            Scoin = input.ReadUInt32();
            break;
          }
          case 1976: {
            SingleLimit = input.ReadUInt32();
            break;
          }
          case 2064: {
            DiscountEndTime = input.ReadUInt32();
            break;
          }
          case 2544: {
            SecondarySheetId = input.ReadUInt32();
            break;
          }
          case 4592: {
            DiscountBeginTime = input.ReadUInt32();
            break;
          }
          case 15984: {
            DiscountId = input.ReadUInt32();
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
            Hcoin = input.ReadUInt32();
            break;
          }
          case 18:
          case 16: {
            preGoodsIdList_.AddEntriesFrom(ref input, _repeated_preGoodsIdList_codec);
            break;
          }
          case 26: {
            costItemList_.AddEntriesFrom(ref input, _repeated_costItemList_codec);
            break;
          }
          case 32: {
            MaxLevel = input.ReadUInt32();
            break;
          }
          case 40: {
            BeginTime = input.ReadUInt32();
            break;
          }
          case 48: {
            DisableType = input.ReadUInt32();
            break;
          }
          case 56: {
            NextRefreshTime = input.ReadUInt32();
            break;
          }
          case 64: {
            MinLevel = input.ReadUInt32();
            break;
          }
          case 74: {
            if (goodsItem_ == null) {
              GoodsItem = new global::MiHomo.Protos.ItemParam();
            }
            input.ReadMessage(GoodsItem);
            break;
          }
          case 80: {
            BoughtNum = input.ReadUInt32();
            break;
          }
          case 88: {
            EndTime = input.ReadUInt32();
            break;
          }
          case 96: {
            BuyLimit = input.ReadUInt32();
            break;
          }
          case 104: {
            GoodsId = input.ReadUInt32();
            break;
          }
          case 112: {
            Mcoin = input.ReadUInt32();
            break;
          }
          case 120: {
            Scoin = input.ReadUInt32();
            break;
          }
          case 1976: {
            SingleLimit = input.ReadUInt32();
            break;
          }
          case 2064: {
            DiscountEndTime = input.ReadUInt32();
            break;
          }
          case 2544: {
            SecondarySheetId = input.ReadUInt32();
            break;
          }
          case 4592: {
            DiscountBeginTime = input.ReadUInt32();
            break;
          }
          case 15984: {
            DiscountId = input.ReadUInt32();
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
