// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegionSearchChangeRegionNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RegionSearchChangeRegionNotify.proto</summary>
  public static partial class RegionSearchChangeRegionNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for RegionSearchChangeRegionNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegionSearchChangeRegionNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRSZWdpb25TZWFyY2hDaGFuZ2VSZWdpb25Ob3RpZnkucHJvdG8SDW1pSG9t",
            "by5Qcm90b3MitwIKHlJlZ2lvblNlYXJjaENoYW5nZVJlZ2lvbk5vdGlmeRJI",
            "CgVldmVudBgBIAEoDjI5Lm1pSG9tby5Qcm90b3MuUmVnaW9uU2VhcmNoQ2hh",
            "bmdlUmVnaW9uTm90aWZ5LlJlZ2lvbkV2ZW50EhEKCXJlZ2lvbl9pZBgKIAEo",
            "DSJiCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQ",
            "RU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NMSUVOVBABEgsKBkNN",
            "RF9JRBDyKxoCEAEiVAoLUmVnaW9uRXZlbnQSFQoRUkVHSU9OX0VWRU5UX05P",
            "TkUQABIWChJSRUdJT05fRVZFTlRfRU5URVIQARIWChJSRUdJT05fRVZFTlRf",
            "TEVBVkUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.RegionSearchChangeRegionNotify), global::MiHomo.Protos.RegionSearchChangeRegionNotify.Parser, new[]{ "Event", "RegionId" }, null, new[]{ typeof(global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.CmdId), typeof(global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RegionSearchChangeRegionNotify : pb::IMessage<RegionSearchChangeRegionNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RegionSearchChangeRegionNotify> _parser = new pb::MessageParser<RegionSearchChangeRegionNotify>(() => new RegionSearchChangeRegionNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RegionSearchChangeRegionNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.RegionSearchChangeRegionNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionSearchChangeRegionNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionSearchChangeRegionNotify(RegionSearchChangeRegionNotify other) : this() {
      event_ = other.event_;
      regionId_ = other.regionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RegionSearchChangeRegionNotify Clone() {
      return new RegionSearchChangeRegionNotify(this);
    }

    /// <summary>Field number for the "event" field.</summary>
    public const int EventFieldNumber = 1;
    private global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent event_ = global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent Event {
      get { return event_; }
      set {
        event_ = value;
      }
    }

    /// <summary>Field number for the "region_id" field.</summary>
    public const int RegionIdFieldNumber = 10;
    private uint regionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RegionId {
      get { return regionId_; }
      set {
        regionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RegionSearchChangeRegionNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RegionSearchChangeRegionNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Event != other.Event) return false;
      if (RegionId != other.RegionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Event != global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent.None) hash ^= Event.GetHashCode();
      if (RegionId != 0) hash ^= RegionId.GetHashCode();
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
      if (Event != global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Event);
      }
      if (RegionId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RegionId);
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
      if (Event != global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent.None) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Event);
      }
      if (RegionId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(RegionId);
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
      if (Event != global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Event);
      }
      if (RegionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RegionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RegionSearchChangeRegionNotify other) {
      if (other == null) {
        return;
      }
      if (other.Event != global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent.None) {
        Event = other.Event;
      }
      if (other.RegionId != 0) {
        RegionId = other.RegionId;
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
            Event = (global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent) input.ReadEnum();
            break;
          }
          case 80: {
            RegionId = input.ReadUInt32();
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
            Event = (global::MiHomo.Protos.RegionSearchChangeRegionNotify.Types.RegionEvent) input.ReadEnum();
            break;
          }
          case 80: {
            RegionId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the RegionSearchChangeRegionNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 5618,
      }

      public enum RegionEvent {
        [pbr::OriginalName("REGION_EVENT_NONE")] None = 0,
        [pbr::OriginalName("REGION_EVENT_ENTER")] Enter = 1,
        [pbr::OriginalName("REGION_EVENT_LEAVE")] Leave = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
