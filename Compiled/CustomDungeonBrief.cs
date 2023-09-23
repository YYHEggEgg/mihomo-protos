// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CustomDungeonBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CustomDungeonBrief.proto</summary>
  public static partial class CustomDungeonBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for CustomDungeonBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomDungeonBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDdXN0b21EdW5nZW9uQnJpZWYucHJvdG8SDW1pSG9tby5Qcm90b3MaG0N1",
            "c3RvbUR1bmdlb25BYnN0cmFjdC5wcm90bxoaQ3VzdG9tRHVuZ2VvblNldHRp",
            "bmcucHJvdG8aGUN1c3RvbUR1bmdlb25Tb2NpYWwucHJvdG8aGEN1c3RvbUR1",
            "bmdlb25TdGF0ZS5wcm90byLzAgoSQ3VzdG9tRHVuZ2VvbkJyaWVmEjYKCGFi",
            "c3RyYWN0GAggASgLMiQubWlIb21vLlByb3Rvcy5DdXN0b21EdW5nZW9uQWJz",
            "dHJhY3QSHAoUYmF0dGxlX21pbl9jb3N0X3RpbWUYDyABKA0SFAoMZHVuZ2Vv",
            "bl9ndWlkGA4gASgEEhIKCmR1bmdlb25faWQYAyABKA0SFwoPaXNfcHNuX3Bs",
            "YXRmb3JtGAkgASgIEhYKDmxhc3Rfc2F2ZV90aW1lGAwgASgNEjQKB3NldHRp",
            "bmcYByABKAsyIy5taUhvbW8uUHJvdG9zLkN1c3RvbUR1bmdlb25TZXR0aW5n",
            "EjIKBnNvY2lhbBgKIAEoCzIiLm1pSG9tby5Qcm90b3MuQ3VzdG9tRHVuZ2Vv",
            "blNvY2lhbBIwCgVzdGF0ZRgCIAEoDjIhLm1pSG9tby5Qcm90b3MuQ3VzdG9t",
            "RHVuZ2VvblN0YXRlEhAKCHRhZ19saXN0GAQgAygNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CustomDungeonAbstractReflection.Descriptor, global::MiHomo.Protos.CustomDungeonSettingReflection.Descriptor, global::MiHomo.Protos.CustomDungeonSocialReflection.Descriptor, global::MiHomo.Protos.CustomDungeonStateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CustomDungeonBrief), global::MiHomo.Protos.CustomDungeonBrief.Parser, new[]{ "Abstract", "BattleMinCostTime", "DungeonGuid", "DungeonId", "IsPsnPlatform", "LastSaveTime", "Setting", "Social", "State", "TagList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomDungeonBrief : pb::IMessage<CustomDungeonBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomDungeonBrief> _parser = new pb::MessageParser<CustomDungeonBrief>(() => new CustomDungeonBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomDungeonBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CustomDungeonBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBrief(CustomDungeonBrief other) : this() {
      abstract_ = other.abstract_ != null ? other.abstract_.Clone() : null;
      battleMinCostTime_ = other.battleMinCostTime_;
      dungeonGuid_ = other.dungeonGuid_;
      dungeonId_ = other.dungeonId_;
      isPsnPlatform_ = other.isPsnPlatform_;
      lastSaveTime_ = other.lastSaveTime_;
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      social_ = other.social_ != null ? other.social_.Clone() : null;
      state_ = other.state_;
      tagList_ = other.tagList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomDungeonBrief Clone() {
      return new CustomDungeonBrief(this);
    }

    /// <summary>Field number for the "abstract" field.</summary>
    public const int AbstractFieldNumber = 8;
    private global::MiHomo.Protos.CustomDungeonAbstract abstract_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomDungeonAbstract Abstract {
      get { return abstract_; }
      set {
        abstract_ = value;
      }
    }

    /// <summary>Field number for the "battle_min_cost_time" field.</summary>
    public const int BattleMinCostTimeFieldNumber = 15;
    private uint battleMinCostTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BattleMinCostTime {
      get { return battleMinCostTime_; }
      set {
        battleMinCostTime_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_guid" field.</summary>
    public const int DungeonGuidFieldNumber = 14;
    private ulong dungeonGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong DungeonGuid {
      get { return dungeonGuid_; }
      set {
        dungeonGuid_ = value;
      }
    }

    /// <summary>Field number for the "dungeon_id" field.</summary>
    public const int DungeonIdFieldNumber = 3;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "is_psn_platform" field.</summary>
    public const int IsPsnPlatformFieldNumber = 9;
    private bool isPsnPlatform_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPsnPlatform {
      get { return isPsnPlatform_; }
      set {
        isPsnPlatform_ = value;
      }
    }

    /// <summary>Field number for the "last_save_time" field.</summary>
    public const int LastSaveTimeFieldNumber = 12;
    private uint lastSaveTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LastSaveTime {
      get { return lastSaveTime_; }
      set {
        lastSaveTime_ = value;
      }
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 7;
    private global::MiHomo.Protos.CustomDungeonSetting setting_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomDungeonSetting Setting {
      get { return setting_; }
      set {
        setting_ = value;
      }
    }

    /// <summary>Field number for the "social" field.</summary>
    public const int SocialFieldNumber = 10;
    private global::MiHomo.Protos.CustomDungeonSocial social_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomDungeonSocial Social {
      get { return social_; }
      set {
        social_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 2;
    private global::MiHomo.Protos.CustomDungeonState state_ = global::MiHomo.Protos.CustomDungeonState.Edit;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomDungeonState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TagList {
      get { return tagList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomDungeonBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomDungeonBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Abstract, other.Abstract)) return false;
      if (BattleMinCostTime != other.BattleMinCostTime) return false;
      if (DungeonGuid != other.DungeonGuid) return false;
      if (DungeonId != other.DungeonId) return false;
      if (IsPsnPlatform != other.IsPsnPlatform) return false;
      if (LastSaveTime != other.LastSaveTime) return false;
      if (!object.Equals(Setting, other.Setting)) return false;
      if (!object.Equals(Social, other.Social)) return false;
      if (State != other.State) return false;
      if(!tagList_.Equals(other.tagList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (abstract_ != null) hash ^= Abstract.GetHashCode();
      if (BattleMinCostTime != 0) hash ^= BattleMinCostTime.GetHashCode();
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (IsPsnPlatform != false) hash ^= IsPsnPlatform.GetHashCode();
      if (LastSaveTime != 0) hash ^= LastSaveTime.GetHashCode();
      if (setting_ != null) hash ^= Setting.GetHashCode();
      if (social_ != null) hash ^= Social.GetHashCode();
      if (State != global::MiHomo.Protos.CustomDungeonState.Edit) hash ^= State.GetHashCode();
      hash ^= tagList_.GetHashCode();
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
      if (State != global::MiHomo.Protos.CustomDungeonState.Edit) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      tagList_.WriteTo(output, _repeated_tagList_codec);
      if (setting_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Setting);
      }
      if (abstract_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Abstract);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (social_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Social);
      }
      if (LastSaveTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LastSaveTime);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(DungeonGuid);
      }
      if (BattleMinCostTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattleMinCostTime);
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
      if (State != global::MiHomo.Protos.CustomDungeonState.Edit) {
        output.WriteRawTag(16);
        output.WriteEnum((int) State);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DungeonId);
      }
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (setting_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Setting);
      }
      if (abstract_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(Abstract);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (social_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Social);
      }
      if (LastSaveTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(LastSaveTime);
      }
      if (DungeonGuid != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(DungeonGuid);
      }
      if (BattleMinCostTime != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(BattleMinCostTime);
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
      if (abstract_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Abstract);
      }
      if (BattleMinCostTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BattleMinCostTime);
      }
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (IsPsnPlatform != false) {
        size += 1 + 1;
      }
      if (LastSaveTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LastSaveTime);
      }
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      if (social_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Social);
      }
      if (State != global::MiHomo.Protos.CustomDungeonState.Edit) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomDungeonBrief other) {
      if (other == null) {
        return;
      }
      if (other.abstract_ != null) {
        if (abstract_ == null) {
          Abstract = new global::MiHomo.Protos.CustomDungeonAbstract();
        }
        Abstract.MergeFrom(other.Abstract);
      }
      if (other.BattleMinCostTime != 0) {
        BattleMinCostTime = other.BattleMinCostTime;
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.IsPsnPlatform != false) {
        IsPsnPlatform = other.IsPsnPlatform;
      }
      if (other.LastSaveTime != 0) {
        LastSaveTime = other.LastSaveTime;
      }
      if (other.setting_ != null) {
        if (setting_ == null) {
          Setting = new global::MiHomo.Protos.CustomDungeonSetting();
        }
        Setting.MergeFrom(other.Setting);
      }
      if (other.social_ != null) {
        if (social_ == null) {
          Social = new global::MiHomo.Protos.CustomDungeonSocial();
        }
        Social.MergeFrom(other.Social);
      }
      if (other.State != global::MiHomo.Protos.CustomDungeonState.Edit) {
        State = other.State;
      }
      tagList_.Add(other.tagList_);
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
            State = (global::MiHomo.Protos.CustomDungeonState) input.ReadEnum();
            break;
          }
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
            break;
          }
          case 58: {
            if (setting_ == null) {
              Setting = new global::MiHomo.Protos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 66: {
            if (abstract_ == null) {
              Abstract = new global::MiHomo.Protos.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            if (social_ == null) {
              Social = new global::MiHomo.Protos.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
            break;
          }
          case 96: {
            LastSaveTime = input.ReadUInt32();
            break;
          }
          case 112: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 120: {
            BattleMinCostTime = input.ReadUInt32();
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
            State = (global::MiHomo.Protos.CustomDungeonState) input.ReadEnum();
            break;
          }
          case 24: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
            break;
          }
          case 58: {
            if (setting_ == null) {
              Setting = new global::MiHomo.Protos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 66: {
            if (abstract_ == null) {
              Abstract = new global::MiHomo.Protos.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            if (social_ == null) {
              Social = new global::MiHomo.Protos.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
            break;
          }
          case 96: {
            LastSaveTime = input.ReadUInt32();
            break;
          }
          case 112: {
            DungeonGuid = input.ReadUInt64();
            break;
          }
          case 120: {
            BattleMinCostTime = input.ReadUInt32();
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
