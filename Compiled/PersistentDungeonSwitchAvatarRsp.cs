// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PersistentDungeonSwitchAvatarRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PersistentDungeonSwitchAvatarRsp.proto</summary>
  public static partial class PersistentDungeonSwitchAvatarRspReflection {

    #region Descriptor
    /// <summary>File descriptor for PersistentDungeonSwitchAvatarRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersistentDungeonSwitchAvatarRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQZXJzaXN0ZW50RHVuZ2VvblN3aXRjaEF2YXRhclJzcC5wcm90bxINbWlI",
            "b21vLlByb3RvcyK6AQogUGVyc2lzdGVudER1bmdlb25Td2l0Y2hBdmF0YXJS",
            "c3ASHQoVYXZhdGFyX3RlYW1fZ3VpZF9saXN0GA4gAygEEhcKD2N1cl9hdmF0",
            "YXJfZ3VpZBgPIAEoBBIPCgdyZXRjb2RlGAcgASgFIk0KBUNtZElkEggKBE5P",
            "TkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxF",
            "EAESCwoGQ01EX0lEEOgNGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PersistentDungeonSwitchAvatarRsp), global::MiHomo.Protos.PersistentDungeonSwitchAvatarRsp.Parser, new[]{ "AvatarTeamGuidList", "CurAvatarGuid", "Retcode" }, null, new[]{ typeof(global::MiHomo.Protos.PersistentDungeonSwitchAvatarRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PersistentDungeonSwitchAvatarRsp : pb::IMessage<PersistentDungeonSwitchAvatarRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PersistentDungeonSwitchAvatarRsp> _parser = new pb::MessageParser<PersistentDungeonSwitchAvatarRsp>(() => new PersistentDungeonSwitchAvatarRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PersistentDungeonSwitchAvatarRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PersistentDungeonSwitchAvatarRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersistentDungeonSwitchAvatarRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersistentDungeonSwitchAvatarRsp(PersistentDungeonSwitchAvatarRsp other) : this() {
      avatarTeamGuidList_ = other.avatarTeamGuidList_.Clone();
      curAvatarGuid_ = other.curAvatarGuid_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PersistentDungeonSwitchAvatarRsp Clone() {
      return new PersistentDungeonSwitchAvatarRsp(this);
    }

    /// <summary>Field number for the "avatar_team_guid_list" field.</summary>
    public const int AvatarTeamGuidListFieldNumber = 14;
    private static readonly pb::FieldCodec<ulong> _repeated_avatarTeamGuidList_codec
        = pb::FieldCodec.ForUInt64(114);
    private readonly pbc::RepeatedField<ulong> avatarTeamGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> AvatarTeamGuidList {
      get { return avatarTeamGuidList_; }
    }

    /// <summary>Field number for the "cur_avatar_guid" field.</summary>
    public const int CurAvatarGuidFieldNumber = 15;
    private ulong curAvatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CurAvatarGuid {
      get { return curAvatarGuid_; }
      set {
        curAvatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PersistentDungeonSwitchAvatarRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PersistentDungeonSwitchAvatarRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarTeamGuidList_.Equals(other.avatarTeamGuidList_)) return false;
      if (CurAvatarGuid != other.CurAvatarGuid) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarTeamGuidList_.GetHashCode();
      if (CurAvatarGuid != 0UL) hash ^= CurAvatarGuid.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      avatarTeamGuidList_.WriteTo(output, _repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(CurAvatarGuid);
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
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      avatarTeamGuidList_.WriteTo(ref output, _repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(120);
        output.WriteUInt64(CurAvatarGuid);
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
      size += avatarTeamGuidList_.CalculateSize(_repeated_avatarTeamGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CurAvatarGuid);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PersistentDungeonSwitchAvatarRsp other) {
      if (other == null) {
        return;
      }
      avatarTeamGuidList_.Add(other.avatarTeamGuidList_);
      if (other.CurAvatarGuid != 0UL) {
        CurAvatarGuid = other.CurAvatarGuid;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114:
          case 112: {
            avatarTeamGuidList_.AddEntriesFrom(input, _repeated_avatarTeamGuidList_codec);
            break;
          }
          case 120: {
            CurAvatarGuid = input.ReadUInt64();
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
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114:
          case 112: {
            avatarTeamGuidList_.AddEntriesFrom(ref input, _repeated_avatarTeamGuidList_codec);
            break;
          }
          case 120: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PersistentDungeonSwitchAvatarRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1768,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
