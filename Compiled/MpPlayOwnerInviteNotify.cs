// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MpPlayOwnerInviteNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MpPlayOwnerInviteNotify.proto</summary>
  public static partial class MpPlayOwnerInviteNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for MpPlayOwnerInviteNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MpPlayOwnerInviteNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1NcFBsYXlPd25lckludml0ZU5vdGlmeS5wcm90bxINbWlIb21vLlByb3Rv",
            "cyJTChdNcFBsYXlPd25lckludml0ZU5vdGlmeRIKCgJjZBgHIAEoDRIYChBp",
            "c19yZW1haW5fcmV3YXJkGAQgASgIEhIKCm1wX3BsYXlfaWQYCyABKA1iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MpPlayOwnerInviteNotify), global::MiHomo.Protos.MpPlayOwnerInviteNotify.Parser, new[]{ "Cd", "IsRemainReward", "MpPlayId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MpPlayOwnerInviteNotify : pb::IMessage<MpPlayOwnerInviteNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MpPlayOwnerInviteNotify> _parser = new pb::MessageParser<MpPlayOwnerInviteNotify>(() => new MpPlayOwnerInviteNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MpPlayOwnerInviteNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MpPlayOwnerInviteNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MpPlayOwnerInviteNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MpPlayOwnerInviteNotify(MpPlayOwnerInviteNotify other) : this() {
      cd_ = other.cd_;
      isRemainReward_ = other.isRemainReward_;
      mpPlayId_ = other.mpPlayId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MpPlayOwnerInviteNotify Clone() {
      return new MpPlayOwnerInviteNotify(this);
    }

    /// <summary>Field number for the "cd" field.</summary>
    public const int CdFieldNumber = 7;
    private uint cd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Cd {
      get { return cd_; }
      set {
        cd_ = value;
      }
    }

    /// <summary>Field number for the "is_remain_reward" field.</summary>
    public const int IsRemainRewardFieldNumber = 4;
    private bool isRemainReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRemainReward {
      get { return isRemainReward_; }
      set {
        isRemainReward_ = value;
      }
    }

    /// <summary>Field number for the "mp_play_id" field.</summary>
    public const int MpPlayIdFieldNumber = 11;
    private uint mpPlayId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MpPlayId {
      get { return mpPlayId_; }
      set {
        mpPlayId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MpPlayOwnerInviteNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MpPlayOwnerInviteNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Cd != other.Cd) return false;
      if (IsRemainReward != other.IsRemainReward) return false;
      if (MpPlayId != other.MpPlayId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Cd != 0) hash ^= Cd.GetHashCode();
      if (IsRemainReward != false) hash ^= IsRemainReward.GetHashCode();
      if (MpPlayId != 0) hash ^= MpPlayId.GetHashCode();
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
      if (IsRemainReward != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsRemainReward);
      }
      if (Cd != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Cd);
      }
      if (MpPlayId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MpPlayId);
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
      if (IsRemainReward != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsRemainReward);
      }
      if (Cd != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Cd);
      }
      if (MpPlayId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(MpPlayId);
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
      if (Cd != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Cd);
      }
      if (IsRemainReward != false) {
        size += 1 + 1;
      }
      if (MpPlayId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MpPlayId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MpPlayOwnerInviteNotify other) {
      if (other == null) {
        return;
      }
      if (other.Cd != 0) {
        Cd = other.Cd;
      }
      if (other.IsRemainReward != false) {
        IsRemainReward = other.IsRemainReward;
      }
      if (other.MpPlayId != 0) {
        MpPlayId = other.MpPlayId;
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
            IsRemainReward = input.ReadBool();
            break;
          }
          case 56: {
            Cd = input.ReadUInt32();
            break;
          }
          case 88: {
            MpPlayId = input.ReadUInt32();
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
            IsRemainReward = input.ReadBool();
            break;
          }
          case 56: {
            Cd = input.ReadUInt32();
            break;
          }
          case 88: {
            MpPlayId = input.ReadUInt32();
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
