// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WatcherChangeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WatcherChangeNotify.proto</summary>
  public static partial class WatcherChangeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WatcherChangeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WatcherChangeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlXYXRjaGVyQ2hhbmdlTm90aWZ5LnByb3RvEg1taUhvbW8uUHJvdG9zIk0K",
            "E1dhdGNoZXJDaGFuZ2VOb3RpZnkSGAoQbmV3X3dhdGNoZXJfbGlzdBgFIAMo",
            "DRIcChRyZW1vdmVkX3dhdGNoZXJfbGlzdBgKIAMoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WatcherChangeNotify), global::MiHomo.Protos.WatcherChangeNotify.Parser, new[]{ "NewWatcherList", "RemovedWatcherList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WatcherChangeNotify : pb::IMessage<WatcherChangeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WatcherChangeNotify> _parser = new pb::MessageParser<WatcherChangeNotify>(() => new WatcherChangeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WatcherChangeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WatcherChangeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatcherChangeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatcherChangeNotify(WatcherChangeNotify other) : this() {
      newWatcherList_ = other.newWatcherList_.Clone();
      removedWatcherList_ = other.removedWatcherList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WatcherChangeNotify Clone() {
      return new WatcherChangeNotify(this);
    }

    /// <summary>Field number for the "new_watcher_list" field.</summary>
    public const int NewWatcherListFieldNumber = 5;
    private static readonly pb::FieldCodec<uint> _repeated_newWatcherList_codec
        = pb::FieldCodec.ForUInt32(42);
    private readonly pbc::RepeatedField<uint> newWatcherList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> NewWatcherList {
      get { return newWatcherList_; }
    }

    /// <summary>Field number for the "removed_watcher_list" field.</summary>
    public const int RemovedWatcherListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_removedWatcherList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> removedWatcherList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> RemovedWatcherList {
      get { return removedWatcherList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WatcherChangeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WatcherChangeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!newWatcherList_.Equals(other.newWatcherList_)) return false;
      if(!removedWatcherList_.Equals(other.removedWatcherList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= newWatcherList_.GetHashCode();
      hash ^= removedWatcherList_.GetHashCode();
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
      newWatcherList_.WriteTo(output, _repeated_newWatcherList_codec);
      removedWatcherList_.WriteTo(output, _repeated_removedWatcherList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      newWatcherList_.WriteTo(ref output, _repeated_newWatcherList_codec);
      removedWatcherList_.WriteTo(ref output, _repeated_removedWatcherList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += newWatcherList_.CalculateSize(_repeated_newWatcherList_codec);
      size += removedWatcherList_.CalculateSize(_repeated_removedWatcherList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WatcherChangeNotify other) {
      if (other == null) {
        return;
      }
      newWatcherList_.Add(other.newWatcherList_);
      removedWatcherList_.Add(other.removedWatcherList_);
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
          case 42:
          case 40: {
            newWatcherList_.AddEntriesFrom(input, _repeated_newWatcherList_codec);
            break;
          }
          case 82:
          case 80: {
            removedWatcherList_.AddEntriesFrom(input, _repeated_removedWatcherList_codec);
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
          case 42:
          case 40: {
            newWatcherList_.AddEntriesFrom(ref input, _repeated_newWatcherList_codec);
            break;
          }
          case 82:
          case 80: {
            removedWatcherList_.AddEntriesFrom(ref input, _repeated_removedWatcherList_codec);
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
