// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ServiceType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ServiceType.proto</summary>
  public static partial class ServiceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ServiceType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServiceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFTZXJ2aWNlVHlwZS5wcm90bxINbWlIb21vLlByb3RvcyqqAwoLU2Vydmlj",
            "ZVR5cGUSEAoMU0VSVklDRV9OT05FEAASEgoOU0VSVklDRV9DTElFTlQQARIQ",
            "CgxTRVJWSUNFX0dBVEUQAhIQCgxTRVJWSUNFX0dBTUUQAxIQCgxTRVJWSUNF",
            "X05PREUQBBIOCgpTRVJWSUNFX0RCEAUSDwoLU0VSVklDRV9TTlMQBhIUChBT",
            "RVJWSUNFX0RJU1BBVENIEAcSEAoMU0VSVklDRV9NVUlQEAgSFwoTU0VSVklD",
            "RV9PRkZMSU5FX01TRxAJEhAKDFNFUlZJQ0VfTUFJTBAKEg4KClNFUlZJQ0Vf",
            "TVAQCxIVChFTRVJWSUNFX0hUVFBQUk9YWRAMEhQKEFNFUlZJQ0VfQUNUSVZJ",
            "VFkQDRIXChNTRVJWSUNFX1BBVEhGSU5ESU5HEA4SEgoOU0VSVklDRV9TT0NJ",
            "QUwQDxIOCgpTRVJWSUNFX09BEBASEQoNU0VSVklDRV9NQVRDSBAREhYKElNF",
            "UlZJQ0VfT0ZGTElORV9PUBASEhUKEVNFUlZJQ0VfVE9USEVNT09OEBMSDwoL",
            "U0VSVklDRV9HQ0cQFGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.ServiceType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ServiceType {
    [pbr::OriginalName("SERVICE_NONE")] ServiceNone = 0,
    [pbr::OriginalName("SERVICE_CLIENT")] ServiceClient = 1,
    [pbr::OriginalName("SERVICE_GATE")] ServiceGate = 2,
    [pbr::OriginalName("SERVICE_GAME")] ServiceGame = 3,
    [pbr::OriginalName("SERVICE_NODE")] ServiceNode = 4,
    [pbr::OriginalName("SERVICE_DB")] ServiceDb = 5,
    [pbr::OriginalName("SERVICE_SNS")] ServiceSns = 6,
    [pbr::OriginalName("SERVICE_DISPATCH")] ServiceDispatch = 7,
    [pbr::OriginalName("SERVICE_MUIP")] ServiceMuip = 8,
    [pbr::OriginalName("SERVICE_OFFLINE_MSG")] ServiceOfflineMsg = 9,
    [pbr::OriginalName("SERVICE_MAIL")] ServiceMail = 10,
    [pbr::OriginalName("SERVICE_MP")] ServiceMp = 11,
    [pbr::OriginalName("SERVICE_HTTPPROXY")] ServiceHttpproxy = 12,
    [pbr::OriginalName("SERVICE_ACTIVITY")] ServiceActivity = 13,
    [pbr::OriginalName("SERVICE_PATHFINDING")] ServicePathfinding = 14,
    [pbr::OriginalName("SERVICE_SOCIAL")] ServiceSocial = 15,
    [pbr::OriginalName("SERVICE_OA")] ServiceOa = 16,
    [pbr::OriginalName("SERVICE_MATCH")] ServiceMatch = 17,
    [pbr::OriginalName("SERVICE_OFFLINE_OP")] ServiceOfflineOp = 18,
    [pbr::OriginalName("SERVICE_TOTHEMOON")] ServiceTothemoon = 19,
    [pbr::OriginalName("SERVICE_GCG")] ServiceGcg = 20,
  }

  #endregion

}

#endregion Designer generated code
