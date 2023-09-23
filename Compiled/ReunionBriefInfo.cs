// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReunionBriefInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ReunionBriefInfo.proto</summary>
  public static partial class ReunionBriefInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ReunionBriefInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReunionBriefInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZSZXVuaW9uQnJpZWZJbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zGhpSZXVu",
            "aW9uUHJpdmlsZWdlSW5mby5wcm90byLfAgoQUmV1bmlvbkJyaWVmSW5mbxIT",
            "CgtmaW5pc2hfdGltZRgMIAEoDRIcChRmaXJzdF9kYXlfc3RhcnRfdGltZRgD",
            "IAEoDRIcChRmaXJzdF9naWZ0X3Jld2FyZF9pZBgPIAEoDRIbChNpc190YWtl",
            "bl9maXJzdF9naWZ0GAggASgIEhoKEm1pc3Npb25faGFzX3Jld2FyZBgJIAEo",
            "CBISCgptaXNzaW9uX2lkGAogASgNEhQKDHByaXZpbGVnZV9pZBgFIAEoDRI7",
            "Cg5wcml2aWxlZ2VfaW5mbxgOIAEoCzIjLm1pSG9tby5Qcm90b3MuUmV1bmlv",
            "blByaXZpbGVnZUluZm8SGQoRc2lnbl9pbl9jb25maWdfaWQYBiABKA0SGgoS",
            "c2lnbl9pbl9oYXNfcmV3YXJkGAIgASgIEhIKCnN0YXJ0X3RpbWUYByABKA0S",
            "DwoHdmVyc2lvbhgNIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.ReunionPrivilegeInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ReunionBriefInfo), global::MiHomo.Protos.ReunionBriefInfo.Parser, new[]{ "FinishTime", "FirstDayStartTime", "FirstGiftRewardId", "IsTakenFirstGift", "MissionHasReward", "MissionId", "PrivilegeId", "PrivilegeInfo", "SignInConfigId", "SignInHasReward", "StartTime", "Version" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ReunionBriefInfo : pb::IMessage<ReunionBriefInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ReunionBriefInfo> _parser = new pb::MessageParser<ReunionBriefInfo>(() => new ReunionBriefInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ReunionBriefInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ReunionBriefInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionBriefInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionBriefInfo(ReunionBriefInfo other) : this() {
      finishTime_ = other.finishTime_;
      firstDayStartTime_ = other.firstDayStartTime_;
      firstGiftRewardId_ = other.firstGiftRewardId_;
      isTakenFirstGift_ = other.isTakenFirstGift_;
      missionHasReward_ = other.missionHasReward_;
      missionId_ = other.missionId_;
      privilegeId_ = other.privilegeId_;
      privilegeInfo_ = other.privilegeInfo_ != null ? other.privilegeInfo_.Clone() : null;
      signInConfigId_ = other.signInConfigId_;
      signInHasReward_ = other.signInHasReward_;
      startTime_ = other.startTime_;
      version_ = other.version_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ReunionBriefInfo Clone() {
      return new ReunionBriefInfo(this);
    }

    /// <summary>Field number for the "finish_time" field.</summary>
    public const int FinishTimeFieldNumber = 12;
    private uint finishTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FinishTime {
      get { return finishTime_; }
      set {
        finishTime_ = value;
      }
    }

    /// <summary>Field number for the "first_day_start_time" field.</summary>
    public const int FirstDayStartTimeFieldNumber = 3;
    private uint firstDayStartTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FirstDayStartTime {
      get { return firstDayStartTime_; }
      set {
        firstDayStartTime_ = value;
      }
    }

    /// <summary>Field number for the "first_gift_reward_id" field.</summary>
    public const int FirstGiftRewardIdFieldNumber = 15;
    private uint firstGiftRewardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FirstGiftRewardId {
      get { return firstGiftRewardId_; }
      set {
        firstGiftRewardId_ = value;
      }
    }

    /// <summary>Field number for the "is_taken_first_gift" field.</summary>
    public const int IsTakenFirstGiftFieldNumber = 8;
    private bool isTakenFirstGift_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsTakenFirstGift {
      get { return isTakenFirstGift_; }
      set {
        isTakenFirstGift_ = value;
      }
    }

    /// <summary>Field number for the "mission_has_reward" field.</summary>
    public const int MissionHasRewardFieldNumber = 9;
    private bool missionHasReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool MissionHasReward {
      get { return missionHasReward_; }
      set {
        missionHasReward_ = value;
      }
    }

    /// <summary>Field number for the "mission_id" field.</summary>
    public const int MissionIdFieldNumber = 10;
    private uint missionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MissionId {
      get { return missionId_; }
      set {
        missionId_ = value;
      }
    }

    /// <summary>Field number for the "privilege_id" field.</summary>
    public const int PrivilegeIdFieldNumber = 5;
    private uint privilegeId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PrivilegeId {
      get { return privilegeId_; }
      set {
        privilegeId_ = value;
      }
    }

    /// <summary>Field number for the "privilege_info" field.</summary>
    public const int PrivilegeInfoFieldNumber = 14;
    private global::MiHomo.Protos.ReunionPrivilegeInfo privilegeInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.ReunionPrivilegeInfo PrivilegeInfo {
      get { return privilegeInfo_; }
      set {
        privilegeInfo_ = value;
      }
    }

    /// <summary>Field number for the "sign_in_config_id" field.</summary>
    public const int SignInConfigIdFieldNumber = 6;
    private uint signInConfigId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint SignInConfigId {
      get { return signInConfigId_; }
      set {
        signInConfigId_ = value;
      }
    }

    /// <summary>Field number for the "sign_in_has_reward" field.</summary>
    public const int SignInHasRewardFieldNumber = 2;
    private bool signInHasReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool SignInHasReward {
      get { return signInHasReward_; }
      set {
        signInHasReward_ = value;
      }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 7;
    private uint startTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 13;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ReunionBriefInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ReunionBriefInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FinishTime != other.FinishTime) return false;
      if (FirstDayStartTime != other.FirstDayStartTime) return false;
      if (FirstGiftRewardId != other.FirstGiftRewardId) return false;
      if (IsTakenFirstGift != other.IsTakenFirstGift) return false;
      if (MissionHasReward != other.MissionHasReward) return false;
      if (MissionId != other.MissionId) return false;
      if (PrivilegeId != other.PrivilegeId) return false;
      if (!object.Equals(PrivilegeInfo, other.PrivilegeInfo)) return false;
      if (SignInConfigId != other.SignInConfigId) return false;
      if (SignInHasReward != other.SignInHasReward) return false;
      if (StartTime != other.StartTime) return false;
      if (Version != other.Version) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (FinishTime != 0) hash ^= FinishTime.GetHashCode();
      if (FirstDayStartTime != 0) hash ^= FirstDayStartTime.GetHashCode();
      if (FirstGiftRewardId != 0) hash ^= FirstGiftRewardId.GetHashCode();
      if (IsTakenFirstGift != false) hash ^= IsTakenFirstGift.GetHashCode();
      if (MissionHasReward != false) hash ^= MissionHasReward.GetHashCode();
      if (MissionId != 0) hash ^= MissionId.GetHashCode();
      if (PrivilegeId != 0) hash ^= PrivilegeId.GetHashCode();
      if (privilegeInfo_ != null) hash ^= PrivilegeInfo.GetHashCode();
      if (SignInConfigId != 0) hash ^= SignInConfigId.GetHashCode();
      if (SignInHasReward != false) hash ^= SignInHasReward.GetHashCode();
      if (StartTime != 0) hash ^= StartTime.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
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
      if (SignInHasReward != false) {
        output.WriteRawTag(16);
        output.WriteBool(SignInHasReward);
      }
      if (FirstDayStartTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FirstDayStartTime);
      }
      if (PrivilegeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PrivilegeId);
      }
      if (SignInConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SignInConfigId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StartTime);
      }
      if (IsTakenFirstGift != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTakenFirstGift);
      }
      if (MissionHasReward != false) {
        output.WriteRawTag(72);
        output.WriteBool(MissionHasReward);
      }
      if (MissionId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MissionId);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FinishTime);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Version);
      }
      if (privilegeInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PrivilegeInfo);
      }
      if (FirstGiftRewardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FirstGiftRewardId);
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
      if (SignInHasReward != false) {
        output.WriteRawTag(16);
        output.WriteBool(SignInHasReward);
      }
      if (FirstDayStartTime != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(FirstDayStartTime);
      }
      if (PrivilegeId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(PrivilegeId);
      }
      if (SignInConfigId != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SignInConfigId);
      }
      if (StartTime != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(StartTime);
      }
      if (IsTakenFirstGift != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsTakenFirstGift);
      }
      if (MissionHasReward != false) {
        output.WriteRawTag(72);
        output.WriteBool(MissionHasReward);
      }
      if (MissionId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MissionId);
      }
      if (FinishTime != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(FinishTime);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(106);
        output.WriteString(Version);
      }
      if (privilegeInfo_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(PrivilegeInfo);
      }
      if (FirstGiftRewardId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(FirstGiftRewardId);
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
      if (FinishTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FinishTime);
      }
      if (FirstDayStartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FirstDayStartTime);
      }
      if (FirstGiftRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FirstGiftRewardId);
      }
      if (IsTakenFirstGift != false) {
        size += 1 + 1;
      }
      if (MissionHasReward != false) {
        size += 1 + 1;
      }
      if (MissionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MissionId);
      }
      if (PrivilegeId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PrivilegeId);
      }
      if (privilegeInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrivilegeInfo);
      }
      if (SignInConfigId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SignInConfigId);
      }
      if (SignInHasReward != false) {
        size += 1 + 1;
      }
      if (StartTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StartTime);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ReunionBriefInfo other) {
      if (other == null) {
        return;
      }
      if (other.FinishTime != 0) {
        FinishTime = other.FinishTime;
      }
      if (other.FirstDayStartTime != 0) {
        FirstDayStartTime = other.FirstDayStartTime;
      }
      if (other.FirstGiftRewardId != 0) {
        FirstGiftRewardId = other.FirstGiftRewardId;
      }
      if (other.IsTakenFirstGift != false) {
        IsTakenFirstGift = other.IsTakenFirstGift;
      }
      if (other.MissionHasReward != false) {
        MissionHasReward = other.MissionHasReward;
      }
      if (other.MissionId != 0) {
        MissionId = other.MissionId;
      }
      if (other.PrivilegeId != 0) {
        PrivilegeId = other.PrivilegeId;
      }
      if (other.privilegeInfo_ != null) {
        if (privilegeInfo_ == null) {
          PrivilegeInfo = new global::MiHomo.Protos.ReunionPrivilegeInfo();
        }
        PrivilegeInfo.MergeFrom(other.PrivilegeInfo);
      }
      if (other.SignInConfigId != 0) {
        SignInConfigId = other.SignInConfigId;
      }
      if (other.SignInHasReward != false) {
        SignInHasReward = other.SignInHasReward;
      }
      if (other.StartTime != 0) {
        StartTime = other.StartTime;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
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
          case 16: {
            SignInHasReward = input.ReadBool();
            break;
          }
          case 24: {
            FirstDayStartTime = input.ReadUInt32();
            break;
          }
          case 40: {
            PrivilegeId = input.ReadUInt32();
            break;
          }
          case 48: {
            SignInConfigId = input.ReadUInt32();
            break;
          }
          case 56: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 64: {
            IsTakenFirstGift = input.ReadBool();
            break;
          }
          case 72: {
            MissionHasReward = input.ReadBool();
            break;
          }
          case 80: {
            MissionId = input.ReadUInt32();
            break;
          }
          case 96: {
            FinishTime = input.ReadUInt32();
            break;
          }
          case 106: {
            Version = input.ReadString();
            break;
          }
          case 114: {
            if (privilegeInfo_ == null) {
              PrivilegeInfo = new global::MiHomo.Protos.ReunionPrivilegeInfo();
            }
            input.ReadMessage(PrivilegeInfo);
            break;
          }
          case 120: {
            FirstGiftRewardId = input.ReadUInt32();
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
            SignInHasReward = input.ReadBool();
            break;
          }
          case 24: {
            FirstDayStartTime = input.ReadUInt32();
            break;
          }
          case 40: {
            PrivilegeId = input.ReadUInt32();
            break;
          }
          case 48: {
            SignInConfigId = input.ReadUInt32();
            break;
          }
          case 56: {
            StartTime = input.ReadUInt32();
            break;
          }
          case 64: {
            IsTakenFirstGift = input.ReadBool();
            break;
          }
          case 72: {
            MissionHasReward = input.ReadBool();
            break;
          }
          case 80: {
            MissionId = input.ReadUInt32();
            break;
          }
          case 96: {
            FinishTime = input.ReadUInt32();
            break;
          }
          case 106: {
            Version = input.ReadString();
            break;
          }
          case 114: {
            if (privilegeInfo_ == null) {
              PrivilegeInfo = new global::MiHomo.Protos.ReunionPrivilegeInfo();
            }
            input.ReadMessage(PrivilegeInfo);
            break;
          }
          case 120: {
            FirstGiftRewardId = input.ReadUInt32();
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
