// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ToTheMoonObstacleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ToTheMoonObstacleInfo.proto</summary>
  public static partial class ToTheMoonObstacleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ToTheMoonObstacleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ToTheMoonObstacleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtUb1RoZU1vb25PYnN0YWNsZUluZm8ucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "FE1hdGhRdWF0ZXJuaW9uLnByb3RvGgxWZWN0b3IucHJvdG8irgIKFVRvVGhl",
            "TW9vbk9ic3RhY2xlSW5mbxIlCgZjZW50ZXIYDSABKAsyFS5taUhvbW8uUHJv",
            "dG9zLlZlY3RvchIrCgxoYWxmX2V4dGVudHMYDiABKAsyFS5taUhvbW8uUHJv",
            "dG9zLlZlY3RvchIRCgloYW5kbGVfaWQYCyABKAUSLwoIcm90YXRpb24YByAB",
            "KAsyHS5taUhvbW8uUHJvdG9zLk1hdGhRdWF0ZXJuaW9uEjwKBHR5cGUYAiAB",
            "KA4yLi5taUhvbW8uUHJvdG9zLlRvVGhlTW9vbk9ic3RhY2xlSW5mby5TaGFw",
            "ZVR5cGUiPwoJU2hhcGVUeXBlEhoKFk9CU1RBQ0xFX1NIQVBFX0NBUFNVTEUQ",
            "ABIWChJPQlNUQUNMRV9TSEFQRV9CT1gQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.MathQuaternionReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ToTheMoonObstacleInfo), global::MiHomo.Protos.ToTheMoonObstacleInfo.Parser, new[]{ "Center", "HalfExtents", "HandleId", "Rotation", "Type" }, null, new[]{ typeof(global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ToTheMoonObstacleInfo : pb::IMessage<ToTheMoonObstacleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ToTheMoonObstacleInfo> _parser = new pb::MessageParser<ToTheMoonObstacleInfo>(() => new ToTheMoonObstacleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ToTheMoonObstacleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ToTheMoonObstacleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonObstacleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonObstacleInfo(ToTheMoonObstacleInfo other) : this() {
      center_ = other.center_ != null ? other.center_.Clone() : null;
      halfExtents_ = other.halfExtents_ != null ? other.halfExtents_.Clone() : null;
      handleId_ = other.handleId_;
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonObstacleInfo Clone() {
      return new ToTheMoonObstacleInfo(this);
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 13;
    private global::MiHomo.Protos.Vector center_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "half_extents" field.</summary>
    public const int HalfExtentsFieldNumber = 14;
    private global::MiHomo.Protos.Vector halfExtents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector HalfExtents {
      get { return halfExtents_; }
      set {
        halfExtents_ = value;
      }
    }

    /// <summary>Field number for the "handle_id" field.</summary>
    public const int HandleIdFieldNumber = 11;
    private int handleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int HandleId {
      get { return handleId_; }
      set {
        handleId_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 7;
    private global::MiHomo.Protos.MathQuaternion rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.MathQuaternion Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType type_ = global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType.ObstacleShapeCapsule;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ToTheMoonObstacleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ToTheMoonObstacleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Center, other.Center)) return false;
      if (!object.Equals(HalfExtents, other.HalfExtents)) return false;
      if (HandleId != other.HandleId) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (center_ != null) hash ^= Center.GetHashCode();
      if (halfExtents_ != null) hash ^= HalfExtents.GetHashCode();
      if (HandleId != 0) hash ^= HandleId.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (Type != global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) hash ^= Type.GetHashCode();
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
      if (Type != global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (rotation_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Rotation);
      }
      if (HandleId != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(HandleId);
      }
      if (center_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Center);
      }
      if (halfExtents_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(HalfExtents);
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
      if (Type != global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (rotation_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Rotation);
      }
      if (HandleId != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(HandleId);
      }
      if (center_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(Center);
      }
      if (halfExtents_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(HalfExtents);
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
      if (center_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Center);
      }
      if (halfExtents_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(HalfExtents);
      }
      if (HandleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(HandleId);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (Type != global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ToTheMoonObstacleInfo other) {
      if (other == null) {
        return;
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::MiHomo.Protos.Vector();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.halfExtents_ != null) {
        if (halfExtents_ == null) {
          HalfExtents = new global::MiHomo.Protos.Vector();
        }
        HalfExtents.MergeFrom(other.HalfExtents);
      }
      if (other.HandleId != 0) {
        HandleId = other.HandleId;
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::MiHomo.Protos.MathQuaternion();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      if (other.Type != global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        Type = other.Type;
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
          case 16: {
            Type = (global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType) input.ReadEnum();
            break;
          }
          case 58: {
            if (rotation_ == null) {
              Rotation = new global::MiHomo.Protos.MathQuaternion();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 88: {
            HandleId = input.ReadInt32();
            break;
          }
          case 106: {
            if (center_ == null) {
              Center = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 114: {
            if (halfExtents_ == null) {
              HalfExtents = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(HalfExtents);
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
          case 16: {
            Type = (global::MiHomo.Protos.ToTheMoonObstacleInfo.Types.ShapeType) input.ReadEnum();
            break;
          }
          case 58: {
            if (rotation_ == null) {
              Rotation = new global::MiHomo.Protos.MathQuaternion();
            }
            input.ReadMessage(Rotation);
            break;
          }
          case 88: {
            HandleId = input.ReadInt32();
            break;
          }
          case 106: {
            if (center_ == null) {
              Center = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 114: {
            if (halfExtents_ == null) {
              HalfExtents = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(HalfExtents);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ToTheMoonObstacleInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ShapeType {
        [pbr::OriginalName("OBSTACLE_SHAPE_CAPSULE")] ObstacleShapeCapsule = 0,
        [pbr::OriginalName("OBSTACLE_SHAPE_BOX")] ObstacleShapeBox = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
