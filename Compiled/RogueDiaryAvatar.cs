// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryAvatar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RogueDiaryAvatar.proto</summary>
  public static partial class RogueDiaryAvatarReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryAvatar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryAvatarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSb2d1ZURpYXJ5QXZhdGFyLnByb3RvEg1taUhvbW8uUHJvdG9zGhtBY3Rp",
            "dml0eUR1bmdlb25BdmF0YXIucHJvdG8aI1JvZ3VlRGlhcnlBdmF0YXJEaXNh",
            "YmxlU3RhdHVzLnByb3RvIrcBChBSb2d1ZURpYXJ5QXZhdGFyEjQKBmF2YXRh",
            "chgCIAEoCzIkLm1pSG9tby5Qcm90b3MuQWN0aXZpdHlEdW5nZW9uQXZhdGFy",
            "EkkKE2Rpc2FibGVfc3RhdHVzX2xpc3QYCSADKA4yLC5taUhvbW8uUHJvdG9z",
            "LlJvZ3VlRGlhcnlBdmF0YXJEaXNhYmxlU3RhdHVzEg0KBWxldmVsGA4gASgN",
            "EhMKC3RpcmVkX3JvdW5kGA0gASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ActivityDungeonAvatarReflection.Descriptor, global::MiHomo.Protos.RogueDiaryAvatarDisableStatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RogueDiaryAvatar), global::MiHomo.Protos.RogueDiaryAvatar.Parser, new[]{ "Avatar", "DisableStatusList", "Level", "TiredRound" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueDiaryAvatar : pb::IMessage<RogueDiaryAvatar>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryAvatar> _parser = new pb::MessageParser<RogueDiaryAvatar>(() => new RogueDiaryAvatar());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryAvatar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RogueDiaryAvatarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryAvatar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryAvatar(RogueDiaryAvatar other) : this() {
      avatar_ = other.avatar_ != null ? other.avatar_.Clone() : null;
      disableStatusList_ = other.disableStatusList_.Clone();
      level_ = other.level_;
      tiredRound_ = other.tiredRound_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryAvatar Clone() {
      return new RogueDiaryAvatar(this);
    }

    /// <summary>Field number for the "avatar" field.</summary>
    public const int AvatarFieldNumber = 2;
    private global::MiHomo.Protos.ActivityDungeonAvatar avatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ActivityDungeonAvatar Avatar {
      get { return avatar_; }
      set {
        avatar_ = value;
      }
    }

    /// <summary>Field number for the "disable_status_list" field.</summary>
    public const int DisableStatusListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.RogueDiaryAvatarDisableStatus> _repeated_disableStatusList_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::MiHomo.Protos.RogueDiaryAvatarDisableStatus) x);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatarDisableStatus> disableStatusList_ = new pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatarDisableStatus>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatarDisableStatus> DisableStatusList {
      get { return disableStatusList_; }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 14;
    private uint level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "tired_round" field.</summary>
    public const int TiredRoundFieldNumber = 13;
    private uint tiredRound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TiredRound {
      get { return tiredRound_; }
      set {
        tiredRound_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryAvatar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryAvatar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Avatar, other.Avatar)) return false;
      if(!disableStatusList_.Equals(other.disableStatusList_)) return false;
      if (Level != other.Level) return false;
      if (TiredRound != other.TiredRound) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (avatar_ != null) hash ^= Avatar.GetHashCode();
      hash ^= disableStatusList_.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (TiredRound != 0) hash ^= TiredRound.GetHashCode();
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
      if (avatar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Avatar);
      }
      disableStatusList_.WriteTo(output, _repeated_disableStatusList_codec);
      if (TiredRound != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TiredRound);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
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
      if (avatar_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Avatar);
      }
      disableStatusList_.WriteTo(ref output, _repeated_disableStatusList_codec);
      if (TiredRound != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(TiredRound);
      }
      if (Level != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Level);
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
      if (avatar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Avatar);
      }
      size += disableStatusList_.CalculateSize(_repeated_disableStatusList_codec);
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (TiredRound != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TiredRound);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryAvatar other) {
      if (other == null) {
        return;
      }
      if (other.avatar_ != null) {
        if (avatar_ == null) {
          Avatar = new global::MiHomo.Protos.ActivityDungeonAvatar();
        }
        Avatar.MergeFrom(other.Avatar);
      }
      disableStatusList_.Add(other.disableStatusList_);
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.TiredRound != 0) {
        TiredRound = other.TiredRound;
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
            if (avatar_ == null) {
              Avatar = new global::MiHomo.Protos.ActivityDungeonAvatar();
            }
            input.ReadMessage(Avatar);
            break;
          }
          case 74:
          case 72: {
            disableStatusList_.AddEntriesFrom(input, _repeated_disableStatusList_codec);
            break;
          }
          case 104: {
            TiredRound = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
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
            if (avatar_ == null) {
              Avatar = new global::MiHomo.Protos.ActivityDungeonAvatar();
            }
            input.ReadMessage(Avatar);
            break;
          }
          case 74:
          case 72: {
            disableStatusList_.AddEntriesFrom(ref input, _repeated_disableStatusList_codec);
            break;
          }
          case 104: {
            TiredRound = input.ReadUInt32();
            break;
          }
          case 112: {
            Level = input.ReadUInt32();
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
