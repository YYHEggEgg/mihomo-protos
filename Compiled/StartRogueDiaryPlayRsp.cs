// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartRogueDiaryPlayRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from StartRogueDiaryPlayRsp.proto</summary>
  public static partial class StartRogueDiaryPlayRspReflection {

    #region Descriptor
    /// <summary>File descriptor for StartRogueDiaryPlayRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRogueDiaryPlayRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxTdGFydFJvZ3VlRGlhcnlQbGF5UnNwLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "GhZSb2d1ZURpYXJ5QXZhdGFyLnByb3RvIrMBChZTdGFydFJvZ3VlRGlhcnlQ",
            "bGF5UnNwEjQKC2F2YXRhcl9saXN0GA8gAygLMh8ubWlIb21vLlByb3Rvcy5S",
            "b2d1ZURpYXJ5QXZhdGFyEhYKDnJhbmRfY2FyZF9saXN0GAIgAygNEg8KB3Jl",
            "dGNvZGUYBiABKAUSOgoRdHJpYWxfYXZhdGFyX2xpc3QYCSADKAsyHy5taUhv",
            "bW8uUHJvdG9zLlJvZ3VlRGlhcnlBdmF0YXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.RogueDiaryAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.StartRogueDiaryPlayRsp), global::MiHomo.Protos.StartRogueDiaryPlayRsp.Parser, new[]{ "AvatarList", "RandCardList", "Retcode", "TrialAvatarList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StartRogueDiaryPlayRsp : pb::IMessage<StartRogueDiaryPlayRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartRogueDiaryPlayRsp> _parser = new pb::MessageParser<StartRogueDiaryPlayRsp>(() => new StartRogueDiaryPlayRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartRogueDiaryPlayRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.StartRogueDiaryPlayRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueDiaryPlayRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueDiaryPlayRsp(StartRogueDiaryPlayRsp other) : this() {
      avatarList_ = other.avatarList_.Clone();
      randCardList_ = other.randCardList_.Clone();
      retcode_ = other.retcode_;
      trialAvatarList_ = other.trialAvatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueDiaryPlayRsp Clone() {
      return new StartRogueDiaryPlayRsp(this);
    }

    /// <summary>Field number for the "avatar_list" field.</summary>
    public const int AvatarListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.RogueDiaryAvatar> _repeated_avatarList_codec
        = pb::FieldCodec.ForMessage(122, global::MiHomo.Protos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar> avatarList_ = new pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar> AvatarList {
      get { return avatarList_; }
    }

    /// <summary>Field number for the "rand_card_list" field.</summary>
    public const int RandCardListFieldNumber = 2;
    private static readonly pb::FieldCodec<uint> _repeated_randCardList_codec
        = pb::FieldCodec.ForUInt32(18);
    private readonly pbc::RepeatedField<uint> randCardList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RandCardList {
      get { return randCardList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    /// <summary>Field number for the "trial_avatar_list" field.</summary>
    public const int TrialAvatarListFieldNumber = 9;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.RogueDiaryAvatar> _repeated_trialAvatarList_codec
        = pb::FieldCodec.ForMessage(74, global::MiHomo.Protos.RogueDiaryAvatar.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar> trialAvatarList_ = new pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.RogueDiaryAvatar> TrialAvatarList {
      get { return trialAvatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartRogueDiaryPlayRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartRogueDiaryPlayRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!avatarList_.Equals(other.avatarList_)) return false;
      if(!randCardList_.Equals(other.randCardList_)) return false;
      if (Retcode != other.Retcode) return false;
      if(!trialAvatarList_.Equals(other.trialAvatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= avatarList_.GetHashCode();
      hash ^= randCardList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
      hash ^= trialAvatarList_.GetHashCode();
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
      randCardList_.WriteTo(output, _repeated_randCardList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      trialAvatarList_.WriteTo(output, _repeated_trialAvatarList_codec);
      avatarList_.WriteTo(output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      randCardList_.WriteTo(ref output, _repeated_randCardList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      trialAvatarList_.WriteTo(ref output, _repeated_trialAvatarList_codec);
      avatarList_.WriteTo(ref output, _repeated_avatarList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += avatarList_.CalculateSize(_repeated_avatarList_codec);
      size += randCardList_.CalculateSize(_repeated_randCardList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      size += trialAvatarList_.CalculateSize(_repeated_trialAvatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartRogueDiaryPlayRsp other) {
      if (other == null) {
        return;
      }
      avatarList_.Add(other.avatarList_);
      randCardList_.Add(other.randCardList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
      }
      trialAvatarList_.Add(other.trialAvatarList_);
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
          case 18:
          case 16: {
            randCardList_.AddEntriesFrom(input, _repeated_randCardList_codec);
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74: {
            trialAvatarList_.AddEntriesFrom(input, _repeated_trialAvatarList_codec);
            break;
          }
          case 122: {
            avatarList_.AddEntriesFrom(input, _repeated_avatarList_codec);
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
          case 18:
          case 16: {
            randCardList_.AddEntriesFrom(ref input, _repeated_randCardList_codec);
            break;
          }
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 74: {
            trialAvatarList_.AddEntriesFrom(ref input, _repeated_trialAvatarList_codec);
            break;
          }
          case 122: {
            avatarList_.AddEntriesFrom(ref input, _repeated_avatarList_codec);
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
