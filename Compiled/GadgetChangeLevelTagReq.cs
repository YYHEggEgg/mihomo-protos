// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetChangeLevelTagReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GadgetChangeLevelTagReq.proto</summary>
  public static partial class GadgetChangeLevelTagReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetChangeLevelTagReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetChangeLevelTagReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1HYWRnZXRDaGFuZ2VMZXZlbFRhZ1JlcS5wcm90bxINbWlIb21vLlByb3Rv",
            "cxoaQ3VzdG9tR2FkZ2V0VHJlZUluZm8ucHJvdG8i7AEKF0dhZGdldENoYW5n",
            "ZUxldmVsVGFnUmVxEj0KEGNvbWJpbmF0aW9uX2luZm8YCyABKAsyIy5taUhv",
            "bW8uUHJvdG9zLkN1c3RvbUdhZGdldFRyZWVJbmZvEhgKEGdhZGdldF9lbnRp",
            "dHlfaWQYCiABKA0SFAoMbGV2ZWxfdGFnX2lkGA4gASgNImIKBUNtZElkEggK",
            "BE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElB",
            "QkxFEAESEwoPSVNfQUxMT1dfQ0xJRU5UEAESCwoGQ01EX0lEEMsGGgIQAWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CustomGadgetTreeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GadgetChangeLevelTagReq), global::MiHomo.Protos.GadgetChangeLevelTagReq.Parser, new[]{ "CombinationInfo", "GadgetEntityId", "LevelTagId" }, null, new[]{ typeof(global::MiHomo.Protos.GadgetChangeLevelTagReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GadgetChangeLevelTagReq : pb::IMessage<GadgetChangeLevelTagReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GadgetChangeLevelTagReq> _parser = new pb::MessageParser<GadgetChangeLevelTagReq>(() => new GadgetChangeLevelTagReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GadgetChangeLevelTagReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GadgetChangeLevelTagReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetChangeLevelTagReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetChangeLevelTagReq(GadgetChangeLevelTagReq other) : this() {
      combinationInfo_ = other.combinationInfo_ != null ? other.combinationInfo_.Clone() : null;
      gadgetEntityId_ = other.gadgetEntityId_;
      levelTagId_ = other.levelTagId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetChangeLevelTagReq Clone() {
      return new GadgetChangeLevelTagReq(this);
    }

    /// <summary>Field number for the "combination_info" field.</summary>
    public const int CombinationInfoFieldNumber = 11;
    private global::MiHomo.Protos.CustomGadgetTreeInfo combinationInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomGadgetTreeInfo CombinationInfo {
      get { return combinationInfo_; }
      set {
        combinationInfo_ = value;
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 10;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "level_tag_id" field.</summary>
    public const int LevelTagIdFieldNumber = 14;
    private uint levelTagId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelTagId {
      get { return levelTagId_; }
      set {
        levelTagId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GadgetChangeLevelTagReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GadgetChangeLevelTagReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CombinationInfo, other.CombinationInfo)) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      if (LevelTagId != other.LevelTagId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (combinationInfo_ != null) hash ^= CombinationInfo.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
      if (LevelTagId != 0) hash ^= LevelTagId.GetHashCode();
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
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (combinationInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CombinationInfo);
      }
      if (LevelTagId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelTagId);
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
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (combinationInfo_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(CombinationInfo);
      }
      if (LevelTagId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(LevelTagId);
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
      if (combinationInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CombinationInfo);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (LevelTagId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelTagId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GadgetChangeLevelTagReq other) {
      if (other == null) {
        return;
      }
      if (other.combinationInfo_ != null) {
        if (combinationInfo_ == null) {
          CombinationInfo = new global::MiHomo.Protos.CustomGadgetTreeInfo();
        }
        CombinationInfo.MergeFrom(other.CombinationInfo);
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
      }
      if (other.LevelTagId != 0) {
        LevelTagId = other.LevelTagId;
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
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (combinationInfo_ == null) {
              CombinationInfo = new global::MiHomo.Protos.CustomGadgetTreeInfo();
            }
            input.ReadMessage(CombinationInfo);
            break;
          }
          case 112: {
            LevelTagId = input.ReadUInt32();
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
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (combinationInfo_ == null) {
              CombinationInfo = new global::MiHomo.Protos.CustomGadgetTreeInfo();
            }
            input.ReadMessage(CombinationInfo);
            break;
          }
          case 112: {
            LevelTagId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GadgetChangeLevelTagReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 843,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
