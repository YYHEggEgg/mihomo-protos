// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGallerySummerTimeV2BoatInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SceneGallerySummerTimeV2BoatInfo.proto</summary>
  public static partial class SceneGallerySummerTimeV2BoatInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGallerySummerTimeV2BoatInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGallerySummerTimeV2BoatInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZTY2VuZUdhbGxlcnlTdW1tZXJUaW1lVjJCb2F0SW5mby5wcm90bxINbWlI",
            "b21vLlByb3RvcyJlCiBTY2VuZUdhbGxlcnlTdW1tZXJUaW1lVjJCb2F0SW5m",
            "bxIOCgZwYXJhbTEYBSABKA0SDgoGcGFyYW0yGAMgASgNEg4KBnBhcmFtMxgM",
            "IAEoDRIRCgl1c2VkX3RpbWUYBiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SceneGallerySummerTimeV2BoatInfo), global::MiHomo.Protos.SceneGallerySummerTimeV2BoatInfo.Parser, new[]{ "Param1", "Param2", "Param3", "UsedTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGallerySummerTimeV2BoatInfo : pb::IMessage<SceneGallerySummerTimeV2BoatInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGallerySummerTimeV2BoatInfo> _parser = new pb::MessageParser<SceneGallerySummerTimeV2BoatInfo>(() => new SceneGallerySummerTimeV2BoatInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGallerySummerTimeV2BoatInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SceneGallerySummerTimeV2BoatInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGallerySummerTimeV2BoatInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGallerySummerTimeV2BoatInfo(SceneGallerySummerTimeV2BoatInfo other) : this() {
      param1_ = other.param1_;
      param2_ = other.param2_;
      param3_ = other.param3_;
      usedTime_ = other.usedTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGallerySummerTimeV2BoatInfo Clone() {
      return new SceneGallerySummerTimeV2BoatInfo(this);
    }

    /// <summary>Field number for the "param1" field.</summary>
    public const int Param1FieldNumber = 5;
    private uint param1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param1 {
      get { return param1_; }
      set {
        param1_ = value;
      }
    }

    /// <summary>Field number for the "param2" field.</summary>
    public const int Param2FieldNumber = 3;
    private uint param2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param2 {
      get { return param2_; }
      set {
        param2_ = value;
      }
    }

    /// <summary>Field number for the "param3" field.</summary>
    public const int Param3FieldNumber = 12;
    private uint param3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param3 {
      get { return param3_; }
      set {
        param3_ = value;
      }
    }

    /// <summary>Field number for the "used_time" field.</summary>
    public const int UsedTimeFieldNumber = 6;
    private uint usedTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UsedTime {
      get { return usedTime_; }
      set {
        usedTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGallerySummerTimeV2BoatInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGallerySummerTimeV2BoatInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Param1 != other.Param1) return false;
      if (Param2 != other.Param2) return false;
      if (Param3 != other.Param3) return false;
      if (UsedTime != other.UsedTime) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Param1 != 0) hash ^= Param1.GetHashCode();
      if (Param2 != 0) hash ^= Param2.GetHashCode();
      if (Param3 != 0) hash ^= Param3.GetHashCode();
      if (UsedTime != 0) hash ^= UsedTime.GetHashCode();
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
      if (Param2 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Param2);
      }
      if (Param1 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Param1);
      }
      if (UsedTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UsedTime);
      }
      if (Param3 != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Param3);
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
      if (Param2 != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Param2);
      }
      if (Param1 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Param1);
      }
      if (UsedTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(UsedTime);
      }
      if (Param3 != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Param3);
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
      if (Param1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param1);
      }
      if (Param2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param2);
      }
      if (Param3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param3);
      }
      if (UsedTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UsedTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGallerySummerTimeV2BoatInfo other) {
      if (other == null) {
        return;
      }
      if (other.Param1 != 0) {
        Param1 = other.Param1;
      }
      if (other.Param2 != 0) {
        Param2 = other.Param2;
      }
      if (other.Param3 != 0) {
        Param3 = other.Param3;
      }
      if (other.UsedTime != 0) {
        UsedTime = other.UsedTime;
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
          case 24: {
            Param2 = input.ReadUInt32();
            break;
          }
          case 40: {
            Param1 = input.ReadUInt32();
            break;
          }
          case 48: {
            UsedTime = input.ReadUInt32();
            break;
          }
          case 96: {
            Param3 = input.ReadUInt32();
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
            Param2 = input.ReadUInt32();
            break;
          }
          case 40: {
            Param1 = input.ReadUInt32();
            break;
          }
          case 48: {
            UsedTime = input.ReadUInt32();
            break;
          }
          case 96: {
            Param3 = input.ReadUInt32();
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
