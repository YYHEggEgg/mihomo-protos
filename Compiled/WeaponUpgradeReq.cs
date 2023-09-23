// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WeaponUpgradeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WeaponUpgradeReq.proto</summary>
  public static partial class WeaponUpgradeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for WeaponUpgradeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeaponUpgradeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZXZWFwb25VcGdyYWRlUmVxLnByb3RvEg1taUhvbW8uUHJvdG9zGg9JdGVt",
            "UGFyYW0ucHJvdG8i5AEKEFdlYXBvblVwZ3JhZGVSZXESHQoVZm9vZF93ZWFw",
            "b25fZ3VpZF9saXN0GAEgAygEEjEKD2l0ZW1fcGFyYW1fbGlzdBgPIAMoCzIY",
            "Lm1pSG9tby5Qcm90b3MuSXRlbVBhcmFtEhoKEnRhcmdldF93ZWFwb25fZ3Vp",
            "ZBgEIAEoBCJiCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lE",
            "EAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVOVBAB",
            "EgsKBkNNRF9JRBD/BBoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ItemParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WeaponUpgradeReq), global::MiHomo.Protos.WeaponUpgradeReq.Parser, new[]{ "FoodWeaponGuidList", "ItemParamList", "TargetWeaponGuid" }, null, new[]{ typeof(global::MiHomo.Protos.WeaponUpgradeReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WeaponUpgradeReq : pb::IMessage<WeaponUpgradeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WeaponUpgradeReq> _parser = new pb::MessageParser<WeaponUpgradeReq>(() => new WeaponUpgradeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WeaponUpgradeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WeaponUpgradeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponUpgradeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponUpgradeReq(WeaponUpgradeReq other) : this() {
      foodWeaponGuidList_ = other.foodWeaponGuidList_.Clone();
      itemParamList_ = other.itemParamList_.Clone();
      targetWeaponGuid_ = other.targetWeaponGuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WeaponUpgradeReq Clone() {
      return new WeaponUpgradeReq(this);
    }

    /// <summary>Field number for the "food_weapon_guid_list" field.</summary>
    public const int FoodWeaponGuidListFieldNumber = 1;
    private static readonly pb::FieldCodec<ulong> _repeated_foodWeaponGuidList_codec
        = pb::FieldCodec.ForUInt64(10);
    private readonly pbc::RepeatedField<ulong> foodWeaponGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> FoodWeaponGuidList {
      get { return foodWeaponGuidList_; }
    }

    /// <summary>Field number for the "item_param_list" field.</summary>
    public const int ItemParamListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ItemParam> _repeated_itemParamList_codec
        = pb::FieldCodec.ForMessage(122, global::MiHomo.Protos.ItemParam.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ItemParam> itemParamList_ = new pbc::RepeatedField<global::MiHomo.Protos.ItemParam>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ItemParam> ItemParamList {
      get { return itemParamList_; }
    }

    /// <summary>Field number for the "target_weapon_guid" field.</summary>
    public const int TargetWeaponGuidFieldNumber = 4;
    private ulong targetWeaponGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TargetWeaponGuid {
      get { return targetWeaponGuid_; }
      set {
        targetWeaponGuid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WeaponUpgradeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WeaponUpgradeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!foodWeaponGuidList_.Equals(other.foodWeaponGuidList_)) return false;
      if(!itemParamList_.Equals(other.itemParamList_)) return false;
      if (TargetWeaponGuid != other.TargetWeaponGuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= foodWeaponGuidList_.GetHashCode();
      hash ^= itemParamList_.GetHashCode();
      if (TargetWeaponGuid != 0UL) hash ^= TargetWeaponGuid.GetHashCode();
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
      foodWeaponGuidList_.WriteTo(output, _repeated_foodWeaponGuidList_codec);
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TargetWeaponGuid);
      }
      itemParamList_.WriteTo(output, _repeated_itemParamList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      foodWeaponGuidList_.WriteTo(ref output, _repeated_foodWeaponGuidList_codec);
      if (TargetWeaponGuid != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TargetWeaponGuid);
      }
      itemParamList_.WriteTo(ref output, _repeated_itemParamList_codec);
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
      size += itemParamList_.CalculateSize(_repeated_itemParamList_codec);
      if (TargetWeaponGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetWeaponGuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WeaponUpgradeReq other) {
      if (other == null) {
        return;
      }
      foodWeaponGuidList_.Add(other.foodWeaponGuidList_);
      itemParamList_.Add(other.itemParamList_);
      if (other.TargetWeaponGuid != 0UL) {
        TargetWeaponGuid = other.TargetWeaponGuid;
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
          case 10:
          case 8: {
            foodWeaponGuidList_.AddEntriesFrom(input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 32: {
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 122: {
            itemParamList_.AddEntriesFrom(input, _repeated_itemParamList_codec);
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
          case 10:
          case 8: {
            foodWeaponGuidList_.AddEntriesFrom(ref input, _repeated_foodWeaponGuidList_codec);
            break;
          }
          case 32: {
            TargetWeaponGuid = input.ReadUInt64();
            break;
          }
          case 122: {
            itemParamList_.AddEntriesFrom(ref input, _repeated_itemParamList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the WeaponUpgradeReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 639,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
