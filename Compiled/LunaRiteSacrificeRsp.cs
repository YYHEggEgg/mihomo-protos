// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LunaRiteSacrificeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from LunaRiteSacrificeRsp.proto</summary>
  public static partial class LunaRiteSacrificeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for LunaRiteSacrificeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LunaRiteSacrificeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpMdW5hUml0ZVNhY3JpZmljZVJzcC5wcm90bxINbWlIb21vLlByb3RvcyJf",
            "ChRMdW5hUml0ZVNhY3JpZmljZVJzcBIPCgdhcmVhX2lkGA4gASgNEg0KBWlu",
            "ZGV4GAMgASgNEg8KB3JldGNvZGUYDCABKAUSFgoOc2FjcmlmaWNlX2xpc3QY",
            "CyADKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.LunaRiteSacrificeRsp), global::MiHomo.Protos.LunaRiteSacrificeRsp.Parser, new[]{ "AreaId", "Index", "Retcode", "SacrificeList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LunaRiteSacrificeRsp : pb::IMessage<LunaRiteSacrificeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LunaRiteSacrificeRsp> _parser = new pb::MessageParser<LunaRiteSacrificeRsp>(() => new LunaRiteSacrificeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LunaRiteSacrificeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.LunaRiteSacrificeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteSacrificeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteSacrificeRsp(LunaRiteSacrificeRsp other) : this() {
      areaId_ = other.areaId_;
      index_ = other.index_;
      retcode_ = other.retcode_;
      sacrificeList_ = other.sacrificeList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LunaRiteSacrificeRsp Clone() {
      return new LunaRiteSacrificeRsp(this);
    }

    /// <summary>Field number for the "area_id" field.</summary>
    public const int AreaIdFieldNumber = 14;
    private uint areaId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AreaId {
      get { return areaId_; }
      set {
        areaId_ = value;
      }
    }

    /// <summary>Field number for the "index" field.</summary>
    public const int IndexFieldNumber = 3;
    private uint index_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 12;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "sacrifice_list" field.</summary>
    public const int SacrificeListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_sacrificeList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> sacrificeList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SacrificeList {
      get { return sacrificeList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LunaRiteSacrificeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LunaRiteSacrificeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AreaId != other.AreaId) return false;
      if (Index != other.Index) return false;
      if (Retcode != other.Retcode) return false;
      if(!sacrificeList_.Equals(other.sacrificeList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AreaId != 0) hash ^= AreaId.GetHashCode();
      if (Index != 0) hash ^= Index.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= sacrificeList_.GetHashCode();
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
      if (Index != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Index);
      }
      sacrificeList_.WriteTo(output, _repeated_sacrificeList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (AreaId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AreaId);
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
      if (Index != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Index);
      }
      sacrificeList_.WriteTo(ref output, _repeated_sacrificeList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(Retcode);
      }
      if (AreaId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(AreaId);
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
      if (AreaId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AreaId);
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += sacrificeList_.CalculateSize(_repeated_sacrificeList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LunaRiteSacrificeRsp other) {
      if (other == null) {
        return;
      }
      if (other.AreaId != 0) {
        AreaId = other.AreaId;
      }
      if (other.Index != 0) {
        Index = other.Index;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      sacrificeList_.Add(other.sacrificeList_);
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
            Index = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            sacrificeList_.AddEntriesFrom(input, _repeated_sacrificeList_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            AreaId = input.ReadUInt32();
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
            Index = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            sacrificeList_.AddEntriesFrom(ref input, _repeated_sacrificeList_codec);
            break;
          }
          case 96: {
            Retcode = input.ReadInt32();
            break;
          }
          case 112: {
            AreaId = input.ReadUInt32();
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
