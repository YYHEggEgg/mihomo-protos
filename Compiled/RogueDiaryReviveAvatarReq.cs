// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryReviveAvatarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RogueDiaryReviveAvatarReq.proto</summary>
  public static partial class RogueDiaryReviveAvatarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryReviveAvatarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryReviveAvatarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Sb2d1ZURpYXJ5UmV2aXZlQXZhdGFyUmVxLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zGhZSb2d1ZURpYXJ5QXZhdGFyLnByb3RvIrcBChlSb2d1ZURpYXJ5UmV2",
            "aXZlQXZhdGFyUmVxEjYKDXJldml2ZV9hdmF0YXIYAiABKAsyHy5taUhvbW8u",
            "UHJvdG9zLlJvZ3VlRGlhcnlBdmF0YXIiYgoFQ21kSWQSCAoETk9ORRAAEhMK",
            "D0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARITCg9J",
            "U19BTExPV19DTElFTlQQARILCgZDTURfSUQQ5j4aAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RogueDiaryReviveAvatarReq), global::MiHomo.Protos.RogueDiaryReviveAvatarReq.Parser, new[]{ "ReviveAvatar" }, null, new[]{ typeof(global::MiHomo.Protos.RogueDiaryReviveAvatarReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueDiaryReviveAvatarReq : pb::IMessage<RogueDiaryReviveAvatarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryReviveAvatarReq> _parser = new pb::MessageParser<RogueDiaryReviveAvatarReq>(() => new RogueDiaryReviveAvatarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryReviveAvatarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RogueDiaryReviveAvatarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryReviveAvatarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryReviveAvatarReq(RogueDiaryReviveAvatarReq other) : this() {
      reviveAvatar_ = other.reviveAvatar_ != null ? other.reviveAvatar_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryReviveAvatarReq Clone() {
      return new RogueDiaryReviveAvatarReq(this);
    }

    /// <summary>Field number for the "revive_avatar" field.</summary>
    public const int ReviveAvatarFieldNumber = 2;
    private global::MiHomo.Protos.RogueDiaryAvatar reviveAvatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.RogueDiaryAvatar ReviveAvatar {
      get { return reviveAvatar_; }
      set {
        reviveAvatar_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryReviveAvatarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryReviveAvatarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ReviveAvatar, other.ReviveAvatar)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (reviveAvatar_ != null) hash ^= ReviveAvatar.GetHashCode();
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
      if (reviveAvatar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReviveAvatar);
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
      if (reviveAvatar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ReviveAvatar);
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
      if (reviveAvatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReviveAvatar);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryReviveAvatarReq other) {
      if (other == null) {
        return;
      }
      if (other.reviveAvatar_ != null) {
        if (reviveAvatar_ == null) {
          ReviveAvatar = new global::MiHomo.Protos.RogueDiaryAvatar();
        }
        ReviveAvatar.MergeFrom(other.ReviveAvatar);
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
          case 18: {
            if (reviveAvatar_ == null) {
              ReviveAvatar = new global::MiHomo.Protos.RogueDiaryAvatar();
            }
            input.ReadMessage(ReviveAvatar);
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
          case 18: {
            if (reviveAvatar_ == null) {
              ReviveAvatar = new global::MiHomo.Protos.RogueDiaryAvatar();
            }
            input.ReadMessage(ReviveAvatar);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RogueDiaryReviveAvatarReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 8038,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
