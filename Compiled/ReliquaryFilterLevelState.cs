// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ReliquaryFilterLevelState.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ReliquaryFilterLevelState.proto</summary>
  public static partial class ReliquaryFilterLevelStateReflection {

    #region Descriptor
    /// <summary>File descriptor for ReliquaryFilterLevelState.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReliquaryFilterLevelStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9SZWxpcXVhcnlGaWx0ZXJMZXZlbFN0YXRlLnByb3RvEg1taUhvbW8uUHJv",
            "dG9zKqABChlSZWxpcXVhcnlGaWx0ZXJMZXZlbFN0YXRlEiUKIVJFTElRVUFS",
            "WV9GSUxURVJfTEVWRUxfU1RBVEVfTk9ORRAAEisKJ1JFTElRVUFSWV9GSUxU",
            "RVJfTEVWRUxfU1RBVEVfRlVMTF9MRVZFTBABEi8KK1JFTElRVUFSWV9GSUxU",
            "RVJfTEVWRUxfU1RBVEVfTk9UX0ZVTExfTEVWRUwQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.ReliquaryFilterLevelState), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ReliquaryFilterLevelState {
    [pbr::OriginalName("RELIQUARY_FILTER_LEVEL_STATE_NONE")] None = 0,
    [pbr::OriginalName("RELIQUARY_FILTER_LEVEL_STATE_FULL_LEVEL")] FullLevel = 1,
    [pbr::OriginalName("RELIQUARY_FILTER_LEVEL_STATE_NOT_FULL_LEVEL")] NotFullLevel = 2,
  }

  #endregion

}

#endregion Designer generated code
