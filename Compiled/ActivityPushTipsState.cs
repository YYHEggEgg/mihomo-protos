// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ActivityPushTipsState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ActivityPushTipsState.proto</summary>
  public static partial class ActivityPushTipsStateReflection {

    #region Descriptor
    /// <summary>File descriptor for ActivityPushTipsState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityPushTipsStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtBY3Rpdml0eVB1c2hUaXBzU3RhdGUucHJvdG8SDW1pSG9tby5Qcm90b3Mq",
            "gQEKFUFjdGl2aXR5UHVzaFRpcHNTdGF0ZRIhCh1BQ1RJVklUWV9QVVNIX1RJ",
            "UFNfU1RBVEVfTk9ORRAAEiIKHkFDVElWSVRZX1BVU0hfVElQU19TVEFURV9T",
            "VEFSVBABEiEKHUFDVElWSVRZX1BVU0hfVElQU19TVEFURV9SRUFEEAJiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.ActivityPushTipsState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ActivityPushTipsState {
    [pbr::OriginalName("ACTIVITY_PUSH_TIPS_STATE_NONE")] None = 0,
    [pbr::OriginalName("ACTIVITY_PUSH_TIPS_STATE_START")] Start = 1,
    [pbr::OriginalName("ACTIVITY_PUSH_TIPS_STATE_READ")] Read = 2,
  }

  #endregion

}

#endregion Designer generated code
