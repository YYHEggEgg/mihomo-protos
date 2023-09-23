// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityInvokeEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityInvokeEntry.proto</summary>
  public static partial class AbilityInvokeEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityInvokeEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityInvokeEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBYmlsaXR5SW52b2tlRW50cnkucHJvdG8SDW1pSG9tby5Qcm90b3MaG0Fi",
            "aWxpdHlJbnZva2VBcmd1bWVudC5wcm90bxocQWJpbGl0eUludm9rZUVudHJ5",
            "SGVhZC5wcm90bxoRRm9yd2FyZFR5cGUucHJvdG8iugIKEkFiaWxpdHlJbnZv",
            "a2VFbnRyeRIUCgxhYmlsaXR5X2RhdGEYDyABKAwSOwoNYXJndW1lbnRfdHlw",
            "ZRgBIAEoDjIkLm1pSG9tby5Qcm90b3MuQWJpbGl0eUludm9rZUFyZ3VtZW50",
            "EhEKCWVudGl0eV9pZBgJIAEoDRIQCghldmVudF9pZBgMIAEoDRIUCgxmb3J3",
            "YXJkX3BlZXIYBCABKA0SMAoMZm9yd2FyZF90eXBlGAMgASgOMhoubWlIb21v",
            "LlByb3Rvcy5Gb3J3YXJkVHlwZRIzCgRoZWFkGAIgASgLMiUubWlIb21vLlBy",
            "b3Rvcy5BYmlsaXR5SW52b2tlRW50cnlIZWFkEhYKDmlzX2lnbm9yZV9hdXRo",
            "GAggASgIEhcKD3RvdGFsX3RpY2tfdGltZRgOIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.AbilityInvokeArgumentReflection.Descriptor, global::MiHomo.Protos.AbilityInvokeEntryHeadReflection.Descriptor, global::MiHomo.Protos.ForwardTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityInvokeEntry), global::MiHomo.Protos.AbilityInvokeEntry.Parser, new[]{ "AbilityData", "ArgumentType", "EntityId", "EventId", "ForwardPeer", "ForwardType", "Head", "IsIgnoreAuth", "TotalTickTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityInvokeEntry : pb::IMessage<AbilityInvokeEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityInvokeEntry> _parser = new pb::MessageParser<AbilityInvokeEntry>(() => new AbilityInvokeEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityInvokeEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityInvokeEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntry(AbilityInvokeEntry other) : this() {
      abilityData_ = other.abilityData_;
      argumentType_ = other.argumentType_;
      entityId_ = other.entityId_;
      eventId_ = other.eventId_;
      forwardPeer_ = other.forwardPeer_;
      forwardType_ = other.forwardType_;
      head_ = other.head_ != null ? other.head_.Clone() : null;
      isIgnoreAuth_ = other.isIgnoreAuth_;
      totalTickTime_ = other.totalTickTime_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityInvokeEntry Clone() {
      return new AbilityInvokeEntry(this);
    }

    /// <summary>Field number for the "ability_data" field.</summary>
    public const int AbilityDataFieldNumber = 15;
    private pb::ByteString abilityData_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString AbilityData {
      get { return abilityData_; }
      set {
        abilityData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "argument_type" field.</summary>
    public const int ArgumentTypeFieldNumber = 1;
    private global::MiHomo.Protos.AbilityInvokeArgument argumentType_ = global::MiHomo.Protos.AbilityInvokeArgument.AbilityNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.AbilityInvokeArgument ArgumentType {
      get { return argumentType_; }
      set {
        argumentType_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 9;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "event_id" field.</summary>
    public const int EventIdFieldNumber = 12;
    private uint eventId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EventId {
      get { return eventId_; }
      set {
        eventId_ = value;
      }
    }

    /// <summary>Field number for the "forward_peer" field.</summary>
    public const int ForwardPeerFieldNumber = 4;
    private uint forwardPeer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ForwardPeer {
      get { return forwardPeer_; }
      set {
        forwardPeer_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 3;
    private global::MiHomo.Protos.ForwardType forwardType_ = global::MiHomo.Protos.ForwardType.ForwardLocal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "head" field.</summary>
    public const int HeadFieldNumber = 2;
    private global::MiHomo.Protos.AbilityInvokeEntryHead head_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.AbilityInvokeEntryHead Head {
      get { return head_; }
      set {
        head_ = value;
      }
    }

    /// <summary>Field number for the "is_ignore_auth" field.</summary>
    public const int IsIgnoreAuthFieldNumber = 8;
    private bool isIgnoreAuth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsIgnoreAuth {
      get { return isIgnoreAuth_; }
      set {
        isIgnoreAuth_ = value;
      }
    }

    /// <summary>Field number for the "total_tick_time" field.</summary>
    public const int TotalTickTimeFieldNumber = 14;
    private double totalTickTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double TotalTickTime {
      get { return totalTickTime_; }
      set {
        totalTickTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityInvokeEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityInvokeEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AbilityData != other.AbilityData) return false;
      if (ArgumentType != other.ArgumentType) return false;
      if (EntityId != other.EntityId) return false;
      if (EventId != other.EventId) return false;
      if (ForwardPeer != other.ForwardPeer) return false;
      if (ForwardType != other.ForwardType) return false;
      if (!object.Equals(Head, other.Head)) return false;
      if (IsIgnoreAuth != other.IsIgnoreAuth) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(TotalTickTime, other.TotalTickTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AbilityData.Length != 0) hash ^= AbilityData.GetHashCode();
      if (ArgumentType != global::MiHomo.Protos.AbilityInvokeArgument.AbilityNone) hash ^= ArgumentType.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (EventId != 0) hash ^= EventId.GetHashCode();
      if (ForwardPeer != 0) hash ^= ForwardPeer.GetHashCode();
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) hash ^= ForwardType.GetHashCode();
      if (head_ != null) hash ^= Head.GetHashCode();
      if (IsIgnoreAuth != false) hash ^= IsIgnoreAuth.GetHashCode();
      if (TotalTickTime != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(TotalTickTime);
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
      if (ArgumentType != global::MiHomo.Protos.AbilityInvokeArgument.AbilityNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ArgumentType);
      }
      if (head_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Head);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ForwardType);
      }
      if (ForwardPeer != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ForwardPeer);
      }
      if (IsIgnoreAuth != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsIgnoreAuth);
      }
      if (EntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntityId);
      }
      if (EventId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EventId);
      }
      if (TotalTickTime != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(TotalTickTime);
      }
      if (AbilityData.Length != 0) {
        output.WriteRawTag(122);
        output.WriteBytes(AbilityData);
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
      if (ArgumentType != global::MiHomo.Protos.AbilityInvokeArgument.AbilityNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ArgumentType);
      }
      if (head_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Head);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ForwardType);
      }
      if (ForwardPeer != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(ForwardPeer);
      }
      if (IsIgnoreAuth != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsIgnoreAuth);
      }
      if (EntityId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(EntityId);
      }
      if (EventId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(EventId);
      }
      if (TotalTickTime != 0D) {
        output.WriteRawTag(113);
        output.WriteDouble(TotalTickTime);
      }
      if (AbilityData.Length != 0) {
        output.WriteRawTag(122);
        output.WriteBytes(AbilityData);
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
      if (AbilityData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(AbilityData);
      }
      if (ArgumentType != global::MiHomo.Protos.AbilityInvokeArgument.AbilityNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ArgumentType);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (EventId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EventId);
      }
      if (ForwardPeer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ForwardPeer);
      }
      if (ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (head_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Head);
      }
      if (IsIgnoreAuth != false) {
        size += 1 + 1;
      }
      if (TotalTickTime != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityInvokeEntry other) {
      if (other == null) {
        return;
      }
      if (other.AbilityData.Length != 0) {
        AbilityData = other.AbilityData;
      }
      if (other.ArgumentType != global::MiHomo.Protos.AbilityInvokeArgument.AbilityNone) {
        ArgumentType = other.ArgumentType;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.EventId != 0) {
        EventId = other.EventId;
      }
      if (other.ForwardPeer != 0) {
        ForwardPeer = other.ForwardPeer;
      }
      if (other.ForwardType != global::MiHomo.Protos.ForwardType.ForwardLocal) {
        ForwardType = other.ForwardType;
      }
      if (other.head_ != null) {
        if (head_ == null) {
          Head = new global::MiHomo.Protos.AbilityInvokeEntryHead();
        }
        Head.MergeFrom(other.Head);
      }
      if (other.IsIgnoreAuth != false) {
        IsIgnoreAuth = other.IsIgnoreAuth;
      }
      if (other.TotalTickTime != 0D) {
        TotalTickTime = other.TotalTickTime;
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
            ArgumentType = (global::MiHomo.Protos.AbilityInvokeArgument) input.ReadEnum();
            break;
          }
          case 18: {
            if (head_ == null) {
              Head = new global::MiHomo.Protos.AbilityInvokeEntryHead();
            }
            input.ReadMessage(Head);
            break;
          }
          case 24: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 32: {
            ForwardPeer = input.ReadUInt32();
            break;
          }
          case 64: {
            IsIgnoreAuth = input.ReadBool();
            break;
          }
          case 72: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            EventId = input.ReadUInt32();
            break;
          }
          case 113: {
            TotalTickTime = input.ReadDouble();
            break;
          }
          case 122: {
            AbilityData = input.ReadBytes();
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
            ArgumentType = (global::MiHomo.Protos.AbilityInvokeArgument) input.ReadEnum();
            break;
          }
          case 18: {
            if (head_ == null) {
              Head = new global::MiHomo.Protos.AbilityInvokeEntryHead();
            }
            input.ReadMessage(Head);
            break;
          }
          case 24: {
            ForwardType = (global::MiHomo.Protos.ForwardType) input.ReadEnum();
            break;
          }
          case 32: {
            ForwardPeer = input.ReadUInt32();
            break;
          }
          case 64: {
            IsIgnoreAuth = input.ReadBool();
            break;
          }
          case 72: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 96: {
            EventId = input.ReadUInt32();
            break;
          }
          case 113: {
            TotalTickTime = input.ReadDouble();
            break;
          }
          case 122: {
            AbilityData = input.ReadBytes();
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
