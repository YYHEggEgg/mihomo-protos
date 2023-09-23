// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StartRogueEliteCellChallengeReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from StartRogueEliteCellChallengeReq.proto</summary>
  public static partial class StartRogueEliteCellChallengeReqReflection {

    #region Descriptor
    /// <summary>File descriptor for StartRogueEliteCellChallengeReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRogueEliteCellChallengeReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVTdGFydFJvZ3VlRWxpdGVDZWxsQ2hhbGxlbmdlUmVxLnByb3RvEg1taUhv",
            "bW8uUHJvdG9zGiJSb2d1ZUVsaXRlQ2VsbERpZmZpY3VsdHlUeXBlLnByb3Rv",
            "IocBCh9TdGFydFJvZ3VlRWxpdGVDZWxsQ2hhbGxlbmdlUmVxEg8KB2NlbGxf",
            "aWQYCiABKA0SPwoKZGlmZmljdWx0eRgGIAEoDjIrLm1pSG9tby5Qcm90b3Mu",
            "Um9ndWVFbGl0ZUNlbGxEaWZmaWN1bHR5VHlwZRISCgpkdW5nZW9uX2lkGAsg",
            "ASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.RogueEliteCellDifficultyTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.StartRogueEliteCellChallengeReq), global::MiHomo.Protos.StartRogueEliteCellChallengeReq.Parser, new[]{ "CellId", "Difficulty", "DungeonId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StartRogueEliteCellChallengeReq : pb::IMessage<StartRogueEliteCellChallengeReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StartRogueEliteCellChallengeReq> _parser = new pb::MessageParser<StartRogueEliteCellChallengeReq>(() => new StartRogueEliteCellChallengeReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<StartRogueEliteCellChallengeReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.StartRogueEliteCellChallengeReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueEliteCellChallengeReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueEliteCellChallengeReq(StartRogueEliteCellChallengeReq other) : this() {
      cellId_ = other.cellId_;
      difficulty_ = other.difficulty_;
      dungeonId_ = other.dungeonId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public StartRogueEliteCellChallengeReq Clone() {
      return new StartRogueEliteCellChallengeReq(this);
    }

    /// <summary>Field number for the "cell_id" field.</summary>
    public const int CellIdFieldNumber = 10;
    private uint cellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CellId {
      get { return cellId_; }
      set {
        cellId_ = value;
      }
    }

    /// <summary>Field number for the "difficulty" field.</summary>
    public const int DifficultyFieldNumber = 6;
    private global::MiHomo.Protos.RogueEliteCellDifficultyType difficulty_ = global::MiHomo.Protos.RogueEliteCellDifficultyType.Normal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.RogueEliteCellDifficultyType Difficulty {
      get { return difficulty_; }
      set {
        difficulty_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 11;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as StartRogueEliteCellChallengeReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(StartRogueEliteCellChallengeReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CellId != other.CellId) return false;
      if (Difficulty != other.Difficulty) return false;
      if (DungeonId != other.DungeonId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CellId != 0) hash ^= CellId.GetHashCode();
      if (Difficulty != global::MiHomo.Protos.RogueEliteCellDifficultyType.Normal) hash ^= Difficulty.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
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
      if (Difficulty != global::MiHomo.Protos.RogueEliteCellDifficultyType.Normal) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Difficulty);
      }
      if (CellId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CellId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DungeonId);
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
      if (Difficulty != global::MiHomo.Protos.RogueEliteCellDifficultyType.Normal) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Difficulty);
      }
      if (CellId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(CellId);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(DungeonId);
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
      if (CellId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CellId);
      }
      if (Difficulty != global::MiHomo.Protos.RogueEliteCellDifficultyType.Normal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Difficulty);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(StartRogueEliteCellChallengeReq other) {
      if (other == null) {
        return;
      }
      if (other.CellId != 0) {
        CellId = other.CellId;
      }
      if (other.Difficulty != global::MiHomo.Protos.RogueEliteCellDifficultyType.Normal) {
        Difficulty = other.Difficulty;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
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
            Difficulty = (global::MiHomo.Protos.RogueEliteCellDifficultyType) input.ReadEnum();
            break;
          }
          case 80: {
            CellId = input.ReadUInt32();
            break;
          }
          case 88: {
            DungeonId = input.ReadUInt32();
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
            Difficulty = (global::MiHomo.Protos.RogueEliteCellDifficultyType) input.ReadEnum();
            break;
          }
          case 80: {
            CellId = input.ReadUInt32();
            break;
          }
          case 88: {
            DungeonId = input.ReadUInt32();
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
