// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryBalloonScoreNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GalleryBalloonScoreNotify.proto</summary>
  public static partial class GalleryBalloonScoreNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryBalloonScoreNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryBalloonScoreNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9HYWxsZXJ5QmFsbG9vblNjb3JlTm90aWZ5LnByb3RvEg1taUhvbW8uUHJv",
            "dG9zIrUBChlHYWxsZXJ5QmFsbG9vblNjb3JlTm90aWZ5EhIKCmdhbGxlcnlf",
            "aWQYCyABKA0SUAoNdWlkX3Njb3JlX21hcBgMIAMoCzI5Lm1pSG9tby5Qcm90",
            "b3MuR2FsbGVyeUJhbGxvb25TY29yZU5vdGlmeS5VaWRTY29yZU1hcEVudHJ5",
            "GjIKEFVpZFNjb3JlTWFwRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIg",
            "ASgNOgI4AWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GalleryBalloonScoreNotify), global::MiHomo.Protos.GalleryBalloonScoreNotify.Parser, new[]{ "GalleryId", "UidScoreMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GalleryBalloonScoreNotify : pb::IMessage<GalleryBalloonScoreNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GalleryBalloonScoreNotify> _parser = new pb::MessageParser<GalleryBalloonScoreNotify>(() => new GalleryBalloonScoreNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GalleryBalloonScoreNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GalleryBalloonScoreNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryBalloonScoreNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryBalloonScoreNotify(GalleryBalloonScoreNotify other) : this() {
      galleryId_ = other.galleryId_;
      uidScoreMap_ = other.uidScoreMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryBalloonScoreNotify Clone() {
      return new GalleryBalloonScoreNotify(this);
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 11;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "uid_score_map" field.</summary>
    public const int UidScoreMapFieldNumber = 12;
    private static readonly pbc::MapField<uint, uint>.Codec _map_uidScoreMap_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 98);
    private readonly pbc::MapField<uint, uint> uidScoreMap_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> UidScoreMap {
      get { return uidScoreMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GalleryBalloonScoreNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GalleryBalloonScoreNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GalleryId != other.GalleryId) return false;
      if (!UidScoreMap.Equals(other.UidScoreMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      hash ^= UidScoreMap.GetHashCode();
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
      if (GalleryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryId);
      }
      uidScoreMap_.WriteTo(output, _map_uidScoreMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (GalleryId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(GalleryId);
      }
      uidScoreMap_.WriteTo(ref output, _map_uidScoreMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      size += uidScoreMap_.CalculateSize(_map_uidScoreMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GalleryBalloonScoreNotify other) {
      if (other == null) {
        return;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      uidScoreMap_.Add(other.uidScoreMap_);
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
          case 88: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 98: {
            uidScoreMap_.AddEntriesFrom(input, _map_uidScoreMap_codec);
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
          case 88: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 98: {
            uidScoreMap_.AddEntriesFrom(ref input, _map_uidScoreMap_codec);
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
