// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityAttachedModifier.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityAttachedModifier.proto</summary>
  public static partial class AbilityAttachedModifierReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityAttachedModifier.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityAttachedModifierReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1BYmlsaXR5QXR0YWNoZWRNb2RpZmllci5wcm90bxINbWlIb21vLlByb3Rv",
            "cyKfAQoXQWJpbGl0eUF0dGFjaGVkTW9kaWZpZXISGAoQYXR0YWNoX25hbWVf",
            "aGFzaBgFIAEoBRIdChVpbnN0YW5jZWRfbW9kaWZpZXJfaWQYAyABKA0SEgoK",
            "aXNfaW52YWxpZBgBIAEoCBIeChZpc19zZXJ2ZXJidWZmX21vZGlmaWVyGAQg",
            "ASgIEhcKD293bmVyX2VudGl0eV9pZBgCIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityAttachedModifier), global::MiHomo.Protos.AbilityAttachedModifier.Parser, new[]{ "AttachNameHash", "InstancedModifierId", "IsInvalid", "IsServerbuffModifier", "OwnerEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityAttachedModifier : pb::IMessage<AbilityAttachedModifier>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityAttachedModifier> _parser = new pb::MessageParser<AbilityAttachedModifier>(() => new AbilityAttachedModifier());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityAttachedModifier> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityAttachedModifierReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityAttachedModifier() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityAttachedModifier(AbilityAttachedModifier other) : this() {
      attachNameHash_ = other.attachNameHash_;
      instancedModifierId_ = other.instancedModifierId_;
      isInvalid_ = other.isInvalid_;
      isServerbuffModifier_ = other.isServerbuffModifier_;
      ownerEntityId_ = other.ownerEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityAttachedModifier Clone() {
      return new AbilityAttachedModifier(this);
    }

    /// <summary>Field number for the "attach_name_hash" field.</summary>
    public const int AttachNameHashFieldNumber = 5;
    private int attachNameHash_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int AttachNameHash {
      get { return attachNameHash_; }
      set {
        attachNameHash_ = value;
      }
    }

    /// <summary>Field number for the "instanced_modifier_id" field.</summary>
    public const int InstancedModifierIdFieldNumber = 3;
    private uint instancedModifierId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedModifierId {
      get { return instancedModifierId_; }
      set {
        instancedModifierId_ = value;
      }
    }

    /// <summary>Field number for the "is_invalid" field.</summary>
    public const int IsInvalidFieldNumber = 1;
    private bool isInvalid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsInvalid {
      get { return isInvalid_; }
      set {
        isInvalid_ = value;
      }
    }

    /// <summary>Field number for the "is_serverbuff_modifier" field.</summary>
    public const int IsServerbuffModifierFieldNumber = 4;
    private bool isServerbuffModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsServerbuffModifier {
      get { return isServerbuffModifier_; }
      set {
        isServerbuffModifier_ = value;
      }
    }

    /// <summary>Field number for the "owner_entity_id" field.</summary>
    public const int OwnerEntityIdFieldNumber = 2;
    private uint ownerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerEntityId {
      get { return ownerEntityId_; }
      set {
        ownerEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityAttachedModifier);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityAttachedModifier other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AttachNameHash != other.AttachNameHash) return false;
      if (InstancedModifierId != other.InstancedModifierId) return false;
      if (IsInvalid != other.IsInvalid) return false;
      if (IsServerbuffModifier != other.IsServerbuffModifier) return false;
      if (OwnerEntityId != other.OwnerEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AttachNameHash != 0) hash ^= AttachNameHash.GetHashCode();
      if (InstancedModifierId != 0) hash ^= InstancedModifierId.GetHashCode();
      if (IsInvalid != false) hash ^= IsInvalid.GetHashCode();
      if (IsServerbuffModifier != false) hash ^= IsServerbuffModifier.GetHashCode();
      if (OwnerEntityId != 0) hash ^= OwnerEntityId.GetHashCode();
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
      if (IsInvalid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsInvalid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerEntityId);
      }
      if (InstancedModifierId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(InstancedModifierId);
      }
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsServerbuffModifier);
      }
      if (AttachNameHash != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(AttachNameHash);
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
      if (IsInvalid != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsInvalid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(OwnerEntityId);
      }
      if (InstancedModifierId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(InstancedModifierId);
      }
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsServerbuffModifier);
      }
      if (AttachNameHash != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(AttachNameHash);
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
      if (AttachNameHash != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(AttachNameHash);
      }
      if (InstancedModifierId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedModifierId);
      }
      if (IsInvalid != false) {
        size += 1 + 1;
      }
      if (IsServerbuffModifier != false) {
        size += 1 + 1;
      }
      if (OwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityAttachedModifier other) {
      if (other == null) {
        return;
      }
      if (other.AttachNameHash != 0) {
        AttachNameHash = other.AttachNameHash;
      }
      if (other.InstancedModifierId != 0) {
        InstancedModifierId = other.InstancedModifierId;
      }
      if (other.IsInvalid != false) {
        IsInvalid = other.IsInvalid;
      }
      if (other.IsServerbuffModifier != false) {
        IsServerbuffModifier = other.IsServerbuffModifier;
      }
      if (other.OwnerEntityId != 0) {
        OwnerEntityId = other.OwnerEntityId;
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
            IsInvalid = input.ReadBool();
            break;
          }
          case 16: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 32: {
            IsServerbuffModifier = input.ReadBool();
            break;
          }
          case 40: {
            AttachNameHash = input.ReadInt32();
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
            IsInvalid = input.ReadBool();
            break;
          }
          case 16: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 32: {
            IsServerbuffModifier = input.ReadBool();
            break;
          }
          case 40: {
            AttachNameHash = input.ReadInt32();
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
