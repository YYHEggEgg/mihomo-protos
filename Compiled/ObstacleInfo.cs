// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ObstacleInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ObstacleInfo.proto</summary>
  public static partial class ObstacleInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ObstacleInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ObstacleInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJPYnN0YWNsZUluZm8ucHJvdG8SDW1pSG9tby5Qcm90b3MaFE1hdGhRdWF0",
            "ZXJuaW9uLnByb3RvGgxWZWN0b3IucHJvdG8aEFZlY3RvcjNJbnQucHJvdG8i",
            "tAIKDE9ic3RhY2xlSW5mbxIlCgZjZW50ZXIYByABKAsyFS5taUhvbW8uUHJv",
            "dG9zLlZlY3RvchIqCgdleHRlbnRzGAQgASgLMhkubWlIb21vLlByb3Rvcy5W",
            "ZWN0b3IzSW50EhMKC29ic3RhY2xlX2lkGAogASgFEi8KCHJvdGF0aW9uGAsg",
            "ASgLMh0ubWlIb21vLlByb3Rvcy5NYXRoUXVhdGVybmlvbhI0CgVzaGFwZRgC",
            "IAEoDjIlLm1pSG9tby5Qcm90b3MuT2JzdGFjbGVJbmZvLlNoYXBlVHlwZSJV",
            "CglTaGFwZVR5cGUSJQohU0hBUEVfVFlQRV9PQlNUQUNMRV9TSEFQRV9DQVBT",
            "VUxFEAASIQodU0hBUEVfVFlQRV9PQlNUQUNMRV9TSEFQRV9CT1gQAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.MathQuaternionReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, global::MiHomo.Protos.Vector3IntReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ObstacleInfo), global::MiHomo.Protos.ObstacleInfo.Parser, new[]{ "Center", "Extents", "ObstacleId", "Rotation", "Shape" }, null, new[]{ typeof(global::MiHomo.Protos.ObstacleInfo.Types.ShapeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ObstacleInfo : pb::IMessage<ObstacleInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ObstacleInfo> _parser = new pb::MessageParser<ObstacleInfo>(() => new ObstacleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ObstacleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ObstacleInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObstacleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObstacleInfo(ObstacleInfo other) : this() {
      center_ = other.center_ != null ? other.center_.Clone() : null;
      extents_ = other.extents_ != null ? other.extents_.Clone() : null;
      obstacleId_ = other.obstacleId_;
      rotation_ = other.rotation_ != null ? other.rotation_.Clone() : null;
      shape_ = other.shape_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObstacleInfo Clone() {
      return new ObstacleInfo(this);
    }

    /// <summary>Field number for the "center" field.</summary>
    public const int CenterFieldNumber = 7;
    private global::MiHomo.Protos.Vector center_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Center {
      get { return center_; }
      set {
        center_ = value;
      }
    }

    /// <summary>Field number for the "extents" field.</summary>
    public const int ExtentsFieldNumber = 4;
    private global::MiHomo.Protos.Vector3Int extents_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector3Int Extents {
      get { return extents_; }
      set {
        extents_ = value;
      }
    }

    /// <summary>Field number for the "obstacle_id" field.</summary>
    public const int ObstacleIdFieldNumber = 10;
    private int obstacleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int ObstacleId {
      get { return obstacleId_; }
      set {
        obstacleId_ = value;
      }
    }

    /// <summary>Field number for the "rotation" field.</summary>
    public const int RotationFieldNumber = 11;
    private global::MiHomo.Protos.MathQuaternion rotation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.MathQuaternion Rotation {
      get { return rotation_; }
      set {
        rotation_ = value;
      }
    }

    /// <summary>Field number for the "shape" field.</summary>
    public const int ShapeFieldNumber = 2;
    private global::MiHomo.Protos.ObstacleInfo.Types.ShapeType shape_ = global::MiHomo.Protos.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ObstacleInfo.Types.ShapeType Shape {
      get { return shape_; }
      set {
        shape_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ObstacleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ObstacleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Center, other.Center)) return false;
      if (!object.Equals(Extents, other.Extents)) return false;
      if (ObstacleId != other.ObstacleId) return false;
      if (!object.Equals(Rotation, other.Rotation)) return false;
      if (Shape != other.Shape) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (center_ != null) hash ^= Center.GetHashCode();
      if (extents_ != null) hash ^= Extents.GetHashCode();
      if (ObstacleId != 0) hash ^= ObstacleId.GetHashCode();
      if (rotation_ != null) hash ^= Rotation.GetHashCode();
      if (Shape != global::MiHomo.Protos.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) hash ^= Shape.GetHashCode();
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
      if (Shape != global::MiHomo.Protos.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Shape);
      }
      if (extents_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extents);
      }
      if (center_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Center);
      }
      if (ObstacleId != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(ObstacleId);
      }
      if (rotation_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Rotation);
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
      if (Shape != global::MiHomo.Protos.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Shape);
      }
      if (extents_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Extents);
      }
      if (center_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Center);
      }
      if (ObstacleId != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(ObstacleId);
      }
      if (rotation_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Rotation);
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
      if (extents_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Extents);
      }
      if (ObstacleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObstacleId);
      }
      if (rotation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rotation);
      }
      if (Shape != global::MiHomo.Protos.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Shape);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ObstacleInfo other) {
      if (other == null) {
        return;
      }
      if (other.center_ != null) {
        if (center_ == null) {
          Center = new global::MiHomo.Protos.Vector();
        }
        Center.MergeFrom(other.Center);
      }
      if (other.extents_ != null) {
        if (extents_ == null) {
          Extents = new global::MiHomo.Protos.Vector3Int();
        }
        Extents.MergeFrom(other.Extents);
      }
      if (other.ObstacleId != 0) {
        ObstacleId = other.ObstacleId;
      }
      if (other.rotation_ != null) {
        if (rotation_ == null) {
          Rotation = new global::MiHomo.Protos.MathQuaternion();
        }
        Rotation.MergeFrom(other.Rotation);
      }
      if (other.Shape != global::MiHomo.Protos.ObstacleInfo.Types.ShapeType.ObstacleShapeCapsule) {
        Shape = other.Shape;
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
            Shape = (global::MiHomo.Protos.ObstacleInfo.Types.ShapeType) input.ReadEnum();
            break;
          }
          case 34: {
            if (extents_ == null) {
              Extents = new global::MiHomo.Protos.Vector3Int();
            }
            input.ReadMessage(Extents);
            break;
          }
          case 58: {
            if (center_ == null) {
              Center = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 80: {
            ObstacleId = input.ReadInt32();
            break;
          }
          case 90: {
            if (rotation_ == null) {
              Rotation = new global::MiHomo.Protos.MathQuaternion();
            }
            input.ReadMessage(Rotation);
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
            Shape = (global::MiHomo.Protos.ObstacleInfo.Types.ShapeType) input.ReadEnum();
            break;
          }
          case 34: {
            if (extents_ == null) {
              Extents = new global::MiHomo.Protos.Vector3Int();
            }
            input.ReadMessage(Extents);
            break;
          }
          case 58: {
            if (center_ == null) {
              Center = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Center);
            break;
          }
          case 80: {
            ObstacleId = input.ReadInt32();
            break;
          }
          case 90: {
            if (rotation_ == null) {
              Rotation = new global::MiHomo.Protos.MathQuaternion();
            }
            input.ReadMessage(Rotation);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ObstacleInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum ShapeType {
        [pbr::OriginalName("SHAPE_TYPE_OBSTACLE_SHAPE_CAPSULE")] ObstacleShapeCapsule = 0,
        [pbr::OriginalName("SHAPE_TYPE_OBSTACLE_SHAPE_BOX")] ObstacleShapeBox = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
