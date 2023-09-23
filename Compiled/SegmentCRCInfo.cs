// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SegmentCRCInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SegmentCRCInfo.proto</summary>
  public static partial class SegmentCRCInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SegmentCRCInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SegmentCRCInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRTZWdtZW50Q1JDSW5mby5wcm90bxINbWlIb21vLlByb3RvcyJcCg5TZWdt",
            "ZW50Q1JDSW5mbxILCgNjcmMYCCABKAkSDgoGbW9kdWxlGAQgASgNEg4KBm9m",
            "ZnNldBgJIAEoDRIPCgdyZXRjb2RlGAMgASgFEgwKBHNpemUYBiABKA1iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SegmentCRCInfo), global::MiHomo.Protos.SegmentCRCInfo.Parser, new[]{ "Crc", "Module", "Offset", "Retcode", "Size" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SegmentCRCInfo : pb::IMessage<SegmentCRCInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SegmentCRCInfo> _parser = new pb::MessageParser<SegmentCRCInfo>(() => new SegmentCRCInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SegmentCRCInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SegmentCRCInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SegmentCRCInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SegmentCRCInfo(SegmentCRCInfo other) : this() {
      crc_ = other.crc_;
      module_ = other.module_;
      offset_ = other.offset_;
      retcode_ = other.retcode_;
      size_ = other.size_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SegmentCRCInfo Clone() {
      return new SegmentCRCInfo(this);
    }

    /// <summary>Field number for the "crc" field.</summary>
    public const int CrcFieldNumber = 8;
    private string crc_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Crc {
      get { return crc_; }
      set {
        crc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "module" field.</summary>
    public const int ModuleFieldNumber = 4;
    private uint module_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Module {
      get { return module_; }
      set {
        module_ = value;
      }
    }

    /// <summary>Field number for the "offset" field.</summary>
    public const int OffsetFieldNumber = 9;
    private uint offset_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Offset {
      get { return offset_; }
      set {
        offset_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 3;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "size" field.</summary>
    public const int SizeFieldNumber = 6;
    private uint size_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Size {
      get { return size_; }
      set {
        size_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SegmentCRCInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SegmentCRCInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Crc != other.Crc) return false;
      if (Module != other.Module) return false;
      if (Offset != other.Offset) return false;
      if (Retcode != other.Retcode) return false;
      if (Size != other.Size) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Crc.Length != 0) hash ^= Crc.GetHashCode();
      if (Module != 0) hash ^= Module.GetHashCode();
      if (Offset != 0) hash ^= Offset.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      if (Size != 0) hash ^= Size.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Retcode);
      }
      if (Module != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Module);
      }
      if (Size != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Size);
      }
      if (Crc.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Crc);
      }
      if (Offset != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Offset);
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
      if (Retcode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Retcode);
      }
      if (Module != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Module);
      }
      if (Size != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Size);
      }
      if (Crc.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Crc);
      }
      if (Offset != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Offset);
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
      if (Crc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Crc);
      }
      if (Module != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Module);
      }
      if (Offset != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Offset);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (Size != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Size);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SegmentCRCInfo other) {
      if (other == null) {
        return;
      }
      if (other.Crc.Length != 0) {
        Crc = other.Crc;
      }
      if (other.Module != 0) {
        Module = other.Module;
      }
      if (other.Offset != 0) {
        Offset = other.Offset;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      if (other.Size != 0) {
        Size = other.Size;
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
          case 24: {
            Retcode = input.ReadInt32();
            break;
          }
          case 32: {
            Module = input.ReadUInt32();
            break;
          }
          case 48: {
            Size = input.ReadUInt32();
            break;
          }
          case 66: {
            Crc = input.ReadString();
            break;
          }
          case 72: {
            Offset = input.ReadUInt32();
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
          case 24: {
            Retcode = input.ReadInt32();
            break;
          }
          case 32: {
            Module = input.ReadUInt32();
            break;
          }
          case 48: {
            Size = input.ReadUInt32();
            break;
          }
          case 66: {
            Crc = input.ReadString();
            break;
          }
          case 72: {
            Offset = input.ReadUInt32();
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
