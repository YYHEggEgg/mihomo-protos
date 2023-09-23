// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChessPickCardNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ChessPickCardNotify.proto</summary>
  public static partial class ChessPickCardNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for ChessPickCardNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChessPickCardNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDaGVzc1BpY2tDYXJkTm90aWZ5LnByb3RvEg1taUhvbW8uUHJvdG9zGhlD",
            "aGVzc05vcm1hbENhcmRJbmZvLnByb3RvImoKE0NoZXNzUGlja0NhcmROb3Rp",
            "ZnkSFQoNY3Vyc2VfY2FyZF9pZBgGIAEoDRI8ChBub3JtYWxfY2FyZF9pbmZv",
            "GAggASgLMiIubWlIb21vLlByb3Rvcy5DaGVzc05vcm1hbENhcmRJbmZvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ChessNormalCardInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ChessPickCardNotify), global::MiHomo.Protos.ChessPickCardNotify.Parser, new[]{ "CurseCardId", "NormalCardInfo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChessPickCardNotify : pb::IMessage<ChessPickCardNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChessPickCardNotify> _parser = new pb::MessageParser<ChessPickCardNotify>(() => new ChessPickCardNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChessPickCardNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ChessPickCardNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessPickCardNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessPickCardNotify(ChessPickCardNotify other) : this() {
      curseCardId_ = other.curseCardId_;
      normalCardInfo_ = other.normalCardInfo_ != null ? other.normalCardInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChessPickCardNotify Clone() {
      return new ChessPickCardNotify(this);
    }

    /// <summary>Field number for the "curse_card_id" field.</summary>
    public const int CurseCardIdFieldNumber = 6;
    private uint curseCardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurseCardId {
      get { return curseCardId_; }
      set {
        curseCardId_ = value;
      }
    }

    /// <summary>Field number for the "normal_card_info" field.</summary>
    public const int NormalCardInfoFieldNumber = 8;
    private global::MiHomo.Protos.ChessNormalCardInfo normalCardInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ChessNormalCardInfo NormalCardInfo {
      get { return normalCardInfo_; }
      set {
        normalCardInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChessPickCardNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChessPickCardNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurseCardId != other.CurseCardId) return false;
      if (!object.Equals(NormalCardInfo, other.NormalCardInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CurseCardId != 0) hash ^= CurseCardId.GetHashCode();
      if (normalCardInfo_ != null) hash ^= NormalCardInfo.GetHashCode();
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
      if (CurseCardId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurseCardId);
      }
      if (normalCardInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(NormalCardInfo);
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
      if (CurseCardId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CurseCardId);
      }
      if (normalCardInfo_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(NormalCardInfo);
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
      if (CurseCardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurseCardId);
      }
      if (normalCardInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NormalCardInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChessPickCardNotify other) {
      if (other == null) {
        return;
      }
      if (other.CurseCardId != 0) {
        CurseCardId = other.CurseCardId;
      }
      if (other.normalCardInfo_ != null) {
        if (normalCardInfo_ == null) {
          NormalCardInfo = new global::MiHomo.Protos.ChessNormalCardInfo();
        }
        NormalCardInfo.MergeFrom(other.NormalCardInfo);
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
            CurseCardId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (normalCardInfo_ == null) {
              NormalCardInfo = new global::MiHomo.Protos.ChessNormalCardInfo();
            }
            input.ReadMessage(NormalCardInfo);
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
            CurseCardId = input.ReadUInt32();
            break;
          }
          case 66: {
            if (normalCardInfo_ == null) {
              NormalCardInfo = new global::MiHomo.Protos.ChessNormalCardInfo();
            }
            input.ReadMessage(NormalCardInfo);
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
