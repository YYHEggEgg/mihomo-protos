// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetPlayerFriendListRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GetPlayerFriendListRsp.proto</summary>
  public static partial class GetPlayerFriendListRspReflection {

    #region Descriptor
    /// <summary>File descriptor for GetPlayerFriendListRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPlayerFriendListRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxHZXRQbGF5ZXJGcmllbmRMaXN0UnNwLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "GhFGcmllbmRCcmllZi5wcm90byLzAQoWR2V0UGxheWVyRnJpZW5kTGlzdFJz",
            "cBIzCg9hc2tfZnJpZW5kX2xpc3QYCCADKAsyGi5taUhvbW8uUHJvdG9zLkZy",
            "aWVuZEJyaWVmEi8KC2ZyaWVuZF9saXN0GA4gAygLMhoubWlIb21vLlByb3Rv",
            "cy5GcmllbmRCcmllZhIPCgdyZXRjb2RlGAkgASgFImIKBUNtZElkEggKBE5P",
            "TkUQABITCg9FTkVUX0NIQU5ORUxfSUQQABIUChBFTkVUX0lTX1JFTElBQkxF",
            "EAESEwoPSVNfQUxMT1dfQ0xJRU5UEAESCwoGQ01EX0lEEIIgGgIQAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FriendBriefReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GetPlayerFriendListRsp), global::MiHomo.Protos.GetPlayerFriendListRsp.Parser, new[]{ "AskFriendList", "FriendList", "Retcode" }, null, new[]{ typeof(global::MiHomo.Protos.GetPlayerFriendListRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetPlayerFriendListRsp : pb::IMessage<GetPlayerFriendListRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetPlayerFriendListRsp> _parser = new pb::MessageParser<GetPlayerFriendListRsp>(() => new GetPlayerFriendListRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetPlayerFriendListRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GetPlayerFriendListRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlayerFriendListRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlayerFriendListRsp(GetPlayerFriendListRsp other) : this() {
      askFriendList_ = other.askFriendList_.Clone();
      friendList_ = other.friendList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetPlayerFriendListRsp Clone() {
      return new GetPlayerFriendListRsp(this);
    }

    /// <summary>Field number for the "ask_friend_list" field.</summary>
    public const int AskFriendListFieldNumber = 8;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FriendBrief> _repeated_askFriendList_codec
        = pb::FieldCodec.ForMessage(66, global::MiHomo.Protos.FriendBrief.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FriendBrief> askFriendList_ = new pbc::RepeatedField<global::MiHomo.Protos.FriendBrief>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FriendBrief> AskFriendList {
      get { return askFriendList_; }
    }

    /// <summary>Field number for the "friend_list" field.</summary>
    public const int FriendListFieldNumber = 14;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.FriendBrief> _repeated_friendList_codec
        = pb::FieldCodec.ForMessage(114, global::MiHomo.Protos.FriendBrief.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.FriendBrief> friendList_ = new pbc::RepeatedField<global::MiHomo.Protos.FriendBrief>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.FriendBrief> FriendList {
      get { return friendList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 9;
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
      return Equals(other as GetPlayerFriendListRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetPlayerFriendListRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!askFriendList_.Equals(other.askFriendList_)) return false;
      if(!friendList_.Equals(other.friendList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= askFriendList_.GetHashCode();
      hash ^= friendList_.GetHashCode();
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
      askFriendList_.WriteTo(output, _repeated_askFriendList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      friendList_.WriteTo(output, _repeated_friendList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      askFriendList_.WriteTo(ref output, _repeated_askFriendList_codec);
      if (Retcode != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Retcode);
      }
      friendList_.WriteTo(ref output, _repeated_friendList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += askFriendList_.CalculateSize(_repeated_askFriendList_codec);
      size += friendList_.CalculateSize(_repeated_friendList_codec);
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
    public void MergeFrom(GetPlayerFriendListRsp other) {
      if (other == null) {
        return;
      }
      askFriendList_.Add(other.askFriendList_);
      friendList_.Add(other.friendList_);
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
          case 66: {
            askFriendList_.AddEntriesFrom(input, _repeated_askFriendList_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            friendList_.AddEntriesFrom(input, _repeated_friendList_codec);
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
          case 66: {
            askFriendList_.AddEntriesFrom(ref input, _repeated_askFriendList_codec);
            break;
          }
          case 72: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            friendList_.AddEntriesFrom(ref input, _repeated_friendList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GetPlayerFriendListRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4098,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
