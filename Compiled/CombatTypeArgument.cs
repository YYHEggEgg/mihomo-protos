// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CombatTypeArgument.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CombatTypeArgument.proto</summary>
  public static partial class CombatTypeArgumentReflection {

    #region Descriptor
    /// <summary>File descriptor for CombatTypeArgument.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CombatTypeArgumentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhDb21iYXRUeXBlQXJndW1lbnQucHJvdG8SDW1pSG9tby5Qcm90b3MqsAQK",
            "EkNvbWJhdFR5cGVBcmd1bWVudBIPCgtDT01CQVRfTk9ORRAAEhgKFENPTUJB",
            "VF9FVlRfQkVJTkdfSElUEAESIQodQ09NQkFUX0FOSU1BVE9SX1NUQVRFX0NI",
            "QU5HRUQQAhIWChJDT01CQVRfRkFDRV9UT19ESVIQAxIcChhDT01CQVRfU0VU",
            "X0FUVEFDS19UQVJHRVQQBBIUChBDT01CQVRfUlVTSF9NT1ZFEAUSJQohQ09N",
            "QkFUX0FOSU1BVE9SX1BBUkFNRVRFUl9DSEFOR0VEEAYSDwoLRU5USVRZX01P",
            "VkUQBxIYChRTWU5DX0VOVElUWV9QT1NJVElPThAIEhwKGENPTUJBVF9TVEVF",
            "Ul9NT1RJT05fSU5GTxAJEh0KGUNPTUJBVF9GT1JDRV9TRVRfUE9TX0lORk8Q",
            "ChIeChpDT01CQVRfQ09NUEVOU0FURV9QT1NfRElGRhALEhsKF0NPTUJBVF9N",
            "T05TVEVSX0RPX0JMSU5LEAwSGgoWQ09NQkFUX0ZJWEVEX1JVU0hfTU9WRRAN",
            "EhkKFUNPTUJBVF9TWU5DX1RSQU5TRk9STRAOEhoKFkNPTUJBVF9MSUdIVF9D",
            "T1JFX01PVkUQDxIbChdDT01CQVRfQkVJTkdfSEVBTEVEX05URhAQEiQKIENP",
            "TUJBVF9TS0lMTF9BTkNIT1JfUE9TSVRJT05fTlRGEBESHgoaQ09NQkFUX0dS",
            "QVBQTElOR19IT09LX01PVkUQEmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.CombatTypeArgument), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CombatTypeArgument {
    [pbr::OriginalName("COMBAT_NONE")] CombatNone = 0,
    [pbr::OriginalName("COMBAT_EVT_BEING_HIT")] CombatEvtBeingHit = 1,
    [pbr::OriginalName("COMBAT_ANIMATOR_STATE_CHANGED")] CombatAnimatorStateChanged = 2,
    [pbr::OriginalName("COMBAT_FACE_TO_DIR")] CombatFaceToDir = 3,
    [pbr::OriginalName("COMBAT_SET_ATTACK_TARGET")] CombatSetAttackTarget = 4,
    [pbr::OriginalName("COMBAT_RUSH_MOVE")] CombatRushMove = 5,
    [pbr::OriginalName("COMBAT_ANIMATOR_PARAMETER_CHANGED")] CombatAnimatorParameterChanged = 6,
    [pbr::OriginalName("ENTITY_MOVE")] EntityMove = 7,
    [pbr::OriginalName("SYNC_ENTITY_POSITION")] SyncEntityPosition = 8,
    [pbr::OriginalName("COMBAT_STEER_MOTION_INFO")] CombatSteerMotionInfo = 9,
    [pbr::OriginalName("COMBAT_FORCE_SET_POS_INFO")] CombatForceSetPosInfo = 10,
    [pbr::OriginalName("COMBAT_COMPENSATE_POS_DIFF")] CombatCompensatePosDiff = 11,
    [pbr::OriginalName("COMBAT_MONSTER_DO_BLINK")] CombatMonsterDoBlink = 12,
    [pbr::OriginalName("COMBAT_FIXED_RUSH_MOVE")] CombatFixedRushMove = 13,
    [pbr::OriginalName("COMBAT_SYNC_TRANSFORM")] CombatSyncTransform = 14,
    [pbr::OriginalName("COMBAT_LIGHT_CORE_MOVE")] CombatLightCoreMove = 15,
    [pbr::OriginalName("COMBAT_BEING_HEALED_NTF")] CombatBeingHealedNtf = 16,
    [pbr::OriginalName("COMBAT_SKILL_ANCHOR_POSITION_NTF")] CombatSkillAnchorPositionNtf = 17,
    [pbr::OriginalName("COMBAT_GRAPPLING_HOOK_MOVE")] CombatGrapplingHookMove = 18,
  }

  #endregion

}

#endregion Designer generated code
