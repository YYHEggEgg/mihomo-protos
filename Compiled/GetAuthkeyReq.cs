// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GetAuthkeyReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GetAuthkeyReq.proto</summary>
  public static partial class GetAuthkeyReqReflection {

    #region Descriptor
    /// <summary>File descriptor for GetAuthkeyReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetAuthkeyReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHZXRBdXRoa2V5UmVxLnByb3RvEg1taUhvbW8uUHJvdG9zIksKDUdldEF1",
            "dGhrZXlSZXESEgoKYXV0aF9hcHBpZBgNIAEoCRITCgthdXRoa2V5X3ZlchgP",
            "IAEoDRIRCglzaWduX3R5cGUYBiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GetAuthkeyReq), global::MiHomo.Protos.GetAuthkeyReq.Parser, new[]{ "AuthAppid", "AuthkeyVer", "SignType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetAuthkeyReq : pb::IMessage<GetAuthkeyReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetAuthkeyReq> _parser = new pb::MessageParser<GetAuthkeyReq>(() => new GetAuthkeyReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetAuthkeyReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GetAuthkeyReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyReq(GetAuthkeyReq other) : this() {
      authAppid_ = other.authAppid_;
      authkeyVer_ = other.authkeyVer_;
      signType_ = other.signType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetAuthkeyReq Clone() {
      return new GetAuthkeyReq(this);
    }

    /// <summary>Field number for the "auth_appid" field.</summary>
    public const int AuthAppidFieldNumber = 13;
    private string authAppid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AuthAppid {
      get { return authAppid_; }
      set {
        authAppid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "authkey_ver" field.</summary>
    public const int AuthkeyVerFieldNumber = 15;
    private uint authkeyVer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AuthkeyVer {
      get { return authkeyVer_; }
      set {
        authkeyVer_ = value;
      }
    }

    /// <summary>Field number for the "sign_type" field.</summary>
    public const int SignTypeFieldNumber = 6;
    private uint signType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SignType {
      get { return signType_; }
      set {
        signType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetAuthkeyReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetAuthkeyReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AuthAppid != other.AuthAppid) return false;
      if (AuthkeyVer != other.AuthkeyVer) return false;
      if (SignType != other.SignType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AuthAppid.Length != 0) hash ^= AuthAppid.GetHashCode();
      if (AuthkeyVer != 0) hash ^= AuthkeyVer.GetHashCode();
      if (SignType != 0) hash ^= SignType.GetHashCode();
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
      if (SignType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SignType);
      }
      if (AuthAppid.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(AuthAppid);
      }
      if (AuthkeyVer != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AuthkeyVer);
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
      if (SignType != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SignType);
      }
      if (AuthAppid.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(AuthAppid);
      }
      if (AuthkeyVer != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(AuthkeyVer);
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
      if (AuthAppid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AuthAppid);
      }
      if (AuthkeyVer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AuthkeyVer);
      }
      if (SignType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SignType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetAuthkeyReq other) {
      if (other == null) {
        return;
      }
      if (other.AuthAppid.Length != 0) {
        AuthAppid = other.AuthAppid;
      }
      if (other.AuthkeyVer != 0) {
        AuthkeyVer = other.AuthkeyVer;
      }
      if (other.SignType != 0) {
        SignType = other.SignType;
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
            SignType = input.ReadUInt32();
            break;
          }
          case 106: {
            AuthAppid = input.ReadString();
            break;
          }
          case 120: {
            AuthkeyVer = input.ReadUInt32();
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
            SignType = input.ReadUInt32();
            break;
          }
          case 106: {
            AuthAppid = input.ReadString();
            break;
          }
          case 120: {
            AuthkeyVer = input.ReadUInt32();
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
