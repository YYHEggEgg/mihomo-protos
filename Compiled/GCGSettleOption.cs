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
            "ChVHQ0dTZXR0bGVPcHRpb24ucHJvdG8SDW1pSG9tby5Qcm90b3MqmAEKD0dD",
            "R1NldHRsZU9wdGlvbhIeChpHQ0dfU0VUVExFX09QVElPTl9PUFRfTk9ORRAA",
            "Eh4KGkdDR19TRVRUTEVfT1BUSU9OX09QVF9FWElUEAESIgoeR0NHX1NFVFRM",
            "RV9PUFRJT05fT1BUX0NPTlRJTlVFEAISIQodR0NHX1NFVFRMRV9PUFRJT05f",
            "T1BUX1JFU1RBUlQQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.GCGSettleOption), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGSettleOption {
    [pbr::OriginalName("GCG_SETTLE_OPTION_OPT_NONE")] OptNone = 0,
    [pbr::OriginalName("GCG_SETTLE_OPTION_OPT_EXIT")] OptExit = 1,
    [pbr::OriginalName("GCG_SETTLE_OPTION_OPT_CONTINUE")] OptContinue = 2,
    [pbr::OriginalName("GCG_SETTLE_OPTION_OPT_RESTART")] OptRestart = 3,
  }

  #endregion

}

#endregion Designer generated code
