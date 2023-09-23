// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SceneGalleryCoinCollectInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SceneGalleryCoinCollectInfo.proto</summary>
  public static partial class SceneGalleryCoinCollectInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for SceneGalleryCoinCollectInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SceneGalleryCoinCollectInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFTY2VuZUdhbGxlcnlDb2luQ29sbGVjdEluZm8ucHJvdG8SDW1pSG9tby5Q",
            "cm90b3MiTwobU2NlbmVHYWxsZXJ5Q29pbkNvbGxlY3RJbmZvEhgKEGNvaW5f",
            "Y29sbGVjdF9udW0YAiABKA0SFgoOY29pbl90b3RhbF9udW0YBCABKA1iBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.SceneGalleryCoinCollectInfo), global::MiHomo.Protos.SceneGalleryCoinCollectInfo.Parser, new[]{ "CoinCollectNum", "CoinTotalNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SceneGalleryCoinCollectInfo : pb::IMessage<SceneGalleryCoinCollectInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SceneGalleryCoinCollectInfo> _parser = new pb::MessageParser<SceneGalleryCoinCollectInfo>(() => new SceneGalleryCoinCollectInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SceneGalleryCoinCollectInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.SceneGalleryCoinCollectInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryCoinCollectInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryCoinCollectInfo(SceneGalleryCoinCollectInfo other) : this() {
      coinCollectNum_ = other.coinCollectNum_;
      coinTotalNum_ = other.coinTotalNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SceneGalleryCoinCollectInfo Clone() {
      return new SceneGalleryCoinCollectInfo(this);
    }

    /// <summary>Field number for the "coin_collect_num" field.</summary>
    public const int CoinCollectNumFieldNumber = 2;
    private uint coinCollectNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinCollectNum {
      get { return coinCollectNum_; }
      set {
        coinCollectNum_ = value;
      }
    }

    /// <summary>Field number for the "coin_total_num" field.</summary>
    public const int CoinTotalNumFieldNumber = 4;
    private uint coinTotalNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CoinTotalNum {
      get { return coinTotalNum_; }
      set {
        coinTotalNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SceneGalleryCoinCollectInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SceneGalleryCoinCollectInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CoinCollectNum != other.CoinCollectNum) return false;
      if (CoinTotalNum != other.CoinTotalNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CoinCollectNum != 0) hash ^= CoinCollectNum.GetHashCode();
      if (CoinTotalNum != 0) hash ^= CoinTotalNum.GetHashCode();
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
      if (CoinCollectNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CoinCollectNum);
      }
      if (CoinTotalNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CoinTotalNum);
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
      if (CoinCollectNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CoinCollectNum);
      }
      if (CoinTotalNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CoinTotalNum);
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
      if (CoinCollectNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinCollectNum);
      }
      if (CoinTotalNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CoinTotalNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SceneGalleryCoinCollectInfo other) {
      if (other == null) {
        return;
      }
      if (other.CoinCollectNum != 0) {
        CoinCollectNum = other.CoinCollectNum;
      }
      if (other.CoinTotalNum != 0) {
        CoinTotalNum = other.CoinTotalNum;
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
            CoinCollectNum = input.ReadUInt32();
            break;
          }
          case 32: {
            CoinTotalNum = input.ReadUInt32();
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
            CoinCollectNum = input.ReadUInt32();
            break;
          }
          case 32: {
            CoinTotalNum = input.ReadUInt32();
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
