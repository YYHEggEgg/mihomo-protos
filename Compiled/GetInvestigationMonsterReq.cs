// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetInvestigationMonsterReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GetInvestigationMonsterReq.proto</summary>
  public static partial class GetInvestigationMonsterReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetInvestigationMonsterReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetInvestigationMonsterReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBHZXRJbnZlc3RpZ2F0aW9uTW9uc3RlclJlcS5wcm90bxINbWlIb21vLlBy",
            "b3RvcyJHChpHZXRJbnZlc3RpZ2F0aW9uTW9uc3RlclJlcRIUCgxjaXR5X2lk",
            "X2xpc3QYCyADKA0SEwoLaXNfZm9yX21hcmsYCCABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GetInvestigationMonsterReq), global::MiHomo.Protos.GetInvestigationMonsterReq.Parser, new[]{ "CityIdList", "IsForMark" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetInvestigationMonsterReq : pb::IMessage<GetInvestigationMonsterReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetInvestigationMonsterReq> _parser = new pb::MessageParser<GetInvestigationMonsterReq>(() => new GetInvestigationMonsterReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetInvestigationMonsterReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GetInvestigationMonsterReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInvestigationMonsterReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInvestigationMonsterReq(GetInvestigationMonsterReq other) : this() {
      cityIdList_ = other.cityIdList_.Clone();
      isForMark_ = other.isForMark_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetInvestigationMonsterReq Clone() {
      return new GetInvestigationMonsterReq(this);
    }

    /// <summary>Field number for the "city_id_list" field.</summary>
    public const int CityIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_cityIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> cityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CityIdList {
      get { return cityIdList_; }
    }

    /// <summary>Field number for the "is_for_mark" field.</summary>
    public const int IsForMarkFieldNumber = 8;
    private bool isForMark_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsForMark {
      get { return isForMark_; }
      set {
        isForMark_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetInvestigationMonsterReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetInvestigationMonsterReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cityIdList_.Equals(other.cityIdList_)) return false;
      if (IsForMark != other.IsForMark) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cityIdList_.GetHashCode();
      if (IsForMark != false) hash ^= IsForMark.GetHashCode();
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
      if (IsForMark != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsForMark);
      }
      cityIdList_.WriteTo(output, _repeated_cityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsForMark != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsForMark);
      }
      cityIdList_.WriteTo(ref output, _repeated_cityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += cityIdList_.CalculateSize(_repeated_cityIdList_codec);
      if (IsForMark != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetInvestigationMonsterReq other) {
      if (other == null) {
        return;
      }
      cityIdList_.Add(other.cityIdList_);
      if (other.IsForMark != false) {
        IsForMark = other.IsForMark;
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
            IsForMark = input.ReadBool();
            break;
          }
          case 90:
          case 88: {
            cityIdList_.AddEntriesFrom(input, _repeated_cityIdList_codec);
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
            IsForMark = input.ReadBool();
            break;
          }
          case 90:
          case 88: {
            cityIdList_.AddEntriesFrom(ref input, _repeated_cityIdList_codec);
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
