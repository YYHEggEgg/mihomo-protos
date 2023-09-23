// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DropItemReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DropItemReq.proto</summary>
  public static partial class DropItemReqReflection {

    #region Descriptor
    /// <summary>File descriptor for DropItemReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DropItemReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFEcm9wSXRlbVJlcS5wcm90bxINbWlIb21vLlByb3RvcxoPU3RvcmVUeXBl",
            "LnByb3RvGgxWZWN0b3IucHJvdG8ifAoLRHJvcEl0ZW1SZXESDQoFY291bnQY",
            "BCABKA0SDAoEZ3VpZBgJIAEoBBIiCgNwb3MYDCABKAsyFS5taUhvbW8uUHJv",
            "dG9zLlZlY3RvchIsCgpzdG9yZV90eXBlGA0gASgOMhgubWlIb21vLlByb3Rv",
            "cy5TdG9yZVR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.StoreTypeReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.DropItemReq), global::MiHomo.Protos.DropItemReq.Parser, new[]{ "Count", "Guid", "Pos", "StoreType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DropItemReq : pb::IMessage<DropItemReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DropItemReq> _parser = new pb::MessageParser<DropItemReq>(() => new DropItemReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DropItemReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.DropItemReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DropItemReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DropItemReq(DropItemReq other) : this() {
      count_ = other.count_;
      guid_ = other.guid_;
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      storeType_ = other.storeType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DropItemReq Clone() {
      return new DropItemReq(this);
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 4;
    private uint count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 9;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 12;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "store_type" field.</summary>
    public const int StoreTypeFieldNumber = 13;
    private global::MiHomo.Protos.StoreType storeType_ = global::MiHomo.Protos.StoreType.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.StoreType StoreType {
      get { return storeType_; }
      set {
        storeType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DropItemReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DropItemReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Count != other.Count) return false;
      if (Guid != other.Guid) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (StoreType != other.StoreType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Count != 0) hash ^= Count.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (StoreType != global::MiHomo.Protos.StoreType.None) hash ^= StoreType.GetHashCode();
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
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Count);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(Guid);
      }
      if (pos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Pos);
      }
      if (StoreType != global::MiHomo.Protos.StoreType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) StoreType);
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
      if (Count != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Count);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(72);
        output.WriteUInt64(Guid);
      }
      if (pos_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Pos);
      }
      if (StoreType != global::MiHomo.Protos.StoreType.None) {
        output.WriteRawTag(104);
        output.WriteEnum((int) StoreType);
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
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Count);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (StoreType != global::MiHomo.Protos.StoreType.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) StoreType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DropItemReq other) {
      if (other == null) {
        return;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.StoreType != global::MiHomo.Protos.StoreType.None) {
        StoreType = other.StoreType;
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
            Count = input.ReadUInt32();
            break;
          }
          case 72: {
            Guid = input.ReadUInt64();
            break;
          }
          case 98: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 104: {
            StoreType = (global::MiHomo.Protos.StoreType) input.ReadEnum();
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
            Count = input.ReadUInt32();
            break;
          }
          case 72: {
            Guid = input.ReadUInt64();
            break;
          }
          case 98: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 104: {
            StoreType = (global::MiHomo.Protos.StoreType) input.ReadEnum();
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
