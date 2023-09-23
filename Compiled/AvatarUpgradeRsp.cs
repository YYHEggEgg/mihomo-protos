// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AvatarUpgradeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AvatarUpgradeRsp.proto</summary>
  public static partial class AvatarUpgradeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for AvatarUpgradeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AvatarUpgradeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZBdmF0YXJVcGdyYWRlUnNwLnByb3RvEg1taUhvbW8uUHJvdG9zIvICChBB",
            "dmF0YXJVcGdyYWRlUnNwEhMKC2F2YXRhcl9ndWlkGA4gASgEEhEKCWN1cl9s",
            "ZXZlbBgJIAEoDRIRCglvbGRfbGV2ZWwYDCABKA0SDwoHcmV0Y29kZRgIIAEo",
            "BRJQChJjdXJfZmlnaHRfcHJvcF9tYXAYDSADKAsyNC5taUhvbW8uUHJvdG9z",
            "LkF2YXRhclVwZ3JhZGVSc3AuQ3VyRmlnaHRQcm9wTWFwRW50cnkSUAoSb2xk",
            "X2ZpZ2h0X3Byb3BfbWFwGAYgAygLMjQubWlIb21vLlByb3Rvcy5BdmF0YXJV",
            "cGdyYWRlUnNwLk9sZEZpZ2h0UHJvcE1hcEVudHJ5GjYKFEN1ckZpZ2h0UHJv",
            "cE1hcEVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoAjoCOAEaNgoU",
            "T2xkRmlnaHRQcm9wTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg",
            "ASgCOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AvatarUpgradeRsp), global::MiHomo.Protos.AvatarUpgradeRsp.Parser, new[]{ "AvatarGuid", "CurLevel", "OldLevel", "Retcode", "CurFightPropMap", "OldFightPropMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AvatarUpgradeRsp : pb::IMessage<AvatarUpgradeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AvatarUpgradeRsp> _parser = new pb::MessageParser<AvatarUpgradeRsp>(() => new AvatarUpgradeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AvatarUpgradeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AvatarUpgradeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp(AvatarUpgradeRsp other) : this() {
      avatarGuid_ = other.avatarGuid_;
      curLevel_ = other.curLevel_;
      oldLevel_ = other.oldLevel_;
      retcode_ = other.retcode_;
      curFightPropMap_ = other.curFightPropMap_.Clone();
      oldFightPropMap_ = other.oldFightPropMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AvatarUpgradeRsp Clone() {
      return new AvatarUpgradeRsp(this);
    }

    /// <summary>Field number for the "avatar_guid" field.</summary>
    public const int AvatarGuidFieldNumber = 14;
    private ulong avatarGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AvatarGuid {
      get { return avatarGuid_; }
      set {
        avatarGuid_ = value;
      }
    }

    /// <summary>Field number for the "cur_level" field.</summary>
    public const int CurLevelFieldNumber = 9;
    private uint curLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurLevel {
      get { return curLevel_; }
      set {
        curLevel_ = value;
      }
    }

    /// <summary>Field number for the "old_level" field.</summary>
    public const int OldLevelFieldNumber = 12;
    private uint oldLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OldLevel {
      get { return oldLevel_; }
      set {
        oldLevel_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 8;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "cur_fight_prop_map" field.</summary>
    public const int CurFightPropMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, float>.Codec _map_curFightPropMap_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 106);
    private readonly pbc::MapField<uint, float> curFightPropMap_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> CurFightPropMap {
      get { return curFightPropMap_; }
    }

    /// <summary>Field number for the "old_fight_prop_map" field.</summary>
    public const int OldFightPropMapFieldNumber = 6;
    private static readonly pbc::MapField<uint, float>.Codec _map_oldFightPropMap_codec
        = new pbc::MapField<uint, float>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForFloat(21, 0F), 50);
    private readonly pbc::MapField<uint, float> oldFightPropMap_ = new pbc::MapField<uint, float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, float> OldFightPropMap {
      get { return oldFightPropMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AvatarUpgradeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AvatarUpgradeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvatarGuid != other.AvatarGuid) return false;
      if (CurLevel != other.CurLevel) return false;
      if (OldLevel != other.OldLevel) return false;
      if (Retcode != other.Retcode) return false;
      if (!CurFightPropMap.Equals(other.CurFightPropMap)) return false;
      if (!OldFightPropMap.Equals(other.OldFightPropMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AvatarGuid != 0UL) hash ^= AvatarGuid.GetHashCode();
      if (CurLevel != 0) hash ^= CurLevel.GetHashCode();
      if (OldLevel != 0) hash ^= OldLevel.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= CurFightPropMap.GetHashCode();
      hash ^= OldFightPropMap.GetHashCode();
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
      oldFightPropMap_.WriteTo(output, _map_oldFightPropMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurLevel);
      }
      if (OldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OldLevel);
      }
      curFightPropMap_.WriteTo(output, _map_curFightPropMap_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(AvatarGuid);
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
      oldFightPropMap_.WriteTo(ref output, _map_oldFightPropMap_codec);
      if (Retcode != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Retcode);
      }
      if (CurLevel != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(CurLevel);
      }
      if (OldLevel != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(OldLevel);
      }
      curFightPropMap_.WriteTo(ref output, _map_curFightPropMap_codec);
      if (AvatarGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(AvatarGuid);
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
      if (AvatarGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AvatarGuid);
      }
      if (CurLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurLevel);
      }
      if (OldLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OldLevel);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += curFightPropMap_.CalculateSize(_map_curFightPropMap_codec);
      size += oldFightPropMap_.CalculateSize(_map_oldFightPropMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AvatarUpgradeRsp other) {
      if (other == null) {
        return;
      }
      if (other.AvatarGuid != 0UL) {
        AvatarGuid = other.AvatarGuid;
      }
      if (other.CurLevel != 0) {
        CurLevel = other.CurLevel;
      }
      if (other.OldLevel != 0) {
        OldLevel = other.OldLevel;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      curFightPropMap_.Add(other.curFightPropMap_);
      oldFightPropMap_.Add(other.oldFightPropMap_);
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
          case 50: {
            oldFightPropMap_.AddEntriesFrom(input, _map_oldFightPropMap_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 106: {
            curFightPropMap_.AddEntriesFrom(input, _map_curFightPropMap_codec);
            break;
          }
          case 112: {
            AvatarGuid = input.ReadUInt64();
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
          case 50: {
            oldFightPropMap_.AddEntriesFrom(ref input, _map_oldFightPropMap_codec);
            break;
          }
          case 64: {
            Retcode = input.ReadInt32();
            break;
          }
          case 72: {
            CurLevel = input.ReadUInt32();
            break;
          }
          case 96: {
            OldLevel = input.ReadUInt32();
            break;
          }
          case 106: {
            curFightPropMap_.AddEntriesFrom(ref input, _map_curFightPropMap_codec);
            break;
          }
          case 112: {
            AvatarGuid = input.ReadUInt64();
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
