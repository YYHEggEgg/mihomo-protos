// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlantFlowerActivityDetailInfo.proto</summary>
  public static partial class PlantFlowerActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for PlantFlowerActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlantFlowerActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQbGFudEZsb3dlckFjdGl2aXR5RGV0YWlsSW5mby5wcm90bxINbWlIb21v",
            "LlByb3RvcyK9AwodUGxhbnRGbG93ZXJBY3Rpdml0eURldGFpbEluZm8SEQoJ",
            "ZGF5X2luZGV4GAEgASgNEhkKEWlzX2NvbnRlbnRfY2xvc2VkGAMgASgIEhwK",
            "FGlzX3RvZGF5X2hhc19hd2FyZGVkGA0gASgIEhwKFHRvZGF5X3NlZWRfcmV3",
            "YXJkX2lkGAsgASgNEl8KE3VzZWRfZmxvd2VyX251bV9tYXAYByADKAsyQi5t",
            "aUhvbW8uUHJvdG9zLlBsYW50Rmxvd2VyQWN0aXZpdHlEZXRhaWxJbmZvLlVz",
            "ZWRGbG93ZXJOdW1NYXBFbnRyeRJfChN3aXNoX2Zsb3dlcl9udW1fbWFwGAog",
            "AygLMkIubWlIb21vLlByb3Rvcy5QbGFudEZsb3dlckFjdGl2aXR5RGV0YWls",
            "SW5mby5XaXNoRmxvd2VyTnVtTWFwRW50cnkaNwoVVXNlZEZsb3dlck51bU1h",
            "cEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAEaNwoVV2lz",
            "aEZsb3dlck51bU1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEo",
            "DToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlantFlowerActivityDetailInfo), global::MiHomo.Protos.PlantFlowerActivityDetailInfo.Parser, new[]{ "DayIndex", "IsContentClosed", "IsTodayHasAwarded", "TodaySeedRewardId", "UsedFlowerNumMap", "WishFlowerNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlantFlowerActivityDetailInfo : pb::IMessage<PlantFlowerActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlantFlowerActivityDetailInfo> _parser = new pb::MessageParser<PlantFlowerActivityDetailInfo>(() => new PlantFlowerActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlantFlowerActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlantFlowerActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerActivityDetailInfo(PlantFlowerActivityDetailInfo other) : this() {
      dayIndex_ = other.dayIndex_;
      isContentClosed_ = other.isContentClosed_;
      isTodayHasAwarded_ = other.isTodayHasAwarded_;
      todaySeedRewardId_ = other.todaySeedRewardId_;
      usedFlowerNumMap_ = other.usedFlowerNumMap_.Clone();
      wishFlowerNumMap_ = other.wishFlowerNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerActivityDetailInfo Clone() {
      return new PlantFlowerActivityDetailInfo(this);
    }

    /// <summary>Field number for the "day_index" field.</summary>
    public const int DayIndexFieldNumber = 1;
    private uint dayIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DayIndex {
      get { return dayIndex_; }
      set {
        dayIndex_ = value;
      }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 3;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    /// <summary>Field number for the "is_today_has_awarded" field.</summary>
    public const int IsTodayHasAwardedFieldNumber = 13;
    private bool isTodayHasAwarded_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTodayHasAwarded {
      get { return isTodayHasAwarded_; }
      set {
        isTodayHasAwarded_ = value;
      }
    }

    /// <summary>Field number for the "today_seed_reward_id" field.</summary>
    public const int TodaySeedRewardIdFieldNumber = 11;
    private uint todaySeedRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TodaySeedRewardId {
      get { return todaySeedRewardId_; }
      set {
        todaySeedRewardId_ = value;
      }
    }

    /// <summary>Field number for the "used_flower_num_map" field.</summary>
    public const int UsedFlowerNumMapFieldNumber = 7;
    private static readonly pbc::MapField<uint, uint>.Codec _map_usedFlowerNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 58);
    private readonly pbc::MapField<uint, uint> usedFlowerNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> UsedFlowerNumMap {
      get { return usedFlowerNumMap_; }
    }

    /// <summary>Field number for the "wish_flower_num_map" field.</summary>
    public const int WishFlowerNumMapFieldNumber = 10;
    private static readonly pbc::MapField<uint, uint>.Codec _map_wishFlowerNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 82);
    private readonly pbc::MapField<uint, uint> wishFlowerNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> WishFlowerNumMap {
      get { return wishFlowerNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlantFlowerActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlantFlowerActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DayIndex != other.DayIndex) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      if (IsTodayHasAwarded != other.IsTodayHasAwarded) return false;
      if (TodaySeedRewardId != other.TodaySeedRewardId) return false;
      if (!UsedFlowerNumMap.Equals(other.UsedFlowerNumMap)) return false;
      if (!WishFlowerNumMap.Equals(other.WishFlowerNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DayIndex != 0) hash ^= DayIndex.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
      if (IsTodayHasAwarded != false) hash ^= IsTodayHasAwarded.GetHashCode();
      if (TodaySeedRewardId != 0) hash ^= TodaySeedRewardId.GetHashCode();
      hash ^= UsedFlowerNumMap.GetHashCode();
      hash ^= WishFlowerNumMap.GetHashCode();
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
      if (DayIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DayIndex);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsContentClosed);
      }
      usedFlowerNumMap_.WriteTo(output, _map_usedFlowerNumMap_codec);
      wishFlowerNumMap_.WriteTo(output, _map_wishFlowerNumMap_codec);
      if (TodaySeedRewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TodaySeedRewardId);
      }
      if (IsTodayHasAwarded != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsTodayHasAwarded);
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
      if (DayIndex != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(DayIndex);
      }
      if (IsContentClosed != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsContentClosed);
      }
      usedFlowerNumMap_.WriteTo(ref output, _map_usedFlowerNumMap_codec);
      wishFlowerNumMap_.WriteTo(ref output, _map_wishFlowerNumMap_codec);
      if (TodaySeedRewardId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(TodaySeedRewardId);
      }
      if (IsTodayHasAwarded != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsTodayHasAwarded);
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
      if (DayIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DayIndex);
      }
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (IsTodayHasAwarded != false) {
        size += 1 + 1;
      }
      if (TodaySeedRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TodaySeedRewardId);
      }
      size += usedFlowerNumMap_.CalculateSize(_map_usedFlowerNumMap_codec);
      size += wishFlowerNumMap_.CalculateSize(_map_wishFlowerNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlantFlowerActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.DayIndex != 0) {
        DayIndex = other.DayIndex;
      }
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
      }
      if (other.IsTodayHasAwarded != false) {
        IsTodayHasAwarded = other.IsTodayHasAwarded;
      }
      if (other.TodaySeedRewardId != 0) {
        TodaySeedRewardId = other.TodaySeedRewardId;
      }
      usedFlowerNumMap_.Add(other.usedFlowerNumMap_);
      wishFlowerNumMap_.Add(other.wishFlowerNumMap_);
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
            DayIndex = input.ReadUInt32();
            break;
          }
          case 24: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 58: {
            usedFlowerNumMap_.AddEntriesFrom(input, _map_usedFlowerNumMap_codec);
            break;
          }
          case 82: {
            wishFlowerNumMap_.AddEntriesFrom(input, _map_wishFlowerNumMap_codec);
            break;
          }
          case 88: {
            TodaySeedRewardId = input.ReadUInt32();
            break;
          }
          case 104: {
            IsTodayHasAwarded = input.ReadBool();
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
            DayIndex = input.ReadUInt32();
            break;
          }
          case 24: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 58: {
            usedFlowerNumMap_.AddEntriesFrom(ref input, _map_usedFlowerNumMap_codec);
            break;
          }
          case 82: {
            wishFlowerNumMap_.AddEntriesFrom(ref input, _map_wishFlowerNumMap_codec);
            break;
          }
          case 88: {
            TodaySeedRewardId = input.ReadUInt32();
            break;
          }
          case 104: {
            IsTodayHasAwarded = input.ReadBool();
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
