// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityArgument.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityArgument.proto</summary>
  public static partial class AbilityArgumentReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityArgument.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityArgumentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVBYmlsaXR5QXJndW1lbnQucHJvdG8SDW1pSG9tby5Qcm90b3MiUwoPQWJp",
            "bGl0eUFyZ3VtZW50EhMKCWZsb2F0X2FyZxgPIAEoAkgAEhEKB2ludF9hcmcY",
            "BSABKA1IABIRCgdzdHJfYXJnGAsgASgJSABCBQoDYXJnYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityArgument), global::MiHomo.Protos.AbilityArgument.Parser, new[]{ "FloatArg", "IntArg", "StrArg" }, new[]{ "Arg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityArgument : pb::IMessage<AbilityArgument>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityArgument> _parser = new pb::MessageParser<AbilityArgument>(() => new AbilityArgument());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityArgument> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityArgumentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityArgument() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityArgument(AbilityArgument other) : this() {
      switch (other.ArgCase) {
        case ArgOneofCase.FloatArg:
          FloatArg = other.FloatArg;
          break;
        case ArgOneofCase.IntArg:
          IntArg = other.IntArg;
          break;
        case ArgOneofCase.StrArg:
          StrArg = other.StrArg;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityArgument Clone() {
      return new AbilityArgument(this);
    }

    /// <summary>Field number for the "float_arg" field.</summary>
    public const int FloatArgFieldNumber = 15;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float FloatArg {
      get { return argCase_ == ArgOneofCase.FloatArg ? (float) arg_ : 0F; }
      set {
        arg_ = value;
        argCase_ = ArgOneofCase.FloatArg;
      }
    }

    /// <summary>Field number for the "int_arg" field.</summary>
    public const int IntArgFieldNumber = 5;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint IntArg {
      get { return argCase_ == ArgOneofCase.IntArg ? (uint) arg_ : 0; }
      set {
        arg_ = value;
        argCase_ = ArgOneofCase.IntArg;
      }
    }

    /// <summary>Field number for the "str_arg" field.</summary>
    public const int StrArgFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StrArg {
      get { return argCase_ == ArgOneofCase.StrArg ? (string) arg_ : ""; }
      set {
        arg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        argCase_ = ArgOneofCase.StrArg;
      }
    }

    private object arg_;
    /// <summary>Enum of possible cases for the "arg" oneof.</summary>
    public enum ArgOneofCase {
      None = 0,
      FloatArg = 15,
      IntArg = 5,
      StrArg = 11,
    }
    private ArgOneofCase argCase_ = ArgOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ArgOneofCase ArgCase {
      get { return argCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearArg() {
      argCase_ = ArgOneofCase.None;
      arg_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityArgument);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityArgument other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatArg, other.FloatArg)) return false;
      if (IntArg != other.IntArg) return false;
      if (StrArg != other.StrArg) return false;
      if (ArgCase != other.ArgCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (argCase_ == ArgOneofCase.FloatArg) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatArg);
      if (argCase_ == ArgOneofCase.IntArg) hash ^= IntArg.GetHashCode();
      if (argCase_ == ArgOneofCase.StrArg) hash ^= StrArg.GetHashCode();
      hash ^= (int) argCase_;
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
      if (argCase_ == ArgOneofCase.IntArg) {
        output.WriteRawTag(40);
        output.WriteUInt32(IntArg);
      }
      if (argCase_ == ArgOneofCase.StrArg) {
        output.WriteRawTag(90);
        output.WriteString(StrArg);
      }
      if (argCase_ == ArgOneofCase.FloatArg) {
        output.WriteRawTag(125);
        output.WriteFloat(FloatArg);
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
      if (argCase_ == ArgOneofCase.IntArg) {
        output.WriteRawTag(40);
        output.WriteUInt32(IntArg);
      }
      if (argCase_ == ArgOneofCase.StrArg) {
        output.WriteRawTag(90);
        output.WriteString(StrArg);
      }
      if (argCase_ == ArgOneofCase.FloatArg) {
        output.WriteRawTag(125);
        output.WriteFloat(FloatArg);
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
      if (argCase_ == ArgOneofCase.FloatArg) {
        size += 1 + 4;
      }
      if (argCase_ == ArgOneofCase.IntArg) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(IntArg);
      }
      if (argCase_ == ArgOneofCase.StrArg) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StrArg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityArgument other) {
      if (other == null) {
        return;
      }
      switch (other.ArgCase) {
        case ArgOneofCase.FloatArg:
          FloatArg = other.FloatArg;
          break;
        case ArgOneofCase.IntArg:
          IntArg = other.IntArg;
          break;
        case ArgOneofCase.StrArg:
          StrArg = other.StrArg;
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
          case 40: {
            IntArg = input.ReadUInt32();
            break;
          }
          case 90: {
            StrArg = input.ReadString();
            break;
          }
          case 125: {
            FloatArg = input.ReadFloat();
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
          case 40: {
            IntArg = input.ReadUInt32();
            break;
          }
          case 90: {
            StrArg = input.ReadString();
            break;
          }
          case 125: {
            FloatArg = input.ReadFloat();
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
