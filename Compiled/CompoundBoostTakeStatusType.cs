// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CompoundBoostTakeStatusType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CompoundBoostTakeStatusType.proto</summary>
  public static partial class CompoundBoostTakeStatusTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for CompoundBoostTakeStatusType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompoundBoostTakeStatusTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFDb21wb3VuZEJvb3N0VGFrZVN0YXR1c1R5cGUucHJvdG8SDW1pSG9tby5Q",
            "cm90b3Mq2QEKG0NvbXBvdW5kQm9vc3RUYWtlU3RhdHVzVHlwZRIoCiRDT01Q",
            "T1VORF9CT09TVF9UQUtFX1NUQVRVU19UWVBFX05PTkUQABIuCipDT01QT1VO",
            "RF9CT09TVF9UQUtFX1NUQVRVU19UWVBFX0JPT1NUX09OTFkQARIyCi5DT01Q",
            "T1VORF9CT09TVF9UQUtFX1NUQVRVU19UWVBFX0JPT1NUX0FORF9UQUtFEAIS",
            "LAooQ09NUE9VTkRfQk9PU1RfVEFLRV9TVEFUVVNfVFlQRV9CQUdfRlVMTBAD",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.CompoundBoostTakeStatusType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum CompoundBoostTakeStatusType {
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_NONE")] None = 0,
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_BOOST_ONLY")] BoostOnly = 1,
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_BOOST_AND_TAKE")] BoostAndTake = 2,
    [pbr::OriginalName("COMPOUND_BOOST_TAKE_STATUS_TYPE_BAG_FULL")] BagFull = 3,
  }

  #endregion

}

#endregion Designer generated code
