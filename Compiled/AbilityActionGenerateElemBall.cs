// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityActionGenerateElemBall.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AbilityActionGenerateElemBall.proto</summary>
  public static partial class AbilityActionGenerateElemBallReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityActionGenerateElemBall.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityActionGenerateElemBallReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNBYmlsaXR5QWN0aW9uR2VuZXJhdGVFbGVtQmFsbC5wcm90bxINbWlIb21v",
            "LlByb3RvcxoMVmVjdG9yLnByb3RvIngKHUFiaWxpdHlBY3Rpb25HZW5lcmF0",
            "ZUVsZW1CYWxsEiIKA3BvcxgOIAEoCzIVLm1pSG9tby5Qcm90b3MuVmVjdG9y",
            "Eg8KB3Jvb21faWQYCCABKA0SIgoDcm90GAEgASgLMhUubWlIb21vLlByb3Rv",
            "cy5WZWN0b3JiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AbilityActionGenerateElemBall), global::MiHomo.Protos.AbilityActionGenerateElemBall.Parser, new[]{ "Pos", "RoomId", "Rot" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityActionGenerateElemBall : pb::IMessage<AbilityActionGenerateElemBall>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityActionGenerateElemBall> _parser = new pb::MessageParser<AbilityActionGenerateElemBall>(() => new AbilityActionGenerateElemBall());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityActionGenerateElemBall> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AbilityActionGenerateElemBallReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityActionGenerateElemBall() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityActionGenerateElemBall(AbilityActionGenerateElemBall other) : this() {
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      roomId_ = other.roomId_;
      rot_ = other.rot_ != null ? other.rot_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityActionGenerateElemBall Clone() {
      return new AbilityActionGenerateElemBall(this);
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 14;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "room_id" field.</summary>
    public const int RoomIdFieldNumber = 8;
    private uint roomId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RoomId {
      get { return roomId_; }
      set {
        roomId_ = value;
      }
    }

    /// <summary>Field number for the "rot" field.</summary>
    public const int RotFieldNumber = 1;
    private global::MiHomo.Protos.Vector rot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Rot {
      get { return rot_; }
      set {
        rot_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityActionGenerateElemBall);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityActionGenerateElemBall other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pos, other.Pos)) return false;
      if (RoomId != other.RoomId) return false;
      if (!object.Equals(Rot, other.Rot)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (RoomId != 0) hash ^= RoomId.GetHashCode();
      if (rot_ != null) hash ^= Rot.GetHashCode();
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
      if (rot_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Rot);
      }
      if (RoomId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RoomId);
      }
      if (pos_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Pos);
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
      if (rot_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Rot);
      }
      if (RoomId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(RoomId);
      }
      if (pos_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(Pos);
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
      if (RoomId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RoomId);
      }
      if (rot_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rot);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityActionGenerateElemBall other) {
      if (other == null) {
        return;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.RoomId != 0) {
        RoomId = other.RoomId;
      }
      if (other.rot_ != null) {
        if (rot_ == null) {
          Rot = new global::MiHomo.Protos.Vector();
        }
        Rot.MergeFrom(other.Rot);
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
            if (rot_ == null) {
              Rot = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 64: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 114: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
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
            if (rot_ == null) {
              Rot = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Rot);
            break;
          }
          case 64: {
            RoomId = input.ReadUInt32();
            break;
          }
          case 114: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
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
