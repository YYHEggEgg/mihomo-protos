// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeBalloonGalleryRecord.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeBalloonGalleryRecord.proto</summary>
  public static partial class HomeBalloonGalleryRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeBalloonGalleryRecord.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeBalloonGalleryRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Ib21lQmFsbG9vbkdhbGxlcnlSZWNvcmQucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MaGUhvbWVHcm91cFBsYXllckluZm8ucHJvdG8iiAEKGEhvbWVCYWxsb29u",
            "R2FsbGVyeVJlY29yZBIRCgloaXRfY291bnQYDCABKA0SNwoLcGxheWVyX2lu",
            "Zm8YBSABKAsyIi5taUhvbW8uUHJvdG9zLkhvbWVHcm91cFBsYXllckluZm8S",
            "DQoFc2NvcmUYCyABKA0SEQoJdGltZXN0YW1wGAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeGroupPlayerInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeBalloonGalleryRecord), global::MiHomo.Protos.HomeBalloonGalleryRecord.Parser, new[]{ "HitCount", "PlayerInfo", "Score", "Timestamp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeBalloonGalleryRecord : pb::IMessage<HomeBalloonGalleryRecord>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeBalloonGalleryRecord> _parser = new pb::MessageParser<HomeBalloonGalleryRecord>(() => new HomeBalloonGalleryRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeBalloonGalleryRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeBalloonGalleryRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBalloonGalleryRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBalloonGalleryRecord(HomeBalloonGalleryRecord other) : this() {
      hitCount_ = other.hitCount_;
      playerInfo_ = other.playerInfo_ != null ? other.playerInfo_.Clone() : null;
      score_ = other.score_;
      timestamp_ = other.timestamp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeBalloonGalleryRecord Clone() {
      return new HomeBalloonGalleryRecord(this);
    }

    /// <summary>Field number for the "hit_count" field.</summary>
    public const int HitCountFieldNumber = 12;
    private uint hitCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint HitCount {
      get { return hitCount_; }
      set {
        hitCount_ = value;
      }
    }

    /// <summary>Field number for the "player_info" field.</summary>
    public const int PlayerInfoFieldNumber = 5;
    private global::MiHomo.Protos.HomeGroupPlayerInfo playerInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.HomeGroupPlayerInfo PlayerInfo {
      get { return playerInfo_; }
      set {
        playerInfo_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 11;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 2;
    private uint timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeBalloonGalleryRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeBalloonGalleryRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HitCount != other.HitCount) return false;
      if (!object.Equals(PlayerInfo, other.PlayerInfo)) return false;
      if (Score != other.Score) return false;
      if (Timestamp != other.Timestamp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HitCount != 0) hash ^= HitCount.GetHashCode();
      if (playerInfo_ != null) hash ^= PlayerInfo.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Timestamp != 0) hash ^= Timestamp.GetHashCode();
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
      if (Timestamp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Timestamp);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PlayerInfo);
      }
      if (Score != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Score);
      }
      if (HitCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HitCount);
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
      if (Timestamp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Timestamp);
      }
      if (playerInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(PlayerInfo);
      }
      if (Score != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Score);
      }
      if (HitCount != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(HitCount);
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
      if (HitCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(HitCount);
      }
      if (playerInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerInfo);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Timestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeBalloonGalleryRecord other) {
      if (other == null) {
        return;
      }
      if (other.HitCount != 0) {
        HitCount = other.HitCount;
      }
      if (other.playerInfo_ != null) {
        if (playerInfo_ == null) {
          PlayerInfo = new global::MiHomo.Protos.HomeGroupPlayerInfo();
        }
        PlayerInfo.MergeFrom(other.PlayerInfo);
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Timestamp != 0) {
        Timestamp = other.Timestamp;
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
            Timestamp = input.ReadUInt32();
            break;
          }
          case 42: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::MiHomo.Protos.HomeGroupPlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 88: {
            Score = input.ReadUInt32();
            break;
          }
          case 96: {
            HitCount = input.ReadUInt32();
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
            Timestamp = input.ReadUInt32();
            break;
          }
          case 42: {
            if (playerInfo_ == null) {
              PlayerInfo = new global::MiHomo.Protos.HomeGroupPlayerInfo();
            }
            input.ReadMessage(PlayerInfo);
            break;
          }
          case 88: {
            Score = input.ReadUInt32();
            break;
          }
          case 96: {
            HitCount = input.ReadUInt32();
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
