// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGZoneType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGZoneType.proto</summary>
  public static partial class GCGZoneTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGZoneType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGZoneTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFHQ0dab25lVHlwZS5wcm90bxINbWlIb21vLlByb3RvcyrJAQoLR0NHWm9u",
            "ZVR5cGUSFAoQR0NHX1pPTkVfSU5WQUxJRBAAEhEKDUdDR19aT05FX0RFQ0sQ",
            "ARIRCg1HQ0dfWk9ORV9IQU5EEAISFgoSR0NHX1pPTkVfQ0hBUkFDVEVSEAMS",
            "EwoPR0NHX1pPTkVfTU9ESUZZEAQSEwoPR0NHX1pPTkVfU1VNTU9OEAUSEwoP",
            "R0NHX1pPTkVfQVNTSVNUEAcSFAoQR0NHX1pPTkVfT05TVEFHRRAIEhEKDUdD",
            "R19aT05FX1JVTEUQCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.GCGZoneType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum GCGZoneType {
    [pbr::OriginalName("GCG_ZONE_INVALID")] GcgZoneInvalid = 0,
    [pbr::OriginalName("GCG_ZONE_DECK")] GcgZoneDeck = 1,
    [pbr::OriginalName("GCG_ZONE_HAND")] GcgZoneHand = 2,
    [pbr::OriginalName("GCG_ZONE_CHARACTER")] GcgZoneCharacter = 3,
    [pbr::OriginalName("GCG_ZONE_MODIFY")] GcgZoneModify = 4,
    [pbr::OriginalName("GCG_ZONE_SUMMON")] GcgZoneSummon = 5,
    [pbr::OriginalName("GCG_ZONE_ASSIST")] GcgZoneAssist = 7,
    [pbr::OriginalName("GCG_ZONE_ONSTAGE")] GcgZoneOnstage = 8,
    [pbr::OriginalName("GCG_ZONE_RULE")] GcgZoneRule = 9,
  }

  #endregion

}

#endregion Designer generated code
