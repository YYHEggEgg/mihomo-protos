// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: RegionSearchState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from RegionSearchState.proto</summary>
  public static partial class RegionSearchStateReflection {

    #region Descriptor
    /// <summary>File descriptor for RegionSearchState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegionSearchStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdSZWdpb25TZWFyY2hTdGF0ZS5wcm90bxINbWlIb21vLlByb3RvcyqeAQoR",
            "UmVnaW9uU2VhcmNoU3RhdGUSFgoSUkVHSU9OX1NFQVJDSF9OT05FEAASGwoX",
            "UkVHSU9OX1NFQVJDSF9VTlNUQVJURUQQARIZChVSRUdJT05fU0VBUkNIX1NU",
            "QVJURUQQAhIdChlSRUdJT05fU0VBUkNIX1dBSVRfUkVXQVJEEAMSGgoWUkVH",
            "SU9OX1NFQVJDSF9GSU5JU0hFRBAEYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.RegionSearchState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum RegionSearchState {
    [pbr::OriginalName("REGION_SEARCH_NONE")] RegionSearchNone = 0,
    [pbr::OriginalName("REGION_SEARCH_UNSTARTED")] RegionSearchUnstarted = 1,
    [pbr::OriginalName("REGION_SEARCH_STARTED")] RegionSearchStarted = 2,
    [pbr::OriginalName("REGION_SEARCH_WAIT_REWARD")] RegionSearchWaitReward = 3,
    [pbr::OriginalName("REGION_SEARCH_FINISHED")] RegionSearchFinished = 4,
  }

  #endregion

}

#endregion Designer generated code
