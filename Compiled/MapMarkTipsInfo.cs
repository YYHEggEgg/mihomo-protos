// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MapMarkTipsInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MapMarkTipsInfo.proto</summary>
  public static partial class MapMarkTipsInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MapMarkTipsInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapMarkTipsInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNYXBNYXJrVGlwc0luZm8ucHJvdG8SDW1pSG9tby5Qcm90b3MaFU1hcE1h",
            "cmtUaXBzVHlwZS5wcm90byJbCg9NYXBNYXJrVGlwc0luZm8SFQoNcG9pbnRf",
            "aWRfbGlzdBgCIAMoDRIxCgl0aXBzX3R5cGUYASABKA4yHi5taUhvbW8uUHJv",
            "dG9zLk1hcE1hcmtUaXBzVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.MapMarkTipsTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MapMarkTipsInfo), global::MiHomo.Protos.MapMarkTipsInfo.Parser, new[]{ "PointIdList", "TipsType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MapMarkTipsInfo : pb::IMessage<MapMarkTipsInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MapMarkTipsInfo> _parser = new pb::MessageParser<MapMarkTipsInfo>(() => new MapMarkTipsInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MapMarkTipsInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MapMarkTipsInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapMarkTipsInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapMarkTipsInfo(MapMarkTipsInfo other) : this() {
      pointIdList_ = other.pointIdList_.Clone();
      tipsType_ = other.tipsType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapMarkTipsInfo Clone() {
      return new MapMarkTipsInfo(this);
    }

    /// <summary>Field number for the "point_id_list" field.</summary>
    public const int PointIdListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_pointIdList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> pointIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PointIdList {
      get { return pointIdList_; }
    }

    /// <summary>Field number for the "tips_type" field.</summary>
    public const int TipsTypeFieldNumber = 1;
    private global::MiHomo.Protos.MapMarkTipsType tipsType_ = global::MiHomo.Protos.MapMarkTipsType.MarkTipsDungeonElementTrial;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.MapMarkTipsType TipsType {
      get { return tipsType_; }
      set {
        tipsType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MapMarkTipsInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MapMarkTipsInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!pointIdList_.Equals(other.pointIdList_)) return false;
      if (TipsType != other.TipsType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= pointIdList_.GetHashCode();
      if (TipsType != global::MiHomo.Protos.MapMarkTipsType.MarkTipsDungeonElementTrial) hash ^= TipsType.GetHashCode();
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
      if (TipsType != global::MiHomo.Protos.MapMarkTipsType.MarkTipsDungeonElementTrial) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TipsType);
      }
      pointIdList_.WriteTo(output, _repeated_pointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TipsType != global::MiHomo.Protos.MapMarkTipsType.MarkTipsDungeonElementTrial) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TipsType);
      }
      pointIdList_.WriteTo(ref output, _repeated_pointIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += pointIdList_.CalculateSize(_repeated_pointIdList_codec);
      if (TipsType != global::MiHomo.Protos.MapMarkTipsType.MarkTipsDungeonElementTrial) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TipsType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MapMarkTipsInfo other) {
      if (other == null) {
        return;
      }
      pointIdList_.Add(other.pointIdList_);
      if (other.TipsType != global::MiHomo.Protos.MapMarkTipsType.MarkTipsDungeonElementTrial) {
        TipsType = other.TipsType;
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
            TipsType = (global::MiHomo.Protos.MapMarkTipsType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            pointIdList_.AddEntriesFrom(input, _repeated_pointIdList_codec);
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
            TipsType = (global::MiHomo.Protos.MapMarkTipsType) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            pointIdList_.AddEntriesFrom(ref input, _repeated_pointIdList_codec);
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
