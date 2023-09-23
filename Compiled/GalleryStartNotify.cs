// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryStartNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GalleryStartNotify.proto</summary>
  public static partial class GalleryStartNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryStartNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryStartNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhHYWxsZXJ5U3RhcnROb3RpZnkucHJvdG8SDW1pSG9tby5Qcm90b3MaHUdh",
            "bGxlcnlGbG93ZXJTdGFydFBhcmFtLnByb3RvIscBChJHYWxsZXJ5U3RhcnRO",
            "b3RpZnkSEAoIZW5kX3RpbWUYDSABKA0SEgoKZ2FsbGVyeV9pZBgGIAEoDRIR",
            "Cglvd25lcl91aWQYCCABKA0SFAoMcGxheWVyX2NvdW50GAkgASgNEhIKCnN0",
            "YXJ0X3RpbWUYByABKA0SRAoSZmxvd2VyX3N0YXJ0X3BhcmFtGAsgASgLMiYu",
            "bWlIb21vLlByb3Rvcy5HYWxsZXJ5Rmxvd2VyU3RhcnRQYXJhbUgAQggKBmRl",
            "dGFpbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GalleryFlowerStartParamReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GalleryStartNotify), global::MiHomo.Protos.GalleryStartNotify.Parser, new[]{ "EndTime", "GalleryId", "OwnerUid", "PlayerCount", "StartTime", "FlowerStartParam" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GalleryStartNotify : pb::IMessage<GalleryStartNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GalleryStartNotify> _parser = new pb::MessageParser<GalleryStartNotify>(() => new GalleryStartNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GalleryStartNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GalleryStartNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryStartNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryStartNotify(GalleryStartNotify other) : this() {
      endTime_ = other.endTime_;
      galleryId_ = other.galleryId_;
      ownerUid_ = other.ownerUid_;
      playerCount_ = other.playerCount_;
      startTime_ = other.startTime_;
      switch (other.DetailCase) {
        case DetailOneofCase.FlowerStartParam:
          FlowerStartParam = other.FlowerStartParam.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GalleryStartNotify Clone() {
      return new GalleryStartNotify(this);
    }

    /// <summary>Field number for the "end_time" field.</summary>
    public const int EndTimeFieldNumber = 13;
    private uint endTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EndTime {
      get { return endTime_; }
      set {
        endTime_ = value;
      }
    }

    /// <summary>Field number for the "gallery_id" field.</summary>
    public const int GalleryIdFieldNumber = 6;
    private uint galleryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GalleryId {
      get { return galleryId_; }
      set {
        galleryId_ = value;
      }
    }

    /// <summary>Field number for the "owner_uid" field.</summary>
    public const int OwnerUidFieldNumber = 8;
    private uint ownerUid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerUid {
      get { return ownerUid_; }
      set {
        ownerUid_ = value;
      }
    }

    /// <summary>Field number for the "player_count" field.</summary>
    public const int PlayerCountFieldNumber = 9;
    private uint playerCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayerCount {
      get { return playerCount_; }
      set {
        playerCount_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 7;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "flower_start_param" field.</summary>
    public const int FlowerStartParamFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GalleryFlowerStartParam FlowerStartParam {
      get { return detailCase_ == DetailOneofCase.FlowerStartParam ? (global::MiHomo.Protos.GalleryFlowerStartParam) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.FlowerStartParam;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      FlowerStartParam = 11,
    }
    private DetailOneofCase detailCase_ = DetailOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DetailOneofCase DetailCase {
      get { return detailCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDetail() {
      detailCase_ = DetailOneofCase.None;
      detail_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GalleryStartNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GalleryStartNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EndTime != other.EndTime) return false;
      if (GalleryId != other.GalleryId) return false;
      if (OwnerUid != other.OwnerUid) return false;
      if (PlayerCount != other.PlayerCount) return false;
      if (StartTime != other.StartTime) return false;
      if (!object.Equals(FlowerStartParam, other.FlowerStartParam)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EndTime != 0) hash ^= EndTime.GetHashCode();
      if (GalleryId != 0) hash ^= GalleryId.GetHashCode();
      if (OwnerUid != 0) hash ^= OwnerUid.GetHashCode();
      if (PlayerCount != 0) hash ^= PlayerCount.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (detailCase_ == DetailOneofCase.FlowerStartParam) hash ^= FlowerStartParam.GetHashCode();
      hash ^= (int) detailCase_;
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
        output.WriteRawTag(48);
        output.WriteUInt32(GalleryId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StartTime);
      }
      if (OwnerUid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OwnerUid);
      }
      if (PlayerCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PlayerCount);
      }
      if (detailCase_ == DetailOneofCase.FlowerStartParam) {
        output.WriteRawTag(90);
        output.WriteMessage(FlowerStartParam);
      }
      if (EndTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EndTime);
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
        output.WriteRawTag(48);
        output.WriteUInt32(GalleryId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StartTime);
      }
      if (OwnerUid != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(OwnerUid);
      }
      if (PlayerCount != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(PlayerCount);
      }
      if (detailCase_ == DetailOneofCase.FlowerStartParam) {
        output.WriteRawTag(90);
        output.WriteMessage(FlowerStartParam);
      }
      if (EndTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EndTime);
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
      if (EndTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EndTime);
      }
      if (GalleryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GalleryId);
      }
      if (OwnerUid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerUid);
      }
      if (PlayerCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerCount);
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (detailCase_ == DetailOneofCase.FlowerStartParam) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FlowerStartParam);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GalleryStartNotify other) {
      if (other == null) {
        return;
      }
      if (other.EndTime != 0) {
        EndTime = other.EndTime;
      }
      if (other.GalleryId != 0) {
        GalleryId = other.GalleryId;
      }
      if (other.OwnerUid != 0) {
        OwnerUid = other.OwnerUid;
      }
      if (other.PlayerCount != 0) {
        PlayerCount = other.PlayerCount;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.FlowerStartParam:
          if (FlowerStartParam == null) {
            FlowerStartParam = new global::MiHomo.Protos.GalleryFlowerStartParam();
          }
          FlowerStartParam.MergeFrom(other.FlowerStartParam);
          break;
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
          case 48: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 56: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 64: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 72: {
            PlayerCount = input.ReadUInt32();
            break;
          }
          case 90: {
            global::MiHomo.Protos.GalleryFlowerStartParam subBuilder = new global::MiHomo.Protos.GalleryFlowerStartParam();
            if (detailCase_ == DetailOneofCase.FlowerStartParam) {
              subBuilder.MergeFrom(FlowerStartParam);
            }
            input.ReadMessage(subBuilder);
            FlowerStartParam = subBuilder;
            break;
          }
          case 104: {
            EndTime = input.ReadUInt32();
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
          case 48: {
            GalleryId = input.ReadUInt32();
            break;
          }
          case 56: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 64: {
            OwnerUid = input.ReadUInt32();
            break;
          }
          case 72: {
            PlayerCount = input.ReadUInt32();
            break;
          }
          case 90: {
            global::MiHomo.Protos.GalleryFlowerStartParam subBuilder = new global::MiHomo.Protos.GalleryFlowerStartParam();
            if (detailCase_ == DetailOneofCase.FlowerStartParam) {
              subBuilder.MergeFrom(FlowerStartParam);
            }
            input.ReadMessage(subBuilder);
            FlowerStartParam = subBuilder;
            break;
          }
          case 104: {
            EndTime = input.ReadUInt32();
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
