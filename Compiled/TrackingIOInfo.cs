// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TrackingIOInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TrackingIOInfo.proto</summary>
  public static partial class TrackingIOInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TrackingIOInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrackingIOInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRUcmFja2luZ0lPSW5mby5wcm90bxINbWlIb21vLlByb3RvcyLKAQoOVHJh",
            "Y2tpbmdJT0luZm8SEQoJY2xpZW50X3R6GAogASgJEhQKDHJ5ZGV2aWNldHlw",
            "ZRgFIAEoCRIbChNVbmszMzAwX0NDT0dCSUNNSEtHGAkgASgJEhsKE1VuazMz",
            "MDBfQ05QSUdET0VKUEIYAiABKAkSGwoTVW5rMzMwMF9ESkhLSEVGUENESxgB",
            "IAEoCRIbChNVbmszMzAwX05NRE5MSExBS0FNGAcgASgJEhsKE1VuazMzMDBf",
            "UElCRlBEQU1KTEUYDCABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TrackingIOInfo), global::MiHomo.Protos.TrackingIOInfo.Parser, new[]{ "ClientTz", "Rydevicetype", "Unk3300CCOGBICMHKG", "Unk3300CNPIGDOEJPB", "Unk3300DJHKHEFPCDK", "Unk3300NMDNLHLAKAM", "Unk3300PIBFPDAMJLE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TrackingIOInfo : pb::IMessage<TrackingIOInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TrackingIOInfo> _parser = new pb::MessageParser<TrackingIOInfo>(() => new TrackingIOInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TrackingIOInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TrackingIOInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrackingIOInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrackingIOInfo(TrackingIOInfo other) : this() {
      clientTz_ = other.clientTz_;
      rydevicetype_ = other.rydevicetype_;
      unk3300CCOGBICMHKG_ = other.unk3300CCOGBICMHKG_;
      unk3300CNPIGDOEJPB_ = other.unk3300CNPIGDOEJPB_;
      unk3300DJHKHEFPCDK_ = other.unk3300DJHKHEFPCDK_;
      unk3300NMDNLHLAKAM_ = other.unk3300NMDNLHLAKAM_;
      unk3300PIBFPDAMJLE_ = other.unk3300PIBFPDAMJLE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TrackingIOInfo Clone() {
      return new TrackingIOInfo(this);
    }

    /// <summary>Field number for the "client_tz" field.</summary>
    public const int ClientTzFieldNumber = 10;
    private string clientTz_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientTz {
      get { return clientTz_; }
      set {
        clientTz_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rydevicetype" field.</summary>
    public const int RydevicetypeFieldNumber = 5;
    private string rydevicetype_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Rydevicetype {
      get { return rydevicetype_; }
      set {
        rydevicetype_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_CCOGBICMHKG" field.</summary>
    public const int Unk3300CCOGBICMHKGFieldNumber = 9;
    private string unk3300CCOGBICMHKG_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300CCOGBICMHKG {
      get { return unk3300CCOGBICMHKG_; }
      set {
        unk3300CCOGBICMHKG_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_CNPIGDOEJPB" field.</summary>
    public const int Unk3300CNPIGDOEJPBFieldNumber = 2;
    private string unk3300CNPIGDOEJPB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300CNPIGDOEJPB {
      get { return unk3300CNPIGDOEJPB_; }
      set {
        unk3300CNPIGDOEJPB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_DJHKHEFPCDK" field.</summary>
    public const int Unk3300DJHKHEFPCDKFieldNumber = 1;
    private string unk3300DJHKHEFPCDK_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300DJHKHEFPCDK {
      get { return unk3300DJHKHEFPCDK_; }
      set {
        unk3300DJHKHEFPCDK_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_NMDNLHLAKAM" field.</summary>
    public const int Unk3300NMDNLHLAKAMFieldNumber = 7;
    private string unk3300NMDNLHLAKAM_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300NMDNLHLAKAM {
      get { return unk3300NMDNLHLAKAM_; }
      set {
        unk3300NMDNLHLAKAM_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Unk3300_PIBFPDAMJLE" field.</summary>
    public const int Unk3300PIBFPDAMJLEFieldNumber = 12;
    private string unk3300PIBFPDAMJLE_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk3300PIBFPDAMJLE {
      get { return unk3300PIBFPDAMJLE_; }
      set {
        unk3300PIBFPDAMJLE_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TrackingIOInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TrackingIOInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientTz != other.ClientTz) return false;
      if (Rydevicetype != other.Rydevicetype) return false;
      if (Unk3300CCOGBICMHKG != other.Unk3300CCOGBICMHKG) return false;
      if (Unk3300CNPIGDOEJPB != other.Unk3300CNPIGDOEJPB) return false;
      if (Unk3300DJHKHEFPCDK != other.Unk3300DJHKHEFPCDK) return false;
      if (Unk3300NMDNLHLAKAM != other.Unk3300NMDNLHLAKAM) return false;
      if (Unk3300PIBFPDAMJLE != other.Unk3300PIBFPDAMJLE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientTz.Length != 0) hash ^= ClientTz.GetHashCode();
      if (Rydevicetype.Length != 0) hash ^= Rydevicetype.GetHashCode();
      if (Unk3300CCOGBICMHKG.Length != 0) hash ^= Unk3300CCOGBICMHKG.GetHashCode();
      if (Unk3300CNPIGDOEJPB.Length != 0) hash ^= Unk3300CNPIGDOEJPB.GetHashCode();
      if (Unk3300DJHKHEFPCDK.Length != 0) hash ^= Unk3300DJHKHEFPCDK.GetHashCode();
      if (Unk3300NMDNLHLAKAM.Length != 0) hash ^= Unk3300NMDNLHLAKAM.GetHashCode();
      if (Unk3300PIBFPDAMJLE.Length != 0) hash ^= Unk3300PIBFPDAMJLE.GetHashCode();
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
      if (Unk3300DJHKHEFPCDK.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Unk3300DJHKHEFPCDK);
      }
      if (Unk3300CNPIGDOEJPB.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Unk3300CNPIGDOEJPB);
      }
      if (Rydevicetype.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Rydevicetype);
      }
      if (Unk3300NMDNLHLAKAM.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk3300NMDNLHLAKAM);
      }
      if (Unk3300CCOGBICMHKG.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Unk3300CCOGBICMHKG);
      }
      if (ClientTz.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ClientTz);
      }
      if (Unk3300PIBFPDAMJLE.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Unk3300PIBFPDAMJLE);
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
      if (Unk3300DJHKHEFPCDK.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Unk3300DJHKHEFPCDK);
      }
      if (Unk3300CNPIGDOEJPB.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Unk3300CNPIGDOEJPB);
      }
      if (Rydevicetype.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Rydevicetype);
      }
      if (Unk3300NMDNLHLAKAM.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk3300NMDNLHLAKAM);
      }
      if (Unk3300CCOGBICMHKG.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Unk3300CCOGBICMHKG);
      }
      if (ClientTz.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(ClientTz);
      }
      if (Unk3300PIBFPDAMJLE.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(Unk3300PIBFPDAMJLE);
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
      if (ClientTz.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientTz);
      }
      if (Rydevicetype.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Rydevicetype);
      }
      if (Unk3300CCOGBICMHKG.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300CCOGBICMHKG);
      }
      if (Unk3300CNPIGDOEJPB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300CNPIGDOEJPB);
      }
      if (Unk3300DJHKHEFPCDK.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300DJHKHEFPCDK);
      }
      if (Unk3300NMDNLHLAKAM.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300NMDNLHLAKAM);
      }
      if (Unk3300PIBFPDAMJLE.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk3300PIBFPDAMJLE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TrackingIOInfo other) {
      if (other == null) {
        return;
      }
      if (other.ClientTz.Length != 0) {
        ClientTz = other.ClientTz;
      }
      if (other.Rydevicetype.Length != 0) {
        Rydevicetype = other.Rydevicetype;
      }
      if (other.Unk3300CCOGBICMHKG.Length != 0) {
        Unk3300CCOGBICMHKG = other.Unk3300CCOGBICMHKG;
      }
      if (other.Unk3300CNPIGDOEJPB.Length != 0) {
        Unk3300CNPIGDOEJPB = other.Unk3300CNPIGDOEJPB;
      }
      if (other.Unk3300DJHKHEFPCDK.Length != 0) {
        Unk3300DJHKHEFPCDK = other.Unk3300DJHKHEFPCDK;
      }
      if (other.Unk3300NMDNLHLAKAM.Length != 0) {
        Unk3300NMDNLHLAKAM = other.Unk3300NMDNLHLAKAM;
      }
      if (other.Unk3300PIBFPDAMJLE.Length != 0) {
        Unk3300PIBFPDAMJLE = other.Unk3300PIBFPDAMJLE;
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
            Unk3300DJHKHEFPCDK = input.ReadString();
            break;
          }
          case 18: {
            Unk3300CNPIGDOEJPB = input.ReadString();
            break;
          }
          case 42: {
            Rydevicetype = input.ReadString();
            break;
          }
          case 58: {
            Unk3300NMDNLHLAKAM = input.ReadString();
            break;
          }
          case 74: {
            Unk3300CCOGBICMHKG = input.ReadString();
            break;
          }
          case 82: {
            ClientTz = input.ReadString();
            break;
          }
          case 98: {
            Unk3300PIBFPDAMJLE = input.ReadString();
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
            Unk3300DJHKHEFPCDK = input.ReadString();
            break;
          }
          case 18: {
            Unk3300CNPIGDOEJPB = input.ReadString();
            break;
          }
          case 42: {
            Rydevicetype = input.ReadString();
            break;
          }
          case 58: {
            Unk3300NMDNLHLAKAM = input.ReadString();
            break;
          }
          case 74: {
            Unk3300CCOGBICMHKG = input.ReadString();
            break;
          }
          case 82: {
            ClientTz = input.ReadString();
            break;
          }
          case 98: {
            Unk3300PIBFPDAMJLE = input.ReadString();
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
