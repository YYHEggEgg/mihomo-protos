// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReportFightAntiCheatNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ReportFightAntiCheatNotify.proto</summary>
  public static partial class ReportFightAntiCheatNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ReportFightAntiCheatNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportFightAntiCheatNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBSZXBvcnRGaWdodEFudGlDaGVhdE5vdGlmeS5wcm90bxINbWlIb21vLlBy",
            "b3RvcyJWChpSZXBvcnRGaWdodEFudGlDaGVhdE5vdGlmeRIbChNVbmszMzAw",
            "X0FCQ0tNUFBNTkNIGAogASgNEhsKE1VuazMzMDBfTUlGTkFBQURCQlAYCCAB",
            "KA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ReportFightAntiCheatNotify), global::MiHomo.Protos.ReportFightAntiCheatNotify.Parser, new[]{ "Unk3300ABCKMPPMNCH", "Unk3300MIFNAAADBBP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReportFightAntiCheatNotify : pb::IMessage<ReportFightAntiCheatNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReportFightAntiCheatNotify> _parser = new pb::MessageParser<ReportFightAntiCheatNotify>(() => new ReportFightAntiCheatNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReportFightAntiCheatNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ReportFightAntiCheatNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportFightAntiCheatNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportFightAntiCheatNotify(ReportFightAntiCheatNotify other) : this() {
      unk3300ABCKMPPMNCH_ = other.unk3300ABCKMPPMNCH_;
      unk3300MIFNAAADBBP_ = other.unk3300MIFNAAADBBP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReportFightAntiCheatNotify Clone() {
      return new ReportFightAntiCheatNotify(this);
    }

    /// <summary>Field number for the "Unk3300_ABCKMPPMNCH" field.</summary>
    public const int Unk3300ABCKMPPMNCHFieldNumber = 10;
    private uint unk3300ABCKMPPMNCH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300ABCKMPPMNCH {
      get { return unk3300ABCKMPPMNCH_; }
      set {
        unk3300ABCKMPPMNCH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MIFNAAADBBP" field.</summary>
    public const int Unk3300MIFNAAADBBPFieldNumber = 8;
    private uint unk3300MIFNAAADBBP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MIFNAAADBBP {
      get { return unk3300MIFNAAADBBP_; }
      set {
        unk3300MIFNAAADBBP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReportFightAntiCheatNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReportFightAntiCheatNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk3300ABCKMPPMNCH != other.Unk3300ABCKMPPMNCH) return false;
      if (Unk3300MIFNAAADBBP != other.Unk3300MIFNAAADBBP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk3300ABCKMPPMNCH != 0) hash ^= Unk3300ABCKMPPMNCH.GetHashCode();
      if (Unk3300MIFNAAADBBP != 0) hash ^= Unk3300MIFNAAADBBP.GetHashCode();
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
      if (Unk3300MIFNAAADBBP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300MIFNAAADBBP);
      }
      if (Unk3300ABCKMPPMNCH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300ABCKMPPMNCH);
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
      if (Unk3300MIFNAAADBBP != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Unk3300MIFNAAADBBP);
      }
      if (Unk3300ABCKMPPMNCH != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(Unk3300ABCKMPPMNCH);
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
      if (Unk3300ABCKMPPMNCH != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ABCKMPPMNCH);
      }
      if (Unk3300MIFNAAADBBP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MIFNAAADBBP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReportFightAntiCheatNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk3300ABCKMPPMNCH != 0) {
        Unk3300ABCKMPPMNCH = other.Unk3300ABCKMPPMNCH;
      }
      if (other.Unk3300MIFNAAADBBP != 0) {
        Unk3300MIFNAAADBBP = other.Unk3300MIFNAAADBBP;
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
          case 64: {
            Unk3300MIFNAAADBBP = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300ABCKMPPMNCH = input.ReadUInt32();
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
          case 64: {
            Unk3300MIFNAAADBBP = input.ReadUInt32();
            break;
          }
          case 80: {
            Unk3300ABCKMPPMNCH = input.ReadUInt32();
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
