// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SkyCrystalDetectorDataUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SkyCrystalDetectorDataUpdateNotify.proto</summary>
  public static partial class SkyCrystalDetectorDataUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SkyCrystalDetectorDataUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkyCrystalDetectorDataUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihTa3lDcnlzdGFsRGV0ZWN0b3JEYXRhVXBkYXRlTm90aWZ5LnByb3RvEg1t",
            "aUhvbW8uUHJvdG9zGhxTa3lDcnlzdGFsRGV0ZWN0b3JEYXRhLnByb3RvIm4K",
            "IlNreUNyeXN0YWxEZXRlY3RvckRhdGFVcGRhdGVOb3RpZnkSSAoZc2t5X2Ny",
            "eXN0YWxfZGV0ZWN0b3JfZGF0YRgPIAEoCzIlLm1pSG9tby5Qcm90b3MuU2t5",
            "Q3J5c3RhbERldGVjdG9yRGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.SkyCrystalDetectorDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SkyCrystalDetectorDataUpdateNotify), global::MiHomo.Protos.SkyCrystalDetectorDataUpdateNotify.Parser, new[]{ "SkyCrystalDetectorData" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SkyCrystalDetectorDataUpdateNotify : pb::IMessage<SkyCrystalDetectorDataUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkyCrystalDetectorDataUpdateNotify> _parser = new pb::MessageParser<SkyCrystalDetectorDataUpdateNotify>(() => new SkyCrystalDetectorDataUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkyCrystalDetectorDataUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SkyCrystalDetectorDataUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkyCrystalDetectorDataUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkyCrystalDetectorDataUpdateNotify(SkyCrystalDetectorDataUpdateNotify other) : this() {
      skyCrystalDetectorData_ = other.skyCrystalDetectorData_ != null ? other.skyCrystalDetectorData_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkyCrystalDetectorDataUpdateNotify Clone() {
      return new SkyCrystalDetectorDataUpdateNotify(this);
    }

    /// <summary>Field number for the "sky_crystal_detector_data" field.</summary>
    public const int SkyCrystalDetectorDataFieldNumber = 15;
    private global::MiHomo.Protos.SkyCrystalDetectorData skyCrystalDetectorData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.SkyCrystalDetectorData SkyCrystalDetectorData {
      get { return skyCrystalDetectorData_; }
      set {
        skyCrystalDetectorData_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkyCrystalDetectorDataUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkyCrystalDetectorDataUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SkyCrystalDetectorData, other.SkyCrystalDetectorData)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (skyCrystalDetectorData_ != null) hash ^= SkyCrystalDetectorData.GetHashCode();
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
      if (skyCrystalDetectorData_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(SkyCrystalDetectorData);
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
      if (skyCrystalDetectorData_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(SkyCrystalDetectorData);
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
      if (skyCrystalDetectorData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SkyCrystalDetectorData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SkyCrystalDetectorDataUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.skyCrystalDetectorData_ != null) {
        if (skyCrystalDetectorData_ == null) {
          SkyCrystalDetectorData = new global::MiHomo.Protos.SkyCrystalDetectorData();
        }
        SkyCrystalDetectorData.MergeFrom(other.SkyCrystalDetectorData);
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
          case 122: {
            if (skyCrystalDetectorData_ == null) {
              SkyCrystalDetectorData = new global::MiHomo.Protos.SkyCrystalDetectorData();
            }
            input.ReadMessage(SkyCrystalDetectorData);
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
          case 122: {
            if (skyCrystalDetectorData_ == null) {
              SkyCrystalDetectorData = new global::MiHomo.Protos.SkyCrystalDetectorData();
            }
            input.ReadMessage(SkyCrystalDetectorData);
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
