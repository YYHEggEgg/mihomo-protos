// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RogueDiaryAvatarDisableStatus.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RogueDiaryAvatarDisableStatus.proto</summary>
  public static partial class RogueDiaryAvatarDisableStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for RogueDiaryAvatarDisableStatus.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RogueDiaryAvatarDisableStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNSb2d1ZURpYXJ5QXZhdGFyRGlzYWJsZVN0YXR1cy5wcm90bxINbWlIb21v",
            "LlByb3Rvcyq7AQodUm9ndWVEaWFyeUF2YXRhckRpc2FibGVTdGF0dXMSIwof",
            "Uk9HVUVfRElBUllfQVZBVEFSX0RJU0FCTEVfTk9ORRAAEiQKIFJPR1VFX0RJ",
            "QVJZX0FWQVRBUl9ESVNBQkxFX0RFQVRIEAESJAogUk9HVUVfRElBUllfQVZB",
            "VEFSX0RJU0FCTEVfVElSRUQQAhIpCiVST0dVRV9ESUFSWV9BVkFUQVJfRElT",
            "QUJMRV9EVVBMSUNBVEVEEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.RogueDiaryAvatarDisableStatus), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RogueDiaryAvatarDisableStatus {
    [pbr::OriginalName("ROGUE_DIARY_AVATAR_DISABLE_NONE")] RogueDiaryAvatarDisableNone = 0,
    [pbr::OriginalName("ROGUE_DIARY_AVATAR_DISABLE_DEATH")] RogueDiaryAvatarDisableDeath = 1,
    [pbr::OriginalName("ROGUE_DIARY_AVATAR_DISABLE_TIRED")] RogueDiaryAvatarDisableTired = 2,
    [pbr::OriginalName("ROGUE_DIARY_AVATAR_DISABLE_DUPLICATED")] RogueDiaryAvatarDisableDuplicated = 3,
  }

  #endregion

}

#endregion Designer generated code
