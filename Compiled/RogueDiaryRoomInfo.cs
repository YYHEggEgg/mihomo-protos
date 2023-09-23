// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryRoomInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RogueDiaryRoomInfo.proto</summary>
  public static partial class RogueDiaryRoomInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryRoomInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryRoomInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhSb2d1ZURpYXJ5Um9vbUluZm8ucHJvdG8SDW1pSG9tby5Qcm90b3MaEFVp",
            "bnQzMlBhaXIucHJvdG8iaQoSUm9ndWVEaWFyeVJvb21JbmZvEhEKCWNvbmZp",
            "Z19pZBgDIAEoDRIPCgdpc19ib3NzGAYgASgIEi8KDG1vbnN0ZXJfbGlzdBgE",
            "IAMoCzIZLm1pSG9tby5Qcm90b3MuVWludDMyUGFpcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.Uint32PairReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RogueDiaryRoomInfo), global::MiHomo.Protos.RogueDiaryRoomInfo.Parser, new[]{ "ConfigId", "IsBoss", "MonsterList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RogueDiaryRoomInfo : pb::IMessage<RogueDiaryRoomInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RogueDiaryRoomInfo> _parser = new pb::MessageParser<RogueDiaryRoomInfo>(() => new RogueDiaryRoomInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RogueDiaryRoomInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RogueDiaryRoomInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryRoomInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryRoomInfo(RogueDiaryRoomInfo other) : this() {
      configId_ = other.configId_;
      isBoss_ = other.isBoss_;
      monsterList_ = other.monsterList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RogueDiaryRoomInfo Clone() {
      return new RogueDiaryRoomInfo(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 3;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "is_boss" field.</summary>
    public const int IsBossFieldNumber = 6;
    private bool isBoss_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBoss {
      get { return isBoss_; }
      set {
        isBoss_ = value;
      }
    }

    /// <summary>Field number for the "monster_list" field.</summary>
    public const int MonsterListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.Uint32Pair> _repeated_monsterList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.Uint32Pair.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair> monsterList_ = new pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.Uint32Pair> MonsterList {
      get { return monsterList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RogueDiaryRoomInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RogueDiaryRoomInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (IsBoss != other.IsBoss) return false;
      if(!monsterList_.Equals(other.monsterList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (IsBoss != false) hash ^= IsBoss.GetHashCode();
      hash ^= monsterList_.GetHashCode();
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
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      monsterList_.WriteTo(output, _repeated_monsterList_codec);
      if (IsBoss != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsBoss);
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
      if (ConfigId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ConfigId);
      }
      monsterList_.WriteTo(ref output, _repeated_monsterList_codec);
      if (IsBoss != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsBoss);
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
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (IsBoss != false) {
        size += 1 + 1;
      }
      size += monsterList_.CalculateSize(_repeated_monsterList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RogueDiaryRoomInfo other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.IsBoss != false) {
        IsBoss = other.IsBoss;
      }
      monsterList_.Add(other.monsterList_);
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
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 34: {
            monsterList_.AddEntriesFrom(input, _repeated_monsterList_codec);
            break;
          }
          case 48: {
            IsBoss = input.ReadBool();
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
          case 24: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 34: {
            monsterList_.AddEntriesFrom(ref input, _repeated_monsterList_codec);
            break;
          }
          case 48: {
            IsBoss = input.ReadBool();
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
