// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: McoinExchangeHcoinRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from McoinExchangeHcoinRsp.proto</summary>
  public static partial class McoinExchangeHcoinRspReflection {

    #region Descriptor
    /// <summary>File descriptor for McoinExchangeHcoinRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static McoinExchangeHcoinRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtNY29pbkV4Y2hhbmdlSGNvaW5Sc3AucHJvdG8SDW1pSG9tby5Qcm90b3Mi",
            "SwoVTWNvaW5FeGNoYW5nZUhjb2luUnNwEg0KBWhjb2luGAEgASgNEhIKCm1j",
            "b2luX2Nvc3QYDCABKA0SDwoHcmV0Y29kZRgKIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.McoinExchangeHcoinRsp), global::MiHomo.Protos.McoinExchangeHcoinRsp.Parser, new[]{ "Hcoin", "McoinCost", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class McoinExchangeHcoinRsp : pb::IMessage<McoinExchangeHcoinRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<McoinExchangeHcoinRsp> _parser = new pb::MessageParser<McoinExchangeHcoinRsp>(() => new McoinExchangeHcoinRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<McoinExchangeHcoinRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.McoinExchangeHcoinRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public McoinExchangeHcoinRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public McoinExchangeHcoinRsp(McoinExchangeHcoinRsp other) : this() {
      hcoin_ = other.hcoin_;
      mcoinCost_ = other.mcoinCost_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public McoinExchangeHcoinRsp Clone() {
      return new McoinExchangeHcoinRsp(this);
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

    /// <summary>Field number for the "mcoin_cost" field.</summary>
    public const int McoinCostFieldNumber = 12;
    private uint mcoinCost_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint McoinCost {
      get { return mcoinCost_; }
      set {
        mcoinCost_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
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
      return Equals(other as McoinExchangeHcoinRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(McoinExchangeHcoinRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hcoin != other.Hcoin) return false;
      if (McoinCost != other.McoinCost) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Hcoin != 0) hash ^= Hcoin.GetHashCode();
      if (McoinCost != 0) hash ^= McoinCost.GetHashCode();
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
      if (Hcoin != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Hcoin);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (McoinCost != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(McoinCost);
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
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (McoinCost != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(McoinCost);
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
      if (Hcoin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Hcoin);
      }
      if (McoinCost != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(McoinCost);
      }
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
    public void MergeFrom(McoinExchangeHcoinRsp other) {
      if (other == null) {
        return;
      }
      if (other.Hcoin != 0) {
        Hcoin = other.Hcoin;
      }
      if (other.McoinCost != 0) {
        McoinCost = other.McoinCost;
      }
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
          case 8: {
            Hcoin = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            McoinCost = input.ReadUInt32();
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
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 96: {
            McoinCost = input.ReadUInt32();
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
