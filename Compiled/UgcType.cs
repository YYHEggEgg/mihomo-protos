// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UgcType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from UgcType.proto</summary>
  public static partial class UgcTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for UgcType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UgcTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1VZ2NUeXBlLnByb3RvEg1taUhvbW8uUHJvdG9zKjUKB1VnY1R5cGUSEQoN",
            "VUdDX1RZUEVfTk9ORRAAEhcKE1VHQ19UWVBFX01VU0lDX0dBTUUQAWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.UgcType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum UgcType {
    [pbr::OriginalName("UGC_TYPE_NONE")] None = 0,
    [pbr::OriginalName("UGC_TYPE_MUSIC_GAME")] MusicGame = 1,
  }

  #endregion

}

#endregion Designer generated code
