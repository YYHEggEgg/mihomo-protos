// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BargainSnapshot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from BargainSnapshot.proto</summary>
  public static partial class BargainSnapshotReflection {

    #region Descriptor
    /// <summary>File descriptor for BargainSnapshot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BargainSnapshotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVCYXJnYWluU25hcHNob3QucHJvdG8SDW1pSG9tby5Qcm90b3MicQoPQmFy",
            "Z2FpblNuYXBzaG90EhIKCmJhcmdhaW5faWQYAyABKA0SEAoIY3VyX21vb2QY",
            "CCABKAUSGwoTVW5rMzMwMF9LT0NKRUxBQ0pMTRgLIAEoDRIbChNVbmszMzAw",
            "X01IRkRFQk9CRk5FGA4gASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.BargainSnapshot), global::MiHomo.Protos.BargainSnapshot.Parser, new[]{ "BargainId", "CurMood", "Unk3300KOCJELACJLM", "Unk3300MHFDEBOBFNE" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BargainSnapshot : pb::IMessage<BargainSnapshot>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BargainSnapshot> _parser = new pb::MessageParser<BargainSnapshot>(() => new BargainSnapshot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BargainSnapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.BargainSnapshotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BargainSnapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BargainSnapshot(BargainSnapshot other) : this() {
      bargainId_ = other.bargainId_;
      curMood_ = other.curMood_;
      unk3300KOCJELACJLM_ = other.unk3300KOCJELACJLM_;
      unk3300MHFDEBOBFNE_ = other.unk3300MHFDEBOBFNE_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BargainSnapshot Clone() {
      return new BargainSnapshot(this);
    }

    /// <summary>Field number for the "bargain_id" field.</summary>
    public const int BargainIdFieldNumber = 3;
    private uint bargainId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BargainId {
      get { return bargainId_; }
      set {
        bargainId_ = value;
      }
    }

    /// <summary>Field number for the "cur_mood" field.</summary>
    public const int CurMoodFieldNumber = 8;
    private int curMood_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CurMood {
      get { return curMood_; }
      set {
        curMood_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KOCJELACJLM" field.</summary>
    public const int Unk3300KOCJELACJLMFieldNumber = 11;
    private uint unk3300KOCJELACJLM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KOCJELACJLM {
      get { return unk3300KOCJELACJLM_; }
      set {
        unk3300KOCJELACJLM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MHFDEBOBFNE" field.</summary>
    public const int Unk3300MHFDEBOBFNEFieldNumber = 14;
    private uint unk3300MHFDEBOBFNE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MHFDEBOBFNE {
      get { return unk3300MHFDEBOBFNE_; }
      set {
        unk3300MHFDEBOBFNE_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BargainSnapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BargainSnapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BargainId != other.BargainId) return false;
      if (CurMood != other.CurMood) return false;
      if (Unk3300KOCJELACJLM != other.Unk3300KOCJELACJLM) return false;
      if (Unk3300MHFDEBOBFNE != other.Unk3300MHFDEBOBFNE) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BargainId != 0) hash ^= BargainId.GetHashCode();
      if (CurMood != 0) hash ^= CurMood.GetHashCode();
      if (Unk3300KOCJELACJLM != 0) hash ^= Unk3300KOCJELACJLM.GetHashCode();
      if (Unk3300MHFDEBOBFNE != 0) hash ^= Unk3300MHFDEBOBFNE.GetHashCode();
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
      if (BargainId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BargainId);
      }
      if (CurMood != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CurMood);
      }
      if (Unk3300KOCJELACJLM != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300KOCJELACJLM);
      }
      if (Unk3300MHFDEBOBFNE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300MHFDEBOBFNE);
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
      if (BargainId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(BargainId);
      }
      if (CurMood != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(CurMood);
      }
      if (Unk3300KOCJELACJLM != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(Unk3300KOCJELACJLM);
      }
      if (Unk3300MHFDEBOBFNE != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Unk3300MHFDEBOBFNE);
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
      if (BargainId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BargainId);
      }
      if (CurMood != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CurMood);
      }
      if (Unk3300KOCJELACJLM != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KOCJELACJLM);
      }
      if (Unk3300MHFDEBOBFNE != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MHFDEBOBFNE);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BargainSnapshot other) {
      if (other == null) {
        return;
      }
      if (other.BargainId != 0) {
        BargainId = other.BargainId;
      }
      if (other.CurMood != 0) {
        CurMood = other.CurMood;
      }
      if (other.Unk3300KOCJELACJLM != 0) {
        Unk3300KOCJELACJLM = other.Unk3300KOCJELACJLM;
      }
      if (other.Unk3300MHFDEBOBFNE != 0) {
        Unk3300MHFDEBOBFNE = other.Unk3300MHFDEBOBFNE;
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
          case 24: {
            BargainId = input.ReadUInt32();
            break;
          }
          case 64: {
            CurMood = input.ReadInt32();
            break;
          }
          case 88: {
            Unk3300KOCJELACJLM = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300MHFDEBOBFNE = input.ReadUInt32();
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
          case 24: {
            BargainId = input.ReadUInt32();
            break;
          }
          case 64: {
            CurMood = input.ReadInt32();
            break;
          }
          case 88: {
            Unk3300KOCJELACJLM = input.ReadUInt32();
            break;
          }
          case 112: {
            Unk3300MHFDEBOBFNE = input.ReadUInt32();
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
