// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AreaPlayType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from AreaPlayType.proto</summary>
  public static partial class AreaPlayTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for AreaPlayType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AreaPlayTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJBcmVhUGxheVR5cGUucHJvdG8SDW1pSG9tby5Qcm90b3MqZQoMQXJlYVBs",
            "YXlUeXBlEhcKE0FSRUFfUExBWV9UWVBFX05PTkUQABIaChZBUkVBX1BMQVlf",
            "VFlQRV9DTElNQVRFEAESIAocQVJFQV9QTEFZX1RZUEVfUkVHSU9OQUxfUExB",
            "WRACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.AreaPlayType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum AreaPlayType {
    [pbr::OriginalName("AREA_PLAY_TYPE_NONE")] None = 0,
    [pbr::OriginalName("AREA_PLAY_TYPE_CLIMATE")] Climate = 1,
    [pbr::OriginalName("AREA_PLAY_TYPE_REGIONAL_PLAY")] RegionalPlay = 2,
  }

  #endregion

}

#endregion Designer generated code
