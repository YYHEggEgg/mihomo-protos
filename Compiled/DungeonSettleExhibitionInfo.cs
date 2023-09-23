// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonSettleExhibitionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DungeonSettleExhibitionInfo.proto</summary>
  public static partial class DungeonSettleExhibitionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonSettleExhibitionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonSettleExhibitionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFEdW5nZW9uU2V0dGxlRXhoaWJpdGlvbkluZm8ucHJvdG8SDW1pSG9tby5Q",
            "cm90b3MaG0V4aGliaXRpb25EaXNwbGF5SW5mby5wcm90bxoWT25saW5lUGxh",
            "eWVySW5mby5wcm90byKMAQobRHVuZ2VvblNldHRsZUV4aGliaXRpb25JbmZv",
            "EjcKCWNhcmRfbGlzdBgNIAMoCzIkLm1pSG9tby5Qcm90b3MuRXhoaWJpdGlv",
            "bkRpc3BsYXlJbmZvEjQKC3BsYXllcl9pbmZvGAMgASgLMh8ubWlIb21vLlBy",
            "b3Rvcy5PbmxpbmVQbGF5ZXJJbmZvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ExhibitionDisplayInfoReflection.Descriptor, global::MiHomo.Protos.OnlinePlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DungeonSettleExhibitionInfo), global::MiHomo.Protos.DungeonSettleExhibitionInfo.Parser, new[]{ "CardList", "PlayerInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonSettleExhibitionInfo : pb::IMessage<DungeonSettleExhibitionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonSettleExhibitionInfo> _parser = new pb::MessageParser<DungeonSettleExhibitionInfo>(() => new DungeonSettleExhibitionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonSettleExhibitionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DungeonSettleExhibitionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonSettleExhibitionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonSettleExhibitionInfo(DungeonSettleExhibitionInfo other) : this() {
      cardList_ = other.cardList_.Clone();
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonSettleExhibitionInfo Clone() {
      return new DungeonSettleExhibitionInfo(this);
    }

    /// <summary>Field number for the "card_list" field.</summary>
    public const int CardListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.ExhibitionDisplayInfo> _repeated_cardList_codec
        = pb::FieldCodec.ForMessage(106, global::MiHomo.Protos.ExhibitionDisplayInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.ExhibitionDisplayInfo> cardList_ = new pbc::RepeatedField<global::MiHomo.Protos.ExhibitionDisplayInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.ExhibitionDisplayInfo> CardList {
      get { return cardList_; }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 3;
    private global::MiHomo.Protos.OnlinePlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.OnlinePlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonSettleExhibitionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonSettleExhibitionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cardList_.Equals(other.cardList_)) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cardList_.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
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
      if (playerInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PlayerInfo);
      }
      cardList_.WriteTo(output, _repeated_cardList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (playerInfo_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PlayerInfo);
      }
      cardList_.WriteTo(ref output, _repeated_cardList_codec);
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
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonSettleExhibitionInfo other) {
      if (other == null) {
        return;
      }
      cardList_.Add(other.cardList_);
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::MiHomo.Protos.OnlinePlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
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
          case 26: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::MiHomo.Protos.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 106: {
            cardList_.AddEntriesFrom(input, _repeated_cardList_codec);
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
          case 26: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::MiHomo.Protos.OnlinePlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 106: {
            cardList_.AddEntriesFrom(ref input, _repeated_cardList_codec);
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
