// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PhotoActivityFinishReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PhotoActivityFinishReq.proto</summary>
  public static partial class PhotoActivityFinishReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PhotoActivityFinishReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PhotoActivityFinishReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQaG90b0FjdGl2aXR5RmluaXNoUmVxLnByb3RvEg1taUhvbW8uUHJvdG9z",
            "IrQBChZQaG90b0FjdGl2aXR5RmluaXNoUmVxEhUKDWNoZWNrX3Jvb3RfaWQY",
            "AiABKA0SDwoHaXNfc3VjYxgFIAEoCBIOCgZwb3NfaWQYDyABKA0iYgoFQ21k",
            "SWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9JRBAAEhQKEEVORVRfSVNf",
            "UkVMSUFCTEUQARITCg9JU19BTExPV19DTElFTlQQARILCgZDTURfSUQQ2UUa",
            "AhABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PhotoActivityFinishReq), global::MiHomo.Protos.PhotoActivityFinishReq.Parser, new[]{ "CheckRootId", "IsSucc", "PosId" }, null, new[]{ typeof(global::MiHomo.Protos.PhotoActivityFinishReq.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PhotoActivityFinishReq : pb::IMessage<PhotoActivityFinishReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PhotoActivityFinishReq> _parser = new pb::MessageParser<PhotoActivityFinishReq>(() => new PhotoActivityFinishReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PhotoActivityFinishReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PhotoActivityFinishReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoActivityFinishReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoActivityFinishReq(PhotoActivityFinishReq other) : this() {
      checkRootId_ = other.checkRootId_;
      isSucc_ = other.isSucc_;
      posId_ = other.posId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PhotoActivityFinishReq Clone() {
      return new PhotoActivityFinishReq(this);
    }

    /// <summary>Field number for the "check_root_id" field.</summary>
    public const int CheckRootIdFieldNumber = 2;
    private uint checkRootId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CheckRootId {
      get { return checkRootId_; }
      set {
        checkRootId_ = value;
      }
    }

    /// <summary>Field number for the "is_succ" field.</summary>
    public const int IsSuccFieldNumber = 5;
    private bool isSucc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSucc {
      get { return isSucc_; }
      set {
        isSucc_ = value;
      }
    }

    /// <summary>Field number for the "pos_id" field.</summary>
    public const int PosIdFieldNumber = 15;
    private uint posId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PosId {
      get { return posId_; }
      set {
        posId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PhotoActivityFinishReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PhotoActivityFinishReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CheckRootId != other.CheckRootId) return false;
      if (IsSucc != other.IsSucc) return false;
      if (PosId != other.PosId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CheckRootId != 0) hash ^= CheckRootId.GetHashCode();
      if (IsSucc != false) hash ^= IsSucc.GetHashCode();
      if (PosId != 0) hash ^= PosId.GetHashCode();
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
      if (CheckRootId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CheckRootId);
      }
      if (IsSucc != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSucc);
      }
      if (PosId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PosId);
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
      if (CheckRootId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CheckRootId);
      }
      if (IsSucc != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSucc);
      }
      if (PosId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(PosId);
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
      if (CheckRootId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CheckRootId);
      }
      if (IsSucc != false) {
        size += 1 + 1;
      }
      if (PosId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PosId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PhotoActivityFinishReq other) {
      if (other == null) {
        return;
      }
      if (other.CheckRootId != 0) {
        CheckRootId = other.CheckRootId;
      }
      if (other.IsSucc != false) {
        IsSucc = other.IsSucc;
      }
      if (other.PosId != 0) {
        PosId = other.PosId;
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
            CheckRootId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsSucc = input.ReadBool();
            break;
          }
          case 120: {
            PosId = input.ReadUInt32();
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
            CheckRootId = input.ReadUInt32();
            break;
          }
          case 40: {
            IsSucc = input.ReadBool();
            break;
          }
          case 120: {
            PosId = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the PhotoActivityFinishReq message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 8921,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
