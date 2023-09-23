// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonVerify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CustomDungeonVerify.proto</summary>
  public static partial class CustomDungeonVerifyReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonVerify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonVerifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDdXN0b21EdW5nZW9uVmVyaWZ5LnByb3RvEg1taUhvbW8uUHJvdG9zImkK",
            "E0N1c3RvbUR1bmdlb25WZXJpZnkSFAoMZHVuZ2Vvbl9ndWlkGAEgASgEEgwK",
            "BGxhbmcYBiABKA0SDgoGcmVnaW9uGA0gASgJEhEKCXRpbWVzdGFtcBgFIAEo",
            "DRILCgN1aWQYAyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CustomDungeonVerify), global::MiHomo.Protos.CustomDungeonVerify.Parser, new[]{ "DungeonGuid", "Lang", "Region", "Timestamp", "Uid" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonVerify : pb::IMessage<CustomDungeonVerify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonVerify> _parser = new pb::MessageParser<CustomDungeonVerify>(() => new CustomDungeonVerify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonVerify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CustomDungeonVerifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonVerify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonVerify(CustomDungeonVerify other) : this() {
      dungeonGuid_ = other.dungeonGuid_;
      lang_ = other.lang_;
      region_ = other.region_;
      timestamp_ = other.timestamp_;
      uid_ = other.uid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonVerify Clone() {
      return new CustomDungeonVerify(this);
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 1;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    /// <summary>Field number for the "lang" field.</summary>
    public const int LangFieldNumber = 6;
    private uint lang_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Lang {
      get { return lang_; }
      set {
        lang_ = value;
      }
    }

    /// <summary>Field number for the "region" field.</summary>
    public const int RegionFieldNumber = 13;
    private string region_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 5;
    private uint timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 3;
    private uint uid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Uid {
      get { return uid_; }
      set {
        uid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonVerify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonVerify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DungeonGuid != other.DungeonGuid) return false;
      if (Lang != other.Lang) return false;
      if (Region != other.Region) return false;
      if (Timestamp != other.Timestamp) return false;
      if (Uid != other.Uid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (Lang != 0) hash ^= Lang.GetHashCode();
      if (Region.Length != 0) hash ^= Region.GetHashCode();
      if (Timestamp != 0) hash ^= Timestamp.GetHashCode();
      if (Uid != 0) hash ^= Uid.GetHashCode();
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
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DungeonGuid);
      }
      if (Uid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Uid);
      }
      if (Timestamp != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Timestamp);
      }
      if (Lang != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Lang);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Region);
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
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(DungeonGuid);
      }
      if (Uid != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Uid);
      }
      if (Timestamp != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Timestamp);
      }
      if (Lang != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Lang);
      }
      if (Region.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Region);
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
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (Lang != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Lang);
      }
      if (Region.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Region);
      }
      if (Timestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Timestamp);
      }
      if (Uid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonVerify other) {
      if (other == null) {
        return;
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.Lang != 0) {
        Lang = other.Lang;
      }
      if (other.Region.Length != 0) {
        Region = other.Region;
      }
      if (other.Timestamp != 0) {
        Timestamp = other.Timestamp;
      }
      if (other.Uid != 0) {
        Uid = other.Uid;
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
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 24: {
            Uid = input.ReadUInt32();
            break;
          }
          case 40: {
            Timestamp = input.ReadUInt32();
            break;
          }
          case 48: {
            Lang = input.ReadUInt32();
            break;
          }
          case 106: {
            Region = input.ReadString();
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
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 24: {
            Uid = input.ReadUInt32();
            break;
          }
          case 40: {
            Timestamp = input.ReadUInt32();
            break;
          }
          case 48: {
            Lang = input.ReadUInt32();
            break;
          }
          case 106: {
            Region = input.ReadString();
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
