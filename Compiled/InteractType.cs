// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: InteractType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from InteractType.proto</summary>
  public static partial class InteractTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for InteractType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InteractTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJJbnRlcmFjdFR5cGUucHJvdG8SDW1pSG9tby5Qcm90b3MqtgMKDEludGVy",
            "YWN0VHlwZRIRCg1JTlRFUkFDVF9OT05FEAASFgoSSU5URVJBQ1RfUElDS19J",
            "VEVNEAESEwoPSU5URVJBQ1RfR0FUSEVSEAISFwoTSU5URVJBQ1RfT1BFTl9D",
            "SEVTVBADEhgKFElOVEVSQUNUX09QRU5fU1RBVFVFEAQSEwoPSU5URVJBQ1Rf",
            "Q09OU1VNEAUSGwoXSU5URVJBQ1RfTVBfUExBWV9SRVdBUkQQBhIRCg1JTlRF",
            "UkFDVF9WSUVXEAcSGwoXSU5URVJBQ1RfR0VORVJBTF9SRVdBUkQQCBIZChVJ",
            "TlRFUkFDVF9NSVJBQ0xFX1JJTkcQCRIXChNJTlRFUkFDVF9GT1VOREFUSU9O",
            "EAoSFwoTSU5URVJBQ1RfRUNIT19TSEVMTBALEhgKFElOVEVSQUNUX0hPTUVf",
            "R0FUSEVSEAwSFwoTSU5URVJBQ1RfRU5WX0FOSU1BTBANEhkKFUlOVEVSQUNU",
            "X1FVRVNUX0dBREdFVBAOEhgKFElOVEVSQUNUX1VJX0lOVEVSQUNUEA8SHAoY",
            "SU5URVJBQ1RfREVTSFJFVF9PQkVMSVNLEBBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.InteractType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum InteractType {
    [pbr::OriginalName("INTERACT_NONE")] InteractNone = 0,
    [pbr::OriginalName("INTERACT_PICK_ITEM")] InteractPickItem = 1,
    [pbr::OriginalName("INTERACT_GATHER")] InteractGather = 2,
    [pbr::OriginalName("INTERACT_OPEN_CHEST")] InteractOpenChest = 3,
    [pbr::OriginalName("INTERACT_OPEN_STATUE")] InteractOpenStatue = 4,
    [pbr::OriginalName("INTERACT_CONSUM")] InteractConsum = 5,
    [pbr::OriginalName("INTERACT_MP_PLAY_REWARD")] InteractMpPlayReward = 6,
    [pbr::OriginalName("INTERACT_VIEW")] InteractView = 7,
    [pbr::OriginalName("INTERACT_GENERAL_REWARD")] InteractGeneralReward = 8,
    [pbr::OriginalName("INTERACT_MIRACLE_RING")] InteractMiracleRing = 9,
    [pbr::OriginalName("INTERACT_FOUNDATION")] InteractFoundation = 10,
    [pbr::OriginalName("INTERACT_ECHO_SHELL")] InteractEchoShell = 11,
    [pbr::OriginalName("INTERACT_HOME_GATHER")] InteractHomeGather = 12,
    [pbr::OriginalName("INTERACT_ENV_ANIMAL")] InteractEnvAnimal = 13,
    [pbr::OriginalName("INTERACT_QUEST_GADGET")] InteractQuestGadget = 14,
    [pbr::OriginalName("INTERACT_UI_INTERACT")] InteractUiInteract = 15,
    [pbr::OriginalName("INTERACT_DESHRET_OBELISK")] InteractDeshretObelisk = 16,
  }

  #endregion

}

#endregion Designer generated code
