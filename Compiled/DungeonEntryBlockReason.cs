// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DungeonEntryBlockReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from DungeonEntryBlockReason.proto</summary>
  public static partial class DungeonEntryBlockReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for DungeonEntryBlockReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DungeonEntryBlockReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1EdW5nZW9uRW50cnlCbG9ja1JlYXNvbi5wcm90bxINbWlIb21vLlByb3Rv",
            "cyqzAQoXRHVuZ2VvbkVudHJ5QmxvY2tSZWFzb24SIwofRFVOR0VPTl9FTlRS",
            "WV9CTE9DS19SRUFTT05fTk9ORRAAEiQKIERVTkdFT05fRU5UUllfQkxPQ0tf",
            "UkVBU09OX0xFVkVMEAESJAogRFVOR0VPTl9FTlRSWV9CTE9DS19SRUFTT05f",
            "UVVFU1QQAhInCiNEVU5HRU9OX0VOVFJZX0JMT0NLX1JFQVNPTl9NVUxUSVBM",
            "RRADYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.DungeonEntryBlockReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum DungeonEntryBlockReason {
    [pbr::OriginalName("DUNGEON_ENTRY_BLOCK_REASON_NONE")] None = 0,
    [pbr::OriginalName("DUNGEON_ENTRY_BLOCK_REASON_LEVEL")] Level = 1,
    [pbr::OriginalName("DUNGEON_ENTRY_BLOCK_REASON_QUEST")] Quest = 2,
    [pbr::OriginalName("DUNGEON_ENTRY_BLOCK_REASON_MULTIPLE")] Multiple = 3,
  }

  #endregion

}

#endregion Designer generated code
