// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ForgeQueueManipulateType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ForgeQueueManipulateType.proto</summary>
  public static partial class ForgeQueueManipulateTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ForgeQueueManipulateType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ForgeQueueManipulateTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Gb3JnZVF1ZXVlTWFuaXB1bGF0ZVR5cGUucHJvdG8SDW1pSG9tby5Qcm90",
            "b3MqdgoYRm9yZ2VRdWV1ZU1hbmlwdWxhdGVUeXBlEi4KKkZPUkdFX1FVRVVF",
            "X01BTklQVUxBVEVfVFlQRV9SRUNFSVZFX09VVFBVVBAAEioKJkZPUkdFX1FV",
            "RVVFX01BTklQVUxBVEVfVFlQRV9TVE9QX0ZPUkdFEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.ForgeQueueManipulateType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ForgeQueueManipulateType {
    [pbr::OriginalName("FORGE_QUEUE_MANIPULATE_TYPE_RECEIVE_OUTPUT")] ReceiveOutput = 0,
    [pbr::OriginalName("FORGE_QUEUE_MANIPULATE_TYPE_STOP_FORGE")] StopForge = 1,
  }

  #endregion

}

#endregion Designer generated code
