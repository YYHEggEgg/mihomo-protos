// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BlessingFriendPicData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from BlessingFriendPicData.proto</summary>
  public static partial class BlessingFriendPicDataReflection {

    #region Descriptor
    /// <summary>File descriptor for BlessingFriendPicData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BlessingFriendPicDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtCbGVzc2luZ0ZyaWVuZFBpY0RhdGEucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "FFByb2ZpbGVQaWN0dXJlLnByb3RvIqUCChVCbGVzc2luZ0ZyaWVuZFBpY0Rh",
            "dGESEQoJYXZhdGFyX2lkGAQgASgNEhAKCG5pY2tuYW1lGAkgASgJEjYKD3By",
            "b2ZpbGVfcGljdHVyZRgHIAEoCzIdLm1pSG9tby5Qcm90b3MuUHJvZmlsZVBp",
            "Y3R1cmUSEwoLcmVtYXJrX25hbWUYCCABKAkSEQoJc2lnbmF0dXJlGA0gASgJ",
            "EgsKA3VpZBgPIAEoDRJICgtwaWNfbnVtX21hcBgFIAMoCzIzLm1pSG9tby5Q",
            "cm90b3MuQmxlc3NpbmdGcmllbmRQaWNEYXRhLlBpY051bU1hcEVudHJ5GjAK",
            "DlBpY051bU1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToC",
            "OAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.BlessingFriendPicData), global::MiHomo.Protos.BlessingFriendPicData.Parser, new[]{ "AvatarId", "Nickname", "ProfilePicture", "RemarkName", "Signature", "Uid", "PicNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BlessingFriendPicData : pb::IMessage<BlessingFriendPicData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BlessingFriendPicData> _parser = new pb::MessageParser<BlessingFriendPicData>(() => new BlessingFriendPicData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BlessingFriendPicData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.BlessingFriendPicDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingFriendPicData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingFriendPicData(BlessingFriendPicData other) : this() {
      avatarId_ = other.avatarId_;
      nickname_ = other.nickname_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      remarkName_ = other.remarkName_;
      signature_ = other.signature_;
      uid_ = other.uid_;
      picNumMap_ = other.picNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BlessingFriendPicData Clone() {
      return new BlessingFriendPicData(this);
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

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 9;
    private string nickname_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Nickname {
      get { return nickname_; }
      set {
        nickname_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "profile_picture" field.</summary>
    public const int ProfilePictureFieldNumber = 7;
    private global::MiHomo.Protos.ProfilePicture profilePicture_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ProfilePicture ProfilePicture {
      get { return profilePicture_; }
      set {
        profilePicture_ = value;
      }
    }

    /// <summary>Field number for the "remark_name" field.</summary>
    public const int RemarkNameFieldNumber = 8;
    private string remarkName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RemarkName {
      get { return remarkName_; }
      set {
        remarkName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int SignatureFieldNumber = 13;
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
    public const int UidFieldNumber = 15;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "pic_num_map" field.</summary>
    public const int PicNumMapFieldNumber = 5;
    private static readonly pbc::MapField<uint, uint>.Codec _map_picNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 42);
    private readonly pbc::MapField<uint, uint> picNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> PicNumMap {
      get { return picNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BlessingFriendPicData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BlessingFriendPicData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarId != other.AvatarId) return false;
      if (Nickname != other.Nickname) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (RemarkName != other.RemarkName) return false;
      if (Signature != other.Signature) return false;
      if (Uid != other.Uid) return false;
      if (!PicNumMap.Equals(other.PicNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarId != 0) hash ^= AvatarId.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (RemarkName.Length != 0) hash ^= RemarkName.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= PicNumMap.GetHashCode();
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
      if (AvatarId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarId);
      }
      picNumMap_.WriteTo(output, _map_picNumMap_codec);
      if (profilePicture_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ProfilePicture);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(RemarkName);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Nickname);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Signature);
      }
      if (Uid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Uid);
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
      if (AvatarId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AvatarId);
      }
      picNumMap_.WriteTo(ref output, _map_picNumMap_codec);
      if (profilePicture_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ProfilePicture);
      }
      if (RemarkName.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(RemarkName);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(Nickname);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Signature);
      }
      if (Uid != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Uid);
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
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (RemarkName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RemarkName);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Signature);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += picNumMap_.CalculateSize(_map_picNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BlessingFriendPicData other) {
      if (other == null) {
        return;
      }
      if (other.AvatarId != 0) {
        AvatarId = other.AvatarId;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.RemarkName.Length != 0) {
        RemarkName = other.RemarkName;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      picNumMap_.Add(other.picNumMap_);
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 42: {
            picNumMap_.AddEntriesFrom(input, _map_picNumMap_codec);
            break;
          }
          case 58: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 66: {
            RemarkName = input.ReadString();
            break;
          }
          case 74: {
            Nickname = input.ReadString();
            break;
          }
          case 106: {
            Signature = input.ReadString();
            break;
          }
          case 120: {
            Uid = input.ReadUInt32();
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
            AvatarId = input.ReadUInt32();
            break;
          }
          case 42: {
            picNumMap_.AddEntriesFrom(ref input, _map_picNumMap_codec);
            break;
          }
          case 58: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 66: {
            RemarkName = input.ReadString();
            break;
          }
          case 74: {
            Nickname = input.ReadString();
            break;
          }
          case 106: {
            Signature = input.ReadString();
            break;
          }
          case 120: {
            Uid = input.ReadUInt32();
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
