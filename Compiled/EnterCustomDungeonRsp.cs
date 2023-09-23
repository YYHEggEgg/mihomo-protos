// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterCustomDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EnterCustomDungeonRsp.proto</summary>
  public static partial class EnterCustomDungeonRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterCustomDungeonRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterCustomDungeonRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtFbnRlckN1c3RvbUR1bmdlb25Sc3AucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "E0N1c3RvbUR1bmdlb24ucHJvdG8aHEVudGVyQ3VzdG9tRHVuZ2VvblR5cGUu",
            "cHJvdG8i6gIKFUVudGVyQ3VzdG9tRHVuZ2VvblJzcBI0Cg5jdXN0b21fZHVu",
            "Z2VvbhgOIAEoCzIcLm1pSG9tby5Qcm90b3MuQ3VzdG9tRHVuZ2VvbhI5Cgpl",
            "bnRlcl90eXBlGAIgASgOMiUubWlIb21vLlByb3Rvcy5FbnRlckN1c3RvbUR1",
            "bmdlb25UeXBlEg8KB3JldGNvZGUYCiABKAUSTAoNcm9vbV9jb3N0X21hcBgG",
            "IAMoCzI1Lm1pSG9tby5Qcm90b3MuRW50ZXJDdXN0b21EdW5nZW9uUnNwLlJv",
            "b21Db3N0TWFwRW50cnkaMgoQUm9vbUNvc3RNYXBFbnRyeRILCgNrZXkYASAB",
            "KA0SDQoFdmFsdWUYAiABKA06AjgBIk0KBUNtZElkEggKBE5PTkUQABITCg9F",
            "TkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxFEAESCwoGQ01E",
            "X0lEEMowGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CustomDungeonReflection.Descriptor, global::MiHomo.Protos.EnterCustomDungeonTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EnterCustomDungeonRsp), global::MiHomo.Protos.EnterCustomDungeonRsp.Parser, new[]{ "CustomDungeon", "EnterType", "Retcode", "RoomCostMap" }, null, new[]{ typeof(global::MiHomo.Protos.EnterCustomDungeonRsp.Types.CmdId) }, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EnterCustomDungeonRsp : pb::IMessage<EnterCustomDungeonRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterCustomDungeonRsp> _parser = new pb::MessageParser<EnterCustomDungeonRsp>(() => new EnterCustomDungeonRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterCustomDungeonRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EnterCustomDungeonRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterCustomDungeonRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterCustomDungeonRsp(EnterCustomDungeonRsp other) : this() {
      customDungeon_ = other.customDungeon_ != null ? other.customDungeon_.Clone() : null;
      enterType_ = other.enterType_;
      retcode_ = other.retcode_;
      roomCostMap_ = other.roomCostMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterCustomDungeonRsp Clone() {
      return new EnterCustomDungeonRsp(this);
    }

    /// <summary>Field number for the "custom_dungeon" field.</summary>
    public const int CustomDungeonFieldNumber = 14;
    private global::MiHomo.Protos.CustomDungeon customDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomDungeon CustomDungeon {
      get { return customDungeon_; }
      set {
        customDungeon_ = value;
      }
    }

    /// <summary>Field number for the "enter_type" field.</summary>
    public const int EnterTypeFieldNumber = 2;
    private global::MiHomo.Protos.EnterCustomDungeonType enterType_ = global::MiHomo.Protos.EnterCustomDungeonType.EnterCustomDungeonNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.EnterCustomDungeonType EnterType {
      get { return enterType_; }
      set {
        enterType_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "room_cost_map" field.</summary>
    public const int RoomCostMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, uint>.Codec _map_roomCostMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 50);
    private readonly pbc::MapField<uint, uint> roomCostMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> RoomCostMap {
      get { return roomCostMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterCustomDungeonRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterCustomDungeonRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(CustomDungeon, other.CustomDungeon)) return false;
      if (EnterType != other.EnterType) return false;
      if (Retcode != other.Retcode) return false;
      if (!RoomCostMap.Equals(other.RoomCostMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (customDungeon_ != null) hash ^= CustomDungeon.GetHashCode();
      if (EnterType != global::MiHomo.Protos.EnterCustomDungeonType.EnterCustomDungeonNone) hash ^= EnterType.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= RoomCostMap.GetHashCode();
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
      if (EnterType != global::MiHomo.Protos.EnterCustomDungeonType.EnterCustomDungeonNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EnterType);
      }
      roomCostMap_.WriteTo(output, _map_roomCostMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (customDungeon_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CustomDungeon);
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
      if (EnterType != global::MiHomo.Protos.EnterCustomDungeonType.EnterCustomDungeonNone) {
        output.WriteRawTag(16);
        output.WriteEnum((int) EnterType);
      }
      roomCostMap_.WriteTo(ref output, _map_roomCostMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
      }
      if (customDungeon_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(CustomDungeon);
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
      if (customDungeon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomDungeon);
      }
      if (EnterType != global::MiHomo.Protos.EnterCustomDungeonType.EnterCustomDungeonNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EnterType);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += roomCostMap_.CalculateSize(_map_roomCostMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterCustomDungeonRsp other) {
      if (other == null) {
        return;
      }
      if (other.customDungeon_ != null) {
        if (customDungeon_ == null) {
          CustomDungeon = new global::MiHomo.Protos.CustomDungeon();
        }
        CustomDungeon.MergeFrom(other.CustomDungeon);
      }
      if (other.EnterType != global::MiHomo.Protos.EnterCustomDungeonType.EnterCustomDungeonNone) {
        EnterType = other.EnterType;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      roomCostMap_.Add(other.roomCostMap_);
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
          case 16: {
            EnterType = (global::MiHomo.Protos.EnterCustomDungeonType) input.ReadEnum();
            break;
          }
          case 50: {
            roomCostMap_.AddEntriesFrom(input, _map_roomCostMap_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            if (customDungeon_ == null) {
              CustomDungeon = new global::MiHomo.Protos.CustomDungeon();
            }
            input.ReadMessage(CustomDungeon);
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
          case 16: {
            EnterType = (global::MiHomo.Protos.EnterCustomDungeonType) input.ReadEnum();
            break;
          }
          case 50: {
            roomCostMap_.AddEntriesFrom(ref input, _map_roomCostMap_codec);
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            if (customDungeon_ == null) {
              CustomDungeon = new global::MiHomo.Protos.CustomDungeon();
            }
            input.ReadMessage(CustomDungeon);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the EnterCustomDungeonRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 6218,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
