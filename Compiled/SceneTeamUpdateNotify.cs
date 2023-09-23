// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneTeamUpdateNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SceneTeamUpdateNotify.proto</summary>
  public static partial class SceneTeamUpdateNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneTeamUpdateNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneTeamUpdateNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtTY2VuZVRlYW1VcGRhdGVOb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "FVNjZW5lVGVhbUF2YXRhci5wcm90byK4AQoVU2NlbmVUZWFtVXBkYXRlTm90",
            "aWZ5EhAKCGlzX2luX21wGA8gASgIEj4KFnNjZW5lX3RlYW1fYXZhdGFyX2xp",
            "c3QYCyADKAsyHi5taUhvbW8uUHJvdG9zLlNjZW5lVGVhbUF2YXRhciJNCgVD",
            "bWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9J",
            "U19SRUxJQUJMRRABEgsKBkNNRF9JRBDvDRoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.SceneTeamAvatarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SceneTeamUpdateNotify), global::MiHomo.Protos.SceneTeamUpdateNotify.Parser, new[]{ "IsInMp", "SceneTeamAvatarList" }, null, new[]{ typeof(global::MiHomo.Protos.SceneTeamUpdateNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneTeamUpdateNotify : pb::IMessage<SceneTeamUpdateNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneTeamUpdateNotify> _parser = new pb::MessageParser<SceneTeamUpdateNotify>(() => new SceneTeamUpdateNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneTeamUpdateNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SceneTeamUpdateNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneTeamUpdateNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneTeamUpdateNotify(SceneTeamUpdateNotify other) : this() {
      isInMp_ = other.isInMp_;
      sceneTeamAvatarList_ = other.sceneTeamAvatarList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneTeamUpdateNotify Clone() {
      return new SceneTeamUpdateNotify(this);
    }

    /// <summary>Field number for the "is_in_mp" field.</summary>
    public const int IsInMpFieldNumber = 15;
    private bool isInMp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInMp {
      get { return isInMp_; }
      set {
        isInMp_ = value;
      }
    }

    /// <summary>Field number for the "scene_team_avatar_list" field.</summary>
    public const int SceneTeamAvatarListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.SceneTeamAvatar> _repeated_sceneTeamAvatarList_codec
        = pb::FieldCodec.ForMessage(90, global::MiHomo.Protos.SceneTeamAvatar.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.SceneTeamAvatar> sceneTeamAvatarList_ = new pbc::RepeatedField<global::MiHomo.Protos.SceneTeamAvatar>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.SceneTeamAvatar> SceneTeamAvatarList {
      get { return sceneTeamAvatarList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneTeamUpdateNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneTeamUpdateNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsInMp != other.IsInMp) return false;
      if(!sceneTeamAvatarList_.Equals(other.sceneTeamAvatarList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsInMp != false) hash ^= IsInMp.GetHashCode();
      hash ^= sceneTeamAvatarList_.GetHashCode();
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
      sceneTeamAvatarList_.WriteTo(output, _repeated_sceneTeamAvatarList_codec);
      if (IsInMp != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsInMp);
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
      sceneTeamAvatarList_.WriteTo(ref output, _repeated_sceneTeamAvatarList_codec);
      if (IsInMp != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsInMp);
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
      if (IsInMp != false) {
        size += 1 + 1;
      }
      size += sceneTeamAvatarList_.CalculateSize(_repeated_sceneTeamAvatarList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneTeamUpdateNotify other) {
      if (other == null) {
        return;
      }
      if (other.IsInMp != false) {
        IsInMp = other.IsInMp;
      }
      sceneTeamAvatarList_.Add(other.sceneTeamAvatarList_);
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
          case 90: {
            sceneTeamAvatarList_.AddEntriesFrom(input, _repeated_sceneTeamAvatarList_codec);
            break;
          }
          case 120: {
            IsInMp = input.ReadBool();
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
          case 90: {
            sceneTeamAvatarList_.AddEntriesFrom(ref input, _repeated_sceneTeamAvatarList_codec);
            break;
          }
          case 120: {
            IsInMp = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SceneTeamUpdateNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 1775,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
