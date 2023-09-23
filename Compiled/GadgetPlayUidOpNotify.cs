// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetPlayUidOpNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GadgetPlayUidOpNotify.proto</summary>
  public static partial class GadgetPlayUidOpNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetPlayUidOpNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetPlayUidOpNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtHYWRnZXRQbGF5VWlkT3BOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3Mi",
            "0QEKFUdhZGdldFBsYXlVaWRPcE5vdGlmeRIRCgllbnRpdHlfaWQYCyABKA0S",
            "CgoCb3AYByABKA0SEgoKcGFyYW1fbGlzdBgEIAMoDRIRCglwYXJhbV9zdHIY",
            "ASABKAkSEQoJcGxheV90eXBlGAYgASgNEhAKCHVpZF9saXN0GAIgAygNIk0K",
            "BUNtZElkEggKBE5PTkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVU",
            "X0lTX1JFTElBQkxFEAESCwoGQ01EX0lEEOsGGgIQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GadgetPlayUidOpNotify), global::MiHomo.Protos.GadgetPlayUidOpNotify.Parser, new[]{ "EntityId", "Op", "ParamList", "ParamStr", "PlayType", "UidList" }, null, new[]{ typeof(global::MiHomo.Protos.GadgetPlayUidOpNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GadgetPlayUidOpNotify : pb::IMessage<GadgetPlayUidOpNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GadgetPlayUidOpNotify> _parser = new pb::MessageParser<GadgetPlayUidOpNotify>(() => new GadgetPlayUidOpNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GadgetPlayUidOpNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GadgetPlayUidOpNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetPlayUidOpNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetPlayUidOpNotify(GadgetPlayUidOpNotify other) : this() {
      entityId_ = other.entityId_;
      op_ = other.op_;
      paramList_ = other.paramList_.Clone();
      paramStr_ = other.paramStr_;
      playType_ = other.playType_;
      uidList_ = other.uidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GadgetPlayUidOpNotify Clone() {
      return new GadgetPlayUidOpNotify(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 11;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 7;
    private uint op_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Op {
      get { return op_; }
      set {
        op_ = value;
      }
    }

    /// <summary>Field number for the "param_list" field.</summary>
    public const int ParamListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_paramList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> paramList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ParamList {
      get { return paramList_; }
    }

    /// <summary>Field number for the "param_str" field.</summary>
    public const int ParamStrFieldNumber = 1;
    private string paramStr_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ParamStr {
      get { return paramStr_; }
      set {
        paramStr_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "play_type" field.</summary>
    public const int PlayTypeFieldNumber = 6;
    private uint playType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayType {
      get { return playType_; }
      set {
        playType_ = value;
      }
    }

    /// <summary>Field number for the "uid_list" field.</summary>
    public const int UidListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_uidList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> uidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UidList {
      get { return uidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GadgetPlayUidOpNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GadgetPlayUidOpNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (Op != other.Op) return false;
      if(!paramList_.Equals(other.paramList_)) return false;
      if (ParamStr != other.ParamStr) return false;
      if (PlayType != other.PlayType) return false;
      if(!uidList_.Equals(other.uidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (Op != 0) hash ^= Op.GetHashCode();
      hash ^= paramList_.GetHashCode();
      if (ParamStr.Length != 0) hash ^= ParamStr.GetHashCode();
      if (PlayType != 0) hash ^= PlayType.GetHashCode();
      hash ^= uidList_.GetHashCode();
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
      if (ParamStr.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ParamStr);
      }
      uidList_.WriteTo(output, _repeated_uidList_codec);
      paramList_.WriteTo(output, _repeated_paramList_codec);
      if (PlayType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlayType);
      }
      if (Op != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Op);
      }
      if (EntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EntityId);
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
      if (ParamStr.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ParamStr);
      }
      uidList_.WriteTo(ref output, _repeated_uidList_codec);
      paramList_.WriteTo(ref output, _repeated_paramList_codec);
      if (PlayType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(PlayType);
      }
      if (Op != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Op);
      }
      if (EntityId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EntityId);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (Op != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Op);
      }
      size += paramList_.CalculateSize(_repeated_paramList_codec);
      if (ParamStr.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParamStr);
      }
      if (PlayType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayType);
      }
      size += uidList_.CalculateSize(_repeated_uidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GadgetPlayUidOpNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.Op != 0) {
        Op = other.Op;
      }
      paramList_.Add(other.paramList_);
      if (other.ParamStr.Length != 0) {
        ParamStr = other.ParamStr;
      }
      if (other.PlayType != 0) {
        PlayType = other.PlayType;
      }
      uidList_.Add(other.uidList_);
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
            ParamStr = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            uidList_.AddEntriesFrom(input, _repeated_uidList_codec);
            break;
          }
          case 34:
          case 32: {
            paramList_.AddEntriesFrom(input, _repeated_paramList_codec);
            break;
          }
          case 48: {
            PlayType = input.ReadUInt32();
            break;
          }
          case 56: {
            Op = input.ReadUInt32();
            break;
          }
          case 88: {
            EntityId = input.ReadUInt32();
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
            ParamStr = input.ReadString();
            break;
          }
          case 18:
          case 16: {
            uidList_.AddEntriesFrom(ref input, _repeated_uidList_codec);
            break;
          }
          case 34:
          case 32: {
            paramList_.AddEntriesFrom(ref input, _repeated_paramList_codec);
            break;
          }
          case 48: {
            PlayType = input.ReadUInt32();
            break;
          }
          case 56: {
            Op = input.ReadUInt32();
            break;
          }
          case 88: {
            EntityId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GadgetPlayUidOpNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 875,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
