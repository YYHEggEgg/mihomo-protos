// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegionType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RegionType.proto</summary>
  public static partial class RegionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for RegionType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBSZWdpb25UeXBlLnByb3RvEg1taUhvbW8uUHJvdG9zKlkKClJlZ2lvblR5",
            "cGUSEgoOUkVHSU9OX1BST0RVQ1QQABIPCgtSRUdJT05fRVhBTRABEhIKDlJF",
            "R0lPTl9ERVZfUFVCEAISEgoOUkVHSU9OX0RFVl9QUkkQA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.RegionType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RegionType {
    [pbr::OriginalName("REGION_PRODUCT")] RegionProduct = 0,
    [pbr::OriginalName("REGION_EXAM")] RegionExam = 1,
    [pbr::OriginalName("REGION_DEV_PUB")] RegionDevPub = 2,
    [pbr::OriginalName("REGION_DEV_PRI")] RegionDevPri = 3,
  }

  #endregion

}

#endregion Designer generated code
