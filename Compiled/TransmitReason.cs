// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TransmitReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from TransmitReason.proto</summary>
  public static partial class TransmitReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for TransmitReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TransmitReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRUcmFuc21pdFJlYXNvbi5wcm90bxINbWlIb21vLlByb3Rvcyo3Cg5UcmFu",
            "c21pdFJlYXNvbhIRCg1UUkFOU01JVF9OT05FEAASEgoOVFJBTlNNSVRfUVVF",
            "U1QQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.TransmitReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum TransmitReason {
    [pbr::OriginalName("TRANSMIT_NONE")] TransmitNone = 0,
    [pbr::OriginalName("TRANSMIT_QUEST")] TransmitQuest = 1,
  }

  #endregion

}

#endregion Designer generated code
