// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BattlePassBuySuccNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from BattlePassBuySuccNotify.proto</summary>
  public static partial class BattlePassBuySuccNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BattlePassBuySuccNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattlePassBuySuccNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1CYXR0bGVQYXNzQnV5U3VjY05vdGlmeS5wcm90bxINbWlIb21vLlByb3Rv",
            "cxoPSXRlbVBhcmFtLnByb3RvItgBChdCYXR0bGVQYXNzQnV5U3VjY05vdGlm",
            "eRIRCglhZGRfcG9pbnQYDCABKA0SKwoJaXRlbV9saXN0GAkgAygLMhgubWlI",
            "b21vLlByb3Rvcy5JdGVtUGFyYW0SGQoRcHJvZHVjdF9wbGF5X3R5cGUYCyAB",
            "KA0SEwoLc2NoZWR1bGVfaWQYBCABKA0iTQoFQ21kSWQSCAoETk9ORRAAEhMK",
            "D0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZD",
            "TURfSUQQthQaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.BattlePassBuySuccNotify), global::MiHomo.Protos.BattlePassBuySuccNotify.Parser, new[]{ "AddPoint", "ItemList", "ProductPlayType", "ScheduleId" }, null, new[]{ typeof(global::MiHomo.Protos.BattlePassBuySuccNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattlePassBuySuccNotify : pb::IMessage<BattlePassBuySuccNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattlePassBuySuccNotify> _parser = new pb::MessageParser<BattlePassBuySuccNotify>(() => new BattlePassBuySuccNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattlePassBuySuccNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.BattlePassBuySuccNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassBuySuccNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassBuySuccNotify(BattlePassBuySuccNotify other) : this() {
      addPoint_ = other.addPoint_;
      itemList_ = other.itemList_.Clone();
      productPlayType_ = other.productPlayType_;
      scheduleId_ = other.scheduleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattlePassBuySuccNotify Clone() {
      return new BattlePassBuySuccNotify(this);
    }

    /// <summary>Field number for the "add_point" field.</summary>
    public const int AddPointFieldNumber = 12;
    private uint addPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddPoint {
      get { return addPoint_; }
      set {
        addPoint_ = value;
      }
    }

    /// <summary>Field number for the "item_list" field.</summary>
    public const int ItemListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(74, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> itemList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> ItemList {
      get { return itemList_; }
    }

    /// <summary>Field number for the "product_play_type" field.</summary>
    public const int ProductPlayTypeFieldNumber = 11;
    private uint productPlayType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ProductPlayType {
      get { return productPlayType_; }
      set {
        productPlayType_ = value;
      }
    }

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 4;
    private uint scheduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattlePassBuySuccNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattlePassBuySuccNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AddPoint != other.AddPoint) return false;
      if(!itemList_.Equals(other.itemList_)) return false;
      if (ProductPlayType != other.ProductPlayType) return false;
      if (ScheduleId != other.ScheduleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AddPoint != 0) hash ^= AddPoint.GetHashCode();
      hash ^= itemList_.GetHashCode();
      if (ProductPlayType != 0) hash ^= ProductPlayType.GetHashCode();
      if (ScheduleId != 0) hash ^= ScheduleId.GetHashCode();
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
      if (ScheduleId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ScheduleId);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (ProductPlayType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ProductPlayType);
      }
      if (AddPoint != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AddPoint);
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
      if (ScheduleId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ScheduleId);
      }
      itemList_.WriteTo(ref output, _repeated_itemList_codec);
      if (ProductPlayType != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ProductPlayType);
      }
      if (AddPoint != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AddPoint);
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
      if (AddPoint != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddPoint);
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (ProductPlayType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProductPlayType);
      }
      if (ScheduleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ScheduleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattlePassBuySuccNotify other) {
      if (other == null) {
        return;
      }
      if (other.AddPoint != 0) {
        AddPoint = other.AddPoint;
      }
      itemList_.Add(other.itemList_);
      if (other.ProductPlayType != 0) {
        ProductPlayType = other.ProductPlayType;
      }
      if (other.ScheduleId != 0) {
        ScheduleId = other.ScheduleId;
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
          case 32: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 74: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 88: {
            ProductPlayType = input.ReadUInt32();
            break;
          }
          case 96: {
            AddPoint = input.ReadUInt32();
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
          case 32: {
            ScheduleId = input.ReadUInt32();
            break;
          }
          case 74: {
            itemList_.AddEntriesFrom(ref input, _repeated_itemList_codec);
            break;
          }
          case 88: {
            ProductPlayType = input.ReadUInt32();
            break;
          }
          case 96: {
            AddPoint = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BattlePassBuySuccNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2614,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
