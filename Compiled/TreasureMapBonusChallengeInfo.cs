// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TreasureMapBonusChallengeInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TreasureMapBonusChallengeInfo.proto</summary>
  public static partial class TreasureMapBonusChallengeInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for TreasureMapBonusChallengeInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TreasureMapBonusChallengeInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNUcmVhc3VyZU1hcEJvbnVzQ2hhbGxlbmdlSW5mby5wcm90bxINbWlIb21v",
            "LlByb3RvcyL0AQodVHJlYXN1cmVNYXBCb251c0NoYWxsZW5nZUluZm8SEQoJ",
            "Y29uZmlnX2lkGAogASgNEhEKCWlzX2FjdGl2ZRgNIAEoCBIPCgdpc19kb25l",
            "GAUgASgIEhMKC3NvbHV0aW9uX2lkGA8gASgNElMKDGZyYWdtZW50X21hcBgL",
            "IAMoCzI9Lm1pSG9tby5Qcm90b3MuVHJlYXN1cmVNYXBCb251c0NoYWxsZW5n",
            "ZUluZm8uRnJhZ21lbnRNYXBFbnRyeRoyChBGcmFnbWVudE1hcEVudHJ5EgsK",
            "A2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoCDoCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.TreasureMapBonusChallengeInfo), global::MiHomo.Protos.TreasureMapBonusChallengeInfo.Parser, new[]{ "ConfigId", "IsActive", "IsDone", "SolutionId", "FragmentMap" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class TreasureMapBonusChallengeInfo : pb::IMessage<TreasureMapBonusChallengeInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TreasureMapBonusChallengeInfo> _parser = new pb::MessageParser<TreasureMapBonusChallengeInfo>(() => new TreasureMapBonusChallengeInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TreasureMapBonusChallengeInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.TreasureMapBonusChallengeInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapBonusChallengeInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapBonusChallengeInfo(TreasureMapBonusChallengeInfo other) : this() {
      configId_ = other.configId_;
      isActive_ = other.isActive_;
      isDone_ = other.isDone_;
      solutionId_ = other.solutionId_;
      fragmentMap_ = other.fragmentMap_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TreasureMapBonusChallengeInfo Clone() {
      return new TreasureMapBonusChallengeInfo(this);
    }

    /// <summary>Field number for the "config_id" field.</summary>
    public const int ConfigIdFieldNumber = 10;
    private uint configId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ConfigId {
      get { return configId_; }
      set {
        configId_ = value;
      }
    }

    /// <summary>Field number for the "is_active" field.</summary>
    public const int IsActiveFieldNumber = 13;
    private bool isActive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsActive {
      get { return isActive_; }
      set {
        isActive_ = value;
      }
    }

    /// <summary>Field number for the "is_done" field.</summary>
    public const int IsDoneFieldNumber = 5;
    private bool isDone_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsDone {
      get { return isDone_; }
      set {
        isDone_ = value;
      }
    }

    /// <summary>Field number for the "solution_id" field.</summary>
    public const int SolutionIdFieldNumber = 15;
    private uint solutionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SolutionId {
      get { return solutionId_; }
      set {
        solutionId_ = value;
      }
    }

    /// <summary>Field number for the "fragment_map" field.</summary>
    public const int FragmentMapFieldNumber = 11;
    private static readonly pbc::MapField<uint, bool>.Codec _map_fragmentMap_codec
        = new pbc::MapField<uint, bool>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForBool(16, false), 90);
    private readonly pbc::MapField<uint, bool> fragmentMap_ = new pbc::MapField<uint, bool>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, bool> FragmentMap {
      get { return fragmentMap_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TreasureMapBonusChallengeInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TreasureMapBonusChallengeInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ConfigId != other.ConfigId) return false;
      if (IsActive != other.IsActive) return false;
      if (IsDone != other.IsDone) return false;
      if (SolutionId != other.SolutionId) return false;
      if (!FragmentMap.Equals(other.FragmentMap)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ConfigId != 0) hash ^= ConfigId.GetHashCode();
      if (IsActive != false) hash ^= IsActive.GetHashCode();
      if (IsDone != false) hash ^= IsDone.GetHashCode();
      if (SolutionId != 0) hash ^= SolutionId.GetHashCode();
      hash ^= FragmentMap.GetHashCode();
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
      if (IsDone != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDone);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ConfigId);
      }
      fragmentMap_.WriteTo(output, _map_fragmentMap_codec);
      if (IsActive != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsActive);
      }
      if (SolutionId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SolutionId);
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
      if (IsDone != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsDone);
      }
      if (ConfigId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(ConfigId);
      }
      fragmentMap_.WriteTo(ref output, _map_fragmentMap_codec);
      if (IsActive != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsActive);
      }
      if (SolutionId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SolutionId);
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
      if (ConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ConfigId);
      }
      if (IsActive != false) {
        size += 1 + 1;
      }
      if (IsDone != false) {
        size += 1 + 1;
      }
      if (SolutionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SolutionId);
      }
      size += fragmentMap_.CalculateSize(_map_fragmentMap_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TreasureMapBonusChallengeInfo other) {
      if (other == null) {
        return;
      }
      if (other.ConfigId != 0) {
        ConfigId = other.ConfigId;
      }
      if (other.IsActive != false) {
        IsActive = other.IsActive;
      }
      if (other.IsDone != false) {
        IsDone = other.IsDone;
      }
      if (other.SolutionId != 0) {
        SolutionId = other.SolutionId;
      }
      fragmentMap_.Add(other.fragmentMap_);
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
          case 40: {
            IsDone = input.ReadBool();
            break;
          }
          case 80: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 90: {
            fragmentMap_.AddEntriesFrom(input, _map_fragmentMap_codec);
            break;
          }
          case 104: {
            IsActive = input.ReadBool();
            break;
          }
          case 120: {
            SolutionId = input.ReadUInt32();
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
          case 40: {
            IsDone = input.ReadBool();
            break;
          }
          case 80: {
            ConfigId = input.ReadUInt32();
            break;
          }
          case 90: {
            fragmentMap_.AddEntriesFrom(ref input, _map_fragmentMap_codec);
            break;
          }
          case 104: {
            IsActive = input.ReadBool();
            break;
          }
          case 120: {
            SolutionId = input.ReadUInt32();
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
