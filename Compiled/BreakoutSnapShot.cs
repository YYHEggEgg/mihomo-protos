// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BreakoutSnapShot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from BreakoutSnapShot.proto</summary>
  public static partial class BreakoutSnapShotReflection {

    #region Descriptor
    /// <summary>File descriptor for BreakoutSnapShot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BreakoutSnapShotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZCcmVha291dFNuYXBTaG90LnByb3RvEg1taUhvbW8uUHJvdG9zGhRCcmVh",
            "a291dEFjdGlvbi5wcm90bxokQnJlYWtvdXRFbGVtZW50UmVhY3Rpb25Db3Vu",
            "dGVyLnByb3RvGhxCcmVha291dFBoeXNpY2FsT2JqZWN0LnByb3RvGhhCcmVh",
            "a291dFNwYXduUG9pbnQucHJvdG8aIEJyZWFrb3V0U3luY0Nvbm5lY3RVaWRJ",
            "bmZvLnByb3RvIrkGChBCcmVha291dFNuYXBTaG90EjIKC2FjdGlvbl9saXN0",
            "GAUgAygLMh0ubWlIb21vLlByb3Rvcy5CcmVha291dEFjdGlvbhJRChpiYWxs",
            "X2VsZW1lbnRfcmVhY3Rpb25fbGlzdBgQIAMoCzItLm1pSG9tby5Qcm90b3Mu",
            "QnJlYWtvdXRFbGVtZW50UmVhY3Rpb25Db3VudGVyEjgKCWJhbGxfbGlzdBgD",
            "IAMoCzIlLm1pSG9tby5Qcm90b3MuQnJlYWtvdXRQaHlzaWNhbE9iamVjdBJS",
            "Chticmlja19lbGVtZW50X3JlYWN0aW9uX2xpc3QYDyADKAsyLS5taUhvbW8u",
            "UHJvdG9zLkJyZWFrb3V0RWxlbWVudFJlYWN0aW9uQ291bnRlchIYChBjbGll",
            "bnRfZ2FtZV90aW1lGAEgASgEEg0KBWNvbWJvGAkgASgNEkIKE2R5bmFtaWNf",
            "b2JqZWN0X2xpc3QYEiADKAsyJS5taUhvbW8uUHJvdG9zLkJyZWFrb3V0UGh5",
            "c2ljYWxPYmplY3QSFQoNaWRfaW5kZXhfbGlzdBgTIAMoDRIRCglpc19maW5p",
            "c2gYByABKAgSEgoKbGlmZV9jb3VudBgLIAEoDRIRCgltYXhfY29tYm8YCiAB",
            "KA0SQwoUcGh5c2ljYWxfb2JqZWN0X2xpc3QYBCADKAsyJS5taUhvbW8uUHJv",
            "dG9zLkJyZWFrb3V0UGh5c2ljYWxPYmplY3QSHAoUcmF3X2NsaWVudF9nYW1l",
            "X3RpbWUYFCABKAUSGQoRcmVtYWluaW5nX2Jvc3NfaHAYDiABKA0SDQoFc2Nv",
            "cmUYCCABKA0SGAoQc2VydmVyX2dhbWVfdGltZRgCIAEoBBI7ChBzcGF3bl9w",
            "b2ludF9saXN0GA0gAygLMiEubWlIb21vLlByb3Rvcy5CcmVha291dFNwYXdu",
            "UG9pbnQSQAoNdWlkX2luZm9fbGlzdBgRIAMoCzIpLm1pSG9tby5Qcm90b3Mu",
            "QnJlYWtvdXRTeW5jQ29ubmVjdFVpZEluZm8SEgoKd2F2ZV9pbmRleBgGIAEo",
            "DRIYChB3YXZlX3N1aXRlX2luZGV4GAwgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.BreakoutActionReflection.Descriptor, global::MiHomo.Protos.BreakoutElementReactionCounterReflection.Descriptor, global::MiHomo.Protos.BreakoutPhysicalObjectReflection.Descriptor, global::MiHomo.Protos.BreakoutSpawnPointReflection.Descriptor, global::MiHomo.Protos.BreakoutSyncConnectUidInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.BreakoutSnapShot), global::MiHomo.Protos.BreakoutSnapShot.Parser, new[]{ "ActionList", "BallElementReactionList", "BallList", "BrickElementReactionList", "ClientGameTime", "Combo", "DynamicObjectList", "IdIndexList", "IsFinish", "LifeCount", "MaxCombo", "PhysicalObjectList", "RawClientGameTime", "RemainingBossHp", "Score", "ServerGameTime", "SpawnPointList", "UidInfoList", "WaveIndex", "WaveSuiteIndex" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BreakoutSnapShot : pb::IMessage<BreakoutSnapShot>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BreakoutSnapShot> _parser = new pb::MessageParser<BreakoutSnapShot>(() => new BreakoutSnapShot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BreakoutSnapShot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.BreakoutSnapShotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutSnapShot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutSnapShot(BreakoutSnapShot other) : this() {
      actionList_ = other.actionList_.Clone();
      ballElementReactionList_ = other.ballElementReactionList_.Clone();
      ballList_ = other.ballList_.Clone();
      brickElementReactionList_ = other.brickElementReactionList_.Clone();
      clientGameTime_ = other.clientGameTime_;
      combo_ = other.combo_;
      dynamicObjectList_ = other.dynamicObjectList_.Clone();
      idIndexList_ = other.idIndexList_.Clone();
      isFinish_ = other.isFinish_;
      lifeCount_ = other.lifeCount_;
      maxCombo_ = other.maxCombo_;
      physicalObjectList_ = other.physicalObjectList_.Clone();
      rawClientGameTime_ = other.rawClientGameTime_;
      remainingBossHp_ = other.remainingBossHp_;
      score_ = other.score_;
      serverGameTime_ = other.serverGameTime_;
      spawnPointList_ = other.spawnPointList_.Clone();
      uidInfoList_ = other.uidInfoList_.Clone();
      waveIndex_ = other.waveIndex_;
      waveSuiteIndex_ = other.waveSuiteIndex_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BreakoutSnapShot Clone() {
      return new BreakoutSnapShot(this);
    }

    /// <summary>Field number for the "action_list" field.</summary>
    public const int ActionListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutAction> _repeated_actionList_codec
        = pb::FieldCodec.ForMessage(42, global::MiHomo.Protos.BreakoutAction.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutAction> actionList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutAction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutAction> ActionList {
      get { return actionList_; }
    }

    /// <summary>Field number for the "ball_element_reaction_list" field.</summary>
    public const int BallElementReactionListFieldNumber = 16;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutElementReactionCounter> _repeated_ballElementReactionList_codec
        = pb::FieldCodec.ForMessage(130, global::MiHomo.Protos.BreakoutElementReactionCounter.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutElementReactionCounter> ballElementReactionList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutElementReactionCounter>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutElementReactionCounter> BallElementReactionList {
      get { return ballElementReactionList_; }
    }

    /// <summary>Field number for the "ball_list" field.</summary>
    public const int BallListFieldNumber = 3;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutPhysicalObject> _repeated_ballList_codec
        = pb::FieldCodec.ForMessage(26, global::MiHomo.Protos.BreakoutPhysicalObject.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject> ballList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject> BallList {
      get { return ballList_; }
    }

    /// <summary>Field number for the "brick_element_reaction_list" field.</summary>
    public const int BrickElementReactionListFieldNumber = 15;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutElementReactionCounter> _repeated_brickElementReactionList_codec
        = pb::FieldCodec.ForMessage(122, global::MiHomo.Protos.BreakoutElementReactionCounter.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutElementReactionCounter> brickElementReactionList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutElementReactionCounter>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutElementReactionCounter> BrickElementReactionList {
      get { return brickElementReactionList_; }
    }

    /// <summary>Field number for the "client_game_time" field.</summary>
    public const int ClientGameTimeFieldNumber = 1;
    private ulong clientGameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ClientGameTime {
      get { return clientGameTime_; }
      set {
        clientGameTime_ = value;
      }
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 9;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "dynamic_object_list" field.</summary>
    public const int DynamicObjectListFieldNumber = 18;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutPhysicalObject> _repeated_dynamicObjectList_codec
        = pb::FieldCodec.ForMessage(146, global::MiHomo.Protos.BreakoutPhysicalObject.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject> dynamicObjectList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject> DynamicObjectList {
      get { return dynamicObjectList_; }
    }

    /// <summary>Field number for the "id_index_list" field.</summary>
    public const int IdIndexListFieldNumber = 19;
    private static readonly pb::FieldCodec<uint> _repeated_idIndexList_codec
        = pb::FieldCodec.ForUInt32(154);
    private readonly pbc::RepeatedField<uint> idIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> IdIndexList {
      get { return idIndexList_; }
    }

    /// <summary>Field number for the "is_finish" field.</summary>
    public const int IsFinishFieldNumber = 7;
    private bool isFinish_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsFinish {
      get { return isFinish_; }
      set {
        isFinish_ = value;
      }
    }

    /// <summary>Field number for the "life_count" field.</summary>
    public const int LifeCountFieldNumber = 11;
    private uint lifeCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LifeCount {
      get { return lifeCount_; }
      set {
        lifeCount_ = value;
      }
    }

    /// <summary>Field number for the "max_combo" field.</summary>
    public const int MaxComboFieldNumber = 10;
    private uint maxCombo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxCombo {
      get { return maxCombo_; }
      set {
        maxCombo_ = value;
      }
    }

    /// <summary>Field number for the "physical_object_list" field.</summary>
    public const int PhysicalObjectListFieldNumber = 4;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutPhysicalObject> _repeated_physicalObjectList_codec
        = pb::FieldCodec.ForMessage(34, global::MiHomo.Protos.BreakoutPhysicalObject.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject> physicalObjectList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutPhysicalObject> PhysicalObjectList {
      get { return physicalObjectList_; }
    }

    /// <summary>Field number for the "raw_client_game_time" field.</summary>
    public const int RawClientGameTimeFieldNumber = 20;
    private int rawClientGameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int RawClientGameTime {
      get { return rawClientGameTime_; }
      set {
        rawClientGameTime_ = value;
      }
    }

    /// <summary>Field number for the "remaining_boss_hp" field.</summary>
    public const int RemainingBossHpFieldNumber = 14;
    private uint remainingBossHp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint RemainingBossHp {
      get { return remainingBossHp_; }
      set {
        remainingBossHp_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 8;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "server_game_time" field.</summary>
    public const int ServerGameTimeFieldNumber = 2;
    private ulong serverGameTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ServerGameTime {
      get { return serverGameTime_; }
      set {
        serverGameTime_ = value;
      }
    }

    /// <summary>Field number for the "spawn_point_list" field.</summary>
    public const int SpawnPointListFieldNumber = 13;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutSpawnPoint> _repeated_spawnPointList_codec
        = pb::FieldCodec.ForMessage(106, global::MiHomo.Protos.BreakoutSpawnPoint.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutSpawnPoint> spawnPointList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutSpawnPoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutSpawnPoint> SpawnPointList {
      get { return spawnPointList_; }
    }

    /// <summary>Field number for the "uid_info_list" field.</summary>
    public const int UidInfoListFieldNumber = 17;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.BreakoutSyncConnectUidInfo> _repeated_uidInfoList_codec
        = pb::FieldCodec.ForMessage(138, global::MiHomo.Protos.BreakoutSyncConnectUidInfo.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.BreakoutSyncConnectUidInfo> uidInfoList_ = new pbc::RepeatedField<global::MiHomo.Protos.BreakoutSyncConnectUidInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.BreakoutSyncConnectUidInfo> UidInfoList {
      get { return uidInfoList_; }
    }

    /// <summary>Field number for the "wave_index" field.</summary>
    public const int WaveIndexFieldNumber = 6;
    private uint waveIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaveIndex {
      get { return waveIndex_; }
      set {
        waveIndex_ = value;
      }
    }

    /// <summary>Field number for the "wave_suite_index" field.</summary>
    public const int WaveSuiteIndexFieldNumber = 12;
    private uint waveSuiteIndex_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint WaveSuiteIndex {
      get { return waveSuiteIndex_; }
      set {
        waveSuiteIndex_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BreakoutSnapShot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BreakoutSnapShot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!actionList_.Equals(other.actionList_)) return false;
      if(!ballElementReactionList_.Equals(other.ballElementReactionList_)) return false;
      if(!ballList_.Equals(other.ballList_)) return false;
      if(!brickElementReactionList_.Equals(other.brickElementReactionList_)) return false;
      if (ClientGameTime != other.ClientGameTime) return false;
      if (Combo != other.Combo) return false;
      if(!dynamicObjectList_.Equals(other.dynamicObjectList_)) return false;
      if(!idIndexList_.Equals(other.idIndexList_)) return false;
      if (IsFinish != other.IsFinish) return false;
      if (LifeCount != other.LifeCount) return false;
      if (MaxCombo != other.MaxCombo) return false;
      if(!physicalObjectList_.Equals(other.physicalObjectList_)) return false;
      if (RawClientGameTime != other.RawClientGameTime) return false;
      if (RemainingBossHp != other.RemainingBossHp) return false;
      if (Score != other.Score) return false;
      if (ServerGameTime != other.ServerGameTime) return false;
      if(!spawnPointList_.Equals(other.spawnPointList_)) return false;
      if(!uidInfoList_.Equals(other.uidInfoList_)) return false;
      if (WaveIndex != other.WaveIndex) return false;
      if (WaveSuiteIndex != other.WaveSuiteIndex) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= actionList_.GetHashCode();
      hash ^= ballElementReactionList_.GetHashCode();
      hash ^= ballList_.GetHashCode();
      hash ^= brickElementReactionList_.GetHashCode();
      if (ClientGameTime != 0UL) hash ^= ClientGameTime.GetHashCode();
      if (Combo != 0) hash ^= Combo.GetHashCode();
      hash ^= dynamicObjectList_.GetHashCode();
      hash ^= idIndexList_.GetHashCode();
      if (IsFinish != false) hash ^= IsFinish.GetHashCode();
      if (LifeCount != 0) hash ^= LifeCount.GetHashCode();
      if (MaxCombo != 0) hash ^= MaxCombo.GetHashCode();
      hash ^= physicalObjectList_.GetHashCode();
      if (RawClientGameTime != 0) hash ^= RawClientGameTime.GetHashCode();
      if (RemainingBossHp != 0) hash ^= RemainingBossHp.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (ServerGameTime != 0UL) hash ^= ServerGameTime.GetHashCode();
      hash ^= spawnPointList_.GetHashCode();
      hash ^= uidInfoList_.GetHashCode();
      if (WaveIndex != 0) hash ^= WaveIndex.GetHashCode();
      if (WaveSuiteIndex != 0) hash ^= WaveSuiteIndex.GetHashCode();
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
      if (ClientGameTime != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ClientGameTime);
      }
      if (ServerGameTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ServerGameTime);
      }
      ballList_.WriteTo(output, _repeated_ballList_codec);
      physicalObjectList_.WriteTo(output, _repeated_physicalObjectList_codec);
      actionList_.WriteTo(output, _repeated_actionList_codec);
      if (WaveIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WaveIndex);
      }
      if (IsFinish != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinish);
      }
      if (Score != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Score);
      }
      if (Combo != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Combo);
      }
      if (MaxCombo != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxCombo);
      }
      if (LifeCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LifeCount);
      }
      if (WaveSuiteIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WaveSuiteIndex);
      }
      spawnPointList_.WriteTo(output, _repeated_spawnPointList_codec);
      if (RemainingBossHp != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RemainingBossHp);
      }
      brickElementReactionList_.WriteTo(output, _repeated_brickElementReactionList_codec);
      ballElementReactionList_.WriteTo(output, _repeated_ballElementReactionList_codec);
      uidInfoList_.WriteTo(output, _repeated_uidInfoList_codec);
      dynamicObjectList_.WriteTo(output, _repeated_dynamicObjectList_codec);
      idIndexList_.WriteTo(output, _repeated_idIndexList_codec);
      if (RawClientGameTime != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(RawClientGameTime);
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
      if (ClientGameTime != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ClientGameTime);
      }
      if (ServerGameTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ServerGameTime);
      }
      ballList_.WriteTo(ref output, _repeated_ballList_codec);
      physicalObjectList_.WriteTo(ref output, _repeated_physicalObjectList_codec);
      actionList_.WriteTo(ref output, _repeated_actionList_codec);
      if (WaveIndex != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(WaveIndex);
      }
      if (IsFinish != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsFinish);
      }
      if (Score != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Score);
      }
      if (Combo != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(Combo);
      }
      if (MaxCombo != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxCombo);
      }
      if (LifeCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(LifeCount);
      }
      if (WaveSuiteIndex != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(WaveSuiteIndex);
      }
      spawnPointList_.WriteTo(ref output, _repeated_spawnPointList_codec);
      if (RemainingBossHp != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(RemainingBossHp);
      }
      brickElementReactionList_.WriteTo(ref output, _repeated_brickElementReactionList_codec);
      ballElementReactionList_.WriteTo(ref output, _repeated_ballElementReactionList_codec);
      uidInfoList_.WriteTo(ref output, _repeated_uidInfoList_codec);
      dynamicObjectList_.WriteTo(ref output, _repeated_dynamicObjectList_codec);
      idIndexList_.WriteTo(ref output, _repeated_idIndexList_codec);
      if (RawClientGameTime != 0) {
        output.WriteRawTag(160, 1);
        output.WriteInt32(RawClientGameTime);
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
      size += actionList_.CalculateSize(_repeated_actionList_codec);
      size += ballElementReactionList_.CalculateSize(_repeated_ballElementReactionList_codec);
      size += ballList_.CalculateSize(_repeated_ballList_codec);
      size += brickElementReactionList_.CalculateSize(_repeated_brickElementReactionList_codec);
      if (ClientGameTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ClientGameTime);
      }
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      size += dynamicObjectList_.CalculateSize(_repeated_dynamicObjectList_codec);
      size += idIndexList_.CalculateSize(_repeated_idIndexList_codec);
      if (IsFinish != false) {
        size += 1 + 1;
      }
      if (LifeCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LifeCount);
      }
      if (MaxCombo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxCombo);
      }
      size += physicalObjectList_.CalculateSize(_repeated_physicalObjectList_codec);
      if (RawClientGameTime != 0) {
        size += 2 + pb::CodedOutputStream.ComputeInt32Size(RawClientGameTime);
      }
      if (RemainingBossHp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RemainingBossHp);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (ServerGameTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerGameTime);
      }
      size += spawnPointList_.CalculateSize(_repeated_spawnPointList_codec);
      size += uidInfoList_.CalculateSize(_repeated_uidInfoList_codec);
      if (WaveIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaveIndex);
      }
      if (WaveSuiteIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(WaveSuiteIndex);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BreakoutSnapShot other) {
      if (other == null) {
        return;
      }
      actionList_.Add(other.actionList_);
      ballElementReactionList_.Add(other.ballElementReactionList_);
      ballList_.Add(other.ballList_);
      brickElementReactionList_.Add(other.brickElementReactionList_);
      if (other.ClientGameTime != 0UL) {
        ClientGameTime = other.ClientGameTime;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      dynamicObjectList_.Add(other.dynamicObjectList_);
      idIndexList_.Add(other.idIndexList_);
      if (other.IsFinish != false) {
        IsFinish = other.IsFinish;
      }
      if (other.LifeCount != 0) {
        LifeCount = other.LifeCount;
      }
      if (other.MaxCombo != 0) {
        MaxCombo = other.MaxCombo;
      }
      physicalObjectList_.Add(other.physicalObjectList_);
      if (other.RawClientGameTime != 0) {
        RawClientGameTime = other.RawClientGameTime;
      }
      if (other.RemainingBossHp != 0) {
        RemainingBossHp = other.RemainingBossHp;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.ServerGameTime != 0UL) {
        ServerGameTime = other.ServerGameTime;
      }
      spawnPointList_.Add(other.spawnPointList_);
      uidInfoList_.Add(other.uidInfoList_);
      if (other.WaveIndex != 0) {
        WaveIndex = other.WaveIndex;
      }
      if (other.WaveSuiteIndex != 0) {
        WaveSuiteIndex = other.WaveSuiteIndex;
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
            ClientGameTime = input.ReadUInt64();
            break;
          }
          case 16: {
            ServerGameTime = input.ReadUInt64();
            break;
          }
          case 26: {
            ballList_.AddEntriesFrom(input, _repeated_ballList_codec);
            break;
          }
          case 34: {
            physicalObjectList_.AddEntriesFrom(input, _repeated_physicalObjectList_codec);
            break;
          }
          case 42: {
            actionList_.AddEntriesFrom(input, _repeated_actionList_codec);
            break;
          }
          case 48: {
            WaveIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFinish = input.ReadBool();
            break;
          }
          case 64: {
            Score = input.ReadUInt32();
            break;
          }
          case 72: {
            Combo = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 88: {
            LifeCount = input.ReadUInt32();
            break;
          }
          case 96: {
            WaveSuiteIndex = input.ReadUInt32();
            break;
          }
          case 106: {
            spawnPointList_.AddEntriesFrom(input, _repeated_spawnPointList_codec);
            break;
          }
          case 112: {
            RemainingBossHp = input.ReadUInt32();
            break;
          }
          case 122: {
            brickElementReactionList_.AddEntriesFrom(input, _repeated_brickElementReactionList_codec);
            break;
          }
          case 130: {
            ballElementReactionList_.AddEntriesFrom(input, _repeated_ballElementReactionList_codec);
            break;
          }
          case 138: {
            uidInfoList_.AddEntriesFrom(input, _repeated_uidInfoList_codec);
            break;
          }
          case 146: {
            dynamicObjectList_.AddEntriesFrom(input, _repeated_dynamicObjectList_codec);
            break;
          }
          case 154:
          case 152: {
            idIndexList_.AddEntriesFrom(input, _repeated_idIndexList_codec);
            break;
          }
          case 160: {
            RawClientGameTime = input.ReadInt32();
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
            ClientGameTime = input.ReadUInt64();
            break;
          }
          case 16: {
            ServerGameTime = input.ReadUInt64();
            break;
          }
          case 26: {
            ballList_.AddEntriesFrom(ref input, _repeated_ballList_codec);
            break;
          }
          case 34: {
            physicalObjectList_.AddEntriesFrom(ref input, _repeated_physicalObjectList_codec);
            break;
          }
          case 42: {
            actionList_.AddEntriesFrom(ref input, _repeated_actionList_codec);
            break;
          }
          case 48: {
            WaveIndex = input.ReadUInt32();
            break;
          }
          case 56: {
            IsFinish = input.ReadBool();
            break;
          }
          case 64: {
            Score = input.ReadUInt32();
            break;
          }
          case 72: {
            Combo = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 88: {
            LifeCount = input.ReadUInt32();
            break;
          }
          case 96: {
            WaveSuiteIndex = input.ReadUInt32();
            break;
          }
          case 106: {
            spawnPointList_.AddEntriesFrom(ref input, _repeated_spawnPointList_codec);
            break;
          }
          case 112: {
            RemainingBossHp = input.ReadUInt32();
            break;
          }
          case 122: {
            brickElementReactionList_.AddEntriesFrom(ref input, _repeated_brickElementReactionList_codec);
            break;
          }
          case 130: {
            ballElementReactionList_.AddEntriesFrom(ref input, _repeated_ballElementReactionList_codec);
            break;
          }
          case 138: {
            uidInfoList_.AddEntriesFrom(ref input, _repeated_uidInfoList_codec);
            break;
          }
          case 146: {
            dynamicObjectList_.AddEntriesFrom(ref input, _repeated_dynamicObjectList_codec);
            break;
          }
          case 154:
          case 152: {
            idIndexList_.AddEntriesFrom(ref input, _repeated_idIndexList_codec);
            break;
          }
          case 160: {
            RawClientGameTime = input.ReadInt32();
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
