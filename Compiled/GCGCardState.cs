// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGCardState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGCardState.proto</summary>
  public static partial class GCGCardStateReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGCardState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGCardStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJHQ0dDYXJkU3RhdGUucHJvdG8SDW1pSG9tby5Qcm90b3MqWQoMR0NHQ2Fy",
            "ZFN0YXRlEhcKE0dDR19DQVJEX1NUQVRFX0hJREUQABIXChNHQ0dfQ0FSRF9T",
            "VEFURV9TRUxGEAESFwoTR0NHX0NBUkRfU1RBVEVfU0hPVxACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.GCGCardState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGCardState {
    [pbr::OriginalName("GCG_CARD_STATE_HIDE")] Hide = 0,
    [pbr::OriginalName("GCG_CARD_STATE_SELF")] Self = 1,
    [pbr::OriginalName("GCG_CARD_STATE_SHOW")] Show = 2,
  }

  #endregion

}

#endregion Designer generated code
