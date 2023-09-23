// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinShieldBar.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityMixinShieldBar.proto</summary>
  public static partial class AbilityMixinShieldBarReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMixinShieldBar.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMixinShieldBarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBYmlsaXR5TWl4aW5TaGllbGRCYXIucHJvdG8SDW1pSG9tby5Qcm90b3Mi",
            "ZQoVQWJpbGl0eU1peGluU2hpZWxkQmFyEhQKDGVsZW1lbnRfdHlwZRgHIAEo",
            "DRISCgptYXhfc2hpZWxkGAggASgCEhIKCnBsYXllcl9udW0YAyABKA0SDgoG",
            "c2hpZWxkGAQgASgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityMixinShieldBar), global::MiHomo.Protos.AbilityMixinShieldBar.Parser, new[]{ "ElementType", "MaxShield", "PlayerNum", "Shield" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMixinShieldBar : pb::IMessage<AbilityMixinShieldBar>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMixinShieldBar> _parser = new pb::MessageParser<AbilityMixinShieldBar>(() => new AbilityMixinShieldBar());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMixinShieldBar> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityMixinShieldBarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinShieldBar() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinShieldBar(AbilityMixinShieldBar other) : this() {
      elementType_ = other.elementType_;
      maxShield_ = other.maxShield_;
      playerNum_ = other.playerNum_;
      shield_ = other.shield_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinShieldBar Clone() {
      return new AbilityMixinShieldBar(this);
    }

    /// <summary>Field number for the "element_type" field.</summary>
    public const int ElementTypeFieldNumber = 7;
    private uint elementType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ElementType {
      get { return elementType_; }
      set {
        elementType_ = value;
      }
    }

    /// <summary>Field number for the "max_shield" field.</summary>
    public const int MaxShieldFieldNumber = 8;
    private float maxShield_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MaxShield {
      get { return maxShield_; }
      set {
        maxShield_ = value;
      }
    }

    /// <summary>Field number for the "player_num" field.</summary>
    public const int PlayerNumFieldNumber = 3;
    private uint playerNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerNum {
      get { return playerNum_; }
      set {
        playerNum_ = value;
      }
    }

    /// <summary>Field number for the "shield" field.</summary>
    public const int ShieldFieldNumber = 4;
    private float shield_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Shield {
      get { return shield_; }
      set {
        shield_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMixinShieldBar);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMixinShieldBar other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ElementType != other.ElementType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxShield, other.MaxShield)) return false;
      if (PlayerNum != other.PlayerNum) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Shield, other.Shield)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ElementType != 0) hash ^= ElementType.GetHashCode();
      if (MaxShield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxShield);
      if (PlayerNum != 0) hash ^= PlayerNum.GetHashCode();
      if (Shield != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Shield);
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
      if (PlayerNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayerNum);
      }
      if (Shield != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Shield);
      }
      if (ElementType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ElementType);
      }
      if (MaxShield != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(MaxShield);
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
      if (PlayerNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(PlayerNum);
      }
      if (Shield != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Shield);
      }
      if (ElementType != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(ElementType);
      }
      if (MaxShield != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(MaxShield);
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
      if (ElementType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ElementType);
      }
      if (MaxShield != 0F) {
        size += 1 + 4;
      }
      if (PlayerNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerNum);
      }
      if (Shield != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMixinShieldBar other) {
      if (other == null) {
        return;
      }
      if (other.ElementType != 0) {
        ElementType = other.ElementType;
      }
      if (other.MaxShield != 0F) {
        MaxShield = other.MaxShield;
      }
      if (other.PlayerNum != 0) {
        PlayerNum = other.PlayerNum;
      }
      if (other.Shield != 0F) {
        Shield = other.Shield;
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
          case 24: {
            PlayerNum = input.ReadUInt32();
            break;
          }
          case 37: {
            Shield = input.ReadFloat();
            break;
          }
          case 56: {
            ElementType = input.ReadUInt32();
            break;
          }
          case 69: {
            MaxShield = input.ReadFloat();
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
            PlayerNum = input.ReadUInt32();
            break;
          }
          case 37: {
            Shield = input.ReadFloat();
            break;
          }
          case 56: {
            ElementType = input.ReadUInt32();
            break;
          }
          case 69: {
            MaxShield = input.ReadFloat();
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
