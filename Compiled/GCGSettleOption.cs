// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGSettleOption.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGSettleOption.proto</summary>
  public static partial class GCGSettleOptionReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGSettleOption.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGSettleOptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVHQ0dTZXR0bGVPcHRpb24ucHJvdG8SDW1pSG9tby5Qcm90b3MqfAoPR0NH",
            "U2V0dGxlT3B0aW9uEhcKE0dDR19TRVRUTEVfT1BUX05PTkUQABIXChNHQ0df",
            "U0VUVExFX09QVF9FWElUEAESGwoXR0NHX1NFVFRMRV9PUFRfQ09OVElOVUUQ",
            "AhIaChZHQ0dfU0VUVExFX09QVF9SRVNUQVJUEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.GCGSettleOption), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGSettleOption {
    [pbr::OriginalName("GCG_SETTLE_OPT_NONE")] GcgSettleOptNone = 0,
    [pbr::OriginalName("GCG_SETTLE_OPT_EXIT")] GcgSettleOptExit = 1,
    [pbr::OriginalName("GCG_SETTLE_OPT_CONTINUE")] GcgSettleOptContinue = 2,
    [pbr::OriginalName("GCG_SETTLE_OPT_RESTART")] GcgSettleOptRestart = 3,
  }

  #endregion

}

#endregion Designer generated code
