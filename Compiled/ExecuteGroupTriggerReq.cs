// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ExecuteGroupTriggerReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ExecuteGroupTriggerReq.proto</summary>
  public static partial class ExecuteGroupTriggerReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ExecuteGroupTriggerReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExecuteGroupTriggerReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxFeGVjdXRlR3JvdXBUcmlnZ2VyUmVxLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "IvUBChZFeGVjdXRlR3JvdXBUcmlnZ2VyUmVxEg4KBnBhcmFtMRgJIAEoBRIO",
            "CgZwYXJhbTIYCCABKAUSDgoGcGFyYW0zGAogASgFEhgKEHNvdXJjZV9lbnRp",
            "dHlfaWQYBCABKA0SEwoLc291cmNlX25hbWUYDyABKAkSGAoQdGFyZ2V0X2Vu",
            "dGl0eV9pZBgMIAEoDSJiCgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFO",
            "TkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMKD0lTX0FMTE9XX0NM",
            "SUVOVBABEgsKBkNNRF9JRBCBAhoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ExecuteGroupTriggerReq), global::MiHomo.Protos.ExecuteGroupTriggerReq.Parser, new[]{ "Param1", "Param2", "Param3", "SourceEntityId", "SourceName", "TargetEntityId" }, null, new[]{ typeof(global::MiHomo.Protos.ExecuteGroupTriggerReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ExecuteGroupTriggerReq : pb::IMessage<ExecuteGroupTriggerReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExecuteGroupTriggerReq> _parser = new pb::MessageParser<ExecuteGroupTriggerReq>(() => new ExecuteGroupTriggerReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExecuteGroupTriggerReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ExecuteGroupTriggerReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecuteGroupTriggerReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecuteGroupTriggerReq(ExecuteGroupTriggerReq other) : this() {
      param1_ = other.param1_;
      param2_ = other.param2_;
      param3_ = other.param3_;
      sourceEntityId_ = other.sourceEntityId_;
      sourceName_ = other.sourceName_;
      targetEntityId_ = other.targetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExecuteGroupTriggerReq Clone() {
      return new ExecuteGroupTriggerReq(this);
    }

    /// <summary>Field number for the "param1" field.</summary>
    public const int Param1FieldNumber = 9;
    private int param1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Param1 {
      get { return param1_; }
      set {
        param1_ = value;
      }
    }

    /// <summary>Field number for the "param2" field.</summary>
    public const int Param2FieldNumber = 8;
    private int param2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Param2 {
      get { return param2_; }
      set {
        param2_ = value;
      }
    }

    /// <summary>Field number for the "param3" field.</summary>
    public const int Param3FieldNumber = 10;
    private int param3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Param3 {
      get { return param3_; }
      set {
        param3_ = value;
      }
    }

    /// <summary>Field number for the "source_entity_id" field.</summary>
    public const int SourceEntityIdFieldNumber = 4;
    private uint sourceEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SourceEntityId {
      get { return sourceEntityId_; }
      set {
        sourceEntityId_ = value;
      }
    }

    /// <summary>Field number for the "source_name" field.</summary>
    public const int SourceNameFieldNumber = 15;
    private string sourceName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SourceName {
      get { return sourceName_; }
      set {
        sourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 12;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExecuteGroupTriggerReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExecuteGroupTriggerReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Param1 != other.Param1) return false;
      if (Param2 != other.Param2) return false;
      if (Param3 != other.Param3) return false;
      if (SourceEntityId != other.SourceEntityId) return false;
      if (SourceName != other.SourceName) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Param1 != 0) hash ^= Param1.GetHashCode();
      if (Param2 != 0) hash ^= Param2.GetHashCode();
      if (Param3 != 0) hash ^= Param3.GetHashCode();
      if (SourceEntityId != 0) hash ^= SourceEntityId.GetHashCode();
      if (SourceName.Length != 0) hash ^= SourceName.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
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
      if (SourceEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SourceEntityId);
      }
      if (Param2 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Param2);
      }
      if (Param1 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Param1);
      }
      if (Param3 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Param3);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TargetEntityId);
      }
      if (SourceName.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(SourceName);
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
      if (SourceEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SourceEntityId);
      }
      if (Param2 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Param2);
      }
      if (Param1 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(Param1);
      }
      if (Param3 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Param3);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(TargetEntityId);
      }
      if (SourceName.Length != 0) {
        output.WriteRawTag(122);
        output.WriteString(SourceName);
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
      if (Param1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param1);
      }
      if (Param2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param2);
      }
      if (Param3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Param3);
      }
      if (SourceEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SourceEntityId);
      }
      if (SourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceName);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExecuteGroupTriggerReq other) {
      if (other == null) {
        return;
      }
      if (other.Param1 != 0) {
        Param1 = other.Param1;
      }
      if (other.Param2 != 0) {
        Param2 = other.Param2;
      }
      if (other.Param3 != 0) {
        Param3 = other.Param3;
      }
      if (other.SourceEntityId != 0) {
        SourceEntityId = other.SourceEntityId;
      }
      if (other.SourceName.Length != 0) {
        SourceName = other.SourceName;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
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
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 64: {
            Param2 = input.ReadInt32();
            break;
          }
          case 72: {
            Param1 = input.ReadInt32();
            break;
          }
          case 80: {
            Param3 = input.ReadInt32();
            break;
          }
          case 96: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 122: {
            SourceName = input.ReadString();
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
            SourceEntityId = input.ReadUInt32();
            break;
          }
          case 64: {
            Param2 = input.ReadInt32();
            break;
          }
          case 72: {
            Param1 = input.ReadInt32();
            break;
          }
          case 80: {
            Param3 = input.ReadInt32();
            break;
          }
          case 96: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 122: {
            SourceName = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ExecuteGroupTriggerReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 257,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
