// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MusicGameSettleReq.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from MusicGameSettleReq.proto</summary>
  public static partial class MusicGameSettleReqReflection {

    #region Descriptor
    /// <summary>File descriptor for MusicGameSettleReq.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MusicGameSettleReqReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhNdXNpY0dhbWVTZXR0bGVSZXEucHJvdG8SDW1pSG9tby5Qcm90b3Mi0gMK",
            "Ek11c2ljR2FtZVNldHRsZVJlcRINCgVjb21ibxgEIAEoDRITCgtjb3JyZWN0",
            "X2hpdBgLIAEoDRIVCg1pc19zYXZlX3Njb3JlGAcgASgIEhEKCW1heF9jb21i",
            "bxgKIAEoDRIWCg5tdXNpY19iYXNpY19pZBgFIAEoDRINCgVzY29yZRgIIAEo",
            "DRIOCgVzcGVlZBiWBiABKAISEAoIdWdjX2d1aWQYAyABKAQSGwoTVW5rMzMw",
            "MF9BSEFHSEFIR1BMRBgMIAEoDRIcChNVbmszMzAwX0JISUdBTU5ERk1MGKMC",
            "IAEoCBIcChNVbmszMzAwX0RNTE5LT0xPQUFIGMAPIAEoCBIbChNVbmszMzAw",
            "X0VCT0pNR09DUExFGFIgASgNEhwKE1VuazMzMDBfR0pNSUlESU9PTU0Ynw8g",
            "ASgNEhsKE1VuazMzMDBfSEVQSk5DQU9FTVAYASABKA0SHAoTVW5rMzMwMF9I",
            "SEJDRVBOTENMTBjvByADKA0SHAoTVW5rMzMwMF9JUE9ES0VOQ0FPSxiwAiAB",
            "KA0SGwoTVW5rMzMwMF9NREhFSk5GSEJCSRgPIAEoDRIbChNVbmszMzAwX01M",
            "TERBUENJRERPGA4gAygNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.MusicGameSettleReq), global::MiHomo.Protos.MusicGameSettleReq.Parser, new[]{ "Combo", "CorrectHit", "IsSaveScore", "MaxCombo", "MusicBasicId", "Score", "Speed", "UgcGuid", "Unk3300AHAGHAHGPLD", "Unk3300BHIGAMNDFML", "Unk3300DMLNKOLOAAH", "Unk3300EBOJMGOCPLE", "Unk3300GJMIIDIOOMM", "Unk3300HEPJNCAOEMP", "Unk3300HHBCEPNLCLL", "Unk3300IPODKENCAOK", "Unk3300MDHEJNFHBBI", "Unk3300MLLDAPCIDDO" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MusicGameSettleReq : pb::IMessage<MusicGameSettleReq>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MusicGameSettleReq> _parser = new pb::MessageParser<MusicGameSettleReq>(() => new MusicGameSettleReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MusicGameSettleReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.MusicGameSettleReqReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleReq(MusicGameSettleReq other) : this() {
      combo_ = other.combo_;
      correctHit_ = other.correctHit_;
      isSaveScore_ = other.isSaveScore_;
      maxCombo_ = other.maxCombo_;
      musicBasicId_ = other.musicBasicId_;
      score_ = other.score_;
      speed_ = other.speed_;
      ugcGuid_ = other.ugcGuid_;
      unk3300AHAGHAHGPLD_ = other.unk3300AHAGHAHGPLD_;
      unk3300BHIGAMNDFML_ = other.unk3300BHIGAMNDFML_;
      unk3300DMLNKOLOAAH_ = other.unk3300DMLNKOLOAAH_;
      unk3300EBOJMGOCPLE_ = other.unk3300EBOJMGOCPLE_;
      unk3300GJMIIDIOOMM_ = other.unk3300GJMIIDIOOMM_;
      unk3300HEPJNCAOEMP_ = other.unk3300HEPJNCAOEMP_;
      unk3300HHBCEPNLCLL_ = other.unk3300HHBCEPNLCLL_.Clone();
      unk3300IPODKENCAOK_ = other.unk3300IPODKENCAOK_;
      unk3300MDHEJNFHBBI_ = other.unk3300MDHEJNFHBBI_;
      unk3300MLLDAPCIDDO_ = other.unk3300MLLDAPCIDDO_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MusicGameSettleReq Clone() {
      return new MusicGameSettleReq(this);
    }

    /// <summary>Field number for the "combo" field.</summary>
    public const int ComboFieldNumber = 4;
    private uint combo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Combo {
      get { return combo_; }
      set {
        combo_ = value;
      }
    }

    /// <summary>Field number for the "correct_hit" field.</summary>
    public const int CorrectHitFieldNumber = 11;
    private uint correctHit_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CorrectHit {
      get { return correctHit_; }
      set {
        correctHit_ = value;
      }
    }

    /// <summary>Field number for the "is_save_score" field.</summary>
    public const int IsSaveScoreFieldNumber = 7;
    private bool isSaveScore_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSaveScore {
      get { return isSaveScore_; }
      set {
        isSaveScore_ = value;
      }
    }

    /// <summary>Field number for the "max_combo" field.</summary>
    public const int MaxComboFieldNumber = 10;
    private uint maxCombo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MaxCombo {
      get { return maxCombo_; }
      set {
        maxCombo_ = value;
      }
    }

    /// <summary>Field number for the "music_basic_id" field.</summary>
    public const int MusicBasicIdFieldNumber = 5;
    private uint musicBasicId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MusicBasicId {
      get { return musicBasicId_; }
      set {
        musicBasicId_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 8;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 790;
    private float speed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "ugc_guid" field.</summary>
    public const int UgcGuidFieldNumber = 3;
    private ulong ugcGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UgcGuid {
      get { return ugcGuid_; }
      set {
        ugcGuid_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_AHAGHAHGPLD" field.</summary>
    public const int Unk3300AHAGHAHGPLDFieldNumber = 12;
    private uint unk3300AHAGHAHGPLD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300AHAGHAHGPLD {
      get { return unk3300AHAGHAHGPLD_; }
      set {
        unk3300AHAGHAHGPLD_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_BHIGAMNDFML" field.</summary>
    public const int Unk3300BHIGAMNDFMLFieldNumber = 291;
    private bool unk3300BHIGAMNDFML_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300BHIGAMNDFML {
      get { return unk3300BHIGAMNDFML_; }
      set {
        unk3300BHIGAMNDFML_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_DMLNKOLOAAH" field.</summary>
    public const int Unk3300DMLNKOLOAAHFieldNumber = 1984;
    private bool unk3300DMLNKOLOAAH_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Unk3300DMLNKOLOAAH {
      get { return unk3300DMLNKOLOAAH_; }
      set {
        unk3300DMLNKOLOAAH_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_EBOJMGOCPLE" field.</summary>
    public const int Unk3300EBOJMGOCPLEFieldNumber = 82;
    private uint unk3300EBOJMGOCPLE_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300EBOJMGOCPLE {
      get { return unk3300EBOJMGOCPLE_; }
      set {
        unk3300EBOJMGOCPLE_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_GJMIIDIOOMM" field.</summary>
    public const int Unk3300GJMIIDIOOMMFieldNumber = 1951;
    private uint unk3300GJMIIDIOOMM_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300GJMIIDIOOMM {
      get { return unk3300GJMIIDIOOMM_; }
      set {
        unk3300GJMIIDIOOMM_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HEPJNCAOEMP" field.</summary>
    public const int Unk3300HEPJNCAOEMPFieldNumber = 1;
    private uint unk3300HEPJNCAOEMP_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300HEPJNCAOEMP {
      get { return unk3300HEPJNCAOEMP_; }
      set {
        unk3300HEPJNCAOEMP_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_HHBCEPNLCLL" field.</summary>
    public const int Unk3300HHBCEPNLCLLFieldNumber = 1007;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300HHBCEPNLCLL_codec
        = pb::FieldCodec.ForUInt32(8058);
    private readonly pbc::RepeatedField<uint> unk3300HHBCEPNLCLL_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300HHBCEPNLCLL {
      get { return unk3300HHBCEPNLCLL_; }
    }

    /// <summary>Field number for the "Unk3300_IPODKENCAOK" field.</summary>
    public const int Unk3300IPODKENCAOKFieldNumber = 304;
    private uint unk3300IPODKENCAOK_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300IPODKENCAOK {
      get { return unk3300IPODKENCAOK_; }
      set {
        unk3300IPODKENCAOK_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MDHEJNFHBBI" field.</summary>
    public const int Unk3300MDHEJNFHBBIFieldNumber = 15;
    private uint unk3300MDHEJNFHBBI_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Unk3300MDHEJNFHBBI {
      get { return unk3300MDHEJNFHBBI_; }
      set {
        unk3300MDHEJNFHBBI_ = value;
      }
    }

    /// <summary>Field number for the "Unk3300_MLLDAPCIDDO" field.</summary>
    public const int Unk3300MLLDAPCIDDOFieldNumber = 14;
    private static readonly pb::FieldCodec<uint> _repeated_unk3300MLLDAPCIDDO_codec
        = pb::FieldCodec.ForUInt32(114);
    private readonly pbc::RepeatedField<uint> unk3300MLLDAPCIDDO_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> Unk3300MLLDAPCIDDO {
      get { return unk3300MLLDAPCIDDO_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MusicGameSettleReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MusicGameSettleReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Combo != other.Combo) return false;
      if (CorrectHit != other.CorrectHit) return false;
      if (IsSaveScore != other.IsSaveScore) return false;
      if (MaxCombo != other.MaxCombo) return false;
      if (MusicBasicId != other.MusicBasicId) return false;
      if (Score != other.Score) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      if (UgcGuid != other.UgcGuid) return false;
      if (Unk3300AHAGHAHGPLD != other.Unk3300AHAGHAHGPLD) return false;
      if (Unk3300BHIGAMNDFML != other.Unk3300BHIGAMNDFML) return false;
      if (Unk3300DMLNKOLOAAH != other.Unk3300DMLNKOLOAAH) return false;
      if (Unk3300EBOJMGOCPLE != other.Unk3300EBOJMGOCPLE) return false;
      if (Unk3300GJMIIDIOOMM != other.Unk3300GJMIIDIOOMM) return false;
      if (Unk3300HEPJNCAOEMP != other.Unk3300HEPJNCAOEMP) return false;
      if(!unk3300HHBCEPNLCLL_.Equals(other.unk3300HHBCEPNLCLL_)) return false;
      if (Unk3300IPODKENCAOK != other.Unk3300IPODKENCAOK) return false;
      if (Unk3300MDHEJNFHBBI != other.Unk3300MDHEJNFHBBI) return false;
      if(!unk3300MLLDAPCIDDO_.Equals(other.unk3300MLLDAPCIDDO_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Combo != 0) hash ^= Combo.GetHashCode();
      if (CorrectHit != 0) hash ^= CorrectHit.GetHashCode();
      if (IsSaveScore != false) hash ^= IsSaveScore.GetHashCode();
      if (MaxCombo != 0) hash ^= MaxCombo.GetHashCode();
      if (MusicBasicId != 0) hash ^= MusicBasicId.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
      if (UgcGuid != 0UL) hash ^= UgcGuid.GetHashCode();
      if (Unk3300AHAGHAHGPLD != 0) hash ^= Unk3300AHAGHAHGPLD.GetHashCode();
      if (Unk3300BHIGAMNDFML != false) hash ^= Unk3300BHIGAMNDFML.GetHashCode();
      if (Unk3300DMLNKOLOAAH != false) hash ^= Unk3300DMLNKOLOAAH.GetHashCode();
      if (Unk3300EBOJMGOCPLE != 0) hash ^= Unk3300EBOJMGOCPLE.GetHashCode();
      if (Unk3300GJMIIDIOOMM != 0) hash ^= Unk3300GJMIIDIOOMM.GetHashCode();
      if (Unk3300HEPJNCAOEMP != 0) hash ^= Unk3300HEPJNCAOEMP.GetHashCode();
      hash ^= unk3300HHBCEPNLCLL_.GetHashCode();
      if (Unk3300IPODKENCAOK != 0) hash ^= Unk3300IPODKENCAOK.GetHashCode();
      if (Unk3300MDHEJNFHBBI != 0) hash ^= Unk3300MDHEJNFHBBI.GetHashCode();
      hash ^= unk3300MLLDAPCIDDO_.GetHashCode();
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
      if (Unk3300HEPJNCAOEMP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300HEPJNCAOEMP);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(UgcGuid);
      }
      if (Combo != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Combo);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MusicBasicId);
      }
      if (IsSaveScore != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSaveScore);
      }
      if (Score != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Score);
      }
      if (MaxCombo != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxCombo);
      }
      if (CorrectHit != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CorrectHit);
      }
      if (Unk3300AHAGHAHGPLD != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300AHAGHAHGPLD);
      }
      unk3300MLLDAPCIDDO_.WriteTo(output, _repeated_unk3300MLLDAPCIDDO_codec);
      if (Unk3300MDHEJNFHBBI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300MDHEJNFHBBI);
      }
      if (Unk3300EBOJMGOCPLE != 0) {
        output.WriteRawTag(144, 5);
        output.WriteUInt32(Unk3300EBOJMGOCPLE);
      }
      if (Unk3300BHIGAMNDFML != false) {
        output.WriteRawTag(152, 18);
        output.WriteBool(Unk3300BHIGAMNDFML);
      }
      if (Unk3300IPODKENCAOK != 0) {
        output.WriteRawTag(128, 19);
        output.WriteUInt32(Unk3300IPODKENCAOK);
      }
      if (Speed != 0F) {
        output.WriteRawTag(181, 49);
        output.WriteFloat(Speed);
      }
      unk3300HHBCEPNLCLL_.WriteTo(output, _repeated_unk3300HHBCEPNLCLL_codec);
      if (Unk3300GJMIIDIOOMM != 0) {
        output.WriteRawTag(248, 121);
        output.WriteUInt32(Unk3300GJMIIDIOOMM);
      }
      if (Unk3300DMLNKOLOAAH != false) {
        output.WriteRawTag(128, 124);
        output.WriteBool(Unk3300DMLNKOLOAAH);
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
      if (Unk3300HEPJNCAOEMP != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Unk3300HEPJNCAOEMP);
      }
      if (UgcGuid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(UgcGuid);
      }
      if (Combo != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Combo);
      }
      if (MusicBasicId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(MusicBasicId);
      }
      if (IsSaveScore != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSaveScore);
      }
      if (Score != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Score);
      }
      if (MaxCombo != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(MaxCombo);
      }
      if (CorrectHit != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(CorrectHit);
      }
      if (Unk3300AHAGHAHGPLD != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(Unk3300AHAGHAHGPLD);
      }
      unk3300MLLDAPCIDDO_.WriteTo(ref output, _repeated_unk3300MLLDAPCIDDO_codec);
      if (Unk3300MDHEJNFHBBI != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Unk3300MDHEJNFHBBI);
      }
      if (Unk3300EBOJMGOCPLE != 0) {
        output.WriteRawTag(144, 5);
        output.WriteUInt32(Unk3300EBOJMGOCPLE);
      }
      if (Unk3300BHIGAMNDFML != false) {
        output.WriteRawTag(152, 18);
        output.WriteBool(Unk3300BHIGAMNDFML);
      }
      if (Unk3300IPODKENCAOK != 0) {
        output.WriteRawTag(128, 19);
        output.WriteUInt32(Unk3300IPODKENCAOK);
      }
      if (Speed != 0F) {
        output.WriteRawTag(181, 49);
        output.WriteFloat(Speed);
      }
      unk3300HHBCEPNLCLL_.WriteTo(ref output, _repeated_unk3300HHBCEPNLCLL_codec);
      if (Unk3300GJMIIDIOOMM != 0) {
        output.WriteRawTag(248, 121);
        output.WriteUInt32(Unk3300GJMIIDIOOMM);
      }
      if (Unk3300DMLNKOLOAAH != false) {
        output.WriteRawTag(128, 124);
        output.WriteBool(Unk3300DMLNKOLOAAH);
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
      if (Combo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Combo);
      }
      if (CorrectHit != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CorrectHit);
      }
      if (IsSaveScore != false) {
        size += 1 + 1;
      }
      if (MaxCombo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MaxCombo);
      }
      if (MusicBasicId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MusicBasicId);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (Speed != 0F) {
        size += 2 + 4;
      }
      if (UgcGuid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UgcGuid);
      }
      if (Unk3300AHAGHAHGPLD != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300AHAGHAHGPLD);
      }
      if (Unk3300BHIGAMNDFML != false) {
        size += 2 + 1;
      }
      if (Unk3300DMLNKOLOAAH != false) {
        size += 2 + 1;
      }
      if (Unk3300EBOJMGOCPLE != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300EBOJMGOCPLE);
      }
      if (Unk3300GJMIIDIOOMM != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300GJMIIDIOOMM);
      }
      if (Unk3300HEPJNCAOEMP != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300HEPJNCAOEMP);
      }
      size += unk3300HHBCEPNLCLL_.CalculateSize(_repeated_unk3300HHBCEPNLCLL_codec);
      if (Unk3300IPODKENCAOK != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300IPODKENCAOK);
      }
      if (Unk3300MDHEJNFHBBI != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unk3300MDHEJNFHBBI);
      }
      size += unk3300MLLDAPCIDDO_.CalculateSize(_repeated_unk3300MLLDAPCIDDO_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MusicGameSettleReq other) {
      if (other == null) {
        return;
      }
      if (other.Combo != 0) {
        Combo = other.Combo;
      }
      if (other.CorrectHit != 0) {
        CorrectHit = other.CorrectHit;
      }
      if (other.IsSaveScore != false) {
        IsSaveScore = other.IsSaveScore;
      }
      if (other.MaxCombo != 0) {
        MaxCombo = other.MaxCombo;
      }
      if (other.MusicBasicId != 0) {
        MusicBasicId = other.MusicBasicId;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.Speed != 0F) {
        Speed = other.Speed;
      }
      if (other.UgcGuid != 0UL) {
        UgcGuid = other.UgcGuid;
      }
      if (other.Unk3300AHAGHAHGPLD != 0) {
        Unk3300AHAGHAHGPLD = other.Unk3300AHAGHAHGPLD;
      }
      if (other.Unk3300BHIGAMNDFML != false) {
        Unk3300BHIGAMNDFML = other.Unk3300BHIGAMNDFML;
      }
      if (other.Unk3300DMLNKOLOAAH != false) {
        Unk3300DMLNKOLOAAH = other.Unk3300DMLNKOLOAAH;
      }
      if (other.Unk3300EBOJMGOCPLE != 0) {
        Unk3300EBOJMGOCPLE = other.Unk3300EBOJMGOCPLE;
      }
      if (other.Unk3300GJMIIDIOOMM != 0) {
        Unk3300GJMIIDIOOMM = other.Unk3300GJMIIDIOOMM;
      }
      if (other.Unk3300HEPJNCAOEMP != 0) {
        Unk3300HEPJNCAOEMP = other.Unk3300HEPJNCAOEMP;
      }
      unk3300HHBCEPNLCLL_.Add(other.unk3300HHBCEPNLCLL_);
      if (other.Unk3300IPODKENCAOK != 0) {
        Unk3300IPODKENCAOK = other.Unk3300IPODKENCAOK;
      }
      if (other.Unk3300MDHEJNFHBBI != 0) {
        Unk3300MDHEJNFHBBI = other.Unk3300MDHEJNFHBBI;
      }
      unk3300MLLDAPCIDDO_.Add(other.unk3300MLLDAPCIDDO_);
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
            Unk3300HEPJNCAOEMP = input.ReadUInt32();
            break;
          }
          case 24: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 32: {
            Combo = input.ReadUInt32();
            break;
          }
          case 40: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSaveScore = input.ReadBool();
            break;
          }
          case 64: {
            Score = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 88: {
            CorrectHit = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300AHAGHAHGPLD = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            unk3300MLLDAPCIDDO_.AddEntriesFrom(input, _repeated_unk3300MLLDAPCIDDO_codec);
            break;
          }
          case 120: {
            Unk3300MDHEJNFHBBI = input.ReadUInt32();
            break;
          }
          case 656: {
            Unk3300EBOJMGOCPLE = input.ReadUInt32();
            break;
          }
          case 2328: {
            Unk3300BHIGAMNDFML = input.ReadBool();
            break;
          }
          case 2432: {
            Unk3300IPODKENCAOK = input.ReadUInt32();
            break;
          }
          case 6325: {
            Speed = input.ReadFloat();
            break;
          }
          case 8058:
          case 8056: {
            unk3300HHBCEPNLCLL_.AddEntriesFrom(input, _repeated_unk3300HHBCEPNLCLL_codec);
            break;
          }
          case 15608: {
            Unk3300GJMIIDIOOMM = input.ReadUInt32();
            break;
          }
          case 15872: {
            Unk3300DMLNKOLOAAH = input.ReadBool();
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
            Unk3300HEPJNCAOEMP = input.ReadUInt32();
            break;
          }
          case 24: {
            UgcGuid = input.ReadUInt64();
            break;
          }
          case 32: {
            Combo = input.ReadUInt32();
            break;
          }
          case 40: {
            MusicBasicId = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSaveScore = input.ReadBool();
            break;
          }
          case 64: {
            Score = input.ReadUInt32();
            break;
          }
          case 80: {
            MaxCombo = input.ReadUInt32();
            break;
          }
          case 88: {
            CorrectHit = input.ReadUInt32();
            break;
          }
          case 96: {
            Unk3300AHAGHAHGPLD = input.ReadUInt32();
            break;
          }
          case 114:
          case 112: {
            unk3300MLLDAPCIDDO_.AddEntriesFrom(ref input, _repeated_unk3300MLLDAPCIDDO_codec);
            break;
          }
          case 120: {
            Unk3300MDHEJNFHBBI = input.ReadUInt32();
            break;
          }
          case 656: {
            Unk3300EBOJMGOCPLE = input.ReadUInt32();
            break;
          }
          case 2328: {
            Unk3300BHIGAMNDFML = input.ReadBool();
            break;
          }
          case 2432: {
            Unk3300IPODKENCAOK = input.ReadUInt32();
            break;
          }
          case 6325: {
            Speed = input.ReadFloat();
            break;
          }
          case 8058:
          case 8056: {
            unk3300HHBCEPNLCLL_.AddEntriesFrom(ref input, _repeated_unk3300HHBCEPNLCLL_codec);
            break;
          }
          case 15608: {
            Unk3300GJMIIDIOOMM = input.ReadUInt32();
            break;
          }
          case 15872: {
            Unk3300DMLNKOLOAAH = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
