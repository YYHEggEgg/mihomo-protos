// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerTag.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlayerTag.proto</summary>
  public static partial class PlayerTagReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerTag.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerTagReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9QbGF5ZXJUYWcucHJvdG8SDW1pSG9tby5Qcm90b3MqagoJUGxheWVyVGFn",
            "EhUKEVBMQVlFUl9UQUdfTk9STUFMEAASGgoWUExBWUVSX1RBR19TVUJfQUND",
            "T1VOVBADEioKJlBMQVlFUl9UQUdfU1VCX0FDQ09VTlRfVFJBTlNfVE9fTk9S",
            "TUFMEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.PlayerTag), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum PlayerTag {
    [pbr::OriginalName("PLAYER_TAG_NORMAL")] Normal = 0,
    [pbr::OriginalName("PLAYER_TAG_SUB_ACCOUNT")] SubAccount = 3,
    [pbr::OriginalName("PLAYER_TAG_SUB_ACCOUNT_TRANS_TO_NORMAL")] SubAccountTransToNormal = 5,
  }

  #endregion

}

#endregion Designer generated code
