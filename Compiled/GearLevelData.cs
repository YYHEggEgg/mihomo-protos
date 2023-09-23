// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GearLevelData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GearLevelData.proto</summary>
  public static partial class GearLevelDataReflection {

    #region Descriptor
    /// <summary>File descriptor for GearLevelData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GearLevelDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNHZWFyTGV2ZWxEYXRhLnByb3RvEg1taUhvbW8uUHJvdG9zIpQBCg1HZWFy",
            "TGV2ZWxEYXRhEhMKC2lzX2ZpbmlzaGVkGAMgASgIEg8KB2lzX29wZW4YBSAB",
            "KAgSEAoIbGV2ZWxfaWQYCiABKA0SEQoJb3Blbl90aW1lGAsgASgNEhsKE1Vu",
            "azMzMDBfREZHSEtEQkVORUQYBCABKA0SGwoTVW5rMzMwMF9GSUtQTEdKSUJH",
            "UBgPIAEoDWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GearLevelData), global::MiHomo.Protos.GearLevelData.Parser, new[]{ "IsFinished", "IsOpen", "LevelId", "OpenTime", "Unk3300DFGHKDBENED", "Unk3300FIKPLGJIBGP" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GearLevelData : pb::IMessage<GearLevelData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GearLevelData> _parser = new pb::MessageParser<GearLevelData>(() => new GearLevelData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GearLevelData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GearLevelDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearLevelData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearLevelData(GearLevelData other) : this() {
      isFinished_ = other.isFinished_;
      isOpen_ = other.isOpen_;
      levelId_ = other.levelId_;
      openTime_ = other.openTime_;
      unk3300DFGHKDBENED_ = other.unk3300DFGHKDBENED_;
      unk3300FIKPLGJIBGP_ = other.unk3300FIKPLGJIBGP_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GearLevelData Clone() {
      return new GearLevelData(this);
    }

    /// <summary>Field number for the "is_finished" field.</summary>
    public const int IsFinishedFieldNumber = 3;
    private bool isFinished_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinished {
      get { return isFinished_; }
      set {
        isFinished_ = value;
      }
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 5;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "level_id" field.</summary>
    public const int LevelIdFieldNumber = 10;
    private uint levelId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LevelId {
      get { return levelId_; }
      set {
        levelId_ = value;
      }
    }

    /// <summary>Field number for the "open_time" field.</summary>
    public const int OpenTimeFieldNumber = 11;
    private uint openTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OpenTime {
      get { return openTime_; }
      set {
        openTime_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DFGHKDBENED" field.</summary>
    public const int Unk3300DFGHKDBENEDFieldNumber = 4;
    private uint unk3300DFGHKDBENED_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300DFGHKDBENED {
      get { return unk3300DFGHKDBENED_; }
      set {
        unk3300DFGHKDBENED_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FIKPLGJIBGP" field.</summary>
    public const int Unk3300FIKPLGJIBGPFieldNumber = 15;
    private uint unk3300FIKPLGJIBGP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300FIKPLGJIBGP {
      get { return unk3300FIKPLGJIBGP_; }
      set {
        unk3300FIKPLGJIBGP_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GearLevelData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GearLevelData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsFinished != other.IsFinished) return false;
      if (IsOpen != other.IsOpen) return false;
      if (LevelId != other.LevelId) return false;
      if (OpenTime != other.OpenTime) return false;
      if (Unk3300DFGHKDBENED != other.Unk3300DFGHKDBENED) return false;
      if (Unk3300FIKPLGJIBGP != other.Unk3300FIKPLGJIBGP) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsFinished != false) hash ^= IsFinished.GetHashCode();
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (LevelId != 0) hash ^= LevelId.GetHashCode();
      if (OpenTime != 0) hash ^= OpenTime.GetHashCode();
      if (Unk3300DFGHKDBENED != 0) hash ^= Unk3300DFGHKDBENED.GetHashCode();
      if (Unk3300FIKPLGJIBGP != 0) hash ^= Unk3300FIKPLGJIBGP.GetHashCode();
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
      if (IsFinished != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFinished);
      }
      if (Unk3300DFGHKDBENED != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300DFGHKDBENED);
      }
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (LevelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelId);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OpenTime);
      }
      if (Unk3300FIKPLGJIBGP != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300FIKPLGJIBGP);
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
      if (IsFinished != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsFinished);
      }
      if (Unk3300DFGHKDBENED != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Unk3300DFGHKDBENED);
      }
      if (IsOpen != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsOpen);
      }
      if (LevelId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(LevelId);
      }
      if (OpenTime != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(OpenTime);
      }
      if (Unk3300FIKPLGJIBGP != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300FIKPLGJIBGP);
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
      if (IsFinished != false) {
        size += 1 + 1;
      }
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (LevelId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelId);
      }
      if (OpenTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OpenTime);
      }
      if (Unk3300DFGHKDBENED != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300DFGHKDBENED);
      }
      if (Unk3300FIKPLGJIBGP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300FIKPLGJIBGP);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GearLevelData other) {
      if (other == null) {
        return;
      }
      if (other.IsFinished != false) {
        IsFinished = other.IsFinished;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.LevelId != 0) {
        LevelId = other.LevelId;
      }
      if (other.OpenTime != 0) {
        OpenTime = other.OpenTime;
      }
      if (other.Unk3300DFGHKDBENED != 0) {
        Unk3300DFGHKDBENED = other.Unk3300DFGHKDBENED;
      }
      if (other.Unk3300FIKPLGJIBGP != 0) {
        Unk3300FIKPLGJIBGP = other.Unk3300FIKPLGJIBGP;
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
            IsFinished = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300DFGHKDBENED = input.ReadUInt32();
            break;
          }
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 80: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 88: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300FIKPLGJIBGP = input.ReadUInt32();
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
            IsFinished = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300DFGHKDBENED = input.ReadUInt32();
            break;
          }
          case 40: {
            IsOpen = input.ReadBool();
            break;
          }
          case 80: {
            LevelId = input.ReadUInt32();
            break;
          }
          case 88: {
            OpenTime = input.ReadUInt32();
            break;
          }
          case 120: {
            Unk3300FIKPLGJIBGP = input.ReadUInt32();
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
