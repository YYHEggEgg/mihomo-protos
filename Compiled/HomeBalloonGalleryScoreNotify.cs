// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBalloonGalleryScoreNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeBalloonGalleryScoreNotify.proto</summary>
  public static partial class HomeBalloonGalleryScoreNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBalloonGalleryScoreNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBalloonGalleryScoreNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIb21lQmFsbG9vbkdhbGxlcnlTY29yZU5vdGlmeS5wcm90bxINbWlIb21v",
            "LlByb3RvcyJ0Ch1Ib21lQmFsbG9vbkdhbGxlcnlTY29yZU5vdGlmeRIRCglh",
            "ZGRfc2NvcmUYBCABKA0SEQoJY3VyX3Njb3JlGA4gASgNEhIKCmdhbGxlcnlf",
            "aWQYASABKA0SGQoRdHJpZ2dlcl9lbnRpdHlfaWQYAyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeBalloonGalleryScoreNotify), global::MiHomo.Protos.HomeBalloonGalleryScoreNotify.Parser, new[]{ "AddScore", "CurScore", "GalleryId", "TriggerEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBalloonGalleryScoreNotify : pb::IMessage<HomeBalloonGalleryScoreNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBalloonGalleryScoreNotify> _parser = new pb::MessageParser<HomeBalloonGalleryScoreNotify>(() => new HomeBalloonGalleryScoreNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBalloonGalleryScoreNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeBalloonGalleryScoreNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBalloonGalleryScoreNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBalloonGalleryScoreNotify(HomeBalloonGalleryScoreNotify other) : this() {
      addScore_ = other.addScore_;
      curScore_ = other.curScore_;
      galleryId_ = other.galleryId_;
      triggerEntityId_ = other.triggerEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBalloonGalleryScoreNotify Clone() {
      return new HomeBalloonGalleryScoreNotify(this);
    }

    /// <summary>Field number for the "add_score" field.</summary>
    public const int AddScoreFieldNumber = 4;
    private uint addScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AddScore {
      get { return addScore_; }
      set {
        addScore_ = value;
      }
    }

    /// <summary>Field number for the "cur_score" field.</summary>
    public const int CurScoreFieldNumber = 14;
    private uint curScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurScore {
      get { return curScore_; }
      set {
        curScore_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 1;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "trigger_entity_id" field.</summary>
    public const int TriggerEntityIdFieldNumber = 3;
    private uint triggerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TriggerEntityId {
      get { return triggerEntityId_; }
      set {
        triggerEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBalloonGalleryScoreNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBalloonGalleryScoreNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AddScore != other.AddScore) return false;
      if (CurScore != other.CurScore) return false;
      if (GalleryId != other.GalleryId) return false;
      if (TriggerEntityId != other.TriggerEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AddScore != 0) hash ^= AddScore.GetHashCode();
      if (CurScore != 0) hash ^= CurScore.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (TriggerEntityId != 0) hash ^= TriggerEntityId.GetHashCode();
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
        output.WriteRawTag(8);
        output.WriteUInt32(GalleryId);
      }
      if (TriggerEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TriggerEntityId);
      }
      if (AddScore != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AddScore);
      }
      if (CurScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurScore);
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
      if (GalleryId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GalleryId);
      }
      if (TriggerEntityId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(TriggerEntityId);
      }
      if (AddScore != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(AddScore);
      }
      if (CurScore != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(CurScore);
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
      if (AddScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AddScore);
      }
      if (CurScore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurScore);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (TriggerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TriggerEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBalloonGalleryScoreNotify other) {
      if (other == null) {
        return;
      }
      if (other.AddScore != 0) {
        AddScore = other.AddScore;
      }
      if (other.CurScore != 0) {
        CurScore = other.CurScore;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.TriggerEntityId != 0) {
        TriggerEntityId = other.TriggerEntityId;
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
          case 8: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 24: {
            TriggerEntityId = input.ReadUInt32();
            break;
          }
          case 32: {
            AddScore = input.ReadUInt32();
            break;
          }
          case 112: {
            CurScore = input.ReadUInt32();
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
          case 8: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 24: {
            TriggerEntityId = input.ReadUInt32();
            break;
          }
          case 32: {
            AddScore = input.ReadUInt32();
            break;
          }
          case 112: {
            CurScore = input.ReadUInt32();
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
