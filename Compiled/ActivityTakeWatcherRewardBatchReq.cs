// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityTakeWatcherRewardBatchReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ActivityTakeWatcherRewardBatchReq.proto</summary>
  public static partial class ActivityTakeWatcherRewardBatchReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityTakeWatcherRewardBatchReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityTakeWatcherRewardBatchReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidBY3Rpdml0eVRha2VXYXRjaGVyUmV3YXJkQmF0Y2hSZXEucHJvdG8SDW1p",
            "SG9tby5Qcm90b3MitQEKIUFjdGl2aXR5VGFrZVdhdGNoZXJSZXdhcmRCYXRj",
            "aFJlcRITCgthY3Rpdml0eV9pZBgDIAEoDRIXCg93YXRjaGVyX2lkX2xpc3QY",
            "CyADKA0iYgoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAA",
            "EhQKEEVORVRfSVNfUkVMSUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARIL",
            "CgZDTURfSUQQ7xAaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ActivityTakeWatcherRewardBatchReq), global::MiHomo.Protos.ActivityTakeWatcherRewardBatchReq.Parser, new[]{ "ActivityId", "WatcherIdList" }, null, new[]{ typeof(global::MiHomo.Protos.ActivityTakeWatcherRewardBatchReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ActivityTakeWatcherRewardBatchReq : pb::IMessage<ActivityTakeWatcherRewardBatchReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ActivityTakeWatcherRewardBatchReq> _parser = new pb::MessageParser<ActivityTakeWatcherRewardBatchReq>(() => new ActivityTakeWatcherRewardBatchReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ActivityTakeWatcherRewardBatchReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ActivityTakeWatcherRewardBatchReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityTakeWatcherRewardBatchReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityTakeWatcherRewardBatchReq(ActivityTakeWatcherRewardBatchReq other) : this() {
      activityId_ = other.activityId_;
      watcherIdList_ = other.watcherIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ActivityTakeWatcherRewardBatchReq Clone() {
      return new ActivityTakeWatcherRewardBatchReq(this);
    }

    /// <summary>Field number for the "activity_id" field.</summary>
    public const int ActivityIdFieldNumber = 3;
    private uint activityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ActivityId {
      get { return activityId_; }
      set {
        activityId_ = value;
      }
    }

    /// <summary>Field number for the "watcher_id_list" field.</summary>
    public const int WatcherIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_watcherIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> watcherIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> WatcherIdList {
      get { return watcherIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ActivityTakeWatcherRewardBatchReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ActivityTakeWatcherRewardBatchReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ActivityId != other.ActivityId) return false;
      if(!watcherIdList_.Equals(other.watcherIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ActivityId != 0) hash ^= ActivityId.GetHashCode();
      hash ^= watcherIdList_.GetHashCode();
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
      if (ActivityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ActivityId);
      }
      watcherIdList_.WriteTo(output, _repeated_watcherIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ActivityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ActivityId);
      }
      watcherIdList_.WriteTo(ref output, _repeated_watcherIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ActivityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ActivityId);
      }
      size += watcherIdList_.CalculateSize(_repeated_watcherIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ActivityTakeWatcherRewardBatchReq other) {
      if (other == null) {
        return;
      }
      if (other.ActivityId != 0) {
        ActivityId = other.ActivityId;
      }
      watcherIdList_.Add(other.watcherIdList_);
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
            ActivityId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            watcherIdList_.AddEntriesFrom(input, _repeated_watcherIdList_codec);
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
            ActivityId = input.ReadUInt32();
            break;
          }
          case 90:
          case 88: {
            watcherIdList_.AddEntriesFrom(ref input, _repeated_watcherIdList_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ActivityTakeWatcherRewardBatchReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 2159,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
