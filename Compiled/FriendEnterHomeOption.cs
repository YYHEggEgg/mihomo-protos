// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FriendEnterHomeOption.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from FriendEnterHomeOption.proto</summary>
  public static partial class FriendEnterHomeOptionReflection {

    #region Descriptor
    /// <summary>File descriptor for FriendEnterHomeOption.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FriendEnterHomeOptionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtGcmllbmRFbnRlckhvbWVPcHRpb24ucHJvdG8SDW1pSG9tby5Qcm90b3Mq",
            "jAEKFUZyaWVuZEVudGVySG9tZU9wdGlvbhIpCiVGUklFTkRfRU5URVJfSE9N",
            "RV9PUFRJT05fTkVFRF9DT05GSVJNEAASIwofRlJJRU5EX0VOVEVSX0hPTUVf",
            "T1BUSU9OX1JFRlVTRRABEiMKH0ZSSUVORF9FTlRFUl9IT01FX09QVElPTl9E",
            "SVJFQ1QQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.FriendEnterHomeOption), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum FriendEnterHomeOption {
    [pbr::OriginalName("FRIEND_ENTER_HOME_OPTION_NEED_CONFIRM")] NeedConfirm = 0,
    [pbr::OriginalName("FRIEND_ENTER_HOME_OPTION_REFUSE")] Refuse = 1,
    [pbr::OriginalName("FRIEND_ENTER_HOME_OPTION_DIRECT")] Direct = 2,
  }

  #endregion

}

#endregion Designer generated code
