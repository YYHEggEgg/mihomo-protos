// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonSocialMuipData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CustomDungeonSocialMuipData.proto</summary>
  public static partial class CustomDungeonSocialMuipDataReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonSocialMuipData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonSocialMuipDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDdXN0b21EdW5nZW9uU29jaWFsTXVpcERhdGEucHJvdG8SDW1pSG9tby5Q",
            "cm90b3MiZQobQ3VzdG9tRHVuZ2VvblNvY2lhbE11aXBEYXRhEhAKCGxpa2Vf",
            "bnVtGAIgASgNEhAKCHBsYXlfbnVtGAEgASgNEhEKCXN0b3JlX251bRgDIAEo",
            "DRIPCgd3aW5fbnVtGAQgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CustomDungeonSocialMuipData), global::MiHomo.Protos.CustomDungeonSocialMuipData.Parser, new[]{ "LikeNum", "PlayNum", "StoreNum", "WinNum" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonSocialMuipData : pb::IMessage<CustomDungeonSocialMuipData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonSocialMuipData> _parser = new pb::MessageParser<CustomDungeonSocialMuipData>(() => new CustomDungeonSocialMuipData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonSocialMuipData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CustomDungeonSocialMuipDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSocialMuipData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSocialMuipData(CustomDungeonSocialMuipData other) : this() {
      likeNum_ = other.likeNum_;
      playNum_ = other.playNum_;
      storeNum_ = other.storeNum_;
      winNum_ = other.winNum_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonSocialMuipData Clone() {
      return new CustomDungeonSocialMuipData(this);
    }

    /// <summary>Field number for the "like_num" field.</summary>
    public const int LikeNumFieldNumber = 2;
    private uint likeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LikeNum {
      get { return likeNum_; }
      set {
        likeNum_ = value;
      }
    }

    /// <summary>Field number for the "play_num" field.</summary>
    public const int PlayNumFieldNumber = 1;
    private uint playNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PlayNum {
      get { return playNum_; }
      set {
        playNum_ = value;
      }
    }

    /// <summary>Field number for the "store_num" field.</summary>
    public const int StoreNumFieldNumber = 3;
    private uint storeNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StoreNum {
      get { return storeNum_; }
      set {
        storeNum_ = value;
      }
    }

    /// <summary>Field number for the "win_num" field.</summary>
    public const int WinNumFieldNumber = 4;
    private uint winNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WinNum {
      get { return winNum_; }
      set {
        winNum_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonSocialMuipData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonSocialMuipData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LikeNum != other.LikeNum) return false;
      if (PlayNum != other.PlayNum) return false;
      if (StoreNum != other.StoreNum) return false;
      if (WinNum != other.WinNum) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LikeNum != 0) hash ^= LikeNum.GetHashCode();
      if (PlayNum != 0) hash ^= PlayNum.GetHashCode();
      if (StoreNum != 0) hash ^= StoreNum.GetHashCode();
      if (WinNum != 0) hash ^= WinNum.GetHashCode();
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
      if (PlayNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PlayNum);
      }
      if (LikeNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LikeNum);
      }
      if (StoreNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StoreNum);
      }
      if (WinNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WinNum);
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
      if (PlayNum != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PlayNum);
      }
      if (LikeNum != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(LikeNum);
      }
      if (StoreNum != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(StoreNum);
      }
      if (WinNum != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(WinNum);
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
      if (LikeNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LikeNum);
      }
      if (PlayNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayNum);
      }
      if (StoreNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StoreNum);
      }
      if (WinNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WinNum);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonSocialMuipData other) {
      if (other == null) {
        return;
      }
      if (other.LikeNum != 0) {
        LikeNum = other.LikeNum;
      }
      if (other.PlayNum != 0) {
        PlayNum = other.PlayNum;
      }
      if (other.StoreNum != 0) {
        StoreNum = other.StoreNum;
      }
      if (other.WinNum != 0) {
        WinNum = other.WinNum;
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
            PlayNum = input.ReadUInt32();
            break;
          }
          case 16: {
            LikeNum = input.ReadUInt32();
            break;
          }
          case 24: {
            StoreNum = input.ReadUInt32();
            break;
          }
          case 32: {
            WinNum = input.ReadUInt32();
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
            PlayNum = input.ReadUInt32();
            break;
          }
          case 16: {
            LikeNum = input.ReadUInt32();
            break;
          }
          case 24: {
            StoreNum = input.ReadUInt32();
            break;
          }
          case 32: {
            WinNum = input.ReadUInt32();
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
