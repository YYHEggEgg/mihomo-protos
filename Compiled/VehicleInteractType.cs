// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VehicleInteractType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from VehicleInteractType.proto</summary>
  public static partial class VehicleInteractTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for VehicleInteractType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VehicleInteractTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlWZWhpY2xlSW50ZXJhY3RUeXBlLnByb3RvEg1taUhvbW8uUHJvdG9zKnIK",
            "E1ZlaGljbGVJbnRlcmFjdFR5cGUSHgoaVkVISUNMRV9JTlRFUkFDVF9UWVBF",
            "X05PTkUQABIcChhWRUhJQ0xFX0lOVEVSQUNUX1RZUEVfSU4QARIdChlWRUhJ",
            "Q0xFX0lOVEVSQUNUX1RZUEVfT1VUEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.VehicleInteractType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum VehicleInteractType {
    [pbr::OriginalName("VEHICLE_INTERACT_TYPE_NONE")] None = 0,
    [pbr::OriginalName("VEHICLE_INTERACT_TYPE_IN")] In = 1,
    [pbr::OriginalName("VEHICLE_INTERACT_TYPE_OUT")] Out = 2,
  }

  #endregion

}

#endregion Designer generated code
