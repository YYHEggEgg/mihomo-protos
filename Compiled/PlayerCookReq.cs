// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerCookReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlayerCookReq.proto</summary>
  public static partial class PlayerCookReqReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerCookReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerCookReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQbGF5ZXJDb29rUmVxLnByb3RvEg1taUhvbW8uUHJvdG9zImIKDVBsYXll",
            "ckNvb2tSZXESFQoNYXNzaXN0X2F2YXRhchgMIAEoDRISCgpjb29rX2NvdW50",
            "GAcgASgNEhMKC3F0ZV9xdWFsaXR5GAUgASgNEhEKCXJlY2lwZV9pZBgBIAEo",
            "DWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlayerCookReq), global::MiHomo.Protos.PlayerCookReq.Parser, new[]{ "AssistAvatar", "CookCount", "QteQuality", "RecipeId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerCookReq : pb::IMessage<PlayerCookReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerCookReq> _parser = new pb::MessageParser<PlayerCookReq>(() => new PlayerCookReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerCookReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlayerCookReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCookReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCookReq(PlayerCookReq other) : this() {
      assistAvatar_ = other.assistAvatar_;
      cookCount_ = other.cookCount_;
      qteQuality_ = other.qteQuality_;
      recipeId_ = other.recipeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerCookReq Clone() {
      return new PlayerCookReq(this);
    }

    /// <summary>Field number for the "assist_avatar" field.</summary>
    public const int AssistAvatarFieldNumber = 12;
    private uint assistAvatar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AssistAvatar {
      get { return assistAvatar_; }
      set {
        assistAvatar_ = value;
      }
    }

    /// <summary>Field number for the "cook_count" field.</summary>
    public const int CookCountFieldNumber = 7;
    private uint cookCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CookCount {
      get { return cookCount_; }
      set {
        cookCount_ = value;
      }
    }

    /// <summary>Field number for the "qte_quality" field.</summary>
    public const int QteQualityFieldNumber = 5;
    private uint qteQuality_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint QteQuality {
      get { return qteQuality_; }
      set {
        qteQuality_ = value;
      }
    }

    /// <summary>Field number for the "recipe_id" field.</summary>
    public const int RecipeIdFieldNumber = 1;
    private uint recipeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RecipeId {
      get { return recipeId_; }
      set {
        recipeId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerCookReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerCookReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AssistAvatar != other.AssistAvatar) return false;
      if (CookCount != other.CookCount) return false;
      if (QteQuality != other.QteQuality) return false;
      if (RecipeId != other.RecipeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AssistAvatar != 0) hash ^= AssistAvatar.GetHashCode();
      if (CookCount != 0) hash ^= CookCount.GetHashCode();
      if (QteQuality != 0) hash ^= QteQuality.GetHashCode();
      if (RecipeId != 0) hash ^= RecipeId.GetHashCode();
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
      if (RecipeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RecipeId);
      }
      if (QteQuality != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QteQuality);
      }
      if (CookCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CookCount);
      }
      if (AssistAvatar != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AssistAvatar);
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
      if (RecipeId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(RecipeId);
      }
      if (QteQuality != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(QteQuality);
      }
      if (CookCount != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(CookCount);
      }
      if (AssistAvatar != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(AssistAvatar);
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
      if (AssistAvatar != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AssistAvatar);
      }
      if (CookCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CookCount);
      }
      if (QteQuality != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(QteQuality);
      }
      if (RecipeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RecipeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerCookReq other) {
      if (other == null) {
        return;
      }
      if (other.AssistAvatar != 0) {
        AssistAvatar = other.AssistAvatar;
      }
      if (other.CookCount != 0) {
        CookCount = other.CookCount;
      }
      if (other.QteQuality != 0) {
        QteQuality = other.QteQuality;
      }
      if (other.RecipeId != 0) {
        RecipeId = other.RecipeId;
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
            RecipeId = input.ReadUInt32();
            break;
          }
          case 40: {
            QteQuality = input.ReadUInt32();
            break;
          }
          case 56: {
            CookCount = input.ReadUInt32();
            break;
          }
          case 96: {
            AssistAvatar = input.ReadUInt32();
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
            RecipeId = input.ReadUInt32();
            break;
          }
          case 40: {
            QteQuality = input.ReadUInt32();
            break;
          }
          case 56: {
            CookCount = input.ReadUInt32();
            break;
          }
          case 96: {
            AssistAvatar = input.ReadUInt32();
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
