// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: OtherCustomDungeonBrief.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from OtherCustomDungeonBrief.proto</summary>
  public static partial class OtherCustomDungeonBriefReflection {

    #region Descriptor
    /// <summary>File descriptor for OtherCustomDungeonBrief.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OtherCustomDungeonBriefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1PdGhlckN1c3RvbUR1bmdlb25CcmllZi5wcm90bxINbWlIb21vLlByb3Rv",
            "cxobQ3VzdG9tRHVuZ2VvbkFic3RyYWN0LnByb3RvGhpDdXN0b21EdW5nZW9u",
            "U2V0dGluZy5wcm90bxoZQ3VzdG9tRHVuZ2VvblNvY2lhbC5wcm90bxoSU29j",
            "aWFsRGV0YWlsLnByb3RvIpQDChdPdGhlckN1c3RvbUR1bmdlb25CcmllZhI2",
            "CghhYnN0cmFjdBgCIAEoCzIkLm1pSG9tby5Qcm90b3MuQ3VzdG9tRHVuZ2Vv",
            "bkFic3RyYWN0EhwKFGJhdHRsZV9taW5fY29zdF90aW1lGA8gASgNEjMKDmNy",
            "ZWF0b3JfZGV0YWlsGAQgASgLMhsubWlIb21vLlByb3Rvcy5Tb2NpYWxEZXRh",
            "aWwSFAoMZHVuZ2Vvbl9ndWlkGA4gASgEEhIKCmR1bmdlb25faWQYBiABKA0S",
            "HAoUaXNfYWR2ZW50dXJlX2R1bmdlb24YCyABKAgSFwoPaXNfcHNuX3BsYXRm",
            "b3JtGAkgASgIEhEKCWlzX3N0b3JlZBgDIAEoCBI0CgdzZXR0aW5nGAogASgL",
            "MiMubWlIb21vLlByb3Rvcy5DdXN0b21EdW5nZW9uU2V0dGluZxIyCgZzb2Np",
            "YWwYDCABKAsyIi5taUhvbW8uUHJvdG9zLkN1c3RvbUR1bmdlb25Tb2NpYWwS",
            "EAoIdGFnX2xpc3QYASADKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.CustomDungeonAbstractReflection.Descriptor, global::MiHomo.Protos.CustomDungeonSettingReflection.Descriptor, global::MiHomo.Protos.CustomDungeonSocialReflection.Descriptor, global::MiHomo.Protos.SocialDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.OtherCustomDungeonBrief), global::MiHomo.Protos.OtherCustomDungeonBrief.Parser, new[]{ "Abstract", "BattleMinCostTime", "CreatorDetail", "DungeonGuid", "DungeonId", "IsAdventureDungeon", "IsPsnPlatform", "IsStored", "Setting", "Social", "TagList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OtherCustomDungeonBrief : pb::IMessage<OtherCustomDungeonBrief>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OtherCustomDungeonBrief> _parser = new pb::MessageParser<OtherCustomDungeonBrief>(() => new OtherCustomDungeonBrief());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OtherCustomDungeonBrief> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.OtherCustomDungeonBriefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief(OtherCustomDungeonBrief other) : this() {
      abstract_ = other.abstract_ != null ? other.abstract_.Clone() : null;
      battleMinCostTime_ = other.battleMinCostTime_;
      creatorDetail_ = other.creatorDetail_ != null ? other.creatorDetail_.Clone() : null;
      dungeonGuid_ = other.dungeonGuid_;
      dungeonId_ = other.dungeonId_;
      isAdventureDungeon_ = other.isAdventureDungeon_;
      isPsnPlatform_ = other.isPsnPlatform_;
      isStored_ = other.isStored_;
      setting_ = other.setting_ != null ? other.setting_.Clone() : null;
      social_ = other.social_ != null ? other.social_.Clone() : null;
      tagList_ = other.tagList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OtherCustomDungeonBrief Clone() {
      return new OtherCustomDungeonBrief(this);
    }

    /// <summary>Field number for the "abstract" field.</summary>
    public const int AbstractFieldNumber = 2;
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

    /// <summary>Field number for the "creator_detail" field.</summary>
    public const int CreatorDetailFieldNumber = 4;
    private global::MiHomo.Protos.SocialDetail creatorDetail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.SocialDetail CreatorDetail {
      get { return creatorDetail_; }
      set {
        creatorDetail_ = value;
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
    public const int DungeonIdFieldNumber = 6;
    private uint dungeonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DungeonId {
      get { return dungeonId_; }
      set {
        dungeonId_ = value;
      }
    }

    /// <summary>Field number for the "is_adventure_dungeon" field.</summary>
    public const int IsAdventureDungeonFieldNumber = 11;
    private bool isAdventureDungeon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAdventureDungeon {
      get { return isAdventureDungeon_; }
      set {
        isAdventureDungeon_ = value;
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

    /// <summary>Field number for the "is_stored" field.</summary>
    public const int IsStoredFieldNumber = 3;
    private bool isStored_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStored {
      get { return isStored_; }
      set {
        isStored_ = value;
      }
    }

    /// <summary>Field number for the "setting" field.</summary>
    public const int SettingFieldNumber = 10;
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
    public const int SocialFieldNumber = 12;
    private global::MiHomo.Protos.CustomDungeonSocial social_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CustomDungeonSocial Social {
      get { return social_; }
      set {
        social_ = value;
      }
    }

    /// <summary>Field number for the "tag_list" field.</summary>
    public const int TagListFieldNumber = 1;
    private static readonly pb::FieldCodec<uint> _repeated_tagList_codec
        = pb::FieldCodec.ForUInt32(10);
    private readonly pbc::RepeatedField<uint> tagList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TagList {
      get { return tagList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OtherCustomDungeonBrief);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OtherCustomDungeonBrief other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Abstract, other.Abstract)) return false;
      if (BattleMinCostTime != other.BattleMinCostTime) return false;
      if (!object.Equals(CreatorDetail, other.CreatorDetail)) return false;
      if (DungeonGuid != other.DungeonGuid) return false;
      if (DungeonId != other.DungeonId) return false;
      if (IsAdventureDungeon != other.IsAdventureDungeon) return false;
      if (IsPsnPlatform != other.IsPsnPlatform) return false;
      if (IsStored != other.IsStored) return false;
      if (!object.Equals(Setting, other.Setting)) return false;
      if (!object.Equals(Social, other.Social)) return false;
      if(!tagList_.Equals(other.tagList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (abstract_ != null) hash ^= Abstract.GetHashCode();
      if (BattleMinCostTime != 0) hash ^= BattleMinCostTime.GetHashCode();
      if (creatorDetail_ != null) hash ^= CreatorDetail.GetHashCode();
      if (DungeonGuid != 0UL) hash ^= DungeonGuid.GetHashCode();
      if (DungeonId != 0) hash ^= DungeonId.GetHashCode();
      if (IsAdventureDungeon != false) hash ^= IsAdventureDungeon.GetHashCode();
      if (IsPsnPlatform != false) hash ^= IsPsnPlatform.GetHashCode();
      if (IsStored != false) hash ^= IsStored.GetHashCode();
      if (setting_ != null) hash ^= Setting.GetHashCode();
      if (social_ != null) hash ^= Social.GetHashCode();
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
      tagList_.WriteTo(output, _repeated_tagList_codec);
      if (abstract_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Abstract);
      }
      if (IsStored != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsStored);
      }
      if (creatorDetail_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreatorDetail);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (setting_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Setting);
      }
      if (IsAdventureDungeon != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAdventureDungeon);
      }
      if (social_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Social);
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
      tagList_.WriteTo(ref output, _repeated_tagList_codec);
      if (abstract_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Abstract);
      }
      if (IsStored != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsStored);
      }
      if (creatorDetail_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreatorDetail);
      }
      if (DungeonId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(DungeonId);
      }
      if (IsPsnPlatform != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsPsnPlatform);
      }
      if (setting_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(Setting);
      }
      if (IsAdventureDungeon != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsAdventureDungeon);
      }
      if (social_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Social);
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
      if (creatorDetail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatorDetail);
      }
      if (DungeonGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DungeonGuid);
      }
      if (DungeonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DungeonId);
      }
      if (IsAdventureDungeon != false) {
        size += 1 + 1;
      }
      if (IsPsnPlatform != false) {
        size += 1 + 1;
      }
      if (IsStored != false) {
        size += 1 + 1;
      }
      if (setting_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Setting);
      }
      if (social_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Social);
      }
      size += tagList_.CalculateSize(_repeated_tagList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OtherCustomDungeonBrief other) {
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
      if (other.creatorDetail_ != null) {
        if (creatorDetail_ == null) {
          CreatorDetail = new global::MiHomo.Protos.SocialDetail();
        }
        CreatorDetail.MergeFrom(other.CreatorDetail);
      }
      if (other.DungeonGuid != 0UL) {
        DungeonGuid = other.DungeonGuid;
      }
      if (other.DungeonId != 0) {
        DungeonId = other.DungeonId;
      }
      if (other.IsAdventureDungeon != false) {
        IsAdventureDungeon = other.IsAdventureDungeon;
      }
      if (other.IsPsnPlatform != false) {
        IsPsnPlatform = other.IsPsnPlatform;
      }
      if (other.IsStored != false) {
        IsStored = other.IsStored;
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
          case 10:
          case 8: {
            tagList_.AddEntriesFrom(input, _repeated_tagList_codec);
            break;
          }
          case 18: {
            if (abstract_ == null) {
              Abstract = new global::MiHomo.Protos.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 24: {
            IsStored = input.ReadBool();
            break;
          }
          case 34: {
            if (creatorDetail_ == null) {
              CreatorDetail = new global::MiHomo.Protos.SocialDetail();
            }
            input.ReadMessage(CreatorDetail);
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            if (setting_ == null) {
              Setting = new global::MiHomo.Protos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 88: {
            IsAdventureDungeon = input.ReadBool();
            break;
          }
          case 98: {
            if (social_ == null) {
              Social = new global::MiHomo.Protos.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
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
          case 10:
          case 8: {
            tagList_.AddEntriesFrom(ref input, _repeated_tagList_codec);
            break;
          }
          case 18: {
            if (abstract_ == null) {
              Abstract = new global::MiHomo.Protos.CustomDungeonAbstract();
            }
            input.ReadMessage(Abstract);
            break;
          }
          case 24: {
            IsStored = input.ReadBool();
            break;
          }
          case 34: {
            if (creatorDetail_ == null) {
              CreatorDetail = new global::MiHomo.Protos.SocialDetail();
            }
            input.ReadMessage(CreatorDetail);
            break;
          }
          case 48: {
            DungeonId = input.ReadUInt32();
            break;
          }
          case 72: {
            IsPsnPlatform = input.ReadBool();
            break;
          }
          case 82: {
            if (setting_ == null) {
              Setting = new global::MiHomo.Protos.CustomDungeonSetting();
            }
            input.ReadMessage(Setting);
            break;
          }
          case 88: {
            IsAdventureDungeon = input.ReadBool();
            break;
          }
          case 98: {
            if (social_ == null) {
              Social = new global::MiHomo.Protos.CustomDungeonSocial();
            }
            input.ReadMessage(Social);
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
