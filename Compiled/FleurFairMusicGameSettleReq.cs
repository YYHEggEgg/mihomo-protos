// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FleurFairMusicGameSettleReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FleurFairMusicGameSettleReq.proto</summary>
  public static partial class FleurFairMusicGameSettleReqReflection {

    #region Descriptor
    /// <summary>File descriptor for FleurFairMusicGameSettleReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FleurFairMusicGameSettleReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFGbGV1ckZhaXJNdXNpY0dhbWVTZXR0bGVSZXEucHJvdG8SDW1pSG9tby5Q",
            "cm90b3MiaAobRmxldXJGYWlyTXVzaWNHYW1lU2V0dGxlUmVxEg0KBWNvbWJv",
            "GAMgASgNEhMKC2NvcnJlY3RfaGl0GAogASgNEhYKDm11c2ljX2Jhc2ljX2lk",
            "GA4gASgNEg0KBXNjb3JlGAEgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FleurFairMusicGameSettleReq), global::MiHomo.Protos.FleurFairMusicGameSettleReq.Parser, new[]{ "Combo", "CorrectHit", "MusicBasicId", "Score" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FleurFairMusicGameSettleReq : pb::IMessage<FleurFairMusicGameSettleReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FleurFairMusicGameSettleReq> _parser = new pb::MessageParser<FleurFairMusicGameSettleReq>(() => new FleurFairMusicGameSettleReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FleurFairMusicGameSettleReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FleurFairMusicGameSettleReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMusicGameSettleReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMusicGameSettleReq(FleurFairMusicGameSettleReq other) : this() {
      combo_ = other.combo_;
      correctHit_ = other.correctHit_;
      musicBasicId_ = other.musicBasicId_;
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FleurFairMusicGameSettleReq Clone() {
      return new FleurFairMusicGameSettleReq(this);
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 3;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "correct_hit" field.</summary>
    public const int CorrectHitFieldNumber = 10;
    private uint correctHit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CorrectHit {
      get { return correctHit_; }
      set {
        correctHit_ = value;
      }
    }

    /// <summary>Field number for the "music_basic_id" field.</summary>
    public const int MusicBasicIdFieldNumber = 14;
    private uint musicBasicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicBasicId {
      get { return musicBasicId_; }
      set {
        musicBasicId_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 1;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FleurFairMusicGameSettleReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FleurFairMusicGameSettleReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Combo != other.Combo) return false;
      if (CorrectHit != other.CorrectHit) return false;
      if (MusicBasicId != other.MusicBasicId) return false;
      if (Score != other.Score) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Combo != 0) hash ^= Combo.GetHashCode();
      if (CorrectHit != 0) hash ^= CorrectHit.GetHashCode();
      if (MusicBasicId != 0) hash ^= MusicBasicId.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
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
      if (Score != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Score);
      }
      if (Combo != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Combo);
      }
      if (CorrectHit != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CorrectHit);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MusicBasicId);
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
      if (Score != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Score);
      }
      if (Combo != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Combo);
      }
      if (CorrectHit != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CorrectHit);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(MusicBasicId);
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
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      if (CorrectHit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CorrectHit);
      }
      if (MusicBasicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicBasicId);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FleurFairMusicGameSettleReq other) {
      if (other == null) {
        return;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      if (other.CorrectHit != 0) {
        CorrectHit = other.CorrectHit;
      }
      if (other.MusicBasicId != 0) {
        MusicBasicId = other.MusicBasicId;
      }
      if (other.Score != 0) {
        Score = other.Score;
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
            Score = input.ReadUInt32();
            break;
          }
          case 24: {
            Combo = input.ReadUInt32();
            break;
          }
          case 80: {
            CorrectHit = input.ReadUInt32();
            break;
          }
          case 112: {
            MusicBasicId = input.ReadUInt32();
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
            Score = input.ReadUInt32();
            break;
          }
          case 24: {
            Combo = input.ReadUInt32();
            break;
          }
          case 80: {
            CorrectHit = input.ReadUInt32();
            break;
          }
          case 112: {
            MusicBasicId = input.ReadUInt32();
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
