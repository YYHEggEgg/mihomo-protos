// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MarkTargetInvestigationMonsterNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MarkTargetInvestigationMonsterNotify.proto</summary>
  public static partial class MarkTargetInvestigationMonsterNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MarkTargetInvestigationMonsterNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MarkTargetInvestigationMonsterNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipNYXJrVGFyZ2V0SW52ZXN0aWdhdGlvbk1vbnN0ZXJOb3RpZnkucHJvdG8S",
            "DW1pSG9tby5Qcm90b3Mi5AEKJE1hcmtUYXJnZXRJbnZlc3RpZ2F0aW9uTW9u",
            "c3Rlck5vdGlmeRIQCghncm91cF9pZBgFIAEoDRIgChhpbnZlc3RpZ2F0aW9u",
            "X21vbnN0ZXJfaWQYDCABKA0SEgoKbW9uc3Rlcl9pZBgEIAEoDRIQCghzY2Vu",
            "ZV9pZBgLIAEoDSJiCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVM",
            "X0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVO",
            "VBABEgsKBkNNRF9JRBD7DhoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MarkTargetInvestigationMonsterNotify), global::MiHomo.Protos.MarkTargetInvestigationMonsterNotify.Parser, new[]{ "GroupId", "InvestigationMonsterId", "MonsterId", "SceneId" }, null, new[]{ typeof(global::MiHomo.Protos.MarkTargetInvestigationMonsterNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MarkTargetInvestigationMonsterNotify : pb::IMessage<MarkTargetInvestigationMonsterNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MarkTargetInvestigationMonsterNotify> _parser = new pb::MessageParser<MarkTargetInvestigationMonsterNotify>(() => new MarkTargetInvestigationMonsterNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MarkTargetInvestigationMonsterNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MarkTargetInvestigationMonsterNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarkTargetInvestigationMonsterNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarkTargetInvestigationMonsterNotify(MarkTargetInvestigationMonsterNotify other) : this() {
      groupId_ = other.groupId_;
      investigationMonsterId_ = other.investigationMonsterId_;
      monsterId_ = other.monsterId_;
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MarkTargetInvestigationMonsterNotify Clone() {
      return new MarkTargetInvestigationMonsterNotify(this);
    }

    /// <summary>Field number for the "group_id" field.</summary>
    public const int GroupIdFieldNumber = 5;
    private uint groupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GroupId {
      get { return groupId_; }
      set {
        groupId_ = value;
      }
    }

    /// <summary>Field number for the "investigation_monster_id" field.</summary>
    public const int InvestigationMonsterIdFieldNumber = 12;
    private uint investigationMonsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InvestigationMonsterId {
      get { return investigationMonsterId_; }
      set {
        investigationMonsterId_ = value;
      }
    }

    /// <summary>Field number for the "monster_id" field.</summary>
    public const int MonsterIdFieldNumber = 4;
    private uint monsterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MonsterId {
      get { return monsterId_; }
      set {
        monsterId_ = value;
      }
    }

    /// <summary>Field number for the "scene_id" field.</summary>
    public const int SceneIdFieldNumber = 11;
    private uint sceneId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MarkTargetInvestigationMonsterNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MarkTargetInvestigationMonsterNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GroupId != other.GroupId) return false;
      if (InvestigationMonsterId != other.InvestigationMonsterId) return false;
      if (MonsterId != other.MonsterId) return false;
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GroupId != 0) hash ^= GroupId.GetHashCode();
      if (InvestigationMonsterId != 0) hash ^= InvestigationMonsterId.GetHashCode();
      if (MonsterId != 0) hash ^= MonsterId.GetHashCode();
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
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
      if (MonsterId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MonsterId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GroupId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SceneId);
      }
      if (InvestigationMonsterId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(InvestigationMonsterId);
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
      if (MonsterId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MonsterId);
      }
      if (GroupId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(GroupId);
      }
      if (SceneId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(SceneId);
      }
      if (InvestigationMonsterId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(InvestigationMonsterId);
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
      if (GroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GroupId);
      }
      if (InvestigationMonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InvestigationMonsterId);
      }
      if (MonsterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MonsterId);
      }
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MarkTargetInvestigationMonsterNotify other) {
      if (other == null) {
        return;
      }
      if (other.GroupId != 0) {
        GroupId = other.GroupId;
      }
      if (other.InvestigationMonsterId != 0) {
        InvestigationMonsterId = other.InvestigationMonsterId;
      }
      if (other.MonsterId != 0) {
        MonsterId = other.MonsterId;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
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
          case 32: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 40: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 88: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 96: {
            InvestigationMonsterId = input.ReadUInt32();
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
          case 32: {
            MonsterId = input.ReadUInt32();
            break;
          }
          case 40: {
            GroupId = input.ReadUInt32();
            break;
          }
          case 88: {
            SceneId = input.ReadUInt32();
            break;
          }
          case 96: {
            InvestigationMonsterId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MarkTargetInvestigationMonsterNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1915,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
