// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryHandballInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SceneGalleryHandballInfo.proto</summary>
  public static partial class SceneGalleryHandballInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryHandballInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryHandballInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5TY2VuZUdhbGxlcnlIYW5kYmFsbEluZm8ucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaD1BsYWNlSW5mby5wcm90byJjChhTY2VuZUdhbGxlcnlIYW5kYmFsbElu",
            "Zm8SMQoPYmFsbF9wbGFjZV9pbmZvGAkgASgLMhgubWlIb21vLlByb3Rvcy5Q",
            "bGFjZUluZm8SFAoMaXNfaGF2ZV9iYWxsGA8gASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.PlaceInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SceneGalleryHandballInfo), global::MiHomo.Protos.SceneGalleryHandballInfo.Parser, new[]{ "BallPlaceInfo", "IsHaveBall" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryHandballInfo : pb::IMessage<SceneGalleryHandballInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryHandballInfo> _parser = new pb::MessageParser<SceneGalleryHandballInfo>(() => new SceneGalleryHandballInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryHandballInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SceneGalleryHandballInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryHandballInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryHandballInfo(SceneGalleryHandballInfo other) : this() {
      ballPlaceInfo_ = other.ballPlaceInfo_ != null ? other.ballPlaceInfo_.Clone() : null;
      isHaveBall_ = other.isHaveBall_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryHandballInfo Clone() {
      return new SceneGalleryHandballInfo(this);
    }

    /// <summary>Field number for the "ball_place_info" field.</summary>
    public const int BallPlaceInfoFieldNumber = 9;
    private global::MiHomo.Protos.PlaceInfo ballPlaceInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.PlaceInfo BallPlaceInfo {
      get { return ballPlaceInfo_; }
      set {
        ballPlaceInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_have_ball" field.</summary>
    public const int IsHaveBallFieldNumber = 15;
    private bool isHaveBall_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsHaveBall {
      get { return isHaveBall_; }
      set {
        isHaveBall_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryHandballInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryHandballInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BallPlaceInfo, other.BallPlaceInfo)) return false;
      if (IsHaveBall != other.IsHaveBall) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ballPlaceInfo_ != null) hash ^= BallPlaceInfo.GetHashCode();
      if (IsHaveBall != false) hash ^= IsHaveBall.GetHashCode();
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
      if (ballPlaceInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BallPlaceInfo);
      }
      if (IsHaveBall != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsHaveBall);
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
      if (ballPlaceInfo_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BallPlaceInfo);
      }
      if (IsHaveBall != false) {
        output.WriteRawTag(120);
        output.WriteBool(IsHaveBall);
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
      if (ballPlaceInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BallPlaceInfo);
      }
      if (IsHaveBall != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryHandballInfo other) {
      if (other == null) {
        return;
      }
      if (other.ballPlaceInfo_ != null) {
        if (ballPlaceInfo_ == null) {
          BallPlaceInfo = new global::MiHomo.Protos.PlaceInfo();
        }
        BallPlaceInfo.MergeFrom(other.BallPlaceInfo);
      }
      if (other.IsHaveBall != false) {
        IsHaveBall = other.IsHaveBall;
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
          case 74: {
            if (ballPlaceInfo_ == null) {
              BallPlaceInfo = new global::MiHomo.Protos.PlaceInfo();
            }
            input.ReadMessage(BallPlaceInfo);
            break;
          }
          case 120: {
            IsHaveBall = input.ReadBool();
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
          case 74: {
            if (ballPlaceInfo_ == null) {
              BallPlaceInfo = new global::MiHomo.Protos.PlaceInfo();
            }
            input.ReadMessage(BallPlaceInfo);
            break;
          }
          case 120: {
            IsHaveBall = input.ReadBool();
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
