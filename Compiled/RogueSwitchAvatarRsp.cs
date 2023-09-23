// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueSwitchAvatarRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RogueSwitchAvatarRsp.proto</summary>
  public static partial class RogueSwitchAvatarRspReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueSwitchAvatarRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueSwitchAvatarRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpSb2d1ZVN3aXRjaEF2YXRhclJzcC5wcm90bxINbWlIb21vLlByb3RvcyKr",
            "AQoUUm9ndWVTd2l0Y2hBdmF0YXJSc3ASIgoaYmFja3N0YWdlX2F2YXRhcl9n",
            "dWlkX2xpc3QYAyADKAQSDwoHY2VsbF9pZBgBIAEoDRIXCg9jdXJfYXZhdGFy",
            "X2d1aWQYBSABKAQSEgoKZHVuZ2Vvbl9pZBgPIAEoDRIgChhvbnN0YWdlX2F2",
            "YXRhcl9ndWlkX2xpc3QYCCADKAQSDwoHcmV0Y29kZRgHIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RogueSwitchAvatarRsp), global::MiHomo.Protos.RogueSwitchAvatarRsp.Parser, new[]{ "BackstageAvatarGuidList", "CellId", "CurAvatarGuid", "DungeonId", "OnstageAvatarGuidList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueSwitchAvatarRsp : pb::IMessage<RogueSwitchAvatarRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueSwitchAvatarRsp> _parser = new pb::MessageParser<RogueSwitchAvatarRsp>(() => new RogueSwitchAvatarRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueSwitchAvatarRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RogueSwitchAvatarRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSwitchAvatarRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSwitchAvatarRsp(RogueSwitchAvatarRsp other) : this() {
      backstageAvatarGuidList_ = other.backstageAvatarGuidList_.Clone();
      cellId_ = other.cellId_;
      curAvatarGuid_ = other.curAvatarGuid_;
      dungeonId_ = other.dungeonId_;
      onstageAvatarGuidList_ = other.onstageAvatarGuidList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueSwitchAvatarRsp Clone() {
      return new RogueSwitchAvatarRsp(this);
    }

    /// <summary>Field number for the "backstage_avatar_guid_list" field.</summary>
    public const int BackstageAvatarGuidListFieldNumber = 3;
    private static readonly pb::FieldCodec<ulong> _repeated_backstageAvatarGuidList_codec
        = pb::FieldCodec.ForUInt64(26);
    private readonly pbc::RepeatedField<ulong> backstageAvatarGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> BackstageAvatarGuidList {
      get { return backstageAvatarGuidList_; }
    }

    /// <summary>Field number for the "cell_id" field.</summary>
    public const int CellIdFieldNumber = 1;
    private uint cellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellId {
      get { return cellId_; }
      set {
        cellId_ = value;
      }
    }

    /// <summary>Field number for the "cur_avatar_guid" field.</summary>
    public const int CurAvatarGuidFieldNumber = 5;
    private ulong curAvatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CurAvatarGuid {
      get { return curAvatarGuid_; }
      set {
        curAvatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 15;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "onstage_avatar_guid_list" field.</summary>
    public const int OnstageAvatarGuidListFieldNumber = 8;
    private static readonly pb::FieldCodec<ulong> _repeated_onstageAvatarGuidList_codec
        = pb::FieldCodec.ForUInt64(66);
    private readonly pbc::RepeatedField<ulong> onstageAvatarGuidList_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<ulong> OnstageAvatarGuidList {
      get { return onstageAvatarGuidList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 7;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueSwitchAvatarRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueSwitchAvatarRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!backstageAvatarGuidList_.Equals(other.backstageAvatarGuidList_)) return false;
      if (CellId != other.CellId) return false;
      if (CurAvatarGuid != other.CurAvatarGuid) return false;
      if (DungeonId != other.DungeonId) return false;
      if(!onstageAvatarGuidList_.Equals(other.onstageAvatarGuidList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= backstageAvatarGuidList_.GetHashCode();
      if (CellId != 0) hash ^= CellId.GetHashCode();
      if (CurAvatarGuid != 0UL) hash ^= CurAvatarGuid.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      hash ^= onstageAvatarGuidList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (CellId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CellId);
      }
      backstageAvatarGuidList_.WriteTo(output, _repeated_backstageAvatarGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(CurAvatarGuid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      onstageAvatarGuidList_.WriteTo(output, _repeated_onstageAvatarGuidList_codec);
      if (DungeonId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DungeonId);
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
      if (CellId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CellId);
      }
      backstageAvatarGuidList_.WriteTo(ref output, _repeated_backstageAvatarGuidList_codec);
      if (CurAvatarGuid != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(CurAvatarGuid);
      }
      if (Retcode != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Retcode);
      }
      onstageAvatarGuidList_.WriteTo(ref output, _repeated_onstageAvatarGuidList_codec);
      if (DungeonId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(DungeonId);
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
      size += backstageAvatarGuidList_.CalculateSize(_repeated_backstageAvatarGuidList_codec);
      if (CellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellId);
      }
      if (CurAvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CurAvatarGuid);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      size += onstageAvatarGuidList_.CalculateSize(_repeated_onstageAvatarGuidList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueSwitchAvatarRsp other) {
      if (other == null) {
        return;
      }
      backstageAvatarGuidList_.Add(other.backstageAvatarGuidList_);
      if (other.CellId != 0) {
        CellId = other.CellId;
      }
      if (other.CurAvatarGuid != 0UL) {
        CurAvatarGuid = other.CurAvatarGuid;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      onstageAvatarGuidList_.Add(other.onstageAvatarGuidList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
            CellId = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            backstageAvatarGuidList_.AddEntriesFrom(input, _repeated_backstageAvatarGuidList_codec);
            break;
          }
          case 40: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 66:
          case 64: {
            onstageAvatarGuidList_.AddEntriesFrom(input, _repeated_onstageAvatarGuidList_codec);
            break;
          }
          case 120: {
            DungeonId = input.ReadUInt32();
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
            CellId = input.ReadUInt32();
            break;
          }
          case 26:
          case 24: {
            backstageAvatarGuidList_.AddEntriesFrom(ref input, _repeated_backstageAvatarGuidList_codec);
            break;
          }
          case 40: {
            CurAvatarGuid = input.ReadUInt64();
            break;
          }
          case 56: {
            Retcode = input.ReadInt32();
            break;
          }
          case 66:
          case 64: {
            onstageAvatarGuidList_.AddEntriesFrom(ref input, _repeated_onstageAvatarGuidList_codec);
            break;
          }
          case 120: {
            DungeonId = input.ReadUInt32();
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
