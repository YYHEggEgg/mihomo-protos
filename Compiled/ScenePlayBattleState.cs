// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ScenePlayBattleState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ScenePlayBattleState.proto</summary>
  public static partial class ScenePlayBattleStateReflection {

    #region Descriptor
    /// <summary>File descriptor for ScenePlayBattleState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScenePlayBattleStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpTY2VuZVBsYXlCYXR0bGVTdGF0ZS5wcm90bxINbWlIb21vLlByb3Rvcyrj",
            "AQoUU2NlbmVQbGF5QmF0dGxlU3RhdGUSGgoWU0NFTkVfUExBWV9CQVRUTEVf",
            "Tk9ORRAAEhoKFlNDRU5FX1BMQVlfQkFUVExFX0lOSVQQARIdChlTQ0VORV9Q",
            "TEFZX0JBVFRMRV9QUkVQQVJFEAISGwoXU0NFTkVfUExBWV9CQVRUTEVfUkVB",
            "RFkQAxIeChpTQ0VORV9QTEFZX0JBVFRMRV9QUkVTVEFSVBAEEhsKF1NDRU5F",
            "X1BMQVlfQkFUVExFX1NUQVJUEAUSGgoWU0NFTkVfUExBWV9CQVRUTEVfU1RP",
            "UBAGYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.ScenePlayBattleState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ScenePlayBattleState {
    [pbr::OriginalName("SCENE_PLAY_BATTLE_NONE")] ScenePlayBattleNone = 0,
    [pbr::OriginalName("SCENE_PLAY_BATTLE_INIT")] ScenePlayBattleInit = 1,
    [pbr::OriginalName("SCENE_PLAY_BATTLE_PREPARE")] ScenePlayBattlePrepare = 2,
    [pbr::OriginalName("SCENE_PLAY_BATTLE_READY")] ScenePlayBattleReady = 3,
    [pbr::OriginalName("SCENE_PLAY_BATTLE_PRESTART")] ScenePlayBattlePrestart = 4,
    [pbr::OriginalName("SCENE_PLAY_BATTLE_START")] ScenePlayBattleStart = 5,
    [pbr::OriginalName("SCENE_PLAY_BATTLE_STOP")] ScenePlayBattleStop = 6,
  }

  #endregion

}

#endregion Designer generated code
