// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FurnitureMakeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FurnitureMakeRsp.proto</summary>
  public static partial class FurnitureMakeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for FurnitureMakeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FurnitureMakeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGdXJuaXR1cmVNYWtlUnNwLnByb3RvEg1taUhvbW8uUHJvdG9zGh9GdXJu",
            "aXR1cmVNYWtlQmVIZWxwZWREYXRhLnByb3RvGhtGdXJuaXR1cmVNYWtlSGVs",
            "cERhdGEucHJvdG8aF0Z1cm5pdHVyZU1ha2VJbmZvLnByb3RvGhdGdXJuaXR1",
            "cmVNYWtlU2xvdC5wcm90byKeAgoQRnVybml0dXJlTWFrZVJzcBI9ChNmdXJu",
            "aXR1cmVfbWFrZV9zbG90GA0gASgLMiAubWlIb21vLlByb3Rvcy5GdXJuaXR1",
            "cmVNYWtlU2xvdBI8Cg5oZWxwX2RhdGFfbGlzdBgEIAMoCzIkLm1pSG9tby5Q",
            "cm90b3MuRnVybml0dXJlTWFrZUhlbHBEYXRhEkIKEGhlbHBlZF9kYXRhX2xp",
            "c3QYBiADKAsyKC5taUhvbW8uUHJvdG9zLkZ1cm5pdHVyZU1ha2VCZUhlbHBl",
            "ZERhdGESOAoObWFrZV9pbmZvX2xpc3QYByADKAsyIC5taUhvbW8uUHJvdG9z",
            "LkZ1cm5pdHVyZU1ha2VJbmZvEg8KB3JldGNvZGUYCyABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FurnitureMakeBeHelpedDataReflection.Descriptor, global::MiHomo.Protos.FurnitureMakeHelpDataReflection.Descriptor, global::MiHomo.Protos.FurnitureMakeInfoReflection.Descriptor, global::MiHomo.Protos.FurnitureMakeSlotReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FurnitureMakeRsp), global::MiHomo.Protos.FurnitureMakeRsp.Parser, new[]{ "FurnitureMakeSlot", "HelpDataList", "HelpedDataList", "MakeInfoList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FurnitureMakeRsp : pb::IMessage<FurnitureMakeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FurnitureMakeRsp> _parser = new pb::MessageParser<FurnitureMakeRsp>(() => new FurnitureMakeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FurnitureMakeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FurnitureMakeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeRsp(FurnitureMakeRsp other) : this() {
      furnitureMakeSlot_ = other.furnitureMakeSlot_ != null ? other.furnitureMakeSlot_.Clone() : null;
      helpDataList_ = other.helpDataList_.Clone();
      helpedDataList_ = other.helpedDataList_.Clone();
      makeInfoList_ = other.makeInfoList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FurnitureMakeRsp Clone() {
      return new FurnitureMakeRsp(this);
    }

    /// <summary>Field number for the "furniture_make_slot" field.</summary>
    public const int FurnitureMakeSlotFieldNumber = 13;
    private global::MiHomo.Protos.FurnitureMakeSlot furnitureMakeSlot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.FurnitureMakeSlot FurnitureMakeSlot {
      get { return furnitureMakeSlot_; }
      set {
        furnitureMakeSlot_ = value;
      }
    }

    /// <summary>Field number for the "help_data_list" field.</summary>
    public const int HelpDataListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FurnitureMakeHelpData> _repeated_helpDataList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.FurnitureMakeHelpData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeHelpData> helpDataList_ = new pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeHelpData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeHelpData> HelpDataList {
      get { return helpDataList_; }
    }

    /// <summary>Field number for the "helped_data_list" field.</summary>
    public const int HelpedDataListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FurnitureMakeBeHelpedData> _repeated_helpedDataList_codec
        = pb::FieldCodec.ForMessage(50, global::MiHomo.Protos.FurnitureMakeBeHelpedData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeBeHelpedData> helpedDataList_ = new pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeBeHelpedData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeBeHelpedData> HelpedDataList {
      get { return helpedDataList_; }
    }

    /// <summary>Field number for the "make_info_list" field.</summary>
    public const int MakeInfoListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FurnitureMakeInfo> _repeated_makeInfoList_codec
        = pb::FieldCodec.ForMessage(58, global::MiHomo.Protos.FurnitureMakeInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeInfo> makeInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FurnitureMakeInfo> MakeInfoList {
      get { return makeInfoList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 11;
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
      return Equals(other as FurnitureMakeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FurnitureMakeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(FurnitureMakeSlot, other.FurnitureMakeSlot)) return false;
      if(!helpDataList_.Equals(other.helpDataList_)) return false;
      if(!helpedDataList_.Equals(other.helpedDataList_)) return false;
      if(!makeInfoList_.Equals(other.makeInfoList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (furnitureMakeSlot_ != null) hash ^= FurnitureMakeSlot.GetHashCode();
      hash ^= helpDataList_.GetHashCode();
      hash ^= helpedDataList_.GetHashCode();
      hash ^= makeInfoList_.GetHashCode();
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
      helpDataList_.WriteTo(output, _repeated_helpDataList_codec);
      helpedDataList_.WriteTo(output, _repeated_helpedDataList_codec);
      makeInfoList_.WriteTo(output, _repeated_makeInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(FurnitureMakeSlot);
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
      helpDataList_.WriteTo(ref output, _repeated_helpDataList_codec);
      helpedDataList_.WriteTo(ref output, _repeated_helpedDataList_codec);
      makeInfoList_.WriteTo(ref output, _repeated_makeInfoList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(Retcode);
      }
      if (furnitureMakeSlot_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(FurnitureMakeSlot);
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
      if (furnitureMakeSlot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FurnitureMakeSlot);
      }
      size += helpDataList_.CalculateSize(_repeated_helpDataList_codec);
      size += helpedDataList_.CalculateSize(_repeated_helpedDataList_codec);
      size += makeInfoList_.CalculateSize(_repeated_makeInfoList_codec);
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
    public void MergeFrom(FurnitureMakeRsp other) {
      if (other == null) {
        return;
      }
      if (other.furnitureMakeSlot_ != null) {
        if (furnitureMakeSlot_ == null) {
          FurnitureMakeSlot = new global::MiHomo.Protos.FurnitureMakeSlot();
        }
        FurnitureMakeSlot.MergeFrom(other.FurnitureMakeSlot);
      }
      helpDataList_.Add(other.helpDataList_);
      helpedDataList_.Add(other.helpedDataList_);
      makeInfoList_.Add(other.makeInfoList_);
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
          case 34: {
            helpDataList_.AddEntriesFrom(input, _repeated_helpDataList_codec);
            break;
          }
          case 50: {
            helpedDataList_.AddEntriesFrom(input, _repeated_helpedDataList_codec);
            break;
          }
          case 58: {
            makeInfoList_.AddEntriesFrom(input, _repeated_makeInfoList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 106: {
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::MiHomo.Protos.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
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
          case 34: {
            helpDataList_.AddEntriesFrom(ref input, _repeated_helpDataList_codec);
            break;
          }
          case 50: {
            helpedDataList_.AddEntriesFrom(ref input, _repeated_helpedDataList_codec);
            break;
          }
          case 58: {
            makeInfoList_.AddEntriesFrom(ref input, _repeated_makeInfoList_codec);
            break;
          }
          case 88: {
            Retcode = input.ReadInt32();
            break;
          }
          case 106: {
            if (furnitureMakeSlot_ == null) {
              FurnitureMakeSlot = new global::MiHomo.Protos.FurnitureMakeSlot();
            }
            input.ReadMessage(FurnitureMakeSlot);
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
