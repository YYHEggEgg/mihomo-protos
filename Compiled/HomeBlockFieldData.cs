// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBlockFieldData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeBlockFieldData.proto</summary>
  public static partial class HomeBlockFieldDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBlockFieldData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBlockFieldDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhIb21lQmxvY2tGaWVsZERhdGEucHJvdG8SDW1pSG9tby5Qcm90b3MaG0hv",
            "bWVCbG9ja1N1YkZpZWxkRGF0YS5wcm90bxoMVmVjdG9yLnByb3RvIr4BChJI",
            "b21lQmxvY2tGaWVsZERhdGESFAoMZnVybml0dXJlX2lkGAwgASgNEgwKBGd1",
            "aWQYDyABKA0SIgoDcG9zGAggASgLMhUubWlIb21vLlByb3Rvcy5WZWN0b3IS",
            "IgoDcm90GA0gASgLMhUubWlIb21vLlByb3Rvcy5WZWN0b3ISPAoOc3ViX2Zp",
            "ZWxkX2xpc3QYBCADKAsyJC5taUhvbW8uUHJvdG9zLkhvbWVCbG9ja1N1YkZp",
            "ZWxkRGF0YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeBlockSubFieldDataReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeBlockFieldData), global::MiHomo.Protos.HomeBlockFieldData.Parser, new[]{ "FurnitureId", "Guid", "Pos", "Rot", "SubFieldList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBlockFieldData : pb::IMessage<HomeBlockFieldData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBlockFieldData> _parser = new pb::MessageParser<HomeBlockFieldData>(() => new HomeBlockFieldData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBlockFieldData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeBlockFieldDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlockFieldData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlockFieldData(HomeBlockFieldData other) : this() {
      furnitureId_ = other.furnitureId_;
      guid_ = other.guid_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      subFieldList_ = other.subFieldList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlockFieldData Clone() {
      return new HomeBlockFieldData(this);
    }

    /// <summary>Field number for the "furniture_id" field.</summary>
    public const int FurnitureIdFieldNumber = 12;
    private uint furnitureId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureId {
      get { return furnitureId_; }
      set {
        furnitureId_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 15;
    private uint guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 8;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 13;
    private global::MiHomo.Protos.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    /// <summary>Field number for the "sub_field_list" field.</summary>
    public const int SubFieldListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.HomeBlockSubFieldData> _repeated_subFieldList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.HomeBlockSubFieldData.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.HomeBlockSubFieldData> subFieldList_ = new pbc::RepeatedField<global::MiHomo.Protos.HomeBlockSubFieldData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.HomeBlockSubFieldData> SubFieldList {
      get { return subFieldList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBlockFieldData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBlockFieldData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FurnitureId != other.FurnitureId) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      if(!subFieldList_.Equals(other.subFieldList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
      hash ^= subFieldList_.GetHashCode();
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
      subFieldList_.WriteTo(output, _repeated_subFieldList_codec);
      if (pos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Pos);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FurnitureId);
      }
      if (rot_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Rot);
      }
      if (Guid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Guid);
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
      subFieldList_.WriteTo(ref output, _repeated_subFieldList_codec);
      if (pos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Pos);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FurnitureId);
      }
      if (rot_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Rot);
      }
      if (Guid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Guid);
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
      if (FurnitureId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureId);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
      }
      size += subFieldList_.CalculateSize(_repeated_subFieldList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBlockFieldData other) {
      if (other == null) {
        return;
      }
      if (other.FurnitureId != 0) {
        FurnitureId = other.FurnitureId;
      }
      if (other.Guid != 0) {
        Guid = other.Guid;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::MiHomo.Protos.Vector();
        }
        Rot.MergeFrom(other.Rot);
      }
      subFieldList_.Add(other.subFieldList_);
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
          case 34: {
            subFieldList_.AddEntriesFrom(input, _repeated_subFieldList_codec);
            break;
          }
          case 66: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 96: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (rot_ == null) {
              Rot = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 120: {
            Guid = input.ReadUInt32();
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
          case 34: {
            subFieldList_.AddEntriesFrom(ref input, _repeated_subFieldList_codec);
            break;
          }
          case 66: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 96: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 106: {
            if (rot_ == null) {
              Rot = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 120: {
            Guid = input.ReadUInt32();
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
