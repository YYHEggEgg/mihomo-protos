// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlantFlowerRecvFlowerData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlantFlowerRecvFlowerData.proto</summary>
  public static partial class PlantFlowerRecvFlowerDataReflection {

    #region Descriptor
    /// <summary>File descriptor for PlantFlowerRecvFlowerData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlantFlowerRecvFlowerDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9QbGFudEZsb3dlclJlY3ZGbG93ZXJEYXRhLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zGhRQcm9maWxlUGljdHVyZS5wcm90byL7AQoZUGxhbnRGbG93ZXJSZWN2",
            "Rmxvd2VyRGF0YRIQCghuaWNrbmFtZRgFIAEoCRI2Cg9wcm9maWxlX3BpY3R1",
            "cmUYDSABKAsyHS5taUhvbW8uUHJvdG9zLlByb2ZpbGVQaWN0dXJlEgsKA3Vp",
            "ZBgJIAEoDRJSCg5mbG93ZXJfbnVtX21hcBgOIAMoCzI6Lm1pSG9tby5Qcm90",
            "b3MuUGxhbnRGbG93ZXJSZWN2Rmxvd2VyRGF0YS5GbG93ZXJOdW1NYXBFbnRy",
            "eRozChFGbG93ZXJOdW1NYXBFbnRyeRILCgNrZXkYASABKA0SDQoFdmFsdWUY",
            "AiABKA06AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ProfilePictureReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlantFlowerRecvFlowerData), global::MiHomo.Protos.PlantFlowerRecvFlowerData.Parser, new[]{ "Nickname", "ProfilePicture", "Uid", "FlowerNumMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlantFlowerRecvFlowerData : pb::IMessage<PlantFlowerRecvFlowerData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlantFlowerRecvFlowerData> _parser = new pb::MessageParser<PlantFlowerRecvFlowerData>(() => new PlantFlowerRecvFlowerData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlantFlowerRecvFlowerData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlantFlowerRecvFlowerDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerRecvFlowerData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerRecvFlowerData(PlantFlowerRecvFlowerData other) : this() {
      nickname_ = other.nickname_;
      profilePicture_ = other.profilePicture_ != null ? other.profilePicture_.Clone() : null;
      uid_ = other.uid_;
      flowerNumMap_ = other.flowerNumMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlantFlowerRecvFlowerData Clone() {
      return new PlantFlowerRecvFlowerData(this);
    }

    /// <summary>Field number for the "nickname" field.</summary>
    public const int NicknameFieldNumber = 5;
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
    public const int ProfilePictureFieldNumber = 13;
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
    public const int UidFieldNumber = 9;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    /// <summary>Field number for the "flower_num_map" field.</summary>
    public const int FlowerNumMapFieldNumber = 14;
    private static readonly pbc::MapField<uint, uint>.Codec _map_flowerNumMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 114);
    private readonly pbc::MapField<uint, uint> flowerNumMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> FlowerNumMap {
      get { return flowerNumMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlantFlowerRecvFlowerData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlantFlowerRecvFlowerData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Nickname != other.Nickname) return false;
      if (!object.Equals(ProfilePicture, other.ProfilePicture)) return false;
      if (Uid != other.Uid) return false;
      if (!FlowerNumMap.Equals(other.FlowerNumMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Nickname.Length != 0) hash ^= Nickname.GetHashCode();
      if (profilePicture_ != null) hash ^= ProfilePicture.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
      hash ^= FlowerNumMap.GetHashCode();
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
      if (Nickname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Uid);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ProfilePicture);
      }
      flowerNumMap_.WriteTo(output, _map_flowerNumMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Nickname.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Nickname);
      }
      if (Uid != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Uid);
      }
      if (profilePicture_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(ProfilePicture);
      }
      flowerNumMap_.WriteTo(ref output, _map_flowerNumMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Nickname.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Nickname);
      }
      if (profilePicture_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProfilePicture);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      size += flowerNumMap_.CalculateSize(_map_flowerNumMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlantFlowerRecvFlowerData other) {
      if (other == null) {
        return;
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
      if (other.Uid != 0) {
        Uid = other.Uid;
      }
      flowerNumMap_.Add(other.flowerNumMap_);
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
          case 42: {
            Nickname = input.ReadString();
            break;
          }
          case 72: {
            Uid = input.ReadUInt32();
            break;
          }
          case 106: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 114: {
            flowerNumMap_.AddEntriesFrom(input, _map_flowerNumMap_codec);
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
          case 42: {
            Nickname = input.ReadString();
            break;
          }
          case 72: {
            Uid = input.ReadUInt32();
            break;
          }
          case 106: {
            if (profilePicture_ == null) {
              ProfilePicture = new global::MiHomo.Protos.ProfilePicture();
            }
            input.ReadMessage(ProfilePicture);
            break;
          }
          case 114: {
            flowerNumMap_.AddEntriesFrom(ref input, _map_flowerNumMap_codec);
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
