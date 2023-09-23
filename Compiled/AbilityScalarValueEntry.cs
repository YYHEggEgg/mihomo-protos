// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityScalarValueEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityScalarValueEntry.proto</summary>
  public static partial class AbilityScalarValueEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityScalarValueEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityScalarValueEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1BYmlsaXR5U2NhbGFyVmFsdWVFbnRyeS5wcm90bxINbWlIb21vLlByb3Rv",
            "cxoXQWJpbGl0eVNjYWxhclR5cGUucHJvdG8aE0FiaWxpdHlTdHJpbmcucHJv",
            "dG8i3QEKF0FiaWxpdHlTY2FsYXJWYWx1ZUVudHJ5EikKA2tleRgBIAEoCzIc",
            "Lm1pSG9tby5Qcm90b3MuQWJpbGl0eVN0cmluZxI0Cgp2YWx1ZV90eXBlGAIg",
            "ASgOMiAubWlIb21vLlByb3Rvcy5BYmlsaXR5U2NhbGFyVHlwZRIVCgtmbG9h",
            "dF92YWx1ZRgDIAEoAkgAEhMKCWludF92YWx1ZRgFIAEoBUgAEhYKDHN0cmlu",
            "Z192YWx1ZRgEIAEoCUgAEhQKCnVpbnRfdmFsdWUYBiABKA1IAEIHCgV2YWx1",
            "ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.AbilityScalarTypeReflection.Descriptor, global::MiHomo.Protos.AbilityStringReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityScalarValueEntry), global::MiHomo.Protos.AbilityScalarValueEntry.Parser, new[]{ "Key", "ValueType", "FloatValue", "IntValue", "StringValue", "UintValue" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityScalarValueEntry : pb::IMessage<AbilityScalarValueEntry>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityScalarValueEntry> _parser = new pb::MessageParser<AbilityScalarValueEntry>(() => new AbilityScalarValueEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityScalarValueEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityScalarValueEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityScalarValueEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityScalarValueEntry(AbilityScalarValueEntry other) : this() {
      key_ = other.key_ != null ? other.key_.Clone() : null;
      valueType_ = other.valueType_;
      switch (other.ValueCase) {
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
        case ValueOneofCase.IntValue:
          IntValue = other.IntValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
        case ValueOneofCase.UintValue:
          UintValue = other.UintValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityScalarValueEntry Clone() {
      return new AbilityScalarValueEntry(this);
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 1;
    private global::MiHomo.Protos.AbilityString key_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.AbilityString Key {
      get { return key_; }
      set {
        key_ = value;
      }
    }

    /// <summary>Field number for the "value_type" field.</summary>
    public const int ValueTypeFieldNumber = 2;
    private global::MiHomo.Protos.AbilityScalarType valueType_ = global::MiHomo.Protos.AbilityScalarType.Unknow;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.AbilityScalarType ValueType {
      get { return valueType_; }
      set {
        valueType_ = value;
      }
    }

    /// <summary>Field number for the "float_value" field.</summary>
    public const int FloatValueFieldNumber = 3;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FloatValue {
      get { return valueCase_ == ValueOneofCase.FloatValue ? (float) value_ : 0F; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.FloatValue;
      }
    }

    /// <summary>Field number for the "int_value" field.</summary>
    public const int IntValueFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int IntValue {
      get { return valueCase_ == ValueOneofCase.IntValue ? (int) value_ : 0; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.IntValue;
      }
    }

    /// <summary>Field number for the "string_value" field.</summary>
    public const int StringValueFieldNumber = 4;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StringValue {
      get { return valueCase_ == ValueOneofCase.StringValue ? (string) value_ : ""; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.StringValue;
      }
    }

    /// <summary>Field number for the "uint_value" field.</summary>
    public const int UintValueFieldNumber = 6;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UintValue {
      get { return valueCase_ == ValueOneofCase.UintValue ? (uint) value_ : 0; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.UintValue;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      FloatValue = 3,
      IntValue = 5,
      StringValue = 4,
      UintValue = 6,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityScalarValueEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityScalarValueEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Key, other.Key)) return false;
      if (ValueType != other.ValueType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue)) return false;
      if (IntValue != other.IntValue) return false;
      if (StringValue != other.StringValue) return false;
      if (UintValue != other.UintValue) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (key_ != null) hash ^= Key.GetHashCode();
      if (ValueType != global::MiHomo.Protos.AbilityScalarType.Unknow) hash ^= ValueType.GetHashCode();
      if (valueCase_ == ValueOneofCase.FloatValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
      if (valueCase_ == ValueOneofCase.IntValue) hash ^= IntValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.StringValue) hash ^= StringValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.UintValue) hash ^= UintValue.GetHashCode();
      hash ^= (int) valueCase_;
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
      if (key_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Key);
      }
      if (ValueType != global::MiHomo.Protos.AbilityScalarType.Unknow) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ValueType);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(34);
        output.WriteString(StringValue);
      }
      if (valueCase_ == ValueOneofCase.IntValue) {
        output.WriteRawTag(40);
        output.WriteInt32(IntValue);
      }
      if (valueCase_ == ValueOneofCase.UintValue) {
        output.WriteRawTag(48);
        output.WriteUInt32(UintValue);
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
      if (key_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Key);
      }
      if (ValueType != global::MiHomo.Protos.AbilityScalarType.Unknow) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ValueType);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(34);
        output.WriteString(StringValue);
      }
      if (valueCase_ == ValueOneofCase.IntValue) {
        output.WriteRawTag(40);
        output.WriteInt32(IntValue);
      }
      if (valueCase_ == ValueOneofCase.UintValue) {
        output.WriteRawTag(48);
        output.WriteUInt32(UintValue);
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
      if (key_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Key);
      }
      if (ValueType != global::MiHomo.Protos.AbilityScalarType.Unknow) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ValueType);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        size += 1 + 4;
      }
      if (valueCase_ == ValueOneofCase.IntValue) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(IntValue);
      }
      if (valueCase_ == ValueOneofCase.StringValue) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (valueCase_ == ValueOneofCase.UintValue) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UintValue);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityScalarValueEntry other) {
      if (other == null) {
        return;
      }
      if (other.key_ != null) {
        if (key_ == null) {
          Key = new global::MiHomo.Protos.AbilityString();
        }
        Key.MergeFrom(other.Key);
      }
      if (other.ValueType != global::MiHomo.Protos.AbilityScalarType.Unknow) {
        ValueType = other.ValueType;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
        case ValueOneofCase.IntValue:
          IntValue = other.IntValue;
          break;
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
        case ValueOneofCase.UintValue:
          UintValue = other.UintValue;
          break;
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
          case 10: {
            if (key_ == null) {
              Key = new global::MiHomo.Protos.AbilityString();
            }
            input.ReadMessage(Key);
            break;
          }
          case 16: {
            ValueType = (global::MiHomo.Protos.AbilityScalarType) input.ReadEnum();
            break;
          }
          case 29: {
            FloatValue = input.ReadFloat();
            break;
          }
          case 34: {
            StringValue = input.ReadString();
            break;
          }
          case 40: {
            IntValue = input.ReadInt32();
            break;
          }
          case 48: {
            UintValue = input.ReadUInt32();
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
            if (key_ == null) {
              Key = new global::MiHomo.Protos.AbilityString();
            }
            input.ReadMessage(Key);
            break;
          }
          case 16: {
            ValueType = (global::MiHomo.Protos.AbilityScalarType) input.ReadEnum();
            break;
          }
          case 29: {
            FloatValue = input.ReadFloat();
            break;
          }
          case 34: {
            StringValue = input.ReadString();
            break;
          }
          case 40: {
            IntValue = input.ReadInt32();
            break;
          }
          case 48: {
            UintValue = input.ReadUInt32();
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
