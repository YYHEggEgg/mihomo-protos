// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OnlinePlayerInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from OnlinePlayerInfo.proto</summary>
  public static partial class OnlinePlayerInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for OnlinePlayerInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OnlinePlayerInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZPbmxpbmVQbGF5ZXJJbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zGhNNcFNl",
            "dHRpbmdUeXBlLnByb3RvGhRQcm9maWxlUGljdHVyZS5wcm90byLnAgoQT25s",
            "aW5lUGxheWVySW5mbxIRCglhdmF0YXJfaWQYBCABKA0SGgoSYmxhY2tsaXN0",
            "X3VpZF9saXN0GAogAygNEh8KF2N1cl9wbGF5ZXJfbnVtX2luX3dvcmxkGAYg",
            "ASgNEjUKD21wX3NldHRpbmdfdHlwZRgFIAEoDjIcLm1pSG9tby5Qcm90b3Mu",
            "TXBTZXR0aW5nVHlwZRIUCgxuYW1lX2NhcmRfaWQYCSABKA0SEAoIbmlja25h",
            "bWUYAiABKAkSEQoJb25saW5lX2lkGAggASgJEhQKDHBsYXllcl9sZXZlbBgD",
            "IAEoDRI2Cg9wcm9maWxlX3BpY3R1cmUYDCABKAsyHS5taUhvbW8uUHJvdG9z",
            "LlByb2ZpbGVQaWN0dXJlEg4KBnBzbl9pZBgNIAEoCRIRCglzaWduYXR1cmUY",
            "CyABKAkSCwoDdWlkGAEgASgNEhMKC3dvcmxkX2xldmVsGAcgASgNYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.MpSettingTypeReflection.Descriptor, global::MiHomo.Protos.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.OnlinePlayerInfo), global::MiHomo.Protos.OnlinePlayerInfo.Parser, new[]{ "AvatarId", "BlacklistUidList", "CurPlayerNumInWorld", "MpSettingType", "NameCardId", "Nickname", "OnlineId", "PlayerLevel", "ProfilePicture", "PsnId", "Signature", "Uid", "WorldLevel" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OnlinePlayerInfo : pb::IMessage<OnlinePlayerInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OnlinePlayerInfo> _parser = new pb::MessageParser<OnlinePlayerInfo>(() => new OnlinePlayerInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OnlinePlayerInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.OnlinePlayerInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OnlinePlayerInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OnlinePlayerInfo(OnlinePlayerInfo other) : this() {
      avatarId_ = other.avatarId_;
      blacklistUidList_ = other.blacklistUidList_.Clone();
      curPlayerNumInWorld_ = other.curPlayerNumInWorld_;
      mpSettingType_ = other.mpSettingType_;
      nameCardId_ = other.nameCardId_;
      nickname_ = other.nickname_;
      onlineId_ = other.onlineId_;
      playerLevel_ = other.playerLevel_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      psnId_ = other.psnId_;
      signature_ = other.signature_;
      uid_ = other.uid_;
      worldLevel_ = other.worldLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OnlinePlayerInfo Clone() {
      return new OnlinePlayerInfo(this);
    }

    /// <summary>Field number for the "avatar_id" field.</summary>
    public const int AvatarIdFieldNumber = 4;
    private uint avatarId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = value;
      }
    }

    /// <summary>Field number for the "blacklist_uid_list" field.</summary>
    public const int BlacklistUidListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_blacklistUidList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> blacklistUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> BlacklistUidList {
      get { return blacklistUidList_; }
    }

    /// <summary>Field number for the "cur_player_num_in_world" field.</summary>
    public const int CurPlayerNumInWorldFieldNumber = 6;
    private uint curPlayerNumInWorld_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurPlayerNumInWorld {
      get { return curPlayerNumInWorld_; }
      set {
        curPlayerNumInWorld_ = value;
      }
    }

    /// <summary>Field number for the "mp_setting_type" field.</summary>
    public const int MpSettingTypeFieldNumber = 5;
    private global::MiHomo.Protos.MpSettingType mpSettingType_ = global::MiHomo.Protos.MpSettingType.NoEnter;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.MpSettingType MpSettingType {
      get { return mpSettingType_; }
      set {
        mpSettingType_ = value;
      }
    }

    /// <summary>Field number for the "name_card_id" field.</summary>
    public const int NameCardIdFieldNumber = 9;
    private uint nameCardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NameCardId {
      get { return nameCardId_; }
      set {
        nameCardId_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 2;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "online_id" field.</summary>
    public const int OnlineIdFieldNumber = 8;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "player_level" field.</summary>
    public const int PlayerLevelFieldNumber = 3;
    private uint playerLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerLevel {
      get { return playerLevel_; }
      set {
        playerLevel_ = value;
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 12;
    private global::MiHomo.Protos.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "psn_id" field.</summary>
    public const int PsnIdFieldNumber = 13;
    private string psnId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PsnId {
      get { return psnId_; }
      set {
        psnId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 11;
    private string signature_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Signature {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "world_level" field.</summary>
    public const int WorldLevelFieldNumber = 7;
    private uint worldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WorldLevel {
      get { return worldLevel_; }
      set {
        worldLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OnlinePlayerInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OnlinePlayerInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if(!blacklistUidList_.Equals(other.blacklistUidList_)) return false;
      if (CurPlayerNumInWorld != other.CurPlayerNumInWorld) return false;
      if (MpSettingType != other.MpSettingType) return false;
      if (NameCardId != other.NameCardId) return false;
      if (Nickname != other.Nickname) return false;
      if (OnlineId != other.OnlineId) return false;
      if (PlayerLevel != other.PlayerLevel) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (PsnId != other.PsnId) return false;
      if (Signature != other.Signature) return false;
      if (Uid != other.Uid) return false;
      if (WorldLevel != other.WorldLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      hash ^= blacklistUidList_.GetHashCode();
      if (CurPlayerNumInWorld != 0) hash ^= CurPlayerNumInWorld.GetHashCode();
      if (MpSettingType != global::MiHomo.Protos.MpSettingType.NoEnter) hash ^= MpSettingType.GetHashCode();
      if (NameCardId != 0) hash ^= NameCardId.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (PlayerLevel != 0) hash ^= PlayerLevel.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (PsnId.Length != 0) hash ^= PsnId.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      if (WorldLevel != 0) hash ^= WorldLevel.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nickname);
      }
      if (PlayerLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayerLevel);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarId);
      }
      if (MpSettingType != global::MiHomo.Protos.MpSettingType.NoEnter) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MpSettingType);
      }
      if (CurPlayerNumInWorld != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurPlayerNumInWorld);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(WorldLevel);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(OnlineId);
      }
      if (NameCardId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NameCardId);
      }
      blacklistUidList_.WriteTo(output, _repeated_blacklistUidList_codec);
      if (Signature.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Signature);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ProfilePicture);
      }
      if (PsnId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(PsnId);
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
      if (Uid != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Uid);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Nickname);
      }
      if (PlayerLevel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayerLevel);
      }
      if (AvatarId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarId);
      }
      if (MpSettingType != global::MiHomo.Protos.MpSettingType.NoEnter) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MpSettingType);
      }
      if (CurPlayerNumInWorld != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurPlayerNumInWorld);
      }
      if (WorldLevel != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(WorldLevel);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(OnlineId);
      }
      if (NameCardId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(NameCardId);
      }
      blacklistUidList_.WriteTo(ref output, _repeated_blacklistUidList_codec);
      if (Signature.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(Signature);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ProfilePicture);
      }
      if (PsnId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(PsnId);
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
      if (AvatarId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AvatarId);
      }
      size += blacklistUidList_.CalculateSize(_repeated_blacklistUidList_codec);
      if (CurPlayerNumInWorld != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurPlayerNumInWorld);
      }
      if (MpSettingType != global::MiHomo.Protos.MpSettingType.NoEnter) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MpSettingType);
      }
      if (NameCardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NameCardId);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (PlayerLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerLevel);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (PsnId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PsnId);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (WorldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WorldLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OnlinePlayerInfo other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      blacklistUidList_.Add(other.blacklistUidList_);
      if (other.CurPlayerNumInWorld != 0) {
        CurPlayerNumInWorld = other.CurPlayerNumInWorld;
      }
      if (other.MpSettingType != global::MiHomo.Protos.MpSettingType.NoEnter) {
        MpSettingType = other.MpSettingType;
      }
      if (other.NameCardId != 0) {
        NameCardId = other.NameCardId;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.PlayerLevel != 0) {
        PlayerLevel = other.PlayerLevel;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.PsnId.Length != 0) {
        PsnId = other.PsnId;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      if (other.WorldLevel != 0) {
        WorldLevel = other.WorldLevel;
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
          case 8: {
            Uid = input.ReadUInt32();
            break;
          }
          case 18: {
            Nickname = input.ReadString();
            break;
          }
          case 24: {
            PlayerLevel = input.ReadUInt32();
            break;
          }
          case 32: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            MpSettingType = (global::MiHomo.Protos.MpSettingType) input.ReadEnum();
            break;
          }
          case 48: {
            CurPlayerNumInWorld = input.ReadUInt32();
            break;
          }
          case 56: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 66: {
            OnlineId = input.ReadString();
            break;
          }
          case 72: {
            NameCardId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            blacklistUidList_.AddEntriesFrom(input, _repeated_blacklistUidList_codec);
            break;
          }
          case 90: {
            Signature = input.ReadString();
            break;
          }
          case 98: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 106: {
            PsnId = input.ReadString();
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
          case 8: {
            Uid = input.ReadUInt32();
            break;
          }
          case 18: {
            Nickname = input.ReadString();
            break;
          }
          case 24: {
            PlayerLevel = input.ReadUInt32();
            break;
          }
          case 32: {
            AvatarId = input.ReadUInt32();
            break;
          }
          case 40: {
            MpSettingType = (global::MiHomo.Protos.MpSettingType) input.ReadEnum();
            break;
          }
          case 48: {
            CurPlayerNumInWorld = input.ReadUInt32();
            break;
          }
          case 56: {
            WorldLevel = input.ReadUInt32();
            break;
          }
          case 66: {
            OnlineId = input.ReadString();
            break;
          }
          case 72: {
            NameCardId = input.ReadUInt32();
            break;
          }
          case 82:
          case 80: {
            blacklistUidList_.AddEntriesFrom(ref input, _repeated_blacklistUidList_codec);
            break;
          }
          case 90: {
            Signature = input.ReadString();
            break;
          }
          case 98: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 106: {
            PsnId = input.ReadString();
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
