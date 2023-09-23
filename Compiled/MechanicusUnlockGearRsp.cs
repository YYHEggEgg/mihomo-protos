// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MechanicusUnlockGearRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MechanicusUnlockGearRsp.proto</summary>
  public static partial class MechanicusUnlockGearRspReflection {

    #region Descriptor
    /// <summary>File descriptor for MechanicusUnlockGearRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MechanicusUnlockGearRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1NZWNoYW5pY3VzVW5sb2NrR2VhclJzcC5wcm90bxINbWlIb21vLlByb3Rv",
            "cyJSChdNZWNoYW5pY3VzVW5sb2NrR2VhclJzcBIPCgdnZWFyX2lkGAEgASgN",
            "EhUKDW1lY2hhbmljdXNfaWQYByABKA0SDwoHcmV0Y29kZRgKIAEoBWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MechanicusUnlockGearRsp), global::MiHomo.Protos.MechanicusUnlockGearRsp.Parser, new[]{ "GearId", "MechanicusId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MechanicusUnlockGearRsp : pb::IMessage<MechanicusUnlockGearRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MechanicusUnlockGearRsp> _parser = new pb::MessageParser<MechanicusUnlockGearRsp>(() => new MechanicusUnlockGearRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MechanicusUnlockGearRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MechanicusUnlockGearRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusUnlockGearRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusUnlockGearRsp(MechanicusUnlockGearRsp other) : this() {
      gearId_ = other.gearId_;
      mechanicusId_ = other.mechanicusId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MechanicusUnlockGearRsp Clone() {
      return new MechanicusUnlockGearRsp(this);
    }

    /// <summary>Field number for the "gear_id" field.</summary>
    public const int GearIdFieldNumber = 1;
    private uint gearId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GearId {
      get { return gearId_; }
      set {
        gearId_ = value;
      }
    }

    /// <summary>Field number for the "mechanicus_id" field.</summary>
    public const int MechanicusIdFieldNumber = 7;
    private uint mechanicusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MechanicusId {
      get { return mechanicusId_; }
      set {
        mechanicusId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 10;
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
      return Equals(other as MechanicusUnlockGearRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MechanicusUnlockGearRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GearId != other.GearId) return false;
      if (MechanicusId != other.MechanicusId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GearId != 0) hash ^= GearId.GetHashCode();
      if (MechanicusId != 0) hash ^= MechanicusId.GetHashCode();
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
      if (GearId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GearId);
      }
      if (MechanicusId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MechanicusId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
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
      if (GearId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GearId);
      }
      if (MechanicusId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(MechanicusId);
      }
      if (Retcode != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Retcode);
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
      if (GearId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GearId);
      }
      if (MechanicusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MechanicusId);
      }
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
    public void MergeFrom(MechanicusUnlockGearRsp other) {
      if (other == null) {
        return;
      }
      if (other.GearId != 0) {
        GearId = other.GearId;
      }
      if (other.MechanicusId != 0) {
        MechanicusId = other.MechanicusId;
      }
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
          case 8: {
            GearId = input.ReadUInt32();
            break;
          }
          case 56: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
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
            GearId = input.ReadUInt32();
            break;
          }
          case 56: {
            MechanicusId = input.ReadUInt32();
            break;
          }
          case 80: {
            Retcode = input.ReadInt32();
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
