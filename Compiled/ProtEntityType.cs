// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProtEntityType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ProtEntityType.proto</summary>
  public static partial class ProtEntityTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for ProtEntityType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtEntityTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90RW50aXR5VHlwZS5wcm90bxINbWlIb21vLlByb3RvcyrRAwoOUHJv",
            "dEVudGl0eVR5cGUSGQoVUFJPVF9FTlRJVFlfVFlQRV9OT05FEAASGwoXUFJP",
            "VF9FTlRJVFlfVFlQRV9BVkFUQVIQARIcChhQUk9UX0VOVElUWV9UWVBFX01P",
            "TlNURVIQAhIYChRQUk9UX0VOVElUWV9UWVBFX05QQxADEhsKF1BST1RfRU5U",
            "SVRZX1RZUEVfR0FER0VUEAQSGwoXUFJPVF9FTlRJVFlfVFlQRV9SRUdJT04Q",
            "BRIbChdQUk9UX0VOVElUWV9UWVBFX1dFQVBPThAGEhwKGFBST1RfRU5USVRZ",
            "X1RZUEVfV0VBVEhFUhAHEhoKFlBST1RfRU5USVRZX1RZUEVfU0NFTkUQCBIZ",
            "ChVQUk9UX0VOVElUWV9UWVBFX1RFQU0QCRIjCh9QUk9UX0VOVElUWV9UWVBF",
            "X01BU1NJVkVfRU5USVRZEAoSHQoZUFJPVF9FTlRJVFlfVFlQRV9NUF9MRVZF",
            "TBALEiUKIVBST1RfRU5USVRZX1RZUEVfUExBWV9URUFNX0VOVElUWRAMEh4K",
            "GlBST1RfRU5USVRZX1RZUEVfRVlFX1BPSU5UEA0SGAoUUFJPVF9FTlRJVFlf",
            "VFlQRV9NQVgQDmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.ProtEntityType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum ProtEntityType {
    [pbr::OriginalName("PROT_ENTITY_TYPE_NONE")] None = 0,
    [pbr::OriginalName("PROT_ENTITY_TYPE_AVATAR")] Avatar = 1,
    [pbr::OriginalName("PROT_ENTITY_TYPE_MONSTER")] Monster = 2,
    [pbr::OriginalName("PROT_ENTITY_TYPE_NPC")] Npc = 3,
    [pbr::OriginalName("PROT_ENTITY_TYPE_GADGET")] Gadget = 4,
    [pbr::OriginalName("PROT_ENTITY_TYPE_REGION")] Region = 5,
    [pbr::OriginalName("PROT_ENTITY_TYPE_WEAPON")] Weapon = 6,
    [pbr::OriginalName("PROT_ENTITY_TYPE_WEATHER")] Weather = 7,
    [pbr::OriginalName("PROT_ENTITY_TYPE_SCENE")] Scene = 8,
    [pbr::OriginalName("PROT_ENTITY_TYPE_TEAM")] Team = 9,
    [pbr::OriginalName("PROT_ENTITY_TYPE_MASSIVE_ENTITY")] MassiveEntity = 10,
    [pbr::OriginalName("PROT_ENTITY_TYPE_MP_LEVEL")] MpLevel = 11,
    [pbr::OriginalName("PROT_ENTITY_TYPE_PLAY_TEAM_ENTITY")] PlayTeamEntity = 12,
    [pbr::OriginalName("PROT_ENTITY_TYPE_EYE_POINT")] EyePoint = 13,
    [pbr::OriginalName("PROT_ENTITY_TYPE_MAX")] Max = 14,
  }

  #endregion

}

#endregion Designer generated code
