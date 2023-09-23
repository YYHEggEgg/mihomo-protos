// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryCrystalLinkBuffInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GalleryCrystalLinkBuffInfoNotify.proto</summary>
  public static partial class GalleryCrystalLinkBuffInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryCrystalLinkBuffInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryCrystalLinkBuffInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZHYWxsZXJ5Q3J5c3RhbExpbmtCdWZmSW5mb05vdGlmeS5wcm90bxINbWlI",
            "b21vLlByb3RvcyKtAQogR2FsbGVyeUNyeXN0YWxMaW5rQnVmZkluZm9Ob3Rp",
            "ZnkSDwoHYnVmZl9pZBgOIAEoDRISCgpnYWxsZXJ5X2lkGA0gASgNEhUKDWlz",
            "X2J1ZmZfdmFsaWQYCyABKAgiTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRf",
            "Q0hBTk5FTF9JRBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURfSUQQ",
            "oysaAhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GalleryCrystalLinkBuffInfoNotify), global::MiHomo.Protos.GalleryCrystalLinkBuffInfoNotify.Parser, new[]{ "BuffId", "GalleryId", "IsBuffValid" }, null, new[]{ typeof(global::MiHomo.Protos.GalleryCrystalLinkBuffInfoNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GalleryCrystalLinkBuffInfoNotify : pb::IMessage<GalleryCrystalLinkBuffInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GalleryCrystalLinkBuffInfoNotify> _parser = new pb::MessageParser<GalleryCrystalLinkBuffInfoNotify>(() => new GalleryCrystalLinkBuffInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GalleryCrystalLinkBuffInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GalleryCrystalLinkBuffInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryCrystalLinkBuffInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryCrystalLinkBuffInfoNotify(GalleryCrystalLinkBuffInfoNotify other) : this() {
      buffId_ = other.buffId_;
      galleryId_ = other.galleryId_;
      isBuffValid_ = other.isBuffValid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryCrystalLinkBuffInfoNotify Clone() {
      return new GalleryCrystalLinkBuffInfoNotify(this);
    }

    /// <summary>Field number for the "buff_id" field.</summary>
    public const int BuffIdFieldNumber = 14;
    private uint buffId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BuffId {
      get { return buffId_; }
      set {
        buffId_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 13;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "is_buff_valid" field.</summary>
    public const int IsBuffValidFieldNumber = 11;
    private bool isBuffValid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsBuffValid {
      get { return isBuffValid_; }
      set {
        isBuffValid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GalleryCrystalLinkBuffInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GalleryCrystalLinkBuffInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BuffId != other.BuffId) return false;
      if (GalleryId != other.GalleryId) return false;
      if (IsBuffValid != other.IsBuffValid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BuffId != 0) hash ^= BuffId.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (IsBuffValid != false) hash ^= IsBuffValid.GetHashCode();
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
      if (IsBuffValid != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsBuffValid);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (IsBuffValid != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsBuffValid);
      }
      if (GalleryId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(GalleryId);
      }
      if (BuffId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(BuffId);
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
      if (BuffId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BuffId);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (IsBuffValid != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GalleryCrystalLinkBuffInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.BuffId != 0) {
        BuffId = other.BuffId;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.IsBuffValid != false) {
        IsBuffValid = other.IsBuffValid;
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
          case 88: {
            IsBuffValid = input.ReadBool();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
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
            IsBuffValid = input.ReadBool();
            break;
          }
          case 104: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 112: {
            BuffId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the GalleryCrystalLinkBuffInfoNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 5539,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
