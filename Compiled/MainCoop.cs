// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MainCoop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MainCoop.proto</summary>
  public static partial class MainCoopReflection {

    #region Descriptor
    /// <summary>File descriptor for MainCoop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MainCoopReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5NYWluQ29vcC5wcm90bxINbWlIb21vLlByb3RvcyKSBAoITWFpbkNvb3AS",
            "CgoCaWQYCSABKA0SGgoSc2F2ZV9wb2ludF9pZF9saXN0GAEgAygNEhcKD3Nl",
            "bGZfY29uZmlkZW5jZRgFIAEoDRIuCgZzdGF0dXMYBiABKA4yHi5taUhvbW8u",
            "UHJvdG9zLk1haW5Db29wLlN0YXR1cxJBCg5ub3JtYWxfdmFyX21hcBgEIAMo",
            "CzIpLm1pSG9tby5Qcm90b3MuTWFpbkNvb3AuTm9ybWFsVmFyTWFwRW50cnkS",
            "QwoPc2Vlbl9lbmRpbmdfbWFwGA0gAygLMioubWlIb21vLlByb3Rvcy5NYWlu",
            "Q29vcC5TZWVuRW5kaW5nTWFwRW50cnkSPQoMdGVtcF92YXJfbWFwGAsgAygL",
            "MicubWlIb21vLlByb3Rvcy5NYWluQ29vcC5UZW1wVmFyTWFwRW50cnkaMwoR",
            "Tm9ybWFsVmFyTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgF",
            "OgI4ARo0ChJTZWVuRW5kaW5nTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZh",
            "bHVlGAIgASgNOgI4ARoxCg9UZW1wVmFyTWFwRW50cnkSCwoDa2V5GAEgASgN",
            "Eg0KBXZhbHVlGAIgASgFOgI4ASIwCgZTdGF0dXMSCwoHSU5WQUxJRBAAEgsK",
            "B1JVTk5JTkcQARIMCghGSU5JU0hFRBACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MainCoop), global::MiHomo.Protos.MainCoop.Parser, new[]{ "Id", "SavePointIdList", "SelfConfidence", "Status", "NormalVarMap", "SeenEndingMap", "TempVarMap" }, null, new[]{ typeof(global::MiHomo.Protos.MainCoop.Types.Status) }, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MainCoop : pb::IMessage<MainCoop>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MainCoop> _parser = new pb::MessageParser<MainCoop>(() => new MainCoop());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MainCoop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MainCoopReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainCoop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainCoop(MainCoop other) : this() {
      id_ = other.id_;
      savePointIdList_ = other.savePointIdList_.Clone();
      selfConfidence_ = other.selfConfidence_;
      status_ = other.status_;
      normalVarMap_ = other.normalVarMap_.Clone();
      seenEndingMap_ = other.seenEndingMap_.Clone();
      tempVarMap_ = other.tempVarMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MainCoop Clone() {
      return new MainCoop(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 9;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "save_point_id_list" field.</summary>
    public const int SavePointIdListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_savePointIdList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> savePointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> SavePointIdList {
      get { return savePointIdList_; }
    }

    /// <summary>Field number for the "self_confidence" field.</summary>
    public const int SelfConfidenceFieldNumber = 5;
    private uint selfConfidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelfConfidence {
      get { return selfConfidence_; }
      set {
        selfConfidence_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::MiHomo.Protos.MainCoop.Types.Status status_ = global::MiHomo.Protos.MainCoop.Types.Status.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.MainCoop.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "normal_var_map" field.</summary>
    public const int NormalVarMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, int>.Codec _map_normalVarMap_codec
        = new pbc::MapField<uint, int>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 34);
    private readonly pbc::MapField<uint, int> normalVarMap_ = new pbc::MapField<uint, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, int> NormalVarMap {
      get { return normalVarMap_; }
    }

    /// <summary>Field number for the "seen_ending_map" field.</summary>
    public const int SeenEndingMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, uint>.Codec _map_seenEndingMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 106);
    private readonly pbc::MapField<uint, uint> seenEndingMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> SeenEndingMap {
      get { return seenEndingMap_; }
    }

    /// <summary>Field number for the "temp_var_map" field.</summary>
    public const int TempVarMapFieldNumber = 11;
    private static readonly pbc::MapField<uint, int>.Codec _map_tempVarMap_codec
        = new pbc::MapField<uint, int>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 90);
    private readonly pbc::MapField<uint, int> tempVarMap_ = new pbc::MapField<uint, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, int> TempVarMap {
      get { return tempVarMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MainCoop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MainCoop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!savePointIdList_.Equals(other.savePointIdList_)) return false;
      if (SelfConfidence != other.SelfConfidence) return false;
      if (Status != other.Status) return false;
      if (!NormalVarMap.Equals(other.NormalVarMap)) return false;
      if (!SeenEndingMap.Equals(other.SeenEndingMap)) return false;
      if (!TempVarMap.Equals(other.TempVarMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= savePointIdList_.GetHashCode();
      if (SelfConfidence != 0) hash ^= SelfConfidence.GetHashCode();
      if (Status != global::MiHomo.Protos.MainCoop.Types.Status.Invalid) hash ^= Status.GetHashCode();
      hash ^= NormalVarMap.GetHashCode();
      hash ^= SeenEndingMap.GetHashCode();
      hash ^= TempVarMap.GetHashCode();
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
      savePointIdList_.WriteTo(output, _repeated_savePointIdList_codec);
      normalVarMap_.WriteTo(output, _map_normalVarMap_codec);
      if (SelfConfidence != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SelfConfidence);
      }
      if (Status != global::MiHomo.Protos.MainCoop.Types.Status.Invalid) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Id != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Id);
      }
      tempVarMap_.WriteTo(output, _map_tempVarMap_codec);
      seenEndingMap_.WriteTo(output, _map_seenEndingMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      savePointIdList_.WriteTo(ref output, _repeated_savePointIdList_codec);
      normalVarMap_.WriteTo(ref output, _map_normalVarMap_codec);
      if (SelfConfidence != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SelfConfidence);
      }
      if (Status != global::MiHomo.Protos.MainCoop.Types.Status.Invalid) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Id != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Id);
      }
      tempVarMap_.WriteTo(ref output, _map_tempVarMap_codec);
      seenEndingMap_.WriteTo(ref output, _map_seenEndingMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      size += savePointIdList_.CalculateSize(_repeated_savePointIdList_codec);
      if (SelfConfidence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelfConfidence);
      }
      if (Status != global::MiHomo.Protos.MainCoop.Types.Status.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += normalVarMap_.CalculateSize(_map_normalVarMap_codec);
      size += seenEndingMap_.CalculateSize(_map_seenEndingMap_codec);
      size += tempVarMap_.CalculateSize(_map_tempVarMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MainCoop other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      savePointIdList_.Add(other.savePointIdList_);
      if (other.SelfConfidence != 0) {
        SelfConfidence = other.SelfConfidence;
      }
      if (other.Status != global::MiHomo.Protos.MainCoop.Types.Status.Invalid) {
        Status = other.Status;
      }
      normalVarMap_.Add(other.normalVarMap_);
      seenEndingMap_.Add(other.seenEndingMap_);
      tempVarMap_.Add(other.tempVarMap_);
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
          case 10:
          case 8: {
            savePointIdList_.AddEntriesFrom(input, _repeated_savePointIdList_codec);
            break;
          }
          case 34: {
            normalVarMap_.AddEntriesFrom(input, _map_normalVarMap_codec);
            break;
          }
          case 40: {
            SelfConfidence = input.ReadUInt32();
            break;
          }
          case 48: {
            Status = (global::MiHomo.Protos.MainCoop.Types.Status) input.ReadEnum();
            break;
          }
          case 72: {
            Id = input.ReadUInt32();
            break;
          }
          case 90: {
            tempVarMap_.AddEntriesFrom(input, _map_tempVarMap_codec);
            break;
          }
          case 106: {
            seenEndingMap_.AddEntriesFrom(input, _map_seenEndingMap_codec);
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
          case 10:
          case 8: {
            savePointIdList_.AddEntriesFrom(ref input, _repeated_savePointIdList_codec);
            break;
          }
          case 34: {
            normalVarMap_.AddEntriesFrom(ref input, _map_normalVarMap_codec);
            break;
          }
          case 40: {
            SelfConfidence = input.ReadUInt32();
            break;
          }
          case 48: {
            Status = (global::MiHomo.Protos.MainCoop.Types.Status) input.ReadEnum();
            break;
          }
          case 72: {
            Id = input.ReadUInt32();
            break;
          }
          case 90: {
            tempVarMap_.AddEntriesFrom(ref input, _map_tempVarMap_codec);
            break;
          }
          case 106: {
            seenEndingMap_.AddEntriesFrom(ref input, _map_seenEndingMap_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MainCoop message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("INVALID")] Invalid = 0,
        [pbr::OriginalName("RUNNING")] Running = 1,
        [pbr::OriginalName("FINISHED")] Finished = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
