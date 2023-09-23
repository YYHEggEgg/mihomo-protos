// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrystalLinkTeamInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CrystalLinkTeamInfo.proto</summary>
  public static partial class CrystalLinkTeamInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CrystalLinkTeamInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrystalLinkTeamInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDcnlzdGFsTGlua1RlYW1JbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zGhtD",
            "cnlzdGFsTGlua0F2YXRhckluZm8ucHJvdG8aGUNyeXN0YWxMaW5rQnVmZklu",
            "Zm8ucHJvdG8ikQEKE0NyeXN0YWxMaW5rVGVhbUluZm8SPgoQYXZhdGFyX2lu",
            "Zm9fbGlzdBgOIAMoCzIkLm1pSG9tby5Qcm90b3MuQ3J5c3RhbExpbmtBdmF0",
            "YXJJbmZvEjoKDmJ1ZmZfaW5mb19saXN0GAwgAygLMiIubWlIb21vLlByb3Rv",
            "cy5DcnlzdGFsTGlua0J1ZmZJbmZvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CrystalLinkAvatarInfoReflection.Descriptor, global::MiHomo.Protos.CrystalLinkBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CrystalLinkTeamInfo), global::MiHomo.Protos.CrystalLinkTeamInfo.Parser, new[]{ "AvatarInfoList", "BuffInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CrystalLinkTeamInfo : pb::IMessage<CrystalLinkTeamInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CrystalLinkTeamInfo> _parser = new pb::MessageParser<CrystalLinkTeamInfo>(() => new CrystalLinkTeamInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CrystalLinkTeamInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CrystalLinkTeamInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkTeamInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkTeamInfo(CrystalLinkTeamInfo other) : this() {
      avatarInfoList_ = other.avatarInfoList_.Clone();
      buffInfoList_ = other.buffInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkTeamInfo Clone() {
      return new CrystalLinkTeamInfo(this);
    }

    /// <summary>Field number for the "avatar_info_list" field.</summary>
    public const int AvatarInfoListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.CrystalLinkAvatarInfo> _repeated_avatarInfoList_codec
        = pb::FieldCodec.ForMessage(114, global::MiHomo.Protos.CrystalLinkAvatarInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.CrystalLinkAvatarInfo> avatarInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.CrystalLinkAvatarInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.CrystalLinkAvatarInfo> AvatarInfoList {
      get { return avatarInfoList_; }
    }

    /// <summary>Field number for the "buff_info_list" field.</summary>
    public const int BuffInfoListFieldNumber = 12;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.CrystalLinkBuffInfo> _repeated_buffInfoList_codec
        = pb::FieldCodec.ForMessage(98, global::MiHomo.Protos.CrystalLinkBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.CrystalLinkBuffInfo> buffInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.CrystalLinkBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.CrystalLinkBuffInfo> BuffInfoList {
      get { return buffInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CrystalLinkTeamInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CrystalLinkTeamInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarInfoList_.Equals(other.avatarInfoList_)) return false;
      if(!buffInfoList_.Equals(other.buffInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarInfoList_.GetHashCode();
      hash ^= buffInfoList_.GetHashCode();
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
      buffInfoList_.WriteTo(output, _repeated_buffInfoList_codec);
      avatarInfoList_.WriteTo(output, _repeated_avatarInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      buffInfoList_.WriteTo(ref output, _repeated_buffInfoList_codec);
      avatarInfoList_.WriteTo(ref output, _repeated_avatarInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += avatarInfoList_.CalculateSize(_repeated_avatarInfoList_codec);
      size += buffInfoList_.CalculateSize(_repeated_buffInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CrystalLinkTeamInfo other) {
      if (other == null) {
        return;
      }
      avatarInfoList_.Add(other.avatarInfoList_);
      buffInfoList_.Add(other.buffInfoList_);
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
          case 98: {
            buffInfoList_.AddEntriesFrom(input, _repeated_buffInfoList_codec);
            break;
          }
          case 114: {
            avatarInfoList_.AddEntriesFrom(input, _repeated_avatarInfoList_codec);
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
          case 98: {
            buffInfoList_.AddEntriesFrom(ref input, _repeated_buffInfoList_codec);
            break;
          }
          case 114: {
            avatarInfoList_.AddEntriesFrom(ref input, _repeated_avatarInfoList_codec);
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
