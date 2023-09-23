// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGChangeOnstageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGChangeOnstageInfo.proto</summary>
  public static partial class GCGChangeOnstageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGChangeOnstageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGChangeOnstageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHQ0dDaGFuZ2VPbnN0YWdlSW5mby5wcm90bxINbWlIb21vLlByb3RvcxoZ",
            "R0NHU2tpbGxQcmV2aWV3SW5mby5wcm90byKEAQoUR0NHQ2hhbmdlT25zdGFn",
            "ZUluZm8SEQoJY2FyZF9ndWlkGAYgASgNEkcKG2NoYW5nZV9vbnN0YWdlX3By",
            "ZXZpZXdfaW5mbxgFIAEoCzIiLm1pSG9tby5Qcm90b3MuR0NHU2tpbGxQcmV2",
            "aWV3SW5mbxIQCghpc19xdWljaxgLIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GCGSkillPreviewInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GCGChangeOnstageInfo), global::MiHomo.Protos.GCGChangeOnstageInfo.Parser, new[]{ "CardGuid", "ChangeOnstagePreviewInfo", "IsQuick" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGChangeOnstageInfo : pb::IMessage<GCGChangeOnstageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGChangeOnstageInfo> _parser = new pb::MessageParser<GCGChangeOnstageInfo>(() => new GCGChangeOnstageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGChangeOnstageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GCGChangeOnstageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGChangeOnstageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGChangeOnstageInfo(GCGChangeOnstageInfo other) : this() {
      cardGuid_ = other.cardGuid_;
      changeOnstagePreviewInfo_ = other.changeOnstagePreviewInfo_ != null ? other.changeOnstagePreviewInfo_.Clone() : null;
      isQuick_ = other.isQuick_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGChangeOnstageInfo Clone() {
      return new GCGChangeOnstageInfo(this);
    }

    /// <summary>Field number for the "card_guid" field.</summary>
    public const int CardGuidFieldNumber = 6;
    private uint cardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardGuid {
      get { return cardGuid_; }
      set {
        cardGuid_ = value;
      }
    }

    /// <summary>Field number for the "change_onstage_preview_info" field.</summary>
    public const int ChangeOnstagePreviewInfoFieldNumber = 5;
    private global::MiHomo.Protos.GCGSkillPreviewInfo changeOnstagePreviewInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GCGSkillPreviewInfo ChangeOnstagePreviewInfo {
      get { return changeOnstagePreviewInfo_; }
      set {
        changeOnstagePreviewInfo_ = value;
      }
    }

    /// <summary>Field number for the "is_quick" field.</summary>
    public const int IsQuickFieldNumber = 11;
    private bool isQuick_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsQuick {
      get { return isQuick_; }
      set {
        isQuick_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGChangeOnstageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGChangeOnstageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CardGuid != other.CardGuid) return false;
      if (!object.Equals(ChangeOnstagePreviewInfo, other.ChangeOnstagePreviewInfo)) return false;
      if (IsQuick != other.IsQuick) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CardGuid != 0) hash ^= CardGuid.GetHashCode();
      if (changeOnstagePreviewInfo_ != null) hash ^= ChangeOnstagePreviewInfo.GetHashCode();
      if (IsQuick != false) hash ^= IsQuick.GetHashCode();
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
      if (changeOnstagePreviewInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ChangeOnstagePreviewInfo);
      }
      if (CardGuid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CardGuid);
      }
      if (IsQuick != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsQuick);
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
      if (changeOnstagePreviewInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ChangeOnstagePreviewInfo);
      }
      if (CardGuid != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CardGuid);
      }
      if (IsQuick != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsQuick);
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
      if (CardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardGuid);
      }
      if (changeOnstagePreviewInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChangeOnstagePreviewInfo);
      }
      if (IsQuick != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGChangeOnstageInfo other) {
      if (other == null) {
        return;
      }
      if (other.CardGuid != 0) {
        CardGuid = other.CardGuid;
      }
      if (other.changeOnstagePreviewInfo_ != null) {
        if (changeOnstagePreviewInfo_ == null) {
          ChangeOnstagePreviewInfo = new global::MiHomo.Protos.GCGSkillPreviewInfo();
        }
        ChangeOnstagePreviewInfo.MergeFrom(other.ChangeOnstagePreviewInfo);
      }
      if (other.IsQuick != false) {
        IsQuick = other.IsQuick;
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
          case 42: {
            if (changeOnstagePreviewInfo_ == null) {
              ChangeOnstagePreviewInfo = new global::MiHomo.Protos.GCGSkillPreviewInfo();
            }
            input.ReadMessage(ChangeOnstagePreviewInfo);
            break;
          }
          case 48: {
            CardGuid = input.ReadUInt32();
            break;
          }
          case 88: {
            IsQuick = input.ReadBool();
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
          case 42: {
            if (changeOnstagePreviewInfo_ == null) {
              ChangeOnstagePreviewInfo = new global::MiHomo.Protos.GCGSkillPreviewInfo();
            }
            input.ReadMessage(ChangeOnstagePreviewInfo);
            break;
          }
          case 48: {
            CardGuid = input.ReadUInt32();
            break;
          }
          case 88: {
            IsQuick = input.ReadBool();
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
