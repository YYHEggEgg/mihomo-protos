// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BeginCameraSceneLookNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from BeginCameraSceneLookNotify.proto</summary>
  public static partial class BeginCameraSceneLookNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BeginCameraSceneLookNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeginCameraSceneLookNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCZWdpbkNhbWVyYVNjZW5lTG9va05vdGlmeS5wcm90bxINbWlIb21vLlBy",
            "b3RvcxoMVmVjdG9yLnByb3RvIs4FChpCZWdpbkNhbWVyYVNjZW5lTG9va05v",
            "dGlmeRIQCghkdXJhdGlvbhgCIAEoAhISCgllbnRpdHlfaWQY+wogASgNEikK",
            "CmZvbGxvd19wb3MYCCABKAsyFS5taUhvbW8uUHJvdG9zLlZlY3RvchJMCg1r",
            "ZWVwX3JvdF90eXBlGAsgASgOMjUubWlIb21vLlByb3Rvcy5CZWdpbkNhbWVy",
            "YVNjZW5lTG9va05vdGlmeS5LZWVwUm90VHlwZRInCghsb29rX3BvcxgNIAEo",
            "CzIVLm1pSG9tby5Qcm90b3MuVmVjdG9yEhQKDG90aGVyX3BhcmFtcxgJIAMo",
            "CRIcChNVbmszMzAwX0FBT0dCQ0NOSkFGGMgJIAEoCBIcChNVbmszMzAwX0FK",
            "RUVORU9DRk9OGMUHIAEoDRIbChNVbmszMzAwX0RGUENNT0ZPTk5LGA8gASgI",
            "EhsKE1VuazMzMDBfRUVMTk9BSUNIT0oYBCABKAgSGwoTVW5rMzMwMF9GSU9M",
            "R0NJS0ZMSBgKIAEoAhIbChNVbmszMzAwX0hDTFBHR0FPSUFDGAwgASgCEhsK",
            "E1VuazMzMDBfSEZQQ0hGTkZKS1AYDiABKAISHAoTVW5rMzMwMF9IS0tDSENF",
            "TUpJRRi0DSABKAISGwoTVW5rMzMwMF9JTE1IRExITEtHShgBIAEoCBIcChNV",
            "bmszMzAwX0tDSEtLQk9ETkNKGNINIAEoDRIbChNVbmszMzAwX05KTEJJTUpE",
            "RkhKGAMgASgIEhsKE1VuazMzMDBfT0RBRE1CQkZQQVAYByABKAgSGwoTVW5r",
            "MzMwMF9PTkJETUNIRlBETBgFIAEoCBIbChNVbmszMzAwX1BJRUZMQUVHR0JJ",
            "GAYgASgIIjgKC0tlZXBSb3RUeXBlEhMKD0tFRVBfUk9UX1RZUEVfWBAAEhQK",
            "EEtFRVBfUk9UX1RZUEVfWFkQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.BeginCameraSceneLookNotify), global::MiHomo.Protos.BeginCameraSceneLookNotify.Parser, new[]{ "Duration", "EntityId", "FollowPos", "KeepRotType", "LookPos", "OtherParams", "Unk3300AAOGBCCNJAF", "Unk3300AJEENEOCFON", "Unk3300DFPCMOFONNK", "Unk3300EELNOAICHOJ", "Unk3300FIOLGCIKFLH", "Unk3300HCLPGGAOIAC", "Unk3300HFPCHFNFJKP", "Unk3300HKKCHCEMJIE", "Unk3300ILMHDLHLKGJ", "Unk3300KCHKKBODNCJ", "Unk3300NJLBIMJDFHJ", "Unk3300ODADMBBFPAP", "Unk3300ONBDMCHFPDL", "Unk3300PIEFLAEGGBI" }, null, new[]{ typeof(global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BeginCameraSceneLookNotify : pb::IMessage<BeginCameraSceneLookNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BeginCameraSceneLookNotify> _parser = new pb::MessageParser<BeginCameraSceneLookNotify>(() => new BeginCameraSceneLookNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BeginCameraSceneLookNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.BeginCameraSceneLookNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify(BeginCameraSceneLookNotify other) : this() {
      duration_ = other.duration_;
      entityId_ = other.entityId_;
      followPos_ = other.followPos_ != null ? other.followPos_.Clone() : null;
      keepRotType_ = other.keepRotType_;
      lookPos_ = other.lookPos_ != null ? other.lookPos_.Clone() : null;
      otherParams_ = other.otherParams_.Clone();
      unk3300AAOGBCCNJAF_ = other.unk3300AAOGBCCNJAF_;
      unk3300AJEENEOCFON_ = other.unk3300AJEENEOCFON_;
      unk3300DFPCMOFONNK_ = other.unk3300DFPCMOFONNK_;
      unk3300EELNOAICHOJ_ = other.unk3300EELNOAICHOJ_;
      unk3300FIOLGCIKFLH_ = other.unk3300FIOLGCIKFLH_;
      unk3300HCLPGGAOIAC_ = other.unk3300HCLPGGAOIAC_;
      unk3300HFPCHFNFJKP_ = other.unk3300HFPCHFNFJKP_;
      unk3300HKKCHCEMJIE_ = other.unk3300HKKCHCEMJIE_;
      unk3300ILMHDLHLKGJ_ = other.unk3300ILMHDLHLKGJ_;
      unk3300KCHKKBODNCJ_ = other.unk3300KCHKKBODNCJ_;
      unk3300NJLBIMJDFHJ_ = other.unk3300NJLBIMJDFHJ_;
      unk3300ODADMBBFPAP_ = other.unk3300ODADMBBFPAP_;
      unk3300ONBDMCHFPDL_ = other.unk3300ONBDMCHFPDL_;
      unk3300PIEFLAEGGBI_ = other.unk3300PIEFLAEGGBI_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify Clone() {
      return new BeginCameraSceneLookNotify(this);
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 2;
    private float duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1403;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "follow_pos" field.</summary>
    public const int FollowPosFieldNumber = 8;
    private global::MiHomo.Protos.Vector followPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector FollowPos {
      get { return followPos_; }
      set {
        followPos_ = value;
      }
    }

    /// <summary>Field number for the "keep_rot_type" field.</summary>
    public const int KeepRotTypeFieldNumber = 11;
    private global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType keepRotType_ = global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType.X;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType KeepRotType {
      get { return keepRotType_; }
      set {
        keepRotType_ = value;
      }
    }

    /// <summary>Field number for the "look_pos" field.</summary>
    public const int LookPosFieldNumber = 13;
    private global::MiHomo.Protos.Vector lookPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.Vector LookPos {
      get { return lookPos_; }
      set {
        lookPos_ = value;
      }
    }

    /// <summary>Field number for the "other_params" field.</summary>
    public const int OtherParamsFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_otherParams_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> otherParams_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> OtherParams {
      get { return otherParams_; }
    }

    /// <summary>Field number for the "Unk3300_AAOGBCCNJAF" field.</summary>
    public const int Unk3300AAOGBCCNJAFFieldNumber = 1224;
    private bool unk3300AAOGBCCNJAF_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300AAOGBCCNJAF {
      get { return unk3300AAOGBCCNJAF_; }
      set {
        unk3300AAOGBCCNJAF_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AJEENEOCFON" field.</summary>
    public const int Unk3300AJEENEOCFONFieldNumber = 965;
    private uint unk3300AJEENEOCFON_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AJEENEOCFON {
      get { return unk3300AJEENEOCFON_; }
      set {
        unk3300AJEENEOCFON_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DFPCMOFONNK" field.</summary>
    public const int Unk3300DFPCMOFONNKFieldNumber = 15;
    private bool unk3300DFPCMOFONNK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300DFPCMOFONNK {
      get { return unk3300DFPCMOFONNK_; }
      set {
        unk3300DFPCMOFONNK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EELNOAICHOJ" field.</summary>
    public const int Unk3300EELNOAICHOJFieldNumber = 4;
    private bool unk3300EELNOAICHOJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300EELNOAICHOJ {
      get { return unk3300EELNOAICHOJ_; }
      set {
        unk3300EELNOAICHOJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_FIOLGCIKFLH" field.</summary>
    public const int Unk3300FIOLGCIKFLHFieldNumber = 10;
    private float unk3300FIOLGCIKFLH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300FIOLGCIKFLH {
      get { return unk3300FIOLGCIKFLH_; }
      set {
        unk3300FIOLGCIKFLH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HCLPGGAOIAC" field.</summary>
    public const int Unk3300HCLPGGAOIACFieldNumber = 12;
    private float unk3300HCLPGGAOIAC_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300HCLPGGAOIAC {
      get { return unk3300HCLPGGAOIAC_; }
      set {
        unk3300HCLPGGAOIAC_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HFPCHFNFJKP" field.</summary>
    public const int Unk3300HFPCHFNFJKPFieldNumber = 14;
    private float unk3300HFPCHFNFJKP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300HFPCHFNFJKP {
      get { return unk3300HFPCHFNFJKP_; }
      set {
        unk3300HFPCHFNFJKP_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HKKCHCEMJIE" field.</summary>
    public const int Unk3300HKKCHCEMJIEFieldNumber = 1716;
    private float unk3300HKKCHCEMJIE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Unk3300HKKCHCEMJIE {
      get { return unk3300HKKCHCEMJIE_; }
      set {
        unk3300HKKCHCEMJIE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ILMHDLHLKGJ" field.</summary>
    public const int Unk3300ILMHDLHLKGJFieldNumber = 1;
    private bool unk3300ILMHDLHLKGJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ILMHDLHLKGJ {
      get { return unk3300ILMHDLHLKGJ_; }
      set {
        unk3300ILMHDLHLKGJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_KCHKKBODNCJ" field.</summary>
    public const int Unk3300KCHKKBODNCJFieldNumber = 1746;
    private uint unk3300KCHKKBODNCJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300KCHKKBODNCJ {
      get { return unk3300KCHKKBODNCJ_; }
      set {
        unk3300KCHKKBODNCJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_NJLBIMJDFHJ" field.</summary>
    public const int Unk3300NJLBIMJDFHJFieldNumber = 3;
    private bool unk3300NJLBIMJDFHJ_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300NJLBIMJDFHJ {
      get { return unk3300NJLBIMJDFHJ_; }
      set {
        unk3300NJLBIMJDFHJ_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ODADMBBFPAP" field.</summary>
    public const int Unk3300ODADMBBFPAPFieldNumber = 7;
    private bool unk3300ODADMBBFPAP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ODADMBBFPAP {
      get { return unk3300ODADMBBFPAP_; }
      set {
        unk3300ODADMBBFPAP_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_ONBDMCHFPDL" field.</summary>
    public const int Unk3300ONBDMCHFPDLFieldNumber = 5;
    private bool unk3300ONBDMCHFPDL_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300ONBDMCHFPDL {
      get { return unk3300ONBDMCHFPDL_; }
      set {
        unk3300ONBDMCHFPDL_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_PIEFLAEGGBI" field.</summary>
    public const int Unk3300PIEFLAEGGBIFieldNumber = 6;
    private bool unk3300PIEFLAEGGBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300PIEFLAEGGBI {
      get { return unk3300PIEFLAEGGBI_; }
      set {
        unk3300PIEFLAEGGBI_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BeginCameraSceneLookNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BeginCameraSceneLookNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration)) return false;
      if (EntityId != other.EntityId) return false;
      if (!object.Equals(FollowPos, other.FollowPos)) return false;
      if (KeepRotType != other.KeepRotType) return false;
      if (!object.Equals(LookPos, other.LookPos)) return false;
      if(!otherParams_.Equals(other.otherParams_)) return false;
      if (Unk3300AAOGBCCNJAF != other.Unk3300AAOGBCCNJAF) return false;
      if (Unk3300AJEENEOCFON != other.Unk3300AJEENEOCFON) return false;
      if (Unk3300DFPCMOFONNK != other.Unk3300DFPCMOFONNK) return false;
      if (Unk3300EELNOAICHOJ != other.Unk3300EELNOAICHOJ) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300FIOLGCIKFLH, other.Unk3300FIOLGCIKFLH)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300HCLPGGAOIAC, other.Unk3300HCLPGGAOIAC)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300HFPCHFNFJKP, other.Unk3300HFPCHFNFJKP)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Unk3300HKKCHCEMJIE, other.Unk3300HKKCHCEMJIE)) return false;
      if (Unk3300ILMHDLHLKGJ != other.Unk3300ILMHDLHLKGJ) return false;
      if (Unk3300KCHKKBODNCJ != other.Unk3300KCHKKBODNCJ) return false;
      if (Unk3300NJLBIMJDFHJ != other.Unk3300NJLBIMJDFHJ) return false;
      if (Unk3300ODADMBBFPAP != other.Unk3300ODADMBBFPAP) return false;
      if (Unk3300ONBDMCHFPDL != other.Unk3300ONBDMCHFPDL) return false;
      if (Unk3300PIEFLAEGGBI != other.Unk3300PIEFLAEGGBI) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Duration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (followPos_ != null) hash ^= FollowPos.GetHashCode();
      if (KeepRotType != global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType.X) hash ^= KeepRotType.GetHashCode();
      if (lookPos_ != null) hash ^= LookPos.GetHashCode();
      hash ^= otherParams_.GetHashCode();
      if (Unk3300AAOGBCCNJAF != false) hash ^= Unk3300AAOGBCCNJAF.GetHashCode();
      if (Unk3300AJEENEOCFON != 0) hash ^= Unk3300AJEENEOCFON.GetHashCode();
      if (Unk3300DFPCMOFONNK != false) hash ^= Unk3300DFPCMOFONNK.GetHashCode();
      if (Unk3300EELNOAICHOJ != false) hash ^= Unk3300EELNOAICHOJ.GetHashCode();
      if (Unk3300FIOLGCIKFLH != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300FIOLGCIKFLH);
      if (Unk3300HCLPGGAOIAC != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300HCLPGGAOIAC);
      if (Unk3300HFPCHFNFJKP != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300HFPCHFNFJKP);
      if (Unk3300HKKCHCEMJIE != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Unk3300HKKCHCEMJIE);
      if (Unk3300ILMHDLHLKGJ != false) hash ^= Unk3300ILMHDLHLKGJ.GetHashCode();
      if (Unk3300KCHKKBODNCJ != 0) hash ^= Unk3300KCHKKBODNCJ.GetHashCode();
      if (Unk3300NJLBIMJDFHJ != false) hash ^= Unk3300NJLBIMJDFHJ.GetHashCode();
      if (Unk3300ODADMBBFPAP != false) hash ^= Unk3300ODADMBBFPAP.GetHashCode();
      if (Unk3300ONBDMCHFPDL != false) hash ^= Unk3300ONBDMCHFPDL.GetHashCode();
      if (Unk3300PIEFLAEGGBI != false) hash ^= Unk3300PIEFLAEGGBI.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Unk3300ILMHDLHLKGJ != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300ILMHDLHLKGJ);
      }
      if (Duration != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Duration);
      }
      if (Unk3300NJLBIMJDFHJ != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300NJLBIMJDFHJ);
      }
      if (Unk3300EELNOAICHOJ != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300EELNOAICHOJ);
      }
      if (Unk3300ONBDMCHFPDL != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300ONBDMCHFPDL);
      }
      if (Unk3300PIEFLAEGGBI != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300PIEFLAEGGBI);
      }
      if (Unk3300ODADMBBFPAP != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk3300ODADMBBFPAP);
      }
      if (followPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FollowPos);
      }
      otherParams_.WriteTo(output, _repeated_otherParams_codec);
      if (Unk3300FIOLGCIKFLH != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(Unk3300FIOLGCIKFLH);
      }
      if (KeepRotType != global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        output.WriteRawTag(88);
        output.WriteEnum((int) KeepRotType);
      }
      if (Unk3300HCLPGGAOIAC != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Unk3300HCLPGGAOIAC);
      }
      if (lookPos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LookPos);
      }
      if (Unk3300HFPCHFNFJKP != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Unk3300HFPCHFNFJKP);
      }
      if (Unk3300DFPCMOFONNK != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300DFPCMOFONNK);
      }
      if (Unk3300AJEENEOCFON != 0) {
        output.WriteRawTag(168, 60);
        output.WriteUInt32(Unk3300AJEENEOCFON);
      }
      if (Unk3300AAOGBCCNJAF != false) {
        output.WriteRawTag(192, 76);
        output.WriteBool(Unk3300AAOGBCCNJAF);
      }
      if (EntityId != 0) {
        output.WriteRawTag(216, 87);
        output.WriteUInt32(EntityId);
      }
      if (Unk3300HKKCHCEMJIE != 0F) {
        output.WriteRawTag(165, 107);
        output.WriteFloat(Unk3300HKKCHCEMJIE);
      }
      if (Unk3300KCHKKBODNCJ != 0) {
        output.WriteRawTag(144, 109);
        output.WriteUInt32(Unk3300KCHKKBODNCJ);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Unk3300ILMHDLHLKGJ != false) {
        output.WriteRawTag(8);
        output.WriteBool(Unk3300ILMHDLHLKGJ);
      }
      if (Duration != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Duration);
      }
      if (Unk3300NJLBIMJDFHJ != false) {
        output.WriteRawTag(24);
        output.WriteBool(Unk3300NJLBIMJDFHJ);
      }
      if (Unk3300EELNOAICHOJ != false) {
        output.WriteRawTag(32);
        output.WriteBool(Unk3300EELNOAICHOJ);
      }
      if (Unk3300ONBDMCHFPDL != false) {
        output.WriteRawTag(40);
        output.WriteBool(Unk3300ONBDMCHFPDL);
      }
      if (Unk3300PIEFLAEGGBI != false) {
        output.WriteRawTag(48);
        output.WriteBool(Unk3300PIEFLAEGGBI);
      }
      if (Unk3300ODADMBBFPAP != false) {
        output.WriteRawTag(56);
        output.WriteBool(Unk3300ODADMBBFPAP);
      }
      if (followPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FollowPos);
      }
      otherParams_.WriteTo(ref output, _repeated_otherParams_codec);
      if (Unk3300FIOLGCIKFLH != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(Unk3300FIOLGCIKFLH);
      }
      if (KeepRotType != global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        output.WriteRawTag(88);
        output.WriteEnum((int) KeepRotType);
      }
      if (Unk3300HCLPGGAOIAC != 0F) {
        output.WriteRawTag(101);
        output.WriteFloat(Unk3300HCLPGGAOIAC);
      }
      if (lookPos_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(LookPos);
      }
      if (Unk3300HFPCHFNFJKP != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Unk3300HFPCHFNFJKP);
      }
      if (Unk3300DFPCMOFONNK != false) {
        output.WriteRawTag(120);
        output.WriteBool(Unk3300DFPCMOFONNK);
      }
      if (Unk3300AJEENEOCFON != 0) {
        output.WriteRawTag(168, 60);
        output.WriteUInt32(Unk3300AJEENEOCFON);
      }
      if (Unk3300AAOGBCCNJAF != false) {
        output.WriteRawTag(192, 76);
        output.WriteBool(Unk3300AAOGBCCNJAF);
      }
      if (EntityId != 0) {
        output.WriteRawTag(216, 87);
        output.WriteUInt32(EntityId);
      }
      if (Unk3300HKKCHCEMJIE != 0F) {
        output.WriteRawTag(165, 107);
        output.WriteFloat(Unk3300HKKCHCEMJIE);
      }
      if (Unk3300KCHKKBODNCJ != 0) {
        output.WriteRawTag(144, 109);
        output.WriteUInt32(Unk3300KCHKKBODNCJ);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Duration != 0F) {
        size += 1 + 4;
      }
      if (EntityId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (followPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FollowPos);
      }
      if (KeepRotType != global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeepRotType);
      }
      if (lookPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LookPos);
      }
      size += otherParams_.CalculateSize(_repeated_otherParams_codec);
      if (Unk3300AAOGBCCNJAF != false) {
        size += 2 + 1;
      }
      if (Unk3300AJEENEOCFON != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AJEENEOCFON);
      }
      if (Unk3300DFPCMOFONNK != false) {
        size += 1 + 1;
      }
      if (Unk3300EELNOAICHOJ != false) {
        size += 1 + 1;
      }
      if (Unk3300FIOLGCIKFLH != 0F) {
        size += 1 + 4;
      }
      if (Unk3300HCLPGGAOIAC != 0F) {
        size += 1 + 4;
      }
      if (Unk3300HFPCHFNFJKP != 0F) {
        size += 1 + 4;
      }
      if (Unk3300HKKCHCEMJIE != 0F) {
        size += 2 + 4;
      }
      if (Unk3300ILMHDLHLKGJ != false) {
        size += 1 + 1;
      }
      if (Unk3300KCHKKBODNCJ != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300KCHKKBODNCJ);
      }
      if (Unk3300NJLBIMJDFHJ != false) {
        size += 1 + 1;
      }
      if (Unk3300ODADMBBFPAP != false) {
        size += 1 + 1;
      }
      if (Unk3300ONBDMCHFPDL != false) {
        size += 1 + 1;
      }
      if (Unk3300PIEFLAEGGBI != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BeginCameraSceneLookNotify other) {
      if (other == null) {
        return;
      }
      if (other.Duration != 0F) {
        Duration = other.Duration;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.followPos_ != null) {
        if (followPos_ == null) {
          FollowPos = new global::MiHomo.Protos.Vector();
        }
        FollowPos.MergeFrom(other.FollowPos);
      }
      if (other.KeepRotType != global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        KeepRotType = other.KeepRotType;
      }
      if (other.lookPos_ != null) {
        if (lookPos_ == null) {
          LookPos = new global::MiHomo.Protos.Vector();
        }
        LookPos.MergeFrom(other.LookPos);
      }
      otherParams_.Add(other.otherParams_);
      if (other.Unk3300AAOGBCCNJAF != false) {
        Unk3300AAOGBCCNJAF = other.Unk3300AAOGBCCNJAF;
      }
      if (other.Unk3300AJEENEOCFON != 0) {
        Unk3300AJEENEOCFON = other.Unk3300AJEENEOCFON;
      }
      if (other.Unk3300DFPCMOFONNK != false) {
        Unk3300DFPCMOFONNK = other.Unk3300DFPCMOFONNK;
      }
      if (other.Unk3300EELNOAICHOJ != false) {
        Unk3300EELNOAICHOJ = other.Unk3300EELNOAICHOJ;
      }
      if (other.Unk3300FIOLGCIKFLH != 0F) {
        Unk3300FIOLGCIKFLH = other.Unk3300FIOLGCIKFLH;
      }
      if (other.Unk3300HCLPGGAOIAC != 0F) {
        Unk3300HCLPGGAOIAC = other.Unk3300HCLPGGAOIAC;
      }
      if (other.Unk3300HFPCHFNFJKP != 0F) {
        Unk3300HFPCHFNFJKP = other.Unk3300HFPCHFNFJKP;
      }
      if (other.Unk3300HKKCHCEMJIE != 0F) {
        Unk3300HKKCHCEMJIE = other.Unk3300HKKCHCEMJIE;
      }
      if (other.Unk3300ILMHDLHLKGJ != false) {
        Unk3300ILMHDLHLKGJ = other.Unk3300ILMHDLHLKGJ;
      }
      if (other.Unk3300KCHKKBODNCJ != 0) {
        Unk3300KCHKKBODNCJ = other.Unk3300KCHKKBODNCJ;
      }
      if (other.Unk3300NJLBIMJDFHJ != false) {
        Unk3300NJLBIMJDFHJ = other.Unk3300NJLBIMJDFHJ;
      }
      if (other.Unk3300ODADMBBFPAP != false) {
        Unk3300ODADMBBFPAP = other.Unk3300ODADMBBFPAP;
      }
      if (other.Unk3300ONBDMCHFPDL != false) {
        Unk3300ONBDMCHFPDL = other.Unk3300ONBDMCHFPDL;
      }
      if (other.Unk3300PIEFLAEGGBI != false) {
        Unk3300PIEFLAEGGBI = other.Unk3300PIEFLAEGGBI;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Unk3300ILMHDLHLKGJ = input.ReadBool();
            break;
          }
          case 21: {
            Duration = input.ReadFloat();
            break;
          }
          case 24: {
            Unk3300NJLBIMJDFHJ = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300EELNOAICHOJ = input.ReadBool();
            break;
          }
          case 40: {
            Unk3300ONBDMCHFPDL = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300PIEFLAEGGBI = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300ODADMBBFPAP = input.ReadBool();
            break;
          }
          case 66: {
            if (followPos_ == null) {
              FollowPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(FollowPos);
            break;
          }
          case 74: {
            otherParams_.AddEntriesFrom(input, _repeated_otherParams_codec);
            break;
          }
          case 85: {
            Unk3300FIOLGCIKFLH = input.ReadFloat();
            break;
          }
          case 88: {
            KeepRotType = (global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType) input.ReadEnum();
            break;
          }
          case 101: {
            Unk3300HCLPGGAOIAC = input.ReadFloat();
            break;
          }
          case 106: {
            if (lookPos_ == null) {
              LookPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(LookPos);
            break;
          }
          case 117: {
            Unk3300HFPCHFNFJKP = input.ReadFloat();
            break;
          }
          case 120: {
            Unk3300DFPCMOFONNK = input.ReadBool();
            break;
          }
          case 7720: {
            Unk3300AJEENEOCFON = input.ReadUInt32();
            break;
          }
          case 9792: {
            Unk3300AAOGBCCNJAF = input.ReadBool();
            break;
          }
          case 11224: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 13733: {
            Unk3300HKKCHCEMJIE = input.ReadFloat();
            break;
          }
          case 13968: {
            Unk3300KCHKKBODNCJ = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Unk3300ILMHDLHLKGJ = input.ReadBool();
            break;
          }
          case 21: {
            Duration = input.ReadFloat();
            break;
          }
          case 24: {
            Unk3300NJLBIMJDFHJ = input.ReadBool();
            break;
          }
          case 32: {
            Unk3300EELNOAICHOJ = input.ReadBool();
            break;
          }
          case 40: {
            Unk3300ONBDMCHFPDL = input.ReadBool();
            break;
          }
          case 48: {
            Unk3300PIEFLAEGGBI = input.ReadBool();
            break;
          }
          case 56: {
            Unk3300ODADMBBFPAP = input.ReadBool();
            break;
          }
          case 66: {
            if (followPos_ == null) {
              FollowPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(FollowPos);
            break;
          }
          case 74: {
            otherParams_.AddEntriesFrom(ref input, _repeated_otherParams_codec);
            break;
          }
          case 85: {
            Unk3300FIOLGCIKFLH = input.ReadFloat();
            break;
          }
          case 88: {
            KeepRotType = (global::MiHomo.Protos.BeginCameraSceneLookNotify.Types.KeepRotType) input.ReadEnum();
            break;
          }
          case 101: {
            Unk3300HCLPGGAOIAC = input.ReadFloat();
            break;
          }
          case 106: {
            if (lookPos_ == null) {
              LookPos = new global::MiHomo.Protos.Vector();
            }
            input.ReadMessage(LookPos);
            break;
          }
          case 117: {
            Unk3300HFPCHFNFJKP = input.ReadFloat();
            break;
          }
          case 120: {
            Unk3300DFPCMOFONNK = input.ReadBool();
            break;
          }
          case 7720: {
            Unk3300AJEENEOCFON = input.ReadUInt32();
            break;
          }
          case 9792: {
            Unk3300AAOGBCCNJAF = input.ReadBool();
            break;
          }
          case 11224: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 13733: {
            Unk3300HKKCHCEMJIE = input.ReadFloat();
            break;
          }
          case 13968: {
            Unk3300KCHKKBODNCJ = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BeginCameraSceneLookNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum KeepRotType {
        [pbr::OriginalName("KEEP_ROT_TYPE_X")] X = 0,
        [pbr::OriginalName("KEEP_ROT_TYPE_XY")] Xy = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
