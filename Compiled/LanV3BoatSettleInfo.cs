// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LanV3BoatSettleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from LanV3BoatSettleInfo.proto</summary>
  public static partial class LanV3BoatSettleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for LanV3BoatSettleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LanV3BoatSettleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlMYW5WM0JvYXRTZXR0bGVJbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zGhtF",
            "eGhpYml0aW9uRGlzcGxheUluZm8ucHJvdG8aFFByb2ZpbGVQaWN0dXJlLnBy",
            "b3RvIswBChNMYW5WM0JvYXRTZXR0bGVJbmZvEjcKCWNhcmRfbGlzdBgBIAMo",
            "CzIkLm1pSG9tby5Qcm90b3MuRXhoaWJpdGlvbkRpc3BsYXlJbmZvEhIKCmhl",
            "YWRfaW1hZ2UYCiABKA0SEAoIbmlja25hbWUYDiABKAkSEQoJb25saW5lX2lk",
            "GA0gASgJEjYKD3Byb2ZpbGVfcGljdHVyZRgMIAEoCzIdLm1pSG9tby5Qcm90",
            "b3MuUHJvZmlsZVBpY3R1cmUSCwoDdWlkGAggASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ExhibitionDisplayInfoReflection.Descriptor, global::MiHomo.Protos.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.LanV3BoatSettleInfo), global::MiHomo.Protos.LanV3BoatSettleInfo.Parser, new[]{ "CardList", "HeadImage", "Nickname", "OnlineId", "ProfilePicture", "Uid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LanV3BoatSettleInfo : pb::IMessage<LanV3BoatSettleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LanV3BoatSettleInfo> _parser = new pb::MessageParser<LanV3BoatSettleInfo>(() => new LanV3BoatSettleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LanV3BoatSettleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.LanV3BoatSettleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanV3BoatSettleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanV3BoatSettleInfo(LanV3BoatSettleInfo other) : this() {
      cardList_ = other.cardList_.Clone();
      headImage_ = other.headImage_;
      nickname_ = other.nickname_;
      onlineId_ = other.onlineId_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LanV3BoatSettleInfo Clone() {
      return new LanV3BoatSettleInfo(this);
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ExhibitionDisplayInfo> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(10, global::MiHomo.Protos.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ExhibitionDisplayInfo> cardList_ = new pbc::RepeatedField<global::MiHomo.Protos.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ExhibitionDisplayInfo> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "head_image" field.</summary>
    public const int HeadImageFieldNumber = 10;
    private uint headImage_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HeadImage {
      get { return headImage_; }
      set {
        headImage_ = value;
      }
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 14;
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
    public const int OnlineIdFieldNumber = 13;
    private string onlineId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OnlineId {
      get { return onlineId_; }
      set {
        onlineId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 8;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LanV3BoatSettleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LanV3BoatSettleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cardList_.Equals(other.cardList_)) return false;
      if (HeadImage != other.HeadImage) return false;
      if (Nickname != other.Nickname) return false;
      if (OnlineId != other.OnlineId) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cardList_.GetHashCode();
      if (HeadImage != 0) hash ^= HeadImage.GetHashCode();
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (OnlineId.Length != 0) hash ^= OnlineId.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      cardList_.WriteTo(output, _repeated_cardList_codec);
      if (Uid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Uid);
      }
      if (HeadImage != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HeadImage);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ProfilePicture);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(OnlineId);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Nickname);
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
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
      if (Uid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Uid);
      }
      if (HeadImage != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(HeadImage);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(ProfilePicture);
      }
      if (OnlineId.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(OnlineId);
      }
      if (Nickname.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(Nickname);
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
      size += cardList_.CalculateSize(_repeated_cardList_codec);
      if (HeadImage != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HeadImage);
      }
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (OnlineId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OnlineId);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(LanV3BoatSettleInfo other) {
      if (other == null) {
        return;
      }
      cardList_.Add(other.cardList_);
      if (other.HeadImage != 0) {
        HeadImage = other.HeadImage;
      }
      if (other.Nickname.Length != 0) {
        Nickname = other.Nickname;
      }
      if (other.OnlineId.Length != 0) {
        OnlineId = other.OnlineId;
      }
      if (other.profilePicture_ != null) {
        if (profilePicture_ == null) {
          ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
        }
        ProfilePicture.MergeFrom(other.ProfilePicture);
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
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
          case 10: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
            break;
          }
          case 64: {
            Uid = input.ReadUInt32();
            break;
          }
          case 80: {
            HeadImage = input.ReadUInt32();
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
            OnlineId = input.ReadString();
            break;
          }
          case 114: {
            Nickname = input.ReadString();
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
          case 10: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
            break;
          }
          case 64: {
            Uid = input.ReadUInt32();
            break;
          }
          case 80: {
            HeadImage = input.ReadUInt32();
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
            OnlineId = input.ReadString();
            break;
          }
          case 114: {
            Nickname = input.ReadString();
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
