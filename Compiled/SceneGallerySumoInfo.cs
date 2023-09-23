// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGallerySumoInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SceneGallerySumoInfo.proto</summary>
  public static partial class SceneGallerySumoInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGallerySumoInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGallerySumoInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTY2VuZUdhbGxlcnlTdW1vSW5mby5wcm90bxINbWlIb21vLlByb3RvcyJm",
            "ChRTY2VuZUdhbGxlcnlTdW1vSW5mbxIeChZraWxsX2VsaXRlX21vbnN0ZXJf",
            "bnVtGA4gASgNEh8KF2tpbGxfbm9ybWFsX21vc250ZXJfbnVtGA8gASgNEg0K",
            "BXNjb3JlGAIgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SceneGallerySumoInfo), global::MiHomo.Protos.SceneGallerySumoInfo.Parser, new[]{ "KillEliteMonsterNum", "KillNormalMosnterNum", "Score" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGallerySumoInfo : pb::IMessage<SceneGallerySumoInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGallerySumoInfo> _parser = new pb::MessageParser<SceneGallerySumoInfo>(() => new SceneGallerySumoInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGallerySumoInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SceneGallerySumoInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGallerySumoInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGallerySumoInfo(SceneGallerySumoInfo other) : this() {
      killEliteMonsterNum_ = other.killEliteMonsterNum_;
      killNormalMosnterNum_ = other.killNormalMosnterNum_;
      score_ = other.score_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGallerySumoInfo Clone() {
      return new SceneGallerySumoInfo(this);
    }

    /// <summary>Field number for the "kill_elite_monster_num" field.</summary>
    public const int KillEliteMonsterNumFieldNumber = 14;
    private uint killEliteMonsterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillEliteMonsterNum {
      get { return killEliteMonsterNum_; }
      set {
        killEliteMonsterNum_ = value;
      }
    }

    /// <summary>Field number for the "kill_normal_mosnter_num" field.</summary>
    public const int KillNormalMosnterNumFieldNumber = 15;
    private uint killNormalMosnterNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint KillNormalMosnterNum {
      get { return killNormalMosnterNum_; }
      set {
        killNormalMosnterNum_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 2;
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
      return Equals(other as SceneGallerySumoInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGallerySumoInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (KillEliteMonsterNum != other.KillEliteMonsterNum) return false;
      if (KillNormalMosnterNum != other.KillNormalMosnterNum) return false;
      if (Score != other.Score) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (KillEliteMonsterNum != 0) hash ^= KillEliteMonsterNum.GetHashCode();
      if (KillNormalMosnterNum != 0) hash ^= KillNormalMosnterNum.GetHashCode();
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
        output.WriteRawTag(16);
        output.WriteUInt32(Score);
      }
      if (KillEliteMonsterNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(KillEliteMonsterNum);
      }
      if (KillNormalMosnterNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KillNormalMosnterNum);
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
        output.WriteRawTag(16);
        output.WriteUInt32(Score);
      }
      if (KillEliteMonsterNum != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(KillEliteMonsterNum);
      }
      if (KillNormalMosnterNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(KillNormalMosnterNum);
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
      if (KillEliteMonsterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillEliteMonsterNum);
      }
      if (KillNormalMosnterNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(KillNormalMosnterNum);
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
    public void MergeFrom(SceneGallerySumoInfo other) {
      if (other == null) {
        return;
      }
      if (other.KillEliteMonsterNum != 0) {
        KillEliteMonsterNum = other.KillEliteMonsterNum;
      }
      if (other.KillNormalMosnterNum != 0) {
        KillNormalMosnterNum = other.KillNormalMosnterNum;
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
          case 16: {
            Score = input.ReadUInt32();
            break;
          }
          case 112: {
            KillEliteMonsterNum = input.ReadUInt32();
            break;
          }
          case 120: {
            KillNormalMosnterNum = input.ReadUInt32();
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
            Score = input.ReadUInt32();
            break;
          }
          case 112: {
            KillEliteMonsterNum = input.ReadUInt32();
            break;
          }
          case 120: {
            KillNormalMosnterNum = input.ReadUInt32();
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
