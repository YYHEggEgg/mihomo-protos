// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishCastRodReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FishCastRodReq.proto</summary>
  public static partial class FishCastRodReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FishCastRodReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishCastRodReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRGaXNoQ2FzdFJvZFJlcS5wcm90bxINbWlIb21vLlByb3RvcxoMVmVjdG9y",
            "LnByb3RvIoUBCg5GaXNoQ2FzdFJvZFJlcRIiCgNwb3MYCyABKAsyFS5taUhv",
            "bW8uUHJvdG9zLlZlY3RvchIVCg1yb2RfZW50aXR5X2lkGAggASgNEhsKE1Vu",
            "azMzMDBfSUNBTEVJQkpDREEYDSABKA0SGwoTVW5rMzMwMF9QSkZIRURERk9C",
            "TRgHIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FishCastRodReq), global::MiHomo.Protos.FishCastRodReq.Parser, new[]{ "Pos", "RodEntityId", "Unk3300ICALEIBJCDA", "Unk3300PJFHEDDFOBM" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FishCastRodReq : pb::IMessage<FishCastRodReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishCastRodReq> _parser = new pb::MessageParser<FishCastRodReq>(() => new FishCastRodReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishCastRodReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FishCastRodReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishCastRodReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishCastRodReq(FishCastRodReq other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      rodEntityId_ = other.rodEntityId_;
      unk3300ICALEIBJCDA_ = other.unk3300ICALEIBJCDA_;
      unk3300PJFHEDDFOBM_ = other.unk3300PJFHEDDFOBM_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishCastRodReq Clone() {
      return new FishCastRodReq(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 11;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "rod_entity_id" field.</summary>
    public const int RodEntityIdFieldNumber = 8;
    private uint rodEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RodEntityId {
      get { return rodEntityId_; }
      set {
        rodEntityId_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ICALEIBJCDA" field.</summary>
    public const int Unk3300ICALEIBJCDAFieldNumber = 13;
    private uint unk3300ICALEIBJCDA_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300ICALEIBJCDA {
      get { return unk3300ICALEIBJCDA_; }
      set {
        unk3300ICALEIBJCDA_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PJFHEDDFOBM" field.</summary>
    public const int Unk3300PJFHEDDFOBMFieldNumber = 7;
    private uint unk3300PJFHEDDFOBM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300PJFHEDDFOBM {
      get { return unk3300PJFHEDDFOBM_; }
      set {
        unk3300PJFHEDDFOBM_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishCastRodReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishCastRodReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (RodEntityId != other.RodEntityId) return false;
      if (Unk3300ICALEIBJCDA != other.Unk3300ICALEIBJCDA) return false;
      if (Unk3300PJFHEDDFOBM != other.Unk3300PJFHEDDFOBM) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (RodEntityId != 0) hash ^= RodEntityId.GetHashCode();
      if (Unk3300ICALEIBJCDA != 0) hash ^= Unk3300ICALEIBJCDA.GetHashCode();
      if (Unk3300PJFHEDDFOBM != 0) hash ^= Unk3300PJFHEDDFOBM.GetHashCode();
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
      if (Unk3300PJFHEDDFOBM != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300PJFHEDDFOBM);
      }
      if (RodEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RodEntityId);
      }
      if (pos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Pos);
      }
      if (Unk3300ICALEIBJCDA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300ICALEIBJCDA);
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
      if (Unk3300PJFHEDDFOBM != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Unk3300PJFHEDDFOBM);
      }
      if (RodEntityId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RodEntityId);
      }
      if (pos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Pos);
      }
      if (Unk3300ICALEIBJCDA != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Unk3300ICALEIBJCDA);
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
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (RodEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RodEntityId);
      }
      if (Unk3300ICALEIBJCDA != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300ICALEIBJCDA);
      }
      if (Unk3300PJFHEDDFOBM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300PJFHEDDFOBM);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishCastRodReq other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.RodEntityId != 0) {
        RodEntityId = other.RodEntityId;
      }
      if (other.Unk3300ICALEIBJCDA != 0) {
        Unk3300ICALEIBJCDA = other.Unk3300ICALEIBJCDA;
      }
      if (other.Unk3300PJFHEDDFOBM != 0) {
        Unk3300PJFHEDDFOBM = other.Unk3300PJFHEDDFOBM;
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
            Unk3300PJFHEDDFOBM = input.ReadUInt32();
            break;
          }
          case 64: {
            RodEntityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 104: {
            Unk3300ICALEIBJCDA = input.ReadUInt32();
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
            Unk3300PJFHEDDFOBM = input.ReadUInt32();
            break;
          }
          case 64: {
            RodEntityId = input.ReadUInt32();
            break;
          }
          case 90: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 104: {
            Unk3300ICALEIBJCDA = input.ReadUInt32();
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
