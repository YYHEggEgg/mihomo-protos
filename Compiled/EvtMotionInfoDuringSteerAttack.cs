// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtMotionInfoDuringSteerAttack.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EvtMotionInfoDuringSteerAttack.proto</summary>
  public static partial class EvtMotionInfoDuringSteerAttackReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtMotionInfoDuringSteerAttack.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtMotionInfoDuringSteerAttackReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRFdnRNb3Rpb25JbmZvRHVyaW5nU3RlZXJBdHRhY2sucHJvdG8SDW1pSG9t",
            "by5Qcm90b3MaDFZlY3Rvci5wcm90byKpAQoeRXZ0TW90aW9uSW5mb0R1cmlu",
            "Z1N0ZWVyQXR0YWNrEhEKCWVudGl0eV9pZBgEIAEoDRInCghmYWNlX2RpchgP",
            "IAEoCzIVLm1pSG9tby5Qcm90b3MuVmVjdG9yEiIKA3BvcxgIIAEoCzIVLm1p",
            "SG9tby5Qcm90b3MuVmVjdG9yEicKCHZlbG9jaXR5GA4gASgLMhUubWlIb21v",
            "LlByb3Rvcy5WZWN0b3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EvtMotionInfoDuringSteerAttack), global::MiHomo.Protos.EvtMotionInfoDuringSteerAttack.Parser, new[]{ "EntityId", "FaceDir", "Pos", "Velocity" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EvtMotionInfoDuringSteerAttack : pb::IMessage<EvtMotionInfoDuringSteerAttack>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtMotionInfoDuringSteerAttack> _parser = new pb::MessageParser<EvtMotionInfoDuringSteerAttack>(() => new EvtMotionInfoDuringSteerAttack());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtMotionInfoDuringSteerAttack> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EvtMotionInfoDuringSteerAttackReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtMotionInfoDuringSteerAttack() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtMotionInfoDuringSteerAttack(EvtMotionInfoDuringSteerAttack other) : this() {
      entityId_ = other.entityId_;
      faceDir_ = other.faceDir_ != null ? other.faceDir_.Clone() : null;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      velocity_ = other.velocity_ != null ? other.velocity_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtMotionInfoDuringSteerAttack Clone() {
      return new EvtMotionInfoDuringSteerAttack(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 4;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "face_dir" field.</summary>
    public const int FaceDirFieldNumber = 15;
    private global::MiHomo.Protos.Vector faceDir_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector FaceDir {
      get { return faceDir_; }
      set {
        faceDir_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 8;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "velocity" field.</summary>
    public const int VelocityFieldNumber = 14;
    private global::MiHomo.Protos.Vector velocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Velocity {
      get { return velocity_; }
      set {
        velocity_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtMotionInfoDuringSteerAttack);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtMotionInfoDuringSteerAttack other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(FaceDir, other.FaceDir)) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (!object.Equals(Velocity, other.Velocity)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (faceDir_ != null) hash ^= FaceDir.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (velocity_ != null) hash ^= Velocity.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (pos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Pos);
      }
      if (velocity_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Velocity);
      }
      if (faceDir_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FaceDir);
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
      if (EntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(EntityId);
      }
      if (pos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Pos);
      }
      if (velocity_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Velocity);
      }
      if (faceDir_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(FaceDir);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (faceDir_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FaceDir);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (velocity_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Velocity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtMotionInfoDuringSteerAttack other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.faceDir_ != null) {
        if (faceDir_ == null) {
          FaceDir = new global::MiHomo.Protos.Vector();
        }
        FaceDir.MergeFrom(other.FaceDir);
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.velocity_ != null) {
        if (velocity_ == null) {
          Velocity = new global::MiHomo.Protos.Vector();
        }
        Velocity.MergeFrom(other.Velocity);
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
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 114: {
            if (velocity_ == null) {
              Velocity = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 122: {
            if (faceDir_ == null) {
              FaceDir = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(FaceDir);
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
          case 32: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 114: {
            if (velocity_ == null) {
              Velocity = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Velocity);
            break;
          }
          case 122: {
            if (faceDir_ == null) {
              FaceDir = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(FaceDir);
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
