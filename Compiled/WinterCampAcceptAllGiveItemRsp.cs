// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WinterCampAcceptAllGiveItemRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WinterCampAcceptAllGiveItemRsp.proto</summary>
  public static partial class WinterCampAcceptAllGiveItemRspReflection {

    #region Descriptor
    /// <summary>File descriptor for WinterCampAcceptAllGiveItemRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WinterCampAcceptAllGiveItemRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRXaW50ZXJDYW1wQWNjZXB0QWxsR2l2ZUl0ZW1Sc3AucHJvdG8SDW1pSG9t",
            "by5Qcm90b3MaJFdpbnRlckNhbXBBY2NlcHRJdGVtUmVzdWx0SW5mby5wcm90",
            "byLQAQoeV2ludGVyQ2FtcEFjY2VwdEFsbEdpdmVJdGVtUnNwEk4KF2FjY2Vw",
            "dF9pdGVtX3Jlc3VsdF9pbmZvGA4gAygLMi0ubWlIb21vLlByb3Rvcy5XaW50",
            "ZXJDYW1wQWNjZXB0SXRlbVJlc3VsdEluZm8SDwoHcmV0Y29kZRgGIAEoBSJN",
            "CgVDbWRJZBIICgROT05FEAASEwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5F",
            "VF9JU19SRUxJQUJMRRABEgsKBkNNRF9JRBCyQxoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.WinterCampAcceptItemResultInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.WinterCampAcceptAllGiveItemRsp), global::MiHomo.Protos.WinterCampAcceptAllGiveItemRsp.Parser, new[]{ "AcceptItemResultInfo", "Retcode" }, null, new[]{ typeof(global::MiHomo.Protos.WinterCampAcceptAllGiveItemRsp.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WinterCampAcceptAllGiveItemRsp : pb::IMessage<WinterCampAcceptAllGiveItemRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WinterCampAcceptAllGiveItemRsp> _parser = new pb::MessageParser<WinterCampAcceptAllGiveItemRsp>(() => new WinterCampAcceptAllGiveItemRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WinterCampAcceptAllGiveItemRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.WinterCampAcceptAllGiveItemRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampAcceptAllGiveItemRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampAcceptAllGiveItemRsp(WinterCampAcceptAllGiveItemRsp other) : this() {
      acceptItemResultInfo_ = other.acceptItemResultInfo_.Clone();
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WinterCampAcceptAllGiveItemRsp Clone() {
      return new WinterCampAcceptAllGiveItemRsp(this);
    }

    /// <summary>Field number for the "accept_item_result_info" field.</summary>
    public const int AcceptItemResultInfoFieldNumber = 14;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.WinterCampAcceptItemResultInfo> _repeated_acceptItemResultInfo_codec
        = pb::FieldCodec.ForMessage(114, global::MiHomo.Protos.WinterCampAcceptItemResultInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.WinterCampAcceptItemResultInfo> acceptItemResultInfo_ = new pbc::RepeatedField<global::MiHomo.Protos.WinterCampAcceptItemResultInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.WinterCampAcceptItemResultInfo> AcceptItemResultInfo {
      get { return acceptItemResultInfo_; }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 6;
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
      return Equals(other as WinterCampAcceptAllGiveItemRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WinterCampAcceptAllGiveItemRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!acceptItemResultInfo_.Equals(other.acceptItemResultInfo_)) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= acceptItemResultInfo_.GetHashCode();
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
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      acceptItemResultInfo_.WriteTo(output, _repeated_acceptItemResultInfo_codec);
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
        output.WriteRawTag(48);
        output.WriteInt32(Retcode);
      }
      acceptItemResultInfo_.WriteTo(ref output, _repeated_acceptItemResultInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += acceptItemResultInfo_.CalculateSize(_repeated_acceptItemResultInfo_codec);
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
    public void MergeFrom(WinterCampAcceptAllGiveItemRsp other) {
      if (other == null) {
        return;
      }
      acceptItemResultInfo_.Add(other.acceptItemResultInfo_);
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
          case 48: {
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            acceptItemResultInfo_.AddEntriesFrom(input, _repeated_acceptItemResultInfo_codec);
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
            Retcode = input.ReadInt32();
            break;
          }
          case 114: {
            acceptItemResultInfo_.AddEntriesFrom(ref input, _repeated_acceptItemResultInfo_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the WinterCampAcceptAllGiveItemRsp message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 8626,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
