// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: SvrMsgId.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from SvrMsgId.proto</summary>
  public static partial class SvrMsgIdReflection {

    #region Descriptor
    /// <summary>File descriptor for SvrMsgId.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SvrMsgIdReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5TdnJNc2dJZC5wcm90bxINbWlIb21vLlByb3RvcyqUAgoIU3ZyTXNnSWQS",
            "FgoSU1ZSX01TR19JRF9VTktOT1dOEAASJgoiU1ZSX01TR19JRF9CTE9DS19S",
            "RUZSRVNIX0NPVU5URE9XThABEiYKIlNWUl9NU0dfSURfQVZBVEFSX1JFVklW",
            "RV9CWV9TVEFUVUUQAhIoCiRTVlJfTVNHX0lEX0RBSUxZX1RBU0tfUkVXQVJE",
            "X01BWF9OVU0QAxIkCiBTVlJfTVNHX0lEX1JPVVRJTkVfVFlQRV9OT1RfT1BF",
            "ThAEEioKJlNWUl9NU0dfSURfUk9VVElORV9UWVBFX1JFV0FSRF9NQVhfTlVN",
            "EAUSJAogU1ZSX01TR19JRF9NRUNIQU5JQ1VTX0NPSU5fTElNSVQQBmIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.SvrMsgId), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum SvrMsgId {
    [pbr::OriginalName("SVR_MSG_ID_UNKNOWN")] Unknown = 0,
    [pbr::OriginalName("SVR_MSG_ID_BLOCK_REFRESH_COUNTDOWN")] BlockRefreshCountdown = 1,
    [pbr::OriginalName("SVR_MSG_ID_AVATAR_REVIVE_BY_STATUE")] AvatarReviveByStatue = 2,
    [pbr::OriginalName("SVR_MSG_ID_DAILY_TASK_REWARD_MAX_NUM")] DailyTaskRewardMaxNum = 3,
    [pbr::OriginalName("SVR_MSG_ID_ROUTINE_TYPE_NOT_OPEN")] RoutineTypeNotOpen = 4,
    [pbr::OriginalName("SVR_MSG_ID_ROUTINE_TYPE_REWARD_MAX_NUM")] RoutineTypeRewardMaxNum = 5,
    [pbr::OriginalName("SVR_MSG_ID_MECHANICUS_COIN_LIMIT")] MechanicusCoinLimit = 6,
  }

  #endregion

}

#endregion Designer generated code
