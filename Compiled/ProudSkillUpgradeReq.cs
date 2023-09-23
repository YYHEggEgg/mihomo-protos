// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProudSkillUpgradeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ProudSkillUpgradeReq.proto</summary>
  public static partial class ProudSkillUpgradeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ProudSkillUpgradeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProudSkillUpgradeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQcm91ZFNraWxsVXBncmFkZVJlcS5wcm90bxINbWlIb21vLlByb3RvcyJi",
            "ChRQcm91ZFNraWxsVXBncmFkZVJlcRITCgthdmF0YXJfZ3VpZBgNIAEoBBId",
            "ChVvbGRfcHJvdWRfc2tpbGxfbGV2ZWwYAyABKA0SFgoOcHJvdWRfc2tpbGxf",
            "aWQYAiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ProudSkillUpgradeReq), global::MiHomo.Protos.ProudSkillUpgradeReq.Parser, new[]{ "AvatarGuid", "OldProudSkillLevel", "ProudSkillId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProudSkillUpgradeReq : pb::IMessage<ProudSkillUpgradeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProudSkillUpgradeReq> _parser = new pb::MessageParser<ProudSkillUpgradeReq>(() => new ProudSkillUpgradeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProudSkillUpgradeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ProudSkillUpgradeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillUpgradeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillUpgradeReq(ProudSkillUpgradeReq other) : this() {
      avatarGuid_ = other.avatarGuid_;
      oldProudSkillLevel_ = other.oldProudSkillLevel_;
      proudSkillId_ = other.proudSkillId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProudSkillUpgradeReq Clone() {
      return new ProudSkillUpgradeReq(this);
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 13;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "old_proud_skill_level" field.</summary>
    public const int OldProudSkillLevelFieldNumber = 3;
    private uint oldProudSkillLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldProudSkillLevel {
      get { return oldProudSkillLevel_; }
      set {
        oldProudSkillLevel_ = value;
      }
    }

    /// <summary>Field number for the "proud_skill_id" field.</summary>
    public const int ProudSkillIdFieldNumber = 2;
    private uint proudSkillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ProudSkillId {
      get { return proudSkillId_; }
      set {
        proudSkillId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProudSkillUpgradeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProudSkillUpgradeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarGuid != other.AvatarGuid) return false;
      if (OldProudSkillLevel != other.OldProudSkillLevel) return false;
      if (ProudSkillId != other.ProudSkillId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (OldProudSkillLevel != 0) hash ^= OldProudSkillLevel.GetHashCode();
      if (ProudSkillId != 0) hash ^= ProudSkillId.GetHashCode();
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
      if (ProudSkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ProudSkillId);
      }
      if (OldProudSkillLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OldProudSkillLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(AvatarGuid);
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
      if (ProudSkillId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(ProudSkillId);
      }
      if (OldProudSkillLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(OldProudSkillLevel);
      }
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(AvatarGuid);
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
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (OldProudSkillLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldProudSkillLevel);
      }
      if (ProudSkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ProudSkillId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProudSkillUpgradeReq other) {
      if (other == null) {
        return;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.OldProudSkillLevel != 0) {
        OldProudSkillLevel = other.OldProudSkillLevel;
      }
      if (other.ProudSkillId != 0) {
        ProudSkillId = other.ProudSkillId;
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
            ProudSkillId = input.ReadUInt32();
            break;
          }
          case 24: {
            OldProudSkillLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarGuid = input.ReadUInt64();
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
            ProudSkillId = input.ReadUInt32();
            break;
          }
          case 24: {
            OldProudSkillLevel = input.ReadUInt32();
            break;
          }
          case 104: {
            AvatarGuid = input.ReadUInt64();
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
