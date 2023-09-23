// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairMinigameInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FleurFairMinigameInfo.proto</summary>
  public static partial class FleurFairMinigameInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairMinigameInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairMinigameInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGbGV1ckZhaXJNaW5pZ2FtZUluZm8ucHJvdG8SDW1pSG9tby5Qcm90b3Ma",
            "GkZsZXVyRmFpckJhbGxvb25JbmZvLnByb3RvGhdGbGV1ckZhaXJGYWxsSW5m",
            "by5wcm90bxocRmxldXJGYWlyTXVzaWNHYW1lSW5mby5wcm90byKLAgoVRmxl",
            "dXJGYWlyTWluaWdhbWVJbmZvEg8KB2lzX29wZW4YCCABKAgSEwoLbWluaWdh",
            "bWVfaWQYDSABKA0SEQoJb3Blbl90aW1lGA8gASgNEjsKDGJhbGxvb25faW5m",
            "bxgMIAEoCzIjLm1pSG9tby5Qcm90b3MuRmxldXJGYWlyQmFsbG9vbkluZm9I",
            "ABI1CglmYWxsX2luZm8YCyABKAsyIC5taUhvbW8uUHJvdG9zLkZsZXVyRmFp",
            "ckZhbGxJbmZvSAASOwoKbXVzaWNfaW5mbxgJIAEoCzIlLm1pSG9tby5Qcm90",
            "b3MuRmxldXJGYWlyTXVzaWNHYW1lSW5mb0gAQggKBmRldGFpbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FleurFairBalloonInfoReflection.Descriptor, global::MiHomo.Protos.FleurFairFallInfoReflection.Descriptor, global::MiHomo.Protos.FleurFairMusicGameInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FleurFairMinigameInfo), global::MiHomo.Protos.FleurFairMinigameInfo.Parser, new[]{ "IsOpen", "MinigameId", "OpenTime", "BalloonInfo", "FallInfo", "MusicInfo" }, new[]{ "Detail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairMinigameInfo : pb::IMessage<FleurFairMinigameInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairMinigameInfo> _parser = new pb::MessageParser<FleurFairMinigameInfo>(() => new FleurFairMinigameInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairMinigameInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FleurFairMinigameInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMinigameInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMinigameInfo(FleurFairMinigameInfo other) : this() {
      isOpen_ = other.isOpen_;
      minigameId_ = other.minigameId_;
      openTime_ = other.openTime_;
      switch (other.DetailCase) {
        case DetailOneofCase.BalloonInfo:
          BalloonInfo = other.BalloonInfo.Clone();
          break;
        case DetailOneofCase.FallInfo:
          FallInfo = other.FallInfo.Clone();
          break;
        case DetailOneofCase.MusicInfo:
          MusicInfo = other.MusicInfo.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMinigameInfo Clone() {
      return new FleurFairMinigameInfo(this);
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 8;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "minigame_id" field.</summary>
    public const int MinigameIdFieldNumber = 13;
    private uint minigameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinigameId {
      get { return minigameId_; }
      set {
        minigameId_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 15;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "balloon_info" field.</summary>
    public const int BalloonInfoFieldNumber = 12;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.FleurFairBalloonInfo BalloonInfo {
      get { return detailCase_ == DetailOneofCase.BalloonInfo ? (global::MiHomo.Protos.FleurFairBalloonInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.BalloonInfo;
      }
    }

    /// <summary>Field number for the "fall_info" field.</summary>
    public const int FallInfoFieldNumber = 11;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.FleurFairFallInfo FallInfo {
      get { return detailCase_ == DetailOneofCase.FallInfo ? (global::MiHomo.Protos.FleurFairFallInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.FallInfo;
      }
    }

    /// <summary>Field number for the "music_info" field.</summary>
    public const int MusicInfoFieldNumber = 9;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.FleurFairMusicGameInfo MusicInfo {
      get { return detailCase_ == DetailOneofCase.MusicInfo ? (global::MiHomo.Protos.FleurFairMusicGameInfo) detail_ : null; }
      set {
        detail_ = value;
        detailCase_ = value == null ? DetailOneofCase.None : DetailOneofCase.MusicInfo;
      }
    }

    private object detail_;
    /// <summary>Enum of possible cases for the "detail" oneof.</summary>
    public enum DetailOneofCase {
      None = 0,
      BalloonInfo = 12,
      FallInfo = 11,
      MusicInfo = 9,
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
      return Equals(other as FleurFairMinigameInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairMinigameInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOpen != other.IsOpen) return false;
      if (MinigameId != other.MinigameId) return false;
      if (OpenTime != other.OpenTime) return false;
      if (!object.Equals(BalloonInfo, other.BalloonInfo)) return false;
      if (!object.Equals(FallInfo, other.FallInfo)) return false;
      if (!object.Equals(MusicInfo, other.MusicInfo)) return false;
      if (DetailCase != other.DetailCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (MinigameId != 0) hash ^= MinigameId.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (detailCase_ == DetailOneofCase.BalloonInfo) hash ^= BalloonInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.FallInfo) hash ^= FallInfo.GetHashCode();
      if (detailCase_ == DetailOneofCase.MusicInfo) hash ^= MusicInfo.GetHashCode();
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
      if (IsOpen != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsOpen);
      }
      if (detailCase_ == DetailOneofCase.MusicInfo) {
        output.WriteRawTag(74);
        output.WriteMessage(MusicInfo);
      }
      if (detailCase_ == DetailOneofCase.FallInfo) {
        output.WriteRawTag(90);
        output.WriteMessage(FallInfo);
      }
      if (detailCase_ == DetailOneofCase.BalloonInfo) {
        output.WriteRawTag(98);
        output.WriteMessage(BalloonInfo);
      }
      if (MinigameId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MinigameId);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OpenTime);
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
      if (IsOpen != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsOpen);
      }
      if (detailCase_ == DetailOneofCase.MusicInfo) {
        output.WriteRawTag(74);
        output.WriteMessage(MusicInfo);
      }
      if (detailCase_ == DetailOneofCase.FallInfo) {
        output.WriteRawTag(90);
        output.WriteMessage(FallInfo);
      }
      if (detailCase_ == DetailOneofCase.BalloonInfo) {
        output.WriteRawTag(98);
        output.WriteMessage(BalloonInfo);
      }
      if (MinigameId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(MinigameId);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(OpenTime);
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
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (MinigameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinigameId);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (detailCase_ == DetailOneofCase.BalloonInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BalloonInfo);
      }
      if (detailCase_ == DetailOneofCase.FallInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FallInfo);
      }
      if (detailCase_ == DetailOneofCase.MusicInfo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MusicInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairMinigameInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.MinigameId != 0) {
        MinigameId = other.MinigameId;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      switch (other.DetailCase) {
        case DetailOneofCase.BalloonInfo:
          if (BalloonInfo == null) {
            BalloonInfo = new global::MiHomo.Protos.FleurFairBalloonInfo();
          }
          BalloonInfo.MergeFrom(other.BalloonInfo);
          break;
        case DetailOneofCase.FallInfo:
          if (FallInfo == null) {
            FallInfo = new global::MiHomo.Protos.FleurFairFallInfo();
          }
          FallInfo.MergeFrom(other.FallInfo);
          break;
        case DetailOneofCase.MusicInfo:
          if (MusicInfo == null) {
            MusicInfo = new global::MiHomo.Protos.FleurFairMusicGameInfo();
          }
          MusicInfo.MergeFrom(other.MusicInfo);
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
          case 64: {
            IsOpen = input.ReadBool();
            break;
          }
          case 74: {
            global::MiHomo.Protos.FleurFairMusicGameInfo subBuilder = new global::MiHomo.Protos.FleurFairMusicGameInfo();
            if (detailCase_ == DetailOneofCase.MusicInfo) {
              subBuilder.MergeFrom(MusicInfo);
            }
            input.ReadMessage(subBuilder);
            MusicInfo = subBuilder;
            break;
          }
          case 90: {
            global::MiHomo.Protos.FleurFairFallInfo subBuilder = new global::MiHomo.Protos.FleurFairFallInfo();
            if (detailCase_ == DetailOneofCase.FallInfo) {
              subBuilder.MergeFrom(FallInfo);
            }
            input.ReadMessage(subBuilder);
            FallInfo = subBuilder;
            break;
          }
          case 98: {
            global::MiHomo.Protos.FleurFairBalloonInfo subBuilder = new global::MiHomo.Protos.FleurFairBalloonInfo();
            if (detailCase_ == DetailOneofCase.BalloonInfo) {
              subBuilder.MergeFrom(BalloonInfo);
            }
            input.ReadMessage(subBuilder);
            BalloonInfo = subBuilder;
            break;
          }
          case 104: {
            MinigameId = input.ReadUInt32();
            break;
          }
          case 120: {
            OpenTime = input.ReadUInt32();
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
          case 64: {
            IsOpen = input.ReadBool();
            break;
          }
          case 74: {
            global::MiHomo.Protos.FleurFairMusicGameInfo subBuilder = new global::MiHomo.Protos.FleurFairMusicGameInfo();
            if (detailCase_ == DetailOneofCase.MusicInfo) {
              subBuilder.MergeFrom(MusicInfo);
            }
            input.ReadMessage(subBuilder);
            MusicInfo = subBuilder;
            break;
          }
          case 90: {
            global::MiHomo.Protos.FleurFairFallInfo subBuilder = new global::MiHomo.Protos.FleurFairFallInfo();
            if (detailCase_ == DetailOneofCase.FallInfo) {
              subBuilder.MergeFrom(FallInfo);
            }
            input.ReadMessage(subBuilder);
            FallInfo = subBuilder;
            break;
          }
          case 98: {
            global::MiHomo.Protos.FleurFairBalloonInfo subBuilder = new global::MiHomo.Protos.FleurFairBalloonInfo();
            if (detailCase_ == DetailOneofCase.BalloonInfo) {
              subBuilder.MergeFrom(BalloonInfo);
            }
            input.ReadMessage(subBuilder);
            BalloonInfo = subBuilder;
            break;
          }
          case 104: {
            MinigameId = input.ReadUInt32();
            break;
          }
          case 120: {
            OpenTime = input.ReadUInt32();
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
