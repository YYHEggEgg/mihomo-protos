// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MapMarkPointType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MapMarkPointType.proto</summary>
  public static partial class MapMarkPointTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for MapMarkPointType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapMarkPointTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZNYXBNYXJrUG9pbnRUeXBlLnByb3RvEg1taUhvbW8uUHJvdG9zKvUBChBN",
            "YXBNYXJrUG9pbnRUeXBlEhsKF01BUF9NQVJLX1BPSU5UX1RZUEVfTlBDEAAS",
            "HQoZTUFQX01BUktfUE9JTlRfVFlQRV9RVUVTVBABEh8KG01BUF9NQVJLX1BP",
            "SU5UX1RZUEVfU1BFQ0lBTBACEhwKGE1BUF9NQVJLX1BPSU5UX1RZUEVfTUlO",
            "RRADEiIKHk1BUF9NQVJLX1BPSU5UX1RZUEVfQ09MTEVDVElPThAEEh8KG01B",
            "UF9NQVJLX1BPSU5UX1RZUEVfTU9OU1RFUhAFEiEKHU1BUF9NQVJLX1BPSU5U",
            "X1RZUEVfRklTSF9QT09MEAZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.MapMarkPointType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MapMarkPointType {
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_NPC")] Npc = 0,
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_QUEST")] Quest = 1,
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_SPECIAL")] Special = 2,
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_MINE")] Mine = 3,
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_COLLECTION")] Collection = 4,
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_MONSTER")] Monster = 5,
    [pbr::OriginalName("MAP_MARK_POINT_TYPE_FISH_POOL")] FishPool = 6,
  }

  #endregion

}

#endregion Designer generated code
