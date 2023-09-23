// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AISnapshotEntityData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AISnapshotEntityData.proto</summary>
  public static partial class AISnapshotEntityDataReflection {

    #region Descriptor
    /// <summary>File descriptor for AISnapshotEntityData.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AISnapshotEntityDataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpBSVNuYXBzaG90RW50aXR5RGF0YS5wcm90bxINbWlIb21vLlByb3Rvcxog",
            "QUlTbmFwc2hvdEVudGl0eVNraWxsQ3ljbGUucHJvdG8iygMKFEFJU25hcHNo",
            "b3RFbnRpdHlEYXRhEhQKDGFpX3RhcmdldF9pZBgNIAEoDRIYChBhdHRhY2tf",
            "dGFyZ2V0X2lkGAogASgNEhoKEmRpc3RhbmNlX3RvX3BsYXllchgLIAEoAhIR",
            "CgllbnRpdHlfaWQYDyABKA0SSAoVZmluaXNoZWRfc2tpbGxfY3ljbGVzGAkg",
            "AygLMikubWlIb21vLlByb3Rvcy5BSVNuYXBzaG90RW50aXR5U2tpbGxDeWNs",
            "ZRIWCg5tb3ZlZF9kaXN0YW5jZRgEIAEoAhIRCglyZWFsX3RpbWUYDiABKAIS",
            "DgoGdGFjdGljGAIgASgNEhgKEHRocmVhdF9saXN0X3NpemUYASABKA0SGAoQ",
            "dGhyZWF0X3RhcmdldF9pZBgDIAEoDRIRCgl0aWNrX3RpbWUYBSABKAISUAoP",
            "aGl0dGluZ19hdmF0YXJzGAcgAygLMjcubWlIb21vLlByb3Rvcy5BSVNuYXBz",
            "aG90RW50aXR5RGF0YS5IaXR0aW5nQXZhdGFyc0VudHJ5GjUKE0hpdHRpbmdB",
            "dmF0YXJzRW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.AISnapshotEntitySkillCycleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.AISnapshotEntityData), global::MiHomo.Protos.AISnapshotEntityData.Parser, new[]{ "AiTargetId", "AttackTargetId", "DistanceToPlayer", "EntityId", "FinishedSkillCycles", "MovedDistance", "RealTime", "Tactic", "ThreatListSize", "ThreatTargetId", "TickTime", "HittingAvatars" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AISnapshotEntityData : pb::IMessage<AISnapshotEntityData>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AISnapshotEntityData> _parser = new pb::MessageParser<AISnapshotEntityData>(() => new AISnapshotEntityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AISnapshotEntityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.AISnapshotEntityDataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AISnapshotEntityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AISnapshotEntityData(AISnapshotEntityData other) : this() {
      aiTargetId_ = other.aiTargetId_;
      attackTargetId_ = other.attackTargetId_;
      distanceToPlayer_ = other.distanceToPlayer_;
      entityId_ = other.entityId_;
      finishedSkillCycles_ = other.finishedSkillCycles_.Clone();
      movedDistance_ = other.movedDistance_;
      realTime_ = other.realTime_;
      tactic_ = other.tactic_;
      threatListSize_ = other.threatListSize_;
      threatTargetId_ = other.threatTargetId_;
      tickTime_ = other.tickTime_;
      hittingAvatars_ = other.hittingAvatars_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AISnapshotEntityData Clone() {
      return new AISnapshotEntityData(this);
    }

    /// <summary>Field number for the "ai_target_id" field.</summary>
    public const int AiTargetIdFieldNumber = 13;
    private uint aiTargetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AiTargetId {
      get { return aiTargetId_; }
      set {
        aiTargetId_ = value;
      }
    }

    /// <summary>Field number for the "attack_target_id" field.</summary>
    public const int AttackTargetIdFieldNumber = 10;
    private uint attackTargetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint AttackTargetId {
      get { return attackTargetId_; }
      set {
        attackTargetId_ = value;
      }
    }

    /// <summary>Field number for the "distance_to_player" field.</summary>
    public const int DistanceToPlayerFieldNumber = 11;
    private float distanceToPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float DistanceToPlayer {
      get { return distanceToPlayer_; }
      set {
        distanceToPlayer_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 15;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "finished_skill_cycles" field.</summary>
    public const int FinishedSkillCyclesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::MiHomo.Protos.AISnapshotEntitySkillCycle> _repeated_finishedSkillCycles_codec
        = pb::FieldCodec.ForMessage(74, global::MiHomo.Protos.AISnapshotEntitySkillCycle.Parser);
    private readonly pbc::RepeatedField<global::MiHomo.Protos.AISnapshotEntitySkillCycle> finishedSkillCycles_ = new pbc::RepeatedField<global::MiHomo.Protos.AISnapshotEntitySkillCycle>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::MiHomo.Protos.AISnapshotEntitySkillCycle> FinishedSkillCycles {
      get { return finishedSkillCycles_; }
    }

    /// <summary>Field number for the "moved_distance" field.</summary>
    public const int MovedDistanceFieldNumber = 4;
    private float movedDistance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MovedDistance {
      get { return movedDistance_; }
      set {
        movedDistance_ = value;
      }
    }

    /// <summary>Field number for the "real_time" field.</summary>
    public const int RealTimeFieldNumber = 14;
    private float realTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float RealTime {
      get { return realTime_; }
      set {
        realTime_ = value;
      }
    }

    /// <summary>Field number for the "tactic" field.</summary>
    public const int TacticFieldNumber = 2;
    private uint tactic_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Tactic {
      get { return tactic_; }
      set {
        tactic_ = value;
      }
    }

    /// <summary>Field number for the "threat_list_size" field.</summary>
    public const int ThreatListSizeFieldNumber = 1;
    private uint threatListSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ThreatListSize {
      get { return threatListSize_; }
      set {
        threatListSize_ = value;
      }
    }

    /// <summary>Field number for the "threat_target_id" field.</summary>
    public const int ThreatTargetIdFieldNumber = 3;
    private uint threatTargetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ThreatTargetId {
      get { return threatTargetId_; }
      set {
        threatTargetId_ = value;
      }
    }

    /// <summary>Field number for the "tick_time" field.</summary>
    public const int TickTimeFieldNumber = 5;
    private float tickTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float TickTime {
      get { return tickTime_; }
      set {
        tickTime_ = value;
      }
    }

    /// <summary>Field number for the "hitting_avatars" field.</summary>
    public const int HittingAvatarsFieldNumber = 7;
    private static readonly pbc::MapField<uint, uint>.Codec _map_hittingAvatars_codec
        = new pbc::MapField<uint, uint>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForUInt32(16, 0), 58);
    private readonly pbc::MapField<uint, uint> hittingAvatars_ = new pbc::MapField<uint, uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, uint> HittingAvatars {
      get { return hittingAvatars_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AISnapshotEntityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AISnapshotEntityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AiTargetId != other.AiTargetId) return false;
      if (AttackTargetId != other.AttackTargetId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DistanceToPlayer, other.DistanceToPlayer)) return false;
      if (EntityId != other.EntityId) return false;
      if(!finishedSkillCycles_.Equals(other.finishedSkillCycles_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MovedDistance, other.MovedDistance)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(RealTime, other.RealTime)) return false;
      if (Tactic != other.Tactic) return false;
      if (ThreatListSize != other.ThreatListSize) return false;
      if (ThreatTargetId != other.ThreatTargetId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(TickTime, other.TickTime)) return false;
      if (!HittingAvatars.Equals(other.HittingAvatars)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (AiTargetId != 0) hash ^= AiTargetId.GetHashCode();
      if (AttackTargetId != 0) hash ^= AttackTargetId.GetHashCode();
      if (DistanceToPlayer != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DistanceToPlayer);
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      hash ^= finishedSkillCycles_.GetHashCode();
      if (MovedDistance != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MovedDistance);
      if (RealTime != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(RealTime);
      if (Tactic != 0) hash ^= Tactic.GetHashCode();
      if (ThreatListSize != 0) hash ^= ThreatListSize.GetHashCode();
      if (ThreatTargetId != 0) hash ^= ThreatTargetId.GetHashCode();
      if (TickTime != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(TickTime);
      hash ^= HittingAvatars.GetHashCode();
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
      if (ThreatListSize != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ThreatListSize);
      }
      if (Tactic != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Tactic);
      }
      if (ThreatTargetId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ThreatTargetId);
      }
      if (MovedDistance != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(MovedDistance);
      }
      if (TickTime != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(TickTime);
      }
      hittingAvatars_.WriteTo(output, _map_hittingAvatars_codec);
      finishedSkillCycles_.WriteTo(output, _repeated_finishedSkillCycles_codec);
      if (AttackTargetId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AttackTargetId);
      }
      if (DistanceToPlayer != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(DistanceToPlayer);
      }
      if (AiTargetId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AiTargetId);
      }
      if (RealTime != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(RealTime);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntityId);
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
      if (ThreatListSize != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ThreatListSize);
      }
      if (Tactic != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Tactic);
      }
      if (ThreatTargetId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(ThreatTargetId);
      }
      if (MovedDistance != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(MovedDistance);
      }
      if (TickTime != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(TickTime);
      }
      hittingAvatars_.WriteTo(ref output, _map_hittingAvatars_codec);
      finishedSkillCycles_.WriteTo(ref output, _repeated_finishedSkillCycles_codec);
      if (AttackTargetId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(AttackTargetId);
      }
      if (DistanceToPlayer != 0F) {
        output.WriteRawTag(93);
        output.WriteFloat(DistanceToPlayer);
      }
      if (AiTargetId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(AiTargetId);
      }
      if (RealTime != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(RealTime);
      }
      if (EntityId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(EntityId);
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
      if (AiTargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AiTargetId);
      }
      if (AttackTargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AttackTargetId);
      }
      if (DistanceToPlayer != 0F) {
        size += 1 + 4;
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      size += finishedSkillCycles_.CalculateSize(_repeated_finishedSkillCycles_codec);
      if (MovedDistance != 0F) {
        size += 1 + 4;
      }
      if (RealTime != 0F) {
        size += 1 + 4;
      }
      if (Tactic != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Tactic);
      }
      if (ThreatListSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ThreatListSize);
      }
      if (ThreatTargetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ThreatTargetId);
      }
      if (TickTime != 0F) {
        size += 1 + 4;
      }
      size += hittingAvatars_.CalculateSize(_map_hittingAvatars_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AISnapshotEntityData other) {
      if (other == null) {
        return;
      }
      if (other.AiTargetId != 0) {
        AiTargetId = other.AiTargetId;
      }
      if (other.AttackTargetId != 0) {
        AttackTargetId = other.AttackTargetId;
      }
      if (other.DistanceToPlayer != 0F) {
        DistanceToPlayer = other.DistanceToPlayer;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      finishedSkillCycles_.Add(other.finishedSkillCycles_);
      if (other.MovedDistance != 0F) {
        MovedDistance = other.MovedDistance;
      }
      if (other.RealTime != 0F) {
        RealTime = other.RealTime;
      }
      if (other.Tactic != 0) {
        Tactic = other.Tactic;
      }
      if (other.ThreatListSize != 0) {
        ThreatListSize = other.ThreatListSize;
      }
      if (other.ThreatTargetId != 0) {
        ThreatTargetId = other.ThreatTargetId;
      }
      if (other.TickTime != 0F) {
        TickTime = other.TickTime;
      }
      hittingAvatars_.Add(other.hittingAvatars_);
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
            ThreatListSize = input.ReadUInt32();
            break;
          }
          case 16: {
            Tactic = input.ReadUInt32();
            break;
          }
          case 24: {
            ThreatTargetId = input.ReadUInt32();
            break;
          }
          case 37: {
            MovedDistance = input.ReadFloat();
            break;
          }
          case 45: {
            TickTime = input.ReadFloat();
            break;
          }
          case 58: {
            hittingAvatars_.AddEntriesFrom(input, _map_hittingAvatars_codec);
            break;
          }
          case 74: {
            finishedSkillCycles_.AddEntriesFrom(input, _repeated_finishedSkillCycles_codec);
            break;
          }
          case 80: {
            AttackTargetId = input.ReadUInt32();
            break;
          }
          case 93: {
            DistanceToPlayer = input.ReadFloat();
            break;
          }
          case 104: {
            AiTargetId = input.ReadUInt32();
            break;
          }
          case 117: {
            RealTime = input.ReadFloat();
            break;
          }
          case 120: {
            EntityId = input.ReadUInt32();
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
            ThreatListSize = input.ReadUInt32();
            break;
          }
          case 16: {
            Tactic = input.ReadUInt32();
            break;
          }
          case 24: {
            ThreatTargetId = input.ReadUInt32();
            break;
          }
          case 37: {
            MovedDistance = input.ReadFloat();
            break;
          }
          case 45: {
            TickTime = input.ReadFloat();
            break;
          }
          case 58: {
            hittingAvatars_.AddEntriesFrom(ref input, _map_hittingAvatars_codec);
            break;
          }
          case 74: {
            finishedSkillCycles_.AddEntriesFrom(ref input, _repeated_finishedSkillCycles_codec);
            break;
          }
          case 80: {
            AttackTargetId = input.ReadUInt32();
            break;
          }
          case 93: {
            DistanceToPlayer = input.ReadFloat();
            break;
          }
          case 104: {
            AiTargetId = input.ReadUInt32();
            break;
          }
          case 117: {
            RealTime = input.ReadFloat();
            break;
          }
          case 120: {
            EntityId = input.ReadUInt32();
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
