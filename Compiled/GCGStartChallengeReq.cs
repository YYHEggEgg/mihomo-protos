// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGStartChallengeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGStartChallengeReq.proto</summary>
  public static partial class GCGStartChallengeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGStartChallengeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGStartChallengeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHQ0dTdGFydENoYWxsZW5nZVJlcS5wcm90bxINbWlIb21vLlByb3RvcxoS",
            "R0NHTGV2ZWxUeXBlLnByb3RvImwKFEdDR1N0YXJ0Q2hhbGxlbmdlUmVxEhEK",
            "CWNvbmZpZ19pZBgHIAEoDRIQCghsZXZlbF9pZBgCIAEoDRIvCgpsZXZlbF90",
            "eXBlGAwgASgOMhsubWlIb21vLlByb3Rvcy5HQ0dMZXZlbFR5cGViBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GCGLevelTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GCGStartChallengeReq), global::MiHomo.Protos.GCGStartChallengeReq.Parser, new[]{ "ConfigId", "LevelId", "LevelType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGStartChallengeReq : pb::IMessage<GCGStartChallengeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGStartChallengeReq> _parser = new pb::MessageParser<GCGStartChallengeReq>(() => new GCGStartChallengeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGStartChallengeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GCGStartChallengeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGStartChallengeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGStartChallengeReq(GCGStartChallengeReq other) : this() {
      configId_ = other.configId_;
      levelId_ = other.levelId_;
      levelType_ = other.levelType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGStartChallengeReq Clone() {
      return new GCGStartChallengeReq(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 7;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 2;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "level_type" field.</summary>
    public const int LevelTypeFieldNumber = 12;
    private global::MiHomo.Protos.GCGLevelType levelType_ = global::MiHomo.Protos.GCGLevelType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GCGLevelType LevelType {
      get { return levelType_; }
      set {
        levelType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGStartChallengeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGStartChallengeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (LevelId != other.LevelId) return false;
      if (LevelType != other.LevelType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (LevelType != global::MiHomo.Protos.GCGLevelType.None) hash ^= LevelType.GetHashCode();
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
      if (LevelId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LevelId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ConfigId);
      }
      if (LevelType != global::MiHomo.Protos.GCGLevelType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) LevelType);
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
      if (LevelId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LevelId);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ConfigId);
      }
      if (LevelType != global::MiHomo.Protos.GCGLevelType.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) LevelType);
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
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (LevelType != global::MiHomo.Protos.GCGLevelType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) LevelType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGStartChallengeReq other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.LevelType != global::MiHomo.Protos.GCGLevelType.None) {
        LevelType = other.LevelType;
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 56: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 96: {
            LevelType = (global::MiHomo.Protos.GCGLevelType) input.ReadEnum();
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
            LevelId = input.ReadUInt32();
            break;
          }
          case 56: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 96: {
            LevelType = (global::MiHomo.Protos.GCGLevelType) input.ReadEnum();
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
