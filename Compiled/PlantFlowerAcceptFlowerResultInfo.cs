// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerAcceptFlowerResultInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlantFlowerAcceptFlowerResultInfo.proto</summary>
  public static partial class PlantFlowerAcceptFlowerResultInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlantFlowerAcceptFlowerResultInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlantFlowerAcceptFlowerResultInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQbGFudEZsb3dlckFjY2VwdEZsb3dlclJlc3VsdEluZm8ucHJvdG8SDW1p",
            "SG9tby5Qcm90b3Mi9AIKIVBsYW50Rmxvd2VyQWNjZXB0Rmxvd2VyUmVzdWx0",
            "SW5mbxILCgN1aWQYCSABKA0SZQoTVW5rMzMwMF9JTEFBRERDT1BLRRgHIAMo",
            "CzJILm1pSG9tby5Qcm90b3MuUGxhbnRGbG93ZXJBY2NlcHRGbG93ZXJSZXN1",
            "bHRJbmZvLlVuazMzMDBJTEFBRERDT1BLRUVudHJ5EmUKE1VuazMzMDBfUEFM",
            "RUpFRElBSlAYBiADKAsySC5taUhvbW8uUHJvdG9zLlBsYW50Rmxvd2VyQWNj",
            "ZXB0Rmxvd2VyUmVzdWx0SW5mby5VbmszMzAwUEFMRUpFRElBSlBFbnRyeRo5",
            "ChdVbmszMzAwSUxBQUREQ09QS0VFbnRyeRILCgNrZXkYASABKA0SDQoFdmFs",
            "dWUYAiABKA06AjgBGjkKF1VuazMzMDBQQUxFSkVESUFKUEVudHJ5EgsKA2tl",
            "eRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlantFlowerAcceptFlowerResultInfo), global::MiHomo.Protos.PlantFlowerAcceptFlowerResultInfo.Parser, new[]{ "Uid", "Unk3300ILAADDCOPKE", "Unk3300PALEJEDIAJP" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlantFlowerAcceptFlowerResultInfo : pb::IMessage<PlantFlowerAcceptFlowerResultInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlantFlowerAcceptFlowerResultInfo> _parser = new pb::MessageParser<PlantFlowerAcceptFlowerResultInfo>(() => new PlantFlowerAcceptFlowerResultInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlantFlowerAcceptFlowerResultInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlantFlowerAcceptFlowerResultInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptFlowerResultInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptFlowerResultInfo(PlantFlowerAcceptFlowerResultInfo other) : this() {
      uid_ = other.uid_;
      unk3300ILAADDCOPKE_ = other.unk3300ILAADDCOPKE_.Clone();
      unk3300PALEJEDIAJP_ = other.unk3300PALEJEDIAJP_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerAcceptFlowerResultInfo Clone() {
      return new PlantFlowerAcceptFlowerResultInfo(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 9;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ILAADDCOPKE" field.</summary>
    public const int Unk3300ILAADDCOPKEFieldNumber = 7;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk3300ILAADDCOPKE_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 58);
    private readonly pbc::MapField<uint, uint> unk3300ILAADDCOPKE_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk3300ILAADDCOPKE {
      get { return unk3300ILAADDCOPKE_; }
    }

    /// <summary>Field number for the "Unk3300_PALEJEDIAJP" field.</summary>
    public const int Unk3300PALEJEDIAJPFieldNumber = 6;
    private static readonly pbc::MapField<uint, uint>.Codec _map_unk3300PALEJEDIAJP_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 50);
    private readonly pbc::MapField<uint, uint> unk3300PALEJEDIAJP_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> Unk3300PALEJEDIAJP {
      get { return unk3300PALEJEDIAJP_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlantFlowerAcceptFlowerResultInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlantFlowerAcceptFlowerResultInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (!Unk3300ILAADDCOPKE.Equals(other.Unk3300ILAADDCOPKE)) return false;
      if (!Unk3300PALEJEDIAJP.Equals(other.Unk3300PALEJEDIAJP)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= Unk3300ILAADDCOPKE.GetHashCode();
      hash ^= Unk3300PALEJEDIAJP.GetHashCode();
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
      unk3300PALEJEDIAJP_.WriteTo(output, _map_unk3300PALEJEDIAJP_codec);
      unk3300ILAADDCOPKE_.WriteTo(output, _map_unk3300ILAADDCOPKE_codec);
      if (Uid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Uid);
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
      unk3300PALEJEDIAJP_.WriteTo(ref output, _map_unk3300PALEJEDIAJP_codec);
      unk3300ILAADDCOPKE_.WriteTo(ref output, _map_unk3300ILAADDCOPKE_codec);
      if (Uid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Uid);
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
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += unk3300ILAADDCOPKE_.CalculateSize(_map_unk3300ILAADDCOPKE_codec);
      size += unk3300PALEJEDIAJP_.CalculateSize(_map_unk3300PALEJEDIAJP_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlantFlowerAcceptFlowerResultInfo other) {
      if (other == null) {
        return;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      unk3300ILAADDCOPKE_.Add(other.unk3300ILAADDCOPKE_);
      unk3300PALEJEDIAJP_.Add(other.unk3300PALEJEDIAJP_);
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
          case 50: {
            unk3300PALEJEDIAJP_.AddEntriesFrom(input, _map_unk3300PALEJEDIAJP_codec);
            break;
          }
          case 58: {
            unk3300ILAADDCOPKE_.AddEntriesFrom(input, _map_unk3300ILAADDCOPKE_codec);
            break;
          }
          case 72: {
            Uid = input.ReadUInt32();
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
          case 50: {
            unk3300PALEJEDIAJP_.AddEntriesFrom(ref input, _map_unk3300PALEJEDIAJP_codec);
            break;
          }
          case 58: {
            unk3300ILAADDCOPKE_.AddEntriesFrom(ref input, _map_unk3300ILAADDCOPKE_codec);
            break;
          }
          case 72: {
            Uid = input.ReadUInt32();
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
