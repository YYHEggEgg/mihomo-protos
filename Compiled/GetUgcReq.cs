// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetUgcReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GetUgcReq.proto</summary>
  public static partial class GetUgcReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetUgcReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetUgcReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9HZXRVZ2NSZXEucHJvdG8SDW1pSG9tby5Qcm90b3MaEEdldFVnY1R5cGUu",
            "cHJvdG8aEVJlY29yZFVzYWdlLnByb3RvGg1VZ2NUeXBlLnByb3RvIsgBCglH",
            "ZXRVZ2NSZXESLwoMZ2V0X3VnY190eXBlGAwgASgOMhkubWlIb21vLlByb3Rv",
            "cy5HZXRVZ2NUeXBlEhgKEGlzX3JlcXVpcmVfYnJpZWYYByABKAgSEAoIdWdj",
            "X2d1aWQYBiABKAQSNAoQdWdjX3JlY29yZF91c2FnZRgNIAEoDjIaLm1pSG9t",
            "by5Qcm90b3MuUmVjb3JkVXNhZ2USKAoIdWdjX3R5cGUYAiABKA4yFi5taUhv",
            "bW8uUHJvdG9zLlVnY1R5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GetUgcTypeReflection.Descriptor, global::MiHomo.Protos.RecordUsageReflection.Descriptor, global::MiHomo.Protos.UgcTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GetUgcReq), global::MiHomo.Protos.GetUgcReq.Parser, new[]{ "GetUgcType", "IsRequireBrief", "UgcGuid", "UgcRecordUsage", "UgcType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetUgcReq : pb::IMessage<GetUgcReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetUgcReq> _parser = new pb::MessageParser<GetUgcReq>(() => new GetUgcReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetUgcReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GetUgcReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUgcReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUgcReq(GetUgcReq other) : this() {
      getUgcType_ = other.getUgcType_;
      isRequireBrief_ = other.isRequireBrief_;
      ugcGuid_ = other.ugcGuid_;
      ugcRecordUsage_ = other.ugcRecordUsage_;
      ugcType_ = other.ugcType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetUgcReq Clone() {
      return new GetUgcReq(this);
    }

    /// <summary>Field number for the "get_ugc_type" field.</summary>
    public const int GetUgcTypeFieldNumber = 12;
    private global::MiHomo.Protos.GetUgcType getUgcType_ = global::MiHomo.Protos.GetUgcType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GetUgcType GetUgcType {
      get { return getUgcType_; }
      set {
        getUgcType_ = value;
      }
    }

    /// <summary>Field number for the "is_require_brief" field.</summary>
    public const int IsRequireBriefFieldNumber = 7;
    private bool isRequireBrief_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRequireBrief {
      get { return isRequireBrief_; }
      set {
        isRequireBrief_ = value;
      }
    }

    /// <summary>Field number for the "ugc_guid" field.</summary>
    public const int UgcGuidFieldNumber = 6;
    private ulong ugcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UgcGuid {
      get { return ugcGuid_; }
      set {
        ugcGuid_ = value;
      }
    }

    /// <summary>Field number for the "ugc_record_usage" field.</summary>
    public const int UgcRecordUsageFieldNumber = 13;
    private global::MiHomo.Protos.RecordUsage ugcRecordUsage_ = global::MiHomo.Protos.RecordUsage.UgcRecordUsageNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.RecordUsage UgcRecordUsage {
      get { return ugcRecordUsage_; }
      set {
        ugcRecordUsage_ = value;
      }
    }

    /// <summary>Field number for the "ugc_type" field.</summary>
    public const int UgcTypeFieldNumber = 2;
    private global::MiHomo.Protos.UgcType ugcType_ = global::MiHomo.Protos.UgcType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.UgcType UgcType {
      get { return ugcType_; }
      set {
        ugcType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetUgcReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetUgcReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GetUgcType != other.GetUgcType) return false;
      if (IsRequireBrief != other.IsRequireBrief) return false;
      if (UgcGuid != other.UgcGuid) return false;
      if (UgcRecordUsage != other.UgcRecordUsage) return false;
      if (UgcType != other.UgcType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GetUgcType != global::MiHomo.Protos.GetUgcType.None) hash ^= GetUgcType.GetHashCode();
      if (IsRequireBrief != false) hash ^= IsRequireBrief.GetHashCode();
      if (UgcGuid != 0UL) hash ^= UgcGuid.GetHashCode();
      if (UgcRecordUsage != global::MiHomo.Protos.RecordUsage.UgcRecordUsageNone) hash ^= UgcRecordUsage.GetHashCode();
      if (UgcType != global::MiHomo.Protos.UgcType.None) hash ^= UgcType.GetHashCode();
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
      if (UgcType != global::MiHomo.Protos.UgcType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) UgcType);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(UgcGuid);
      }
      if (IsRequireBrief != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsRequireBrief);
      }
      if (GetUgcType != global::MiHomo.Protos.GetUgcType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) GetUgcType);
      }
      if (UgcRecordUsage != global::MiHomo.Protos.RecordUsage.UgcRecordUsageNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) UgcRecordUsage);
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
      if (UgcType != global::MiHomo.Protos.UgcType.None) {
        output.WriteRawTag(16);
        output.WriteEnum((int) UgcType);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(UgcGuid);
      }
      if (IsRequireBrief != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsRequireBrief);
      }
      if (GetUgcType != global::MiHomo.Protos.GetUgcType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) GetUgcType);
      }
      if (UgcRecordUsage != global::MiHomo.Protos.RecordUsage.UgcRecordUsageNone) {
        output.WriteRawTag(104);
        output.WriteEnum((int) UgcRecordUsage);
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
      if (GetUgcType != global::MiHomo.Protos.GetUgcType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) GetUgcType);
      }
      if (IsRequireBrief != false) {
        size += 1 + 1;
      }
      if (UgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UgcGuid);
      }
      if (UgcRecordUsage != global::MiHomo.Protos.RecordUsage.UgcRecordUsageNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UgcRecordUsage);
      }
      if (UgcType != global::MiHomo.Protos.UgcType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) UgcType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetUgcReq other) {
      if (other == null) {
        return;
      }
      if (other.GetUgcType != global::MiHomo.Protos.GetUgcType.None) {
        GetUgcType = other.GetUgcType;
      }
      if (other.IsRequireBrief != false) {
        IsRequireBrief = other.IsRequireBrief;
      }
      if (other.UgcGuid != 0UL) {
        UgcGuid = other.UgcGuid;
      }
      if (other.UgcRecordUsage != global::MiHomo.Protos.RecordUsage.UgcRecordUsageNone) {
        UgcRecordUsage = other.UgcRecordUsage;
      }
      if (other.UgcType != global::MiHomo.Protos.UgcType.None) {
        UgcType = other.UgcType;
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
          case 16: {
            UgcType = (global::MiHomo.Protos.UgcType) input.ReadEnum();
            break;
          }
          case 48: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 56: {
            IsRequireBrief = input.ReadBool();
            break;
          }
          case 96: {
            GetUgcType = (global::MiHomo.Protos.GetUgcType) input.ReadEnum();
            break;
          }
          case 104: {
            UgcRecordUsage = (global::MiHomo.Protos.RecordUsage) input.ReadEnum();
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
          case 16: {
            UgcType = (global::MiHomo.Protos.UgcType) input.ReadEnum();
            break;
          }
          case 48: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 56: {
            IsRequireBrief = input.ReadBool();
            break;
          }
          case 96: {
            GetUgcType = (global::MiHomo.Protos.GetUgcType) input.ReadEnum();
            break;
          }
          case 104: {
            UgcRecordUsage = (global::MiHomo.Protos.RecordUsage) input.ReadEnum();
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
