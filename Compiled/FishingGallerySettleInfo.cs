// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishingGallerySettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FishingGallerySettleInfo.proto</summary>
  public static partial class FishingGallerySettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FishingGallerySettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishingGallerySettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5GaXNoaW5nR2FsbGVyeVNldHRsZUluZm8ucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaDkZpc2hJbmZvLnByb3RvGhJGaXNoaW5nU2NvcmUucHJvdG8i5AEKGEZp",
            "c2hpbmdHYWxsZXJ5U2V0dGxlSW5mbxI3ChJmaXNoaW5nX3Njb3JlX2xpc3QY",
            "DyADKAsyGy5taUhvbW8uUHJvdG9zLkZpc2hpbmdTY29yZRJGCghmaXNoX21h",
            "cBgLIAMoCzI0Lm1pSG9tby5Qcm90b3MuRmlzaGluZ0dhbGxlcnlTZXR0bGVJ",
            "bmZvLkZpc2hNYXBFbnRyeRpHCgxGaXNoTWFwRW50cnkSCwoDa2V5GAEgASgN",
            "EiYKBXZhbHVlGAIgASgLMhcubWlIb21vLlByb3Rvcy5GaXNoSW5mbzoCOAFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FishInfoReflection.Descriptor, global::MiHomo.Protos.FishingScoreReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FishingGallerySettleInfo), global::MiHomo.Protos.FishingGallerySettleInfo.Parser, new[]{ "FishingScoreList", "FishMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FishingGallerySettleInfo : pb::IMessage<FishingGallerySettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishingGallerySettleInfo> _parser = new pb::MessageParser<FishingGallerySettleInfo>(() => new FishingGallerySettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishingGallerySettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FishingGallerySettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishingGallerySettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishingGallerySettleInfo(FishingGallerySettleInfo other) : this() {
      fishingScoreList_ = other.fishingScoreList_.Clone();
      fishMap_ = other.fishMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishingGallerySettleInfo Clone() {
      return new FishingGallerySettleInfo(this);
    }

    /// <summary>Field number for the "fishing_score_list" field.</summary>
    public const int FishingScoreListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FishingScore> _repeated_fishingScoreList_codec
        = pb::FieldCodec.ForMessage(122, global::MiHomo.Protos.FishingScore.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FishingScore> fishingScoreList_ = new pbc::RepeatedField<global::MiHomo.Protos.FishingScore>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FishingScore> FishingScoreList {
      get { return fishingScoreList_; }
    }

    /// <summary>Field number for the "fish_map" field.</summary>
    public const int FishMapFieldNumber = 11;
    private static readonly pbc::MapField<uint, global::MiHomo.Protos.FishInfo>.Codec _map_fishMap_codec
        = new pbc::MapField<uint, global::MiHomo.Protos.FishInfo>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::MiHomo.Protos.FishInfo.Parser), 90);
    private readonly pbc::MapField<uint, global::MiHomo.Protos.FishInfo> fishMap_ = new pbc::MapField<uint, global::MiHomo.Protos.FishInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::MiHomo.Protos.FishInfo> FishMap {
      get { return fishMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishingGallerySettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishingGallerySettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fishingScoreList_.Equals(other.fishingScoreList_)) return false;
      if (!FishMap.Equals(other.FishMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fishingScoreList_.GetHashCode();
      hash ^= FishMap.GetHashCode();
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
      fishMap_.WriteTo(output, _map_fishMap_codec);
      fishingScoreList_.WriteTo(output, _repeated_fishingScoreList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      fishMap_.WriteTo(ref output, _map_fishMap_codec);
      fishingScoreList_.WriteTo(ref output, _repeated_fishingScoreList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += fishingScoreList_.CalculateSize(_repeated_fishingScoreList_codec);
      size += fishMap_.CalculateSize(_map_fishMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishingGallerySettleInfo other) {
      if (other == null) {
        return;
      }
      fishingScoreList_.Add(other.fishingScoreList_);
      fishMap_.Add(other.fishMap_);
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
          case 90: {
            fishMap_.AddEntriesFrom(input, _map_fishMap_codec);
            break;
          }
          case 122: {
            fishingScoreList_.AddEntriesFrom(input, _repeated_fishingScoreList_codec);
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
          case 90: {
            fishMap_.AddEntriesFrom(ref input, _map_fishMap_codec);
            break;
          }
          case 122: {
            fishingScoreList_.AddEntriesFrom(ref input, _repeated_fishingScoreList_codec);
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
