// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AreaPlayInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AreaPlayInfoNotify.proto</summary>
  public static partial class AreaPlayInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for AreaPlayInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AreaPlayInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBcmVhUGxheUluZm9Ob3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3MaEkFy",
            "ZWFQbGF5VHlwZS5wcm90byKyAQoSQXJlYVBsYXlJbmZvTm90aWZ5EjMKDmFy",
            "ZWFfcGxheV90eXBlGAsgASgOMhsubWlIb21vLlByb3Rvcy5BcmVhUGxheVR5",
            "cGUSGAoQZGV0YWlsX3BsYXlfdHlwZRgOIAEoDSJNCgVDbWRJZBIICgROT05F",
            "EAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRAB",
            "EgsKBkNNRF9JRBD7GRoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.AreaPlayTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AreaPlayInfoNotify), global::MiHomo.Protos.AreaPlayInfoNotify.Parser, new[]{ "AreaPlayType", "DetailPlayType" }, null, new[]{ typeof(global::MiHomo.Protos.AreaPlayInfoNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AreaPlayInfoNotify : pb::IMessage<AreaPlayInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AreaPlayInfoNotify> _parser = new pb::MessageParser<AreaPlayInfoNotify>(() => new AreaPlayInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AreaPlayInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AreaPlayInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AreaPlayInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AreaPlayInfoNotify(AreaPlayInfoNotify other) : this() {
      areaPlayType_ = other.areaPlayType_;
      detailPlayType_ = other.detailPlayType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AreaPlayInfoNotify Clone() {
      return new AreaPlayInfoNotify(this);
    }

    /// <summary>Field number for the "area_play_type" field.</summary>
    public const int AreaPlayTypeFieldNumber = 11;
    private global::MiHomo.Protos.AreaPlayType areaPlayType_ = global::MiHomo.Protos.AreaPlayType.AreaPlayNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.AreaPlayType AreaPlayType {
      get { return areaPlayType_; }
      set {
        areaPlayType_ = value;
      }
    }

    /// <summary>Field number for the "detail_play_type" field.</summary>
    public const int DetailPlayTypeFieldNumber = 14;
    private uint detailPlayType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DetailPlayType {
      get { return detailPlayType_; }
      set {
        detailPlayType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AreaPlayInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AreaPlayInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaPlayType != other.AreaPlayType) return false;
      if (DetailPlayType != other.DetailPlayType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaPlayType != global::MiHomo.Protos.AreaPlayType.AreaPlayNone) hash ^= AreaPlayType.GetHashCode();
      if (DetailPlayType != 0) hash ^= DetailPlayType.GetHashCode();
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
      if (AreaPlayType != global::MiHomo.Protos.AreaPlayType.AreaPlayNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) AreaPlayType);
      }
      if (DetailPlayType != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DetailPlayType);
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
      if (AreaPlayType != global::MiHomo.Protos.AreaPlayType.AreaPlayNone) {
        output.WriteRawTag(88);
        output.WriteEnum((int) AreaPlayType);
      }
      if (DetailPlayType != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(DetailPlayType);
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
      if (AreaPlayType != global::MiHomo.Protos.AreaPlayType.AreaPlayNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AreaPlayType);
      }
      if (DetailPlayType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DetailPlayType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AreaPlayInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.AreaPlayType != global::MiHomo.Protos.AreaPlayType.AreaPlayNone) {
        AreaPlayType = other.AreaPlayType;
      }
      if (other.DetailPlayType != 0) {
        DetailPlayType = other.DetailPlayType;
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
          case 88: {
            AreaPlayType = (global::MiHomo.Protos.AreaPlayType) input.ReadEnum();
            break;
          }
          case 112: {
            DetailPlayType = input.ReadUInt32();
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
          case 88: {
            AreaPlayType = (global::MiHomo.Protos.AreaPlayType) input.ReadEnum();
            break;
          }
          case 112: {
            DetailPlayType = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AreaPlayInfoNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 3323,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
