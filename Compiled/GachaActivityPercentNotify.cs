// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GachaActivityPercentNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GachaActivityPercentNotify.proto</summary>
  public static partial class GachaActivityPercentNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GachaActivityPercentNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GachaActivityPercentNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBHYWNoYUFjdGl2aXR5UGVyY2VudE5vdGlmeS5wcm90bxINbWlIb21vLlBy",
            "b3RvcyL9AQoaR2FjaGFBY3Rpdml0eVBlcmNlbnROb3RpZnkSGwoTVW5rMzMw",
            "MF9FT1BKQlBIRkRFRRgGIAEoDRIbChNVbmszMzAwX0dISElHS0ZET05FGA0g",
            "ASgNEhsKE1VuazMzMDBfSU9MUEFKS0RFRUEYBSABKA0SUwoOdGFyZ2V0X251",
            "bV9tYXAYDCADKAsyOy5taUhvbW8uUHJvdG9zLkdhY2hhQWN0aXZpdHlQZXJj",
            "ZW50Tm90aWZ5LlRhcmdldE51bU1hcEVudHJ5GjMKEVRhcmdldE51bU1hcEVu",
            "dHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GachaActivityPercentNotify), global::MiHomo.Protos.GachaActivityPercentNotify.Parser, new[]{ "Unk3300EOPJBPHFDEE", "Unk3300GHHIGKFDONE", "Unk3300IOLPAJKDEEA", "TargetNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GachaActivityPercentNotify : pb::IMessage<GachaActivityPercentNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GachaActivityPercentNotify> _parser = new pb::MessageParser<GachaActivityPercentNotify>(() => new GachaActivityPercentNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GachaActivityPercentNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GachaActivityPercentNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityPercentNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityPercentNotify(GachaActivityPercentNotify other) : this() {
      unk3300EOPJBPHFDEE_ = other.unk3300EOPJBPHFDEE_;
      unk3300GHHIGKFDONE_ = other.unk3300GHHIGKFDONE_;
      unk3300IOLPAJKDEEA_ = other.unk3300IOLPAJKDEEA_;
      targetNumMap_ = other.targetNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GachaActivityPercentNotify Clone() {
      return new GachaActivityPercentNotify(this);
    }

    /// <summary>Field number for the "Unk3300_EOPJBPHFDEE" field.</summary>
    public const int Unk3300EOPJBPHFDEEFieldNumber = 6;
    private uint unk3300EOPJBPHFDEE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EOPJBPHFDEE {
      get { return unk3300EOPJBPHFDEE_; }
      set {
        unk3300EOPJBPHFDEE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GHHIGKFDONE" field.</summary>
    public const int Unk3300GHHIGKFDONEFieldNumber = 13;
    private uint unk3300GHHIGKFDONE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GHHIGKFDONE {
      get { return unk3300GHHIGKFDONE_; }
      set {
        unk3300GHHIGKFDONE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_IOLPAJKDEEA" field.</summary>
    public const int Unk3300IOLPAJKDEEAFieldNumber = 5;
    private uint unk3300IOLPAJKDEEA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IOLPAJKDEEA {
      get { return unk3300IOLPAJKDEEA_; }
      set {
        unk3300IOLPAJKDEEA_ = value;
      }
    }

    /// <summary>Field number for the "target_num_map" field.</summary>
    public const int TargetNumMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_targetNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> targetNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> TargetNumMap {
      get { return targetNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GachaActivityPercentNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GachaActivityPercentNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300EOPJBPHFDEE != other.Unk3300EOPJBPHFDEE) return false;
      if (Unk3300GHHIGKFDONE != other.Unk3300GHHIGKFDONE) return false;
      if (Unk3300IOLPAJKDEEA != other.Unk3300IOLPAJKDEEA) return false;
      if (!TargetNumMap.Equals(other.TargetNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300EOPJBPHFDEE != 0) hash ^= Unk3300EOPJBPHFDEE.GetHashCode();
      if (Unk3300GHHIGKFDONE != 0) hash ^= Unk3300GHHIGKFDONE.GetHashCode();
      if (Unk3300IOLPAJKDEEA != 0) hash ^= Unk3300IOLPAJKDEEA.GetHashCode();
      hash ^= TargetNumMap.GetHashCode();
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
      if (Unk3300IOLPAJKDEEA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300IOLPAJKDEEA);
      }
      if (Unk3300EOPJBPHFDEE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300EOPJBPHFDEE);
      }
      targetNumMap_.WriteTo(output, _map_targetNumMap_codec);
      if (Unk3300GHHIGKFDONE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300GHHIGKFDONE);
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
      if (Unk3300IOLPAJKDEEA != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unk3300IOLPAJKDEEA);
      }
      if (Unk3300EOPJBPHFDEE != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Unk3300EOPJBPHFDEE);
      }
      targetNumMap_.WriteTo(ref output, _map_targetNumMap_codec);
      if (Unk3300GHHIGKFDONE != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300GHHIGKFDONE);
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
      if (Unk3300EOPJBPHFDEE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EOPJBPHFDEE);
      }
      if (Unk3300GHHIGKFDONE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GHHIGKFDONE);
      }
      if (Unk3300IOLPAJKDEEA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IOLPAJKDEEA);
      }
      size += targetNumMap_.CalculateSize(_map_targetNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GachaActivityPercentNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300EOPJBPHFDEE != 0) {
        Unk3300EOPJBPHFDEE = other.Unk3300EOPJBPHFDEE;
      }
      if (other.Unk3300GHHIGKFDONE != 0) {
        Unk3300GHHIGKFDONE = other.Unk3300GHHIGKFDONE;
      }
      if (other.Unk3300IOLPAJKDEEA != 0) {
        Unk3300IOLPAJKDEEA = other.Unk3300IOLPAJKDEEA;
      }
      targetNumMap_.Add(other.targetNumMap_);
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
          case 40: {
            Unk3300IOLPAJKDEEA = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300EOPJBPHFDEE = input.ReadUInt32();
            break;
          }
          case 98: {
            targetNumMap_.AddEntriesFrom(input, _map_targetNumMap_codec);
            break;
          }
          case 104: {
            Unk3300GHHIGKFDONE = input.ReadUInt32();
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
          case 40: {
            Unk3300IOLPAJKDEEA = input.ReadUInt32();
            break;
          }
          case 48: {
            Unk3300EOPJBPHFDEE = input.ReadUInt32();
            break;
          }
          case 98: {
            targetNumMap_.AddEntriesFrom(ref input, _map_targetNumMap_codec);
            break;
          }
          case 104: {
            Unk3300GHHIGKFDONE = input.ReadUInt32();
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
