// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FishEscapeNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FishEscapeNotify.proto</summary>
  public static partial class FishEscapeNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FishEscapeNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FishEscapeNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZGaXNoRXNjYXBlTm90aWZ5LnByb3RvEg1taUhvbW8uUHJvdG9zGhZGaXNo",
            "RXNjYXBlUmVhc29uLnByb3RvGgxWZWN0b3IucHJvdG8iigEKEEZpc2hFc2Nh",
            "cGVOb3RpZnkSFAoMZmlzaF9pZF9saXN0GAkgAygNEiIKA3BvcxgLIAEoCzIV",
            "Lm1pSG9tby5Qcm90b3MuVmVjdG9yEi8KBnJlYXNvbhgMIAEoDjIfLm1pSG9t",
            "by5Qcm90b3MuRmlzaEVzY2FwZVJlYXNvbhILCgN1aWQYAiABKA1iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.FishEscapeReasonReflection.Descriptor, global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.FishEscapeNotify), global::MiHomo.Protos.FishEscapeNotify.Parser, new[]{ "FishIdList", "Pos", "Reason", "Uid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FishEscapeNotify : pb::IMessage<FishEscapeNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FishEscapeNotify> _parser = new pb::MessageParser<FishEscapeNotify>(() => new FishEscapeNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FishEscapeNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.FishEscapeNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishEscapeNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishEscapeNotify(FishEscapeNotify other) : this() {
      fishIdList_ = other.fishIdList_.Clone();
      pos_ = other.pos_ != null ? other.pos_.Clone() : null;
      reason_ = other.reason_;
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FishEscapeNotify Clone() {
      return new FishEscapeNotify(this);
    }

    /// <summary>Field number for the "fish_id_list" field.</summary>
    public const int FishIdListFieldNumber = 9;
    private static readonly pb::FieldCodec<uint> _repeated_fishIdList_codec
        = pb::FieldCodec.ForUInt32(74);
    private readonly pbc::RepeatedField<uint> fishIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> FishIdList {
      get { return fishIdList_; }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 11;
    private global::MiHomo.Protos.Vector pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 12;
    private global::MiHomo.Protos.FishEscapeReason reason_ = global::MiHomo.Protos.FishEscapeReason.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.FishEscapeReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 2;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FishEscapeNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FishEscapeNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!fishIdList_.Equals(other.fishIdList_)) return false;
      if (!object.Equals(Pos, other.Pos)) return false;
      if (Reason != other.Reason) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= fishIdList_.GetHashCode();
      if (pos_ != null) hash ^= Pos.GetHashCode();
      if (Reason != global::MiHomo.Protos.FishEscapeReason.None) hash ^= Reason.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      fishIdList_.WriteTo(output, _repeated_fishIdList_codec);
      if (pos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Pos);
      }
      if (Reason != global::MiHomo.Protos.FishEscapeReason.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Reason);
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
      if (Uid != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Uid);
      }
      fishIdList_.WriteTo(ref output, _repeated_fishIdList_codec);
      if (pos_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(Pos);
      }
      if (Reason != global::MiHomo.Protos.FishEscapeReason.None) {
        output.WriteRawTag(96);
        output.WriteEnum((int) Reason);
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
      size += fishIdList_.CalculateSize(_repeated_fishIdList_codec);
      if (pos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pos);
      }
      if (Reason != global::MiHomo.Protos.FishEscapeReason.None) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FishEscapeNotify other) {
      if (other == null) {
        return;
      }
      fishIdList_.Add(other.fishIdList_);
      if (other.pos_ != null) {
        if (pos_ == null) {
          Pos = new global::MiHomo.Protos.Vector();
        }
        Pos.MergeFrom(other.Pos);
      }
      if (other.Reason != global::MiHomo.Protos.FishEscapeReason.None) {
        Reason = other.Reason;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
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
            Uid = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            fishIdList_.AddEntriesFrom(input, _repeated_fishIdList_codec);
            break;
          }
          case 90: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 96: {
            Reason = (global::MiHomo.Protos.FishEscapeReason) input.ReadEnum();
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
            Uid = input.ReadUInt32();
            break;
          }
          case 74:
          case 72: {
            fishIdList_.AddEntriesFrom(ref input, _repeated_fishIdList_codec);
            break;
          }
          case 90: {
            if (pos_ == null) {
              Pos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(Pos);
            break;
          }
          case 96: {
            Reason = (global::MiHomo.Protos.FishEscapeReason) input.ReadEnum();
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
