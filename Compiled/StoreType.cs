// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: StoreType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from StoreType.proto</summary>
  public static partial class StoreTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for StoreType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StoreTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9TdG9yZVR5cGUucHJvdG8SDW1pSG9tby5Qcm90b3MqPAoJU3RvcmVUeXBl",
            "Eg4KClNUT1JFX05PTkUQABIOCgpTVE9SRV9QQUNLEAESDwoLU1RPUkVfREVQ",
            "T1QQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.StoreType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum StoreType {
    [pbr::OriginalName("STORE_NONE")] StoreNone = 0,
    [pbr::OriginalName("STORE_PACK")] StorePack = 1,
    [pbr::OriginalName("STORE_DEPOT")] StoreDepot = 2,
  }

  #endregion

}

#endregion Designer generated code
