// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterRogueDiaryDungeonReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EnterRogueDiaryDungeonReq.proto</summary>
  public static partial class EnterRogueDiaryDungeonReqReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterRogueDiaryDungeonReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterRogueDiaryDungeonReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9FbnRlclJvZ3VlRGlhcnlEdW5nZW9uUmVxLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zGhZSb2d1ZURpYXJ5QXZhdGFyLnByb3RvItYBChlFbnRlclJvZ3VlRGlh",
            "cnlEdW5nZW9uUmVxEjsKEmNob3Nlbl9hdmF0YXJfbGlzdBgLIAMoCzIfLm1p",
            "SG9tby5Qcm90b3MuUm9ndWVEaWFyeUF2YXRhchIYChBjaG9zZW5fY2FyZF9s",
            "aXN0GAkgAygNImIKBUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxf",
            "SUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAESEwoPSVNfQUxMT1dfQ0xJRU5U",
            "EAESCwoGQ01EX0lEEO9FGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EnterRogueDiaryDungeonReq), global::MiHomo.Protos.EnterRogueDiaryDungeonReq.Parser, new[]{ "ChosenAvatarList", "ChosenCardList" }, null, new[]{ typeof(global::MiHomo.Protos.EnterRogueDiaryDungeonReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EnterRogueDiaryDungeonReq : pb::IMessage<EnterRogueDiaryDungeonReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterRogueDiaryDungeonReq> _parser = new pb::MessageParser<EnterRogueDiaryDungeonReq>(() => new EnterRogueDiaryDungeonReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterRogueDiaryDungeonReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EnterRogueDiaryDungeonReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueDiaryDungeonReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueDiaryDungeonReq(EnterRogueDiaryDungeonReq other) : this() {
      chosenAvatarList_ = other.chosenAvatarList_.Clone();
      chosenCardList_ = other.chosenCardList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterRogueDiaryDungeonReq Clone() {
      return new EnterRogueDiaryDungeonReq(this);
    }

    /// <summary>Field number for the "chosen_avatar_list" field.</summary>
    public const int ChosenAvatarListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.RogueDiaryAvatar> _repeated_chosenAvatarList_codec
        = pb::FieldCodec.ForMessage(90, global::MiHomo.Protos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar> chosenAvatarList_ = new pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar> ChosenAvatarList {
      get { return chosenAvatarList_; }
    }

    /// <summary>Field number for the "chosen_card_list" field.</summary>
    public const int ChosenCardListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_chosenCardList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> chosenCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenCardList {
      get { return chosenCardList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterRogueDiaryDungeonReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterRogueDiaryDungeonReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!chosenAvatarList_.Equals(other.chosenAvatarList_)) return false;
      if(!chosenCardList_.Equals(other.chosenCardList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= chosenAvatarList_.GetHashCode();
      hash ^= chosenCardList_.GetHashCode();
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
      chosenCardList_.WriteTo(output, _repeated_chosenCardList_codec);
      chosenAvatarList_.WriteTo(output, _repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      chosenCardList_.WriteTo(ref output, _repeated_chosenCardList_codec);
      chosenAvatarList_.WriteTo(ref output, _repeated_chosenAvatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += chosenAvatarList_.CalculateSize(_repeated_chosenAvatarList_codec);
      size += chosenCardList_.CalculateSize(_repeated_chosenCardList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterRogueDiaryDungeonReq other) {
      if (other == null) {
        return;
      }
      chosenAvatarList_.Add(other.chosenAvatarList_);
      chosenCardList_.Add(other.chosenCardList_);
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
          case 74:
          case 72: {
            chosenCardList_.AddEntriesFrom(input, _repeated_chosenCardList_codec);
            break;
          }
          case 90: {
            chosenAvatarList_.AddEntriesFrom(input, _repeated_chosenAvatarList_codec);
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
          case 74:
          case 72: {
            chosenCardList_.AddEntriesFrom(ref input, _repeated_chosenCardList_codec);
            break;
          }
          case 90: {
            chosenAvatarList_.AddEntriesFrom(ref input, _repeated_chosenAvatarList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EnterRogueDiaryDungeonReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 8943,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
