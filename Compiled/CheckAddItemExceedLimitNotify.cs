// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CheckAddItemExceedLimitNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CheckAddItemExceedLimitNotify.proto</summary>
  public static partial class CheckAddItemExceedLimitNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CheckAddItemExceedLimitNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CheckAddItemExceedLimitNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNDaGVja0FkZEl0ZW1FeGNlZWRMaW1pdE5vdGlmeS5wcm90bxINbWlIb21v",
            "LlByb3RvcyLOAwodQ2hlY2tBZGRJdGVtRXhjZWVkTGltaXROb3RpZnkSGgoS",
            "ZXhjZWVkZWRfaXRlbV9saXN0GAwgAygNEh8KF2V4Y2VlZGVkX2l0ZW1fdHlw",
            "ZV9saXN0GAogAygNEg8KB2lzX2Ryb3AYBSABKAgSVQoIbXNnX3R5cGUYBCAB",
            "KA4yQy5taUhvbW8uUHJvdG9zLkNoZWNrQWRkSXRlbUV4Y2VlZExpbWl0Tm90",
            "aWZ5Lkl0ZW1FeGNlZWRMaW1pdE1zZ1R5cGUSDgoGcmVhc29uGA4gASgNIk0K",
            "BUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVU",
            "X0lTX1JFTElBQkxFEAESCwoGQ01EX0lEELQFGgIQASKoAQoWSXRlbUV4Y2Vl",
            "ZExpbWl0TXNnVHlwZRIhCh1JVEVNX0VYQ0VFRF9MSU1JVF9NU0dfREVGQVVM",
            "VBAAEh4KGklURU1fRVhDRUVEX0xJTUlUX01TR19URVhUEAESIAocSVRFTV9F",
            "WENFRURfTElNSVRfTVNHX0RJQUxPRxACEikKJUlURU1fRVhDRUVEX0xJTUlU",
            "X01TR19ESUFMT0dfTk9OQkxPQ0sQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CheckAddItemExceedLimitNotify), global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Parser, new[]{ "ExceededItemList", "ExceededItemTypeList", "IsDrop", "MsgType", "Reason" }, null, new[]{ typeof(global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.CmdId), typeof(global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CheckAddItemExceedLimitNotify : pb::IMessage<CheckAddItemExceedLimitNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CheckAddItemExceedLimitNotify> _parser = new pb::MessageParser<CheckAddItemExceedLimitNotify>(() => new CheckAddItemExceedLimitNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CheckAddItemExceedLimitNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CheckAddItemExceedLimitNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckAddItemExceedLimitNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckAddItemExceedLimitNotify(CheckAddItemExceedLimitNotify other) : this() {
      exceededItemList_ = other.exceededItemList_.Clone();
      exceededItemTypeList_ = other.exceededItemTypeList_.Clone();
      isDrop_ = other.isDrop_;
      msgType_ = other.msgType_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CheckAddItemExceedLimitNotify Clone() {
      return new CheckAddItemExceedLimitNotify(this);
    }

    /// <summary>Field number for the "exceeded_item_list" field.</summary>
    public const int ExceededItemListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_exceededItemList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> exceededItemList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExceededItemList {
      get { return exceededItemList_; }
    }

    /// <summary>Field number for the "exceeded_item_type_list" field.</summary>
    public const int ExceededItemTypeListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_exceededItemTypeList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> exceededItemTypeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ExceededItemTypeList {
      get { return exceededItemTypeList_; }
    }

    /// <summary>Field number for the "is_drop" field.</summary>
    public const int IsDropFieldNumber = 5;
    private bool isDrop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDrop {
      get { return isDrop_; }
      set {
        isDrop_ = value;
      }
    }

    /// <summary>Field number for the "msg_type" field.</summary>
    public const int MsgTypeFieldNumber = 4;
    private global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType msgType_ = global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.ItemExceedLimitMsgDefault;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType MsgType {
      get { return msgType_; }
      set {
        msgType_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 14;
    private uint reason_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CheckAddItemExceedLimitNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CheckAddItemExceedLimitNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!exceededItemList_.Equals(other.exceededItemList_)) return false;
      if(!exceededItemTypeList_.Equals(other.exceededItemTypeList_)) return false;
      if (IsDrop != other.IsDrop) return false;
      if (MsgType != other.MsgType) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= exceededItemList_.GetHashCode();
      hash ^= exceededItemTypeList_.GetHashCode();
      if (IsDrop != false) hash ^= IsDrop.GetHashCode();
      if (MsgType != global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.ItemExceedLimitMsgDefault) hash ^= MsgType.GetHashCode();
      if (Reason != 0) hash ^= Reason.GetHashCode();
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
      if (MsgType != global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.ItemExceedLimitMsgDefault) {
        output.WriteRawTag(32);
        output.WriteEnum((int) MsgType);
      }
      if (IsDrop != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDrop);
      }
      exceededItemTypeList_.WriteTo(output, _repeated_exceededItemTypeList_codec);
      exceededItemList_.WriteTo(output, _repeated_exceededItemList_codec);
      if (Reason != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Reason);
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
      if (MsgType != global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.ItemExceedLimitMsgDefault) {
        output.WriteRawTag(32);
        output.WriteEnum((int) MsgType);
      }
      if (IsDrop != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDrop);
      }
      exceededItemTypeList_.WriteTo(ref output, _repeated_exceededItemTypeList_codec);
      exceededItemList_.WriteTo(ref output, _repeated_exceededItemList_codec);
      if (Reason != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Reason);
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
      size += exceededItemList_.CalculateSize(_repeated_exceededItemList_codec);
      size += exceededItemTypeList_.CalculateSize(_repeated_exceededItemTypeList_codec);
      if (IsDrop != false) {
        size += 1 + 1;
      }
      if (MsgType != global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.ItemExceedLimitMsgDefault) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MsgType);
      }
      if (Reason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CheckAddItemExceedLimitNotify other) {
      if (other == null) {
        return;
      }
      exceededItemList_.Add(other.exceededItemList_);
      exceededItemTypeList_.Add(other.exceededItemTypeList_);
      if (other.IsDrop != false) {
        IsDrop = other.IsDrop;
      }
      if (other.MsgType != global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType.ItemExceedLimitMsgDefault) {
        MsgType = other.MsgType;
      }
      if (other.Reason != 0) {
        Reason = other.Reason;
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
            MsgType = (global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType) input.ReadEnum();
            break;
          }
          case 40: {
            IsDrop = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            exceededItemTypeList_.AddEntriesFrom(input, _repeated_exceededItemTypeList_codec);
            break;
          }
          case 98:
          case 96: {
            exceededItemList_.AddEntriesFrom(input, _repeated_exceededItemList_codec);
            break;
          }
          case 112: {
            Reason = input.ReadUInt32();
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
            MsgType = (global::MiHomo.Protos.CheckAddItemExceedLimitNotify.Types.ItemExceedLimitMsgType) input.ReadEnum();
            break;
          }
          case 40: {
            IsDrop = input.ReadBool();
            break;
          }
          case 82:
          case 80: {
            exceededItemTypeList_.AddEntriesFrom(ref input, _repeated_exceededItemTypeList_codec);
            break;
          }
          case 98:
          case 96: {
            exceededItemList_.AddEntriesFrom(ref input, _repeated_exceededItemList_codec);
            break;
          }
          case 112: {
            Reason = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CheckAddItemExceedLimitNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 692,
      }

      public enum ItemExceedLimitMsgType {
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_DEFAULT")] ItemExceedLimitMsgDefault = 0,
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_TEXT")] ItemExceedLimitMsgText = 1,
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_DIALOG")] ItemExceedLimitMsgDialog = 2,
        [pbr::OriginalName("ITEM_EXCEED_LIMIT_MSG_DIALOG_NONBLOCK")] ItemExceedLimitMsgDialogNonblock = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
