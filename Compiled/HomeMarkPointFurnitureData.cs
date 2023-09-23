// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeMarkPointFurnitureData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeMarkPointFurnitureData.proto</summary>
  public static partial class HomeMarkPointFurnitureDataReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeMarkPointFurnitureData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeMarkPointFurnitureDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBIb21lTWFya1BvaW50RnVybml0dXJlRGF0YS5wcm90bxINbWlIb21vLlBy",
            "b3RvcxoaSG9tZU1hcmtQb2ludE5QQ0RhdGEucHJvdG8aHEhvbWVNYXJrUG9p",
            "bnRTdWl0ZURhdGEucHJvdG8aDFZlY3Rvci5wcm90byL7AQoaSG9tZU1hcmtQ",
            "b2ludEZ1cm5pdHVyZURhdGESFAoMZnVybml0dXJlX2lkGAIgASgNEhYKDmZ1",
            "cm5pdHVyZV90eXBlGAMgASgNEgwKBGd1aWQYASABKA0SIgoDcG9zGAQgASgL",
            "MhUubWlIb21vLlByb3Rvcy5WZWN0b3ISNwoIbnBjX2RhdGEYBiABKAsyIy5t",
            "aUhvbW8uUHJvdG9zLkhvbWVNYXJrUG9pbnROUENEYXRhSAASOwoKc3VpdGVf",
            "ZGF0YRgHIAEoCzIlLm1pSG9tby5Qcm90b3MuSG9tZU1hcmtQb2ludFN1aXRl",
            "RGF0YUgAQgcKBWV4dHJhYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeMarkPointNPCDataReflection.Descriptor, global::MiHomo.Protos.HomeMarkPointSuiteDataReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeMarkPointFurnitureData), global::MiHomo.Protos.HomeMarkPointFurnitureData.Parser, new[]{ "FurnitureId", "FurnitureType", "Guid", "Pos", "NpcData", "SuiteData" }, new[]{ "Extra" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeMarkPointFurnitureData : pb::IMessage<HomeMarkPointFurnitureData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeMarkPointFurnitureData> _parser = new pb::MessageParser<HomeMarkPointFurnitureData>(() => new HomeMarkPointFurnitureData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeMarkPointFurnitureData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeMarkPointFurnitureDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointFurnitureData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointFurnitureData(HomeMarkPointFurnitureData other) : this() {
      furnitureId_ = other.furnitureId_;
      furnitureType_ = other.furnitureType_;
      guid_ = other.guid_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      switch (other.ExtraCase) {
        case ExtraOneofCase.NpcData:
          NpcData = other.NpcData.Clone();
          break;
        case ExtraOneofCase.SuiteData:
          SuiteData = other.SuiteData.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeMarkPointFurnitureData Clone() {
      return new HomeMarkPointFurnitureData(this);
    }

    /// <summary>Field number for the "furniture_id" field.</summary>
    public const int FurnitureIdFieldNumber = 2;
    private uint furnitureId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureId {
      get { return furnitureId_; }
      set {
        furnitureId_ = value;
      }
    }

    /// <summary>Field number for the "furniture_type" field.</summary>
    public const int FurnitureTypeFieldNumber = 3;
    private uint furnitureType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FurnitureType {
      get { return furnitureType_; }
      set {
        furnitureType_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 1;
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
    public const int PosFieldNumber = 4;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "npc_data" field.</summary>
    public const int NpcDataFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.HomeMarkPointNPCData NpcData {
      get { return extraCase_ == ExtraOneofCase.NpcData ? (global::MiHomo.Protos.HomeMarkPointNPCData) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.NpcData;
      }
    }

    /// <summary>Field number for the "suite_data" field.</summary>
    public const int SuiteDataFieldNumber = 7;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.HomeMarkPointSuiteData SuiteData {
      get { return extraCase_ == ExtraOneofCase.SuiteData ? (global::MiHomo.Protos.HomeMarkPointSuiteData) extra_ : null; }
      set {
        extra_ = value;
        extraCase_ = value == null ? ExtraOneofCase.None : ExtraOneofCase.SuiteData;
      }
    }

    private object extra_;
    /// <summary>Enum of possible cases for the "extra" oneof.</summary>
    public enum ExtraOneofCase {
      None = 0,
      NpcData = 6,
      SuiteData = 7,
    }
    private ExtraOneofCase extraCase_ = ExtraOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtraOneofCase ExtraCase {
      get { return extraCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearExtra() {
      extraCase_ = ExtraOneofCase.None;
      extra_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeMarkPointFurnitureData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeMarkPointFurnitureData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FurnitureId != other.FurnitureId) return false;
      if (FurnitureType != other.FurnitureType) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(NpcData, other.NpcData)) return false;
      if (!object.Equals(SuiteData, other.SuiteData)) return false;
      if (ExtraCase != other.ExtraCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FurnitureId != 0) hash ^= FurnitureId.GetHashCode();
      if (FurnitureType != 0) hash ^= FurnitureType.GetHashCode();
      if (Guid != 0) hash ^= Guid.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (extraCase_ == ExtraOneofCase.NpcData) hash ^= NpcData.GetHashCode();
      if (extraCase_ == ExtraOneofCase.SuiteData) hash ^= SuiteData.GetHashCode();
      hash ^= (int) extraCase_;
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
      if (Guid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Guid);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FurnitureId);
      }
      if (FurnitureType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FurnitureType);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (extraCase_ == ExtraOneofCase.NpcData) {
        output.WriteRawTag(50);
        output.WriteMessage(NpcData);
      }
      if (extraCase_ == ExtraOneofCase.SuiteData) {
        output.WriteRawTag(58);
        output.WriteMessage(SuiteData);
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
      if (Guid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Guid);
      }
      if (FurnitureId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(FurnitureId);
      }
      if (FurnitureType != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FurnitureType);
      }
      if (pos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Pos);
      }
      if (extraCase_ == ExtraOneofCase.NpcData) {
        output.WriteRawTag(50);
        output.WriteMessage(NpcData);
      }
      if (extraCase_ == ExtraOneofCase.SuiteData) {
        output.WriteRawTag(58);
        output.WriteMessage(SuiteData);
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
      if (FurnitureType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FurnitureType);
      }
      if (Guid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Guid);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (extraCase_ == ExtraOneofCase.NpcData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NpcData);
      }
      if (extraCase_ == ExtraOneofCase.SuiteData) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SuiteData);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeMarkPointFurnitureData other) {
      if (other == null) {
        return;
      }
      if (other.FurnitureId != 0) {
        FurnitureId = other.FurnitureId;
      }
      if (other.FurnitureType != 0) {
        FurnitureType = other.FurnitureType;
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
      switch (other.ExtraCase) {
        case ExtraOneofCase.NpcData:
          if (NpcData == null) {
            NpcData = new global::MiHomo.Protos.HomeMarkPointNPCData();
          }
          NpcData.MergeFrom(other.NpcData);
          break;
        case ExtraOneofCase.SuiteData:
          if (SuiteData == null) {
            SuiteData = new global::MiHomo.Protos.HomeMarkPointSuiteData();
          }
          SuiteData.MergeFrom(other.SuiteData);
          break;
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
            Guid = input.ReadUInt32();
            break;
          }
          case 16: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 24: {
            FurnitureType = input.ReadUInt32();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 50: {
            global::MiHomo.Protos.HomeMarkPointNPCData subBuilder = new global::MiHomo.Protos.HomeMarkPointNPCData();
            if (extraCase_ == ExtraOneofCase.NpcData) {
              subBuilder.MergeFrom(NpcData);
            }
            input.ReadMessage(subBuilder);
            NpcData = subBuilder;
            break;
          }
          case 58: {
            global::MiHomo.Protos.HomeMarkPointSuiteData subBuilder = new global::MiHomo.Protos.HomeMarkPointSuiteData();
            if (extraCase_ == ExtraOneofCase.SuiteData) {
              subBuilder.MergeFrom(SuiteData);
            }
            input.ReadMessage(subBuilder);
            SuiteData = subBuilder;
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
            Guid = input.ReadUInt32();
            break;
          }
          case 16: {
            FurnitureId = input.ReadUInt32();
            break;
          }
          case 24: {
            FurnitureType = input.ReadUInt32();
            break;
          }
          case 34: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 50: {
            global::MiHomo.Protos.HomeMarkPointNPCData subBuilder = new global::MiHomo.Protos.HomeMarkPointNPCData();
            if (extraCase_ == ExtraOneofCase.NpcData) {
              subBuilder.MergeFrom(NpcData);
            }
            input.ReadMessage(subBuilder);
            NpcData = subBuilder;
            break;
          }
          case 58: {
            global::MiHomo.Protos.HomeMarkPointSuiteData subBuilder = new global::MiHomo.Protos.HomeMarkPointSuiteData();
            if (extraCase_ == ExtraOneofCase.SuiteData) {
              subBuilder.MergeFrom(SuiteData);
            }
            input.ReadMessage(subBuilder);
            SuiteData = subBuilder;
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
