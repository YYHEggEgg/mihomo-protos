// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeChangeEditModeRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeChangeEditModeRsp.proto</summary>
  public static partial class HomeChangeEditModeRspReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeChangeEditModeRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeChangeEditModeRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtIb21lQ2hhbmdlRWRpdE1vZGVSc3AucHJvdG8SDW1pSG9tby5Qcm90b3Mi",
            "RAoVSG9tZUNoYW5nZUVkaXRNb2RlUnNwEhoKEmlzX2VudGVyX2VkaXRfbW9k",
            "ZRgCIAEoCBIPCgdyZXRjb2RlGA0gASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeChangeEditModeRsp), global::MiHomo.Protos.HomeChangeEditModeRsp.Parser, new[]{ "IsEnterEditMode", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeChangeEditModeRsp : pb::IMessage<HomeChangeEditModeRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeChangeEditModeRsp> _parser = new pb::MessageParser<HomeChangeEditModeRsp>(() => new HomeChangeEditModeRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeChangeEditModeRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeChangeEditModeRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeChangeEditModeRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeChangeEditModeRsp(HomeChangeEditModeRsp other) : this() {
      isEnterEditMode_ = other.isEnterEditMode_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeChangeEditModeRsp Clone() {
      return new HomeChangeEditModeRsp(this);
    }

    /// <summary>Field number for the "is_enter_edit_mode" field.</summary>
    public const int IsEnterEditModeFieldNumber = 2;
    private bool isEnterEditMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsEnterEditMode {
      get { return isEnterEditMode_; }
      set {
        isEnterEditMode_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 13;
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
      return Equals(other as HomeChangeEditModeRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeChangeEditModeRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsEnterEditMode != other.IsEnterEditMode) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsEnterEditMode != false) hash ^= IsEnterEditMode.GetHashCode();
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
      if (IsEnterEditMode != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsEnterEditMode);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      if (IsEnterEditMode != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsEnterEditMode);
      }
      if (Retcode != 0) {
        output.WriteRawTag(104);
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
      if (IsEnterEditMode != false) {
        size += 1 + 1;
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
    public void MergeFrom(HomeChangeEditModeRsp other) {
      if (other == null) {
        return;
      }
      if (other.IsEnterEditMode != false) {
        IsEnterEditMode = other.IsEnterEditMode;
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
          case 16: {
            IsEnterEditMode = input.ReadBool();
            break;
          }
          case 104: {
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
          case 16: {
            IsEnterEditMode = input.ReadBool();
            break;
          }
          case 104: {
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
