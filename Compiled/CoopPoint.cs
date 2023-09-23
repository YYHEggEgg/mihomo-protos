// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CoopPoint.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CoopPoint.proto</summary>
  public static partial class CoopPointReflection {

    #region Descriptor
    /// <summary>File descriptor for CoopPoint.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoopPointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9Db29wUG9pbnQucHJvdG8SDW1pSG9tby5Qcm90b3MipAEKCUNvb3BQb2lu",
            "dBIKCgJpZBgOIAEoDRIXCg9zZWxmX2NvbmZpZGVuY2UYDyABKA0SLQoFc3Rh",
            "dGUYCiABKA4yHi5taUhvbW8uUHJvdG9zLkNvb3BQb2ludC5TdGF0ZSJDCgVT",
            "dGF0ZRITCg9TVEFURV9VTlNUQVJURUQQABIRCg1TVEFURV9TVEFSVEVEEAES",
            "EgoOU1RBVEVfRklOSVNIRUQQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CoopPoint), global::MiHomo.Protos.CoopPoint.Parser, new[]{ "Id", "SelfConfidence", "State" }, null, new[]{ typeof(global::MiHomo.Protos.CoopPoint.Types.State) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CoopPoint : pb::IMessage<CoopPoint>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CoopPoint> _parser = new pb::MessageParser<CoopPoint>(() => new CoopPoint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CoopPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CoopPointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopPoint(CoopPoint other) : this() {
      id_ = other.id_;
      selfConfidence_ = other.selfConfidence_;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CoopPoint Clone() {
      return new CoopPoint(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 14;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "self_confidence" field.</summary>
    public const int SelfConfidenceFieldNumber = 15;
    private uint selfConfidence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SelfConfidence {
      get { return selfConfidence_; }
      set {
        selfConfidence_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 10;
    private global::MiHomo.Protos.CoopPoint.Types.State state_ = global::MiHomo.Protos.CoopPoint.Types.State.Unstarted;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CoopPoint.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CoopPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CoopPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (SelfConfidence != other.SelfConfidence) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (SelfConfidence != 0) hash ^= SelfConfidence.GetHashCode();
      if (State != global::MiHomo.Protos.CoopPoint.Types.State.Unstarted) hash ^= State.GetHashCode();
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
      if (State != global::MiHomo.Protos.CoopPoint.Types.State.Unstarted) {
        output.WriteRawTag(80);
        output.WriteEnum((int) State);
      }
      if (Id != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Id);
      }
      if (SelfConfidence != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelfConfidence);
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
      if (State != global::MiHomo.Protos.CoopPoint.Types.State.Unstarted) {
        output.WriteRawTag(80);
        output.WriteEnum((int) State);
      }
      if (Id != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Id);
      }
      if (SelfConfidence != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SelfConfidence);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (SelfConfidence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SelfConfidence);
      }
      if (State != global::MiHomo.Protos.CoopPoint.Types.State.Unstarted) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CoopPoint other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.SelfConfidence != 0) {
        SelfConfidence = other.SelfConfidence;
      }
      if (other.State != global::MiHomo.Protos.CoopPoint.Types.State.Unstarted) {
        State = other.State;
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
          case 80: {
            State = (global::MiHomo.Protos.CoopPoint.Types.State) input.ReadEnum();
            break;
          }
          case 112: {
            Id = input.ReadUInt32();
            break;
          }
          case 120: {
            SelfConfidence = input.ReadUInt32();
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
          case 80: {
            State = (global::MiHomo.Protos.CoopPoint.Types.State) input.ReadEnum();
            break;
          }
          case 112: {
            Id = input.ReadUInt32();
            break;
          }
          case 120: {
            SelfConfidence = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CoopPoint message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum State {
        [pbr::OriginalName("STATE_UNSTARTED")] Unstarted = 0,
        [pbr::OriginalName("STATE_STARTED")] Started = 1,
        [pbr::OriginalName("STATE_FINISHED")] Finished = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
