// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonEntryCond.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DungeonEntryCond.proto</summary>
  public static partial class DungeonEntryCondReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonEntryCond.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonEntryCondReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEdW5nZW9uRW50cnlDb25kLnByb3RvEg1taUhvbW8uUHJvdG9zGh1EdW5n",
            "ZW9uRW50cnlCbG9ja1JlYXNvbi5wcm90byJfChBEdW5nZW9uRW50cnlDb25k",
            "EjsKC2NvbmRfcmVhc29uGAcgASgOMiYubWlIb21vLlByb3Rvcy5EdW5nZW9u",
            "RW50cnlCbG9ja1JlYXNvbhIOCgZwYXJhbTEYCCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.DungeonEntryBlockReasonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DungeonEntryCond), global::MiHomo.Protos.DungeonEntryCond.Parser, new[]{ "CondReason", "Param1" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DungeonEntryCond : pb::IMessage<DungeonEntryCond>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DungeonEntryCond> _parser = new pb::MessageParser<DungeonEntryCond>(() => new DungeonEntryCond());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DungeonEntryCond> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DungeonEntryCondReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryCond() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryCond(DungeonEntryCond other) : this() {
      condReason_ = other.condReason_;
      param1_ = other.param1_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DungeonEntryCond Clone() {
      return new DungeonEntryCond(this);
    }

    /// <summary>Field number for the "cond_reason" field.</summary>
    public const int CondReasonFieldNumber = 7;
    private global::MiHomo.Protos.DungeonEntryBlockReason condReason_ = global::MiHomo.Protos.DungeonEntryBlockReason.DungeonEntryReasonNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.DungeonEntryBlockReason CondReason {
      get { return condReason_; }
      set {
        condReason_ = value;
      }
    }

    /// <summary>Field number for the "param1" field.</summary>
    public const int Param1FieldNumber = 8;
    private uint param1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Param1 {
      get { return param1_; }
      set {
        param1_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DungeonEntryCond);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DungeonEntryCond other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CondReason != other.CondReason) return false;
      if (Param1 != other.Param1) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CondReason != global::MiHomo.Protos.DungeonEntryBlockReason.DungeonEntryReasonNone) hash ^= CondReason.GetHashCode();
      if (Param1 != 0) hash ^= Param1.GetHashCode();
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
      if (CondReason != global::MiHomo.Protos.DungeonEntryBlockReason.DungeonEntryReasonNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) CondReason);
      }
      if (Param1 != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Param1);
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
      if (CondReason != global::MiHomo.Protos.DungeonEntryBlockReason.DungeonEntryReasonNone) {
        output.WriteRawTag(56);
        output.WriteEnum((int) CondReason);
      }
      if (Param1 != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Param1);
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
      if (CondReason != global::MiHomo.Protos.DungeonEntryBlockReason.DungeonEntryReasonNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CondReason);
      }
      if (Param1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Param1);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DungeonEntryCond other) {
      if (other == null) {
        return;
      }
      if (other.CondReason != global::MiHomo.Protos.DungeonEntryBlockReason.DungeonEntryReasonNone) {
        CondReason = other.CondReason;
      }
      if (other.Param1 != 0) {
        Param1 = other.Param1;
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
          case 56: {
            CondReason = (global::MiHomo.Protos.DungeonEntryBlockReason) input.ReadEnum();
            break;
          }
          case 64: {
            Param1 = input.ReadUInt32();
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
          case 56: {
            CondReason = (global::MiHomo.Protos.DungeonEntryBlockReason) input.ReadEnum();
            break;
          }
          case 64: {
            Param1 = input.ReadUInt32();
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
