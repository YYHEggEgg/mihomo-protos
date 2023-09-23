// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MotionInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MotionInfo.proto</summary>
  public static partial class MotionInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for MotionInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MotionInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBNb3Rpb25JbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zGhFNb3Rpb25TdGF0",
            "ZS5wcm90bxoMVmVjdG9yLnByb3RvIrMCCgpNb3Rpb25JbmZvEhkKEWludGVy",
            "dmFsX3ZlbG9jaXR5GAkgASgEEiUKBnBhcmFtcxgFIAMoCzIVLm1pSG9tby5Q",
            "cm90b3MuVmVjdG9yEiIKA3BvcxgBIAEoCzIVLm1pSG9tby5Qcm90b3MuVmVj",
            "dG9yEg4KBnJlZl9pZBgHIAEoDRImCgdyZWZfcG9zGAYgASgLMhUubWlIb21v",
            "LlByb3Rvcy5WZWN0b3ISIgoDcm90GAIgASgLMhUubWlIb21vLlByb3Rvcy5W",
            "ZWN0b3ISEgoKc2NlbmVfdGltZRgIIAEoDRIkCgVzcGVlZBgDIAEoCzIVLm1p",
            "SG9tby5Qcm90b3MuVmVjdG9yEikKBXN0YXRlGAQgASgOMhoubWlIb21vLlBy",
            "b3Rvcy5Nb3Rpb25TdGF0ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.MotionStateReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MotionInfo), global::MiHomo.Protos.MotionInfo.Parser, new[]{ "IntervalVelocity", "Params", "Pos", "RefId", "RefPos", "Rot", "SceneTime", "Speed", "State" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MotionInfo : pb::IMessage<MotionInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MotionInfo> _parser = new pb::MessageParser<MotionInfo>(() => new MotionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MotionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MotionInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MotionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MotionInfo(MotionInfo other) : this() {
      intervalVelocity_ = other.intervalVelocity_;
      params_ = other.params_.Clone();
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      refId_ = other.refId_;
      refPos_ = other.refPos_ != null ? other.refPos_.Clone() : null;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      sceneTime_ = other.sceneTime_;
      speed_ = other.speed_ != null ? other.speed_.Clone() : null;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MotionInfo Clone() {
      return new MotionInfo(this);
    }

    /// <summary>Field number for the "interval_velocity" field.</summary>
    public const int IntervalVelocityFieldNumber = 9;
    private ulong intervalVelocity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong IntervalVelocity {
      get { return intervalVelocity_; }
      set {
        intervalVelocity_ = value;
      }
    }

    /// <summary>Field number for the "params" field.</summary>
    public const int ParamsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.Vector> _repeated_params_codec
        = pb::FieldCodec.ForMessage(42, global::MiHomo.Protos.Vector.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.Vector> params_ = new pbc::RepeatedField<global::MiHomo.Protos.Vector>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.Vector> Params {
      get { return params_; }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 1;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "ref_id" field.</summary>
    public const int RefIdFieldNumber = 7;
    private uint refId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RefId {
      get { return refId_; }
      set {
        refId_ = value;
      }
    }

    /// <summary>Field number for the "ref_pos" field.</summary>
    public const int RefPosFieldNumber = 6;
    private global::MiHomo.Protos.Vector refPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector RefPos {
      get { return refPos_; }
      set {
        refPos_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 2;
    private global::MiHomo.Protos.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    /// <summary>Field number for the "scene_time" field.</summary>
    public const int SceneTimeFieldNumber = 8;
    private uint sceneTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SceneTime {
      get { return sceneTime_; }
      set {
        sceneTime_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 3;
    private global::MiHomo.Protos.Vector speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::MiHomo.Protos.MotionState state_ = global::MiHomo.Protos.MotionState.MotionNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.MotionState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MotionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MotionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IntervalVelocity != other.IntervalVelocity) return false;
      if(!params_.Equals(other.params_)) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (RefId != other.RefId) return false;
      if (!object.Equals(RefPos, other.RefPos)) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      if (SceneTime != other.SceneTime) return false;
      if (!object.Equals(Speed, other.Speed)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IntervalVelocity != 0UL) hash ^= IntervalVelocity.GetHashCode();
      hash ^= params_.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (RefId != 0) hash ^= RefId.GetHashCode();
      if (refPos_ != null) hash ^= RefPos.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
      if (SceneTime != 0) hash ^= SceneTime.GetHashCode();
      if (speed_ != null) hash ^= Speed.GetHashCode();
      if (State != global::MiHomo.Protos.MotionState.MotionNone) hash ^= State.GetHashCode();
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
      if (pos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pos);
      }
      if (rot_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rot);
      }
      if (speed_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Speed);
      }
      if (State != global::MiHomo.Protos.MotionState.MotionNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      params_.WriteTo(output, _repeated_params_codec);
      if (refPos_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RefPos);
      }
      if (RefId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RefId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SceneTime);
      }
      if (IntervalVelocity != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(IntervalVelocity);
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
      if (pos_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pos);
      }
      if (rot_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Rot);
      }
      if (speed_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Speed);
      }
      if (State != global::MiHomo.Protos.MotionState.MotionNone) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
      }
      params_.WriteTo(ref output, _repeated_params_codec);
      if (refPos_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(RefPos);
      }
      if (RefId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(RefId);
      }
      if (SceneTime != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SceneTime);
      }
      if (IntervalVelocity != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(IntervalVelocity);
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
      if (IntervalVelocity != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(IntervalVelocity);
      }
      size += params_.CalculateSize(_repeated_params_codec);
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (RefId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RefId);
      }
      if (refPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RefPos);
      }
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
      }
      if (SceneTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SceneTime);
      }
      if (speed_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Speed);
      }
      if (State != global::MiHomo.Protos.MotionState.MotionNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MotionInfo other) {
      if (other == null) {
        return;
      }
      if (other.IntervalVelocity != 0UL) {
        IntervalVelocity = other.IntervalVelocity;
      }
      params_.Add(other.params_);
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.RefId != 0) {
        RefId = other.RefId;
      }
      if (other.refPos_ != null) {
        if (refPos_ == null) {
          RefPos = new global::MiHomo.Protos.Vector();
        }
        RefPos.MergeFrom(other.RefPos);
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::MiHomo.Protos.Vector();
        }
        Rot.MergeFrom(other.Rot);
      }
      if (other.SceneTime != 0) {
        SceneTime = other.SceneTime;
      }
      if (other.speed_ != null) {
        if (speed_ == null) {
          Speed = new global::MiHomo.Protos.Vector();
        }
        Speed.MergeFrom(other.Speed);
      }
      if (other.State != global::MiHomo.Protos.MotionState.MotionNone) {
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
          case 10: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 18: {
            if (rot_ == null) {
              Rot = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 26: {
            if (speed_ == null) {
              Speed = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Speed);
            break;
          }
          case 32: {
            State = (global::MiHomo.Protos.MotionState) input.ReadEnum();
            break;
          }
          case 42: {
            params_.AddEntriesFrom(input, _repeated_params_codec);
            break;
          }
          case 50: {
            if (refPos_ == null) {
              RefPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(RefPos);
            break;
          }
          case 56: {
            RefId = input.ReadUInt32();
            break;
          }
          case 64: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 72: {
            IntervalVelocity = input.ReadUInt64();
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
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 18: {
            if (rot_ == null) {
              Rot = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 26: {
            if (speed_ == null) {
              Speed = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Speed);
            break;
          }
          case 32: {
            State = (global::MiHomo.Protos.MotionState) input.ReadEnum();
            break;
          }
          case 42: {
            params_.AddEntriesFrom(ref input, _repeated_params_codec);
            break;
          }
          case 50: {
            if (refPos_ == null) {
              RefPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(RefPos);
            break;
          }
          case 56: {
            RefId = input.ReadUInt32();
            break;
          }
          case 64: {
            SceneTime = input.ReadUInt32();
            break;
          }
          case 72: {
            IntervalVelocity = input.ReadUInt64();
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
