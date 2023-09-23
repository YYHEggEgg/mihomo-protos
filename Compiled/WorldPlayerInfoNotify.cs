// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WorldPlayerInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WorldPlayerInfoNotify.proto</summary>
  public static partial class WorldPlayerInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WorldPlayerInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WorldPlayerInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtXb3JsZFBsYXllckluZm9Ob3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "Fk9ubGluZVBsYXllckluZm8ucHJvdG8aFlBsYXllcldpZGdldEluZm8ucHJv",
            "dG8irQEKFVdvcmxkUGxheWVySW5mb05vdGlmeRI5ChBwbGF5ZXJfaW5mb19s",
            "aXN0GA8gAygLMh8ubWlIb21vLlByb3Rvcy5PbmxpbmVQbGF5ZXJJbmZvEhcK",
            "D3BsYXllcl91aWRfbGlzdBgMIAMoDRJAChdwbGF5ZXJfd2lkZ2V0X2luZm9f",
            "bGlzdBgHIAMoCzIfLm1pSG9tby5Qcm90b3MuUGxheWVyV2lkZ2V0SW5mb2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.OnlinePlayerInfoReflection.Descriptor, global::MiHomo.Protos.PlayerWidgetInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WorldPlayerInfoNotify), global::MiHomo.Protos.WorldPlayerInfoNotify.Parser, new[]{ "PlayerInfoList", "PlayerUidList", "PlayerWidgetInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WorldPlayerInfoNotify : pb::IMessage<WorldPlayerInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WorldPlayerInfoNotify> _parser = new pb::MessageParser<WorldPlayerInfoNotify>(() => new WorldPlayerInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WorldPlayerInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WorldPlayerInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldPlayerInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldPlayerInfoNotify(WorldPlayerInfoNotify other) : this() {
      playerInfoList_ = other.playerInfoList_.Clone();
      playerUidList_ = other.playerUidList_.Clone();
      playerWidgetInfoList_ = other.playerWidgetInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WorldPlayerInfoNotify Clone() {
      return new WorldPlayerInfoNotify(this);
    }

    /// <summary>Field number for the "player_info_list" field.</summary>
    public const int PlayerInfoListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.OnlinePlayerInfo> _repeated_playerInfoList_codec
        = pb::FieldCodec.ForMessage(122, global::MiHomo.Protos.OnlinePlayerInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.OnlinePlayerInfo> playerInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.OnlinePlayerInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.OnlinePlayerInfo> PlayerInfoList {
      get { return playerInfoList_; }
    }

    /// <summary>Field number for the "player_uid_list" field.</summary>
    public const int PlayerUidListFieldNumber = 12;
    private static readonly pb::FieldCodec<uint> _repeated_playerUidList_codec
        = pb::FieldCodec.ForUInt32(98);
    private readonly pbc::RepeatedField<uint> playerUidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> PlayerUidList {
      get { return playerUidList_; }
    }

    /// <summary>Field number for the "player_widget_info_list" field.</summary>
    public const int PlayerWidgetInfoListFieldNumber = 7;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.PlayerWidgetInfo> _repeated_playerWidgetInfoList_codec
        = pb::FieldCodec.ForMessage(58, global::MiHomo.Protos.PlayerWidgetInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.PlayerWidgetInfo> playerWidgetInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.PlayerWidgetInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.PlayerWidgetInfo> PlayerWidgetInfoList {
      get { return playerWidgetInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WorldPlayerInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WorldPlayerInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!playerInfoList_.Equals(other.playerInfoList_)) return false;
      if(!playerUidList_.Equals(other.playerUidList_)) return false;
      if(!playerWidgetInfoList_.Equals(other.playerWidgetInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= playerInfoList_.GetHashCode();
      hash ^= playerUidList_.GetHashCode();
      hash ^= playerWidgetInfoList_.GetHashCode();
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
      playerWidgetInfoList_.WriteTo(output, _repeated_playerWidgetInfoList_codec);
      playerUidList_.WriteTo(output, _repeated_playerUidList_codec);
      playerInfoList_.WriteTo(output, _repeated_playerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      playerWidgetInfoList_.WriteTo(ref output, _repeated_playerWidgetInfoList_codec);
      playerUidList_.WriteTo(ref output, _repeated_playerUidList_codec);
      playerInfoList_.WriteTo(ref output, _repeated_playerInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += playerInfoList_.CalculateSize(_repeated_playerInfoList_codec);
      size += playerUidList_.CalculateSize(_repeated_playerUidList_codec);
      size += playerWidgetInfoList_.CalculateSize(_repeated_playerWidgetInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WorldPlayerInfoNotify other) {
      if (other == null) {
        return;
      }
      playerInfoList_.Add(other.playerInfoList_);
      playerUidList_.Add(other.playerUidList_);
      playerWidgetInfoList_.Add(other.playerWidgetInfoList_);
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
          case 58: {
            playerWidgetInfoList_.AddEntriesFrom(input, _repeated_playerWidgetInfoList_codec);
            break;
          }
          case 98:
          case 96: {
            playerUidList_.AddEntriesFrom(input, _repeated_playerUidList_codec);
            break;
          }
          case 122: {
            playerInfoList_.AddEntriesFrom(input, _repeated_playerInfoList_codec);
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
          case 58: {
            playerWidgetInfoList_.AddEntriesFrom(ref input, _repeated_playerWidgetInfoList_codec);
            break;
          }
          case 98:
          case 96: {
            playerUidList_.AddEntriesFrom(ref input, _repeated_playerUidList_codec);
            break;
          }
          case 122: {
            playerInfoList_.AddEntriesFrom(ref input, _repeated_playerInfoList_codec);
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
