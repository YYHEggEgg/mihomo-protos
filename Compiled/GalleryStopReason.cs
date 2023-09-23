// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GalleryStopReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GalleryStopReason.proto</summary>
  public static partial class GalleryStopReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for GalleryStopReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GalleryStopReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHYWxsZXJ5U3RvcFJlYXNvbi5wcm90bxINbWlIb21vLlByb3RvcyqaAwoR",
            "R2FsbGVyeVN0b3BSZWFzb24SFQoRR0FMTEVSWV9TVE9QX05PTkUQABIXChNH",
            "QUxMRVJZX1NUT1BfVElNRVVQEAESIQodR0FMTEVSWV9TVE9QX0NMSUVOVF9J",
            "TlRFUlJVUFQQAhImCiJHQUxMRVJZX1NUT1BfTFVBX0lOVEVSUlVQVF9TVUND",
            "RVNTEAMSIwofR0FMTEVSWV9TVE9QX0xVQV9JTlRFUlJVUFRfRkFJTBAEEiIK",
            "HkdBTExFUllfU1RPUF9PV05FUl9MRUFWRV9TQ0VORRAFEiEKHUdBTExFUllf",
            "U1RPUF9QTEFZX0lOSVRfRkFJTEVEEAYSIwofR0FMTEVSWV9TVE9QX09USEVS",
            "X1BMQVlFUl9FTlRFUhAHEhsKF0dBTExFUllfU1RPUF9BVkFUQVJfRElFEAgS",
            "GQoVR0FMTEVSWV9TVE9QX0ZJTklTSEVEEAkSHwobR0FMTEVSWV9TVE9QX0ZV",
            "TkdVU19BTExfRElFEAoSIAocR0FMTEVSWV9TVE9QX0xJRkVfQ09VTlRfWkVS",
            "TxALYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.GalleryStopReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GalleryStopReason {
    [pbr::OriginalName("GALLERY_STOP_NONE")] GalleryStopNone = 0,
    [pbr::OriginalName("GALLERY_STOP_TIMEUP")] GalleryStopTimeup = 1,
    [pbr::OriginalName("GALLERY_STOP_CLIENT_INTERRUPT")] GalleryStopClientInterrupt = 2,
    [pbr::OriginalName("GALLERY_STOP_LUA_INTERRUPT_SUCCESS")] GalleryStopLuaInterruptSuccess = 3,
    [pbr::OriginalName("GALLERY_STOP_LUA_INTERRUPT_FAIL")] GalleryStopLuaInterruptFail = 4,
    [pbr::OriginalName("GALLERY_STOP_OWNER_LEAVE_SCENE")] GalleryStopOwnerLeaveScene = 5,
    [pbr::OriginalName("GALLERY_STOP_PLAY_INIT_FAILED")] GalleryStopPlayInitFailed = 6,
    [pbr::OriginalName("GALLERY_STOP_OTHER_PLAYER_ENTER")] GalleryStopOtherPlayerEnter = 7,
    [pbr::OriginalName("GALLERY_STOP_AVATAR_DIE")] GalleryStopAvatarDie = 8,
    [pbr::OriginalName("GALLERY_STOP_FINISHED")] GalleryStopFinished = 9,
    [pbr::OriginalName("GALLERY_STOP_FUNGUS_ALL_DIE")] GalleryStopFungusAllDie = 10,
    [pbr::OriginalName("GALLERY_STOP_LIFE_COUNT_ZERO")] GalleryStopLifeCountZero = 11,
  }

  #endregion

}

#endregion Designer generated code
