// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeGetBlueprintSlotInfoRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeGetBlueprintSlotInfoRsp.proto</summary>
  public static partial class HomeGetBlueprintSlotInfoRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeGetBlueprintSlotInfoRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeGetBlueprintSlotInfoRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFIb21lR2V0Qmx1ZXByaW50U2xvdEluZm9Sc3AucHJvdG8SDW1pSG9tby5Q",
            "cm90b3MaG0hvbWVCbHVlcHJpbnRTbG90SW5mby5wcm90byLYAQobSG9tZUdl",
            "dEJsdWVwcmludFNsb3RJbmZvUnNwEhsKE2RlbGV0ZV9zbG90X2lkX2xpc3QY",
            "BiADKA0SDwoHcmV0Y29kZRgPIAEoBRI8Cg5zbG90X2luZm9fbGlzdBgDIAMo",
            "CzIkLm1pSG9tby5Qcm90b3MuSG9tZUJsdWVwcmludFNsb3RJbmZvIk0KBUNt",
            "ZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lT",
            "X1JFTElBQkxFEAESCwoGQ01EX0lEELYkGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeBlueprintSlotInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeGetBlueprintSlotInfoRsp), global::MiHomo.Protos.HomeGetBlueprintSlotInfoRsp.Parser, new[]{ "DeleteSlotIdList", "Retcode", "SlotInfoList" }, null, new[]{ typeof(global::MiHomo.Protos.HomeGetBlueprintSlotInfoRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeGetBlueprintSlotInfoRsp : pb::IMessage<HomeGetBlueprintSlotInfoRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeGetBlueprintSlotInfoRsp> _parser = new pb::MessageParser<HomeGetBlueprintSlotInfoRsp>(() => new HomeGetBlueprintSlotInfoRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeGetBlueprintSlotInfoRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeGetBlueprintSlotInfoRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGetBlueprintSlotInfoRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGetBlueprintSlotInfoRsp(HomeGetBlueprintSlotInfoRsp other) : this() {
      deleteSlotIdList_ = other.deleteSlotIdList_.Clone();
      retcode_ = other.retcode_;
      slotInfoList_ = other.slotInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeGetBlueprintSlotInfoRsp Clone() {
      return new HomeGetBlueprintSlotInfoRsp(this);
    }

    /// <summary>Field number for the "delete_slot_id_list" field.</summary>
    public const int DeleteSlotIdListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_deleteSlotIdList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> deleteSlotIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DeleteSlotIdList {
      get { return deleteSlotIdList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 15;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "slot_info_list" field.</summary>
    public const int SlotInfoListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.HomeBlueprintSlotInfo> _repeated_slotInfoList_codec
        = pb::FieldCodec.ForMessage(26, global::MiHomo.Protos.HomeBlueprintSlotInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.HomeBlueprintSlotInfo> slotInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.HomeBlueprintSlotInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.HomeBlueprintSlotInfo> SlotInfoList {
      get { return slotInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeGetBlueprintSlotInfoRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeGetBlueprintSlotInfoRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!deleteSlotIdList_.Equals(other.deleteSlotIdList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!slotInfoList_.Equals(other.slotInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= deleteSlotIdList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= slotInfoList_.GetHashCode();
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
      slotInfoList_.WriteTo(output, _repeated_slotInfoList_codec);
      deleteSlotIdList_.WriteTo(output, _repeated_deleteSlotIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      slotInfoList_.WriteTo(ref output, _repeated_slotInfoList_codec);
      deleteSlotIdList_.WriteTo(ref output, _repeated_deleteSlotIdList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(120);
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
      size += deleteSlotIdList_.CalculateSize(_repeated_deleteSlotIdList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += slotInfoList_.CalculateSize(_repeated_slotInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeGetBlueprintSlotInfoRsp other) {
      if (other == null) {
        return;
      }
      deleteSlotIdList_.Add(other.deleteSlotIdList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      slotInfoList_.Add(other.slotInfoList_);
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
            slotInfoList_.AddEntriesFrom(input, _repeated_slotInfoList_codec);
            break;
          }
          case 50:
          case 48: {
            deleteSlotIdList_.AddEntriesFrom(input, _repeated_deleteSlotIdList_codec);
            break;
          }
          case 120: {
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
            slotInfoList_.AddEntriesFrom(ref input, _repeated_slotInfoList_codec);
            break;
          }
          case 50:
          case 48: {
            deleteSlotIdList_.AddEntriesFrom(ref input, _repeated_deleteSlotIdList_codec);
            break;
          }
          case 120: {
            Retcode = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the HomeGetBlueprintSlotInfoRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4662,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
