// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EnterFungusFighterPlotDungeonRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from EnterFungusFighterPlotDungeonRsp.proto</summary>
  public static partial class EnterFungusFighterPlotDungeonRspReflection {

    #region Descriptor
    /// <summary>File descriptor for EnterFungusFighterPlotDungeonRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnterFungusFighterPlotDungeonRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZFbnRlckZ1bmd1c0ZpZ2h0ZXJQbG90RHVuZ2VvblJzcC5wcm90bxINbWlI",
            "b21vLlByb3RvcyJfCiBFbnRlckZ1bmd1c0ZpZ2h0ZXJQbG90RHVuZ2VvblJz",
            "cBISCgpkdW5nZW9uX2lkGAggASgNEhYKDmZ1bmd1c19pZF9saXN0GA4gAygN",
            "Eg8KB3JldGNvZGUYBCABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.EnterFungusFighterPlotDungeonRsp), global::MiHomo.Protos.EnterFungusFighterPlotDungeonRsp.Parser, new[]{ "DungeonId", "FungusIdList", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EnterFungusFighterPlotDungeonRsp : pb::IMessage<EnterFungusFighterPlotDungeonRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EnterFungusFighterPlotDungeonRsp> _parser = new pb::MessageParser<EnterFungusFighterPlotDungeonRsp>(() => new EnterFungusFighterPlotDungeonRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EnterFungusFighterPlotDungeonRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.EnterFungusFighterPlotDungeonRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterFungusFighterPlotDungeonRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterFungusFighterPlotDungeonRsp(EnterFungusFighterPlotDungeonRsp other) : this() {
      dungeonId_ = other.dungeonId_;
      fungusIdList_ = other.fungusIdList_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EnterFungusFighterPlotDungeonRsp Clone() {
      return new EnterFungusFighterPlotDungeonRsp(this);
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 8;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "fungus_id_list" field.</summary>
    public const int FungusIdListFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_fungusIdList_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> fungusIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FungusIdList {
      get { return fungusIdList_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 4;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EnterFungusFighterPlotDungeonRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EnterFungusFighterPlotDungeonRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DungeonId != other.DungeonId) return false;
      if(!fungusIdList_.Equals(other.fungusIdList_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      hash ^= fungusIdList_.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DungeonId);
      }
      fungusIdList_.WriteTo(output, _repeated_fungusIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Retcode != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Retcode);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(DungeonId);
      }
      fungusIdList_.WriteTo(ref output, _repeated_fungusIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      size += fungusIdList_.CalculateSize(_repeated_fungusIdList_codec);
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EnterFungusFighterPlotDungeonRsp other) {
      if (other == null) {
        return;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      fungusIdList_.Add(other.fungusIdList_);
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 64: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            fungusIdList_.AddEntriesFrom(input, _repeated_fungusIdList_codec);
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
          case 32: {
            Retcode = input.ReadInt32();
            break;
          }
          case 64: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            fungusIdList_.AddEntriesFrom(ref input, _repeated_fungusIdList_codec);
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
