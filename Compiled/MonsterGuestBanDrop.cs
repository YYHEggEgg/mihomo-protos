// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MonsterGuestBanDrop.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MonsterGuestBanDrop.proto</summary>
  public static partial class MonsterGuestBanDropReflection {

    #region Descriptor
    /// <summary>File descriptor for MonsterGuestBanDrop.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterGuestBanDropReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlNb25zdGVyR3Vlc3RCYW5Ecm9wLnByb3RvEg1taUhvbW8uUHJvdG9zKvMB",
            "ChNNb25zdGVyR3Vlc3RCYW5Ecm9wEhoKFk1PTlNURVJfR1VFU1RfQkFOX05P",
            "TkUQABIdChlNT05TVEVSX0dVRVNUX0JBTl9ESUVfRVhQEAESHQoZTU9OU1RF",
            "Ul9HVUVTVF9CQU5fRElFX0xVQRACEh8KG01PTlNURVJfR1VFU1RfQkFOX0RJ",
            "RV9FWENFTBAEEiIKHk1PTlNURVJfR1VFU1RfQkFOX0RJRV9BQ1RJVklUWRAI",
            "Eh0KGU1PTlNURVJfR1VFU1RfQkFOX0RST1BfSFAQEBIeChpNT05TVEVSX0dV",
            "RVNUX0JBTl9TVUJGSUVMRBAgYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.MonsterGuestBanDrop), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MonsterGuestBanDrop {
    [pbr::OriginalName("MONSTER_GUEST_BAN_NONE")] MonsterGuestBanNone = 0,
    [pbr::OriginalName("MONSTER_GUEST_BAN_DIE_EXP")] MonsterGuestBanDieExp = 1,
    [pbr::OriginalName("MONSTER_GUEST_BAN_DIE_LUA")] MonsterGuestBanDieLua = 2,
    [pbr::OriginalName("MONSTER_GUEST_BAN_DIE_EXCEL")] MonsterGuestBanDieExcel = 4,
    [pbr::OriginalName("MONSTER_GUEST_BAN_DIE_ACTIVITY")] MonsterGuestBanDieActivity = 8,
    [pbr::OriginalName("MONSTER_GUEST_BAN_DROP_HP")] Hp = 16,
    [pbr::OriginalName("MONSTER_GUEST_BAN_SUBFIELD")] MonsterGuestBanSubfield = 32,
  }

  #endregion

}

#endregion Designer generated code
