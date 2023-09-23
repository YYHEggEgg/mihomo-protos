// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBlueprintSearchInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeBlueprintSearchInfo.proto</summary>
  public static partial class HomeBlueprintSearchInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBlueprintSearchInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBlueprintSearchInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Ib21lQmx1ZXByaW50U2VhcmNoSW5mby5wcm90bxINbWlIb21vLlByb3Rv",
            "cyJkChdIb21lQmx1ZXByaW50U2VhcmNoSW5mbxIQCghibG9ja19pZBgMIAEo",
            "DRIRCgltb2R1bGVfaWQYCSABKA0SEAoIc2NlbmVfaWQYBSABKA0SEgoKc2hh",
            "cmVfY29kZRgIIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeBlueprintSearchInfo), global::MiHomo.Protos.HomeBlueprintSearchInfo.Parser, new[]{ "BlockId", "ModuleId", "SceneId", "ShareCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBlueprintSearchInfo : pb::IMessage<HomeBlueprintSearchInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBlueprintSearchInfo> _parser = new pb::MessageParser<HomeBlueprintSearchInfo>(() => new HomeBlueprintSearchInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBlueprintSearchInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeBlueprintSearchInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintSearchInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintSearchInfo(HomeBlueprintSearchInfo other) : this() {
      blockId_ = other.blockId_;
      moduleId_ = other.moduleId_;
      sceneId_ = other.sceneId_;
      shareCode_ = other.shareCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBlueprintSearchInfo Clone() {
      return new HomeBlueprintSearchInfo(this);
    }

    /// <summary>Field number for the "block_id" field.</summary>
    public const int BlockIdFieldNumber = 12;
    private uint blockId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlockId {
      get { return blockId_; }
      set {
        blockId_ = value;
      }
    }

    /// <summary>Field number for the "module_id" field.</summary>
    public const int ModuleIdFieldNumber = 9;
    private uint moduleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ModuleId {
      get { return moduleId_; }
      set {
        moduleId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 5;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    /// <summary>Field number for the "share_code" field.</summary>
    public const int ShareCodeFieldNumber = 8;
    private string shareCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ShareCode {
      get { return shareCode_; }
      set {
        shareCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBlueprintSearchInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBlueprintSearchInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BlockId != other.BlockId) return false;
      if (ModuleId != other.ModuleId) return false;
      if (SceneId != other.SceneId) return false;
      if (ShareCode != other.ShareCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BlockId != 0) hash ^= BlockId.GetHashCode();
      if (ModuleId != 0) hash ^= ModuleId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (ShareCode.Length != 0) hash ^= ShareCode.GetHashCode();
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
      if (SceneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneId);
      }
      if (ShareCode.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ShareCode);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ModuleId);
      }
      if (BlockId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BlockId);
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
      if (SceneId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(SceneId);
      }
      if (ShareCode.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ShareCode);
      }
      if (ModuleId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ModuleId);
      }
      if (BlockId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(BlockId);
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
      if (BlockId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BlockId);
      }
      if (ModuleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ModuleId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (ShareCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ShareCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBlueprintSearchInfo other) {
      if (other == null) {
        return;
      }
      if (other.BlockId != 0) {
        BlockId = other.BlockId;
      }
      if (other.ModuleId != 0) {
        ModuleId = other.ModuleId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
      }
      if (other.ShareCode.Length != 0) {
        ShareCode = other.ShareCode;
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
          case 40: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 66: {
            ShareCode = input.ReadString();
            break;
          }
          case 72: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 96: {
            BlockId = input.ReadUInt32();
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
          case 40: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 66: {
            ShareCode = input.ReadString();
            break;
          }
          case 72: {
            ModuleId = input.ReadUInt32();
            break;
          }
          case 96: {
            BlockId = input.ReadUInt32();
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
