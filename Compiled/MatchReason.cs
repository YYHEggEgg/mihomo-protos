// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MatchReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MatchReason.proto</summary>
  public static partial class MatchReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for MatchReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatchReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFNYXRjaFJlYXNvbi5wcm90bxINbWlIb21vLlByb3RvcyqxAgoLTWF0Y2hS",
            "ZWFzb24SFQoRTUFUQ0hfUkVBU09OX05PTkUQABIXChNNQVRDSF9SRUFTT05f",
            "RklOSVNIEAESHgoaTUFUQ0hfUkVBU09OX1BMQVlFUl9DQU5DRUwQAhIYChRN",
            "QVRDSF9SRUFTT05fVElNRU9VVBADEh8KG01BVENIX1JFQVNPTl9QTEFZRVJf",
            "Q09ORklSTRAEEhcKE01BVENIX1JFQVNPTl9GQUlMRUQQBRIdChlNQVRDSF9S",
            "RUFTT05fU1lTVEVNX0VSUk9SEAYSHAoYTUFUQ0hfUkVBU09OX0lOVEVSUlVQ",
            "VEVEEAcSHwobTUFUQ0hfUkVBU09OX01QX1VOQVZBSUxBQkxFEAgSIAocTUFU",
            "Q0hfUkVBU09OX0NPTkZJUk1fVElNRU9VVBAJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.MatchReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum MatchReason {
    [pbr::OriginalName("MATCH_REASON_NONE")] None = 0,
    [pbr::OriginalName("MATCH_REASON_FINISH")] Finish = 1,
    [pbr::OriginalName("MATCH_REASON_PLAYER_CANCEL")] PlayerCancel = 2,
    [pbr::OriginalName("MATCH_REASON_TIMEOUT")] Timeout = 3,
    [pbr::OriginalName("MATCH_REASON_PLAYER_CONFIRM")] PlayerConfirm = 4,
    [pbr::OriginalName("MATCH_REASON_FAILED")] Failed = 5,
    [pbr::OriginalName("MATCH_REASON_SYSTEM_ERROR")] SystemError = 6,
    [pbr::OriginalName("MATCH_REASON_INTERRUPTED")] Interrupted = 7,
    [pbr::OriginalName("MATCH_REASON_MP_UNAVAILABLE")] MpUnavailable = 8,
    [pbr::OriginalName("MATCH_REASON_CONFIRM_TIMEOUT")] ConfirmTimeout = 9,
  }

  #endregion

}

#endregion Designer generated code
