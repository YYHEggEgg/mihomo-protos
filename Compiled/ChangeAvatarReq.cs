// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeAvatarReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ChangeAvatarReq.proto</summary>
  public static partial class ChangeAvatarReqReflection {

    #region Descriptor
    /// <summary>File descriptor for ChangeAvatarReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeAvatarReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVDaGFuZ2VBdmF0YXJSZXEucHJvdG8SDW1pSG9tby5Qcm90b3MaDFZlY3Rv",
            "ci5wcm90byJrCg9DaGFuZ2VBdmF0YXJSZXESDAoEZ3VpZBgOIAEoBBIPCgdp",
            "c19tb3ZlGAsgASgIEicKCG1vdmVfcG9zGAkgASgLMhUubWlIb21vLlByb3Rv",
            "cy5WZWN0b3ISEAoIc2tpbGxfaWQYBCABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ChangeAvatarReq), global::MiHomo.Protos.ChangeAvatarReq.Parser, new[]{ "Guid", "IsMove", "MovePos", "SkillId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChangeAvatarReq : pb::IMessage<ChangeAvatarReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeAvatarReq> _parser = new pb::MessageParser<ChangeAvatarReq>(() => new ChangeAvatarReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeAvatarReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ChangeAvatarReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeAvatarReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeAvatarReq(ChangeAvatarReq other) : this() {
      guid_ = other.guid_;
      isMove_ = other.isMove_;
      movePos_ = other.movePos_ != null ? other.movePos_.Clone() : null;
      skillId_ = other.skillId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeAvatarReq Clone() {
      return new ChangeAvatarReq(this);
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 14;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "is_move" field.</summary>
    public const int IsMoveFieldNumber = 11;
    private bool isMove_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsMove {
      get { return isMove_; }
      set {
        isMove_ = value;
      }
    }

    /// <summary>Field number for the "move_pos" field.</summary>
    public const int MovePosFieldNumber = 9;
    private global::MiHomo.Protos.Vector movePos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector MovePos {
      get { return movePos_; }
      set {
        movePos_ = value;
      }
    }

    /// <summary>Field number for the "skill_id" field.</summary>
    public const int SkillIdFieldNumber = 4;
    private uint skillId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SkillId {
      get { return skillId_; }
      set {
        skillId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeAvatarReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeAvatarReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Guid != other.Guid) return false;
      if (IsMove != other.IsMove) return false;
      if (!object.Equals(MovePos, other.MovePos)) return false;
      if (SkillId != other.SkillId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (IsMove != false) hash ^= IsMove.GetHashCode();
      if (movePos_ != null) hash ^= MovePos.GetHashCode();
      if (SkillId != 0) hash ^= SkillId.GetHashCode();
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
      if (SkillId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SkillId);
      }
      if (movePos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MovePos);
      }
      if (IsMove != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsMove);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(Guid);
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
      if (SkillId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(SkillId);
      }
      if (movePos_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(MovePos);
      }
      if (IsMove != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsMove);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(Guid);
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
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (IsMove != false) {
        size += 1 + 1;
      }
      if (movePos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MovePos);
      }
      if (SkillId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SkillId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeAvatarReq other) {
      if (other == null) {
        return;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.IsMove != false) {
        IsMove = other.IsMove;
      }
      if (other.movePos_ != null) {
        if (movePos_ == null) {
          MovePos = new global::MiHomo.Protos.Vector();
        }
        MovePos.MergeFrom(other.MovePos);
      }
      if (other.SkillId != 0) {
        SkillId = other.SkillId;
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
            SkillId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (movePos_ == null) {
              MovePos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(MovePos);
            break;
          }
          case 88: {
            IsMove = input.ReadBool();
            break;
          }
          case 112: {
            Guid = input.ReadUInt64();
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
            SkillId = input.ReadUInt32();
            break;
          }
          case 74: {
            if (movePos_ == null) {
              MovePos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(MovePos);
            break;
          }
          case 88: {
            IsMove = input.ReadBool();
            break;
          }
          case 112: {
            Guid = input.ReadUInt64();
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
