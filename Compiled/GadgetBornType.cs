// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GadgetBornType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GadgetBornType.proto</summary>
  public static partial class GadgetBornTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GadgetBornType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GadgetBornTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRHYWRnZXRCb3JuVHlwZS5wcm90bxINbWlIb21vLlByb3RvcyrjAQoOR2Fk",
            "Z2V0Qm9yblR5cGUSGQoVR0FER0VUX0JPUk5fVFlQRV9OT05FEAASGwoXR0FE",
            "R0VUX0JPUk5fVFlQRV9JTl9BSVIQARIbChdHQURHRVRfQk9STl9UWVBFX1BM",
            "QVlFUhACEiAKHEdBREdFVF9CT1JOX1RZUEVfTU9OU1RFUl9ISVQQAxIgChxH",
            "QURHRVRfQk9STl9UWVBFX01PTlNURVJfRElFEAQSGwoXR0FER0VUX0JPUk5f",
            "VFlQRV9HQURHRVQQBRIbChdHQURHRVRfQk9STl9UWVBFX0dST1VORBAGYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.GadgetBornType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GadgetBornType {
    [pbr::OriginalName("GADGET_BORN_TYPE_NONE")] None = 0,
    [pbr::OriginalName("GADGET_BORN_TYPE_IN_AIR")] InAir = 1,
    [pbr::OriginalName("GADGET_BORN_TYPE_PLAYER")] Player = 2,
    [pbr::OriginalName("GADGET_BORN_TYPE_MONSTER_HIT")] MonsterHit = 3,
    [pbr::OriginalName("GADGET_BORN_TYPE_MONSTER_DIE")] MonsterDie = 4,
    [pbr::OriginalName("GADGET_BORN_TYPE_GADGET")] Gadget = 5,
    [pbr::OriginalName("GADGET_BORN_TYPE_GROUND")] Ground = 6,
  }

  #endregion

}

#endregion Designer generated code
