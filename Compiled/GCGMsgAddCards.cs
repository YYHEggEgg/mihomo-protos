// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGMsgAddCards.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from GCGMsgAddCards.proto</summary>
  public static partial class GCGMsgAddCardsReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGMsgAddCards.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGMsgAddCardsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRHQ0dNc2dBZGRDYXJkcy5wcm90bxINbWlIb21vLlByb3RvcxoPR0NHUmVh",
            "c29uLnByb3RvGhFHQ0dab25lVHlwZS5wcm90byKgAQoOR0NHTXNnQWRkQ2Fy",
            "ZHMSFgoOY2FyZF9ndWlkX2xpc3QYBCADKA0SFQoNY29udHJvbGxlcl9pZBgJ",
            "IAEoDRILCgNwb3MYDiABKA0SKAoGcmVhc29uGAcgASgOMhgubWlIb21vLlBy",
            "b3Rvcy5HQ0dSZWFzb24SKAoEem9uZRgFIAEoDjIaLm1pSG9tby5Qcm90b3Mu",
            "R0NHWm9uZVR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GCGReasonReflection.Descriptor, global::MiHomo.Protos.GCGZoneTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.GCGMsgAddCards), global::MiHomo.Protos.GCGMsgAddCards.Parser, new[]{ "CardGuidList", "ControllerId", "Pos", "Reason", "Zone" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGMsgAddCards : pb::IMessage<GCGMsgAddCards>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGMsgAddCards> _parser = new pb::MessageParser<GCGMsgAddCards>(() => new GCGMsgAddCards());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGMsgAddCards> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.GCGMsgAddCardsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddCards() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddCards(GCGMsgAddCards other) : this() {
      cardGuidList_ = other.cardGuidList_.Clone();
      controllerId_ = other.controllerId_;
      pos_ = other.pos_;
      reason_ = other.reason_;
      zone_ = other.zone_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGMsgAddCards Clone() {
      return new GCGMsgAddCards(this);
    }

    /// <summary>Field number for the "card_guid_list" field.</summary>
    public const int CardGuidListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_cardGuidList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> cardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CardGuidList {
      get { return cardGuidList_; }
    }

    /// <summary>Field number for the "controller_id" field.</summary>
    public const int ControllerIdFieldNumber = 9;
    private uint controllerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ControllerId {
      get { return controllerId_; }
      set {
        controllerId_ = value;
      }
    }

    /// <summary>Field number for the "pos" field.</summary>
    public const int PosFieldNumber = 14;
    private uint pos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Pos {
      get { return pos_; }
      set {
        pos_ = value;
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 7;
    private global::MiHomo.Protos.GCGReason reason_ = global::MiHomo.Protos.GCGReason.Default;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GCGReason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    /// <summary>Field number for the "zone" field.</summary>
    public const int ZoneFieldNumber = 5;
    private global::MiHomo.Protos.GCGZoneType zone_ = global::MiHomo.Protos.GCGZoneType.Invalid;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GCGZoneType Zone {
      get { return zone_; }
      set {
        zone_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGMsgAddCards);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGMsgAddCards other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!cardGuidList_.Equals(other.cardGuidList_)) return false;
      if (ControllerId != other.ControllerId) return false;
      if (Pos != other.Pos) return false;
      if (Reason != other.Reason) return false;
      if (Zone != other.Zone) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= cardGuidList_.GetHashCode();
      if (ControllerId != 0) hash ^= ControllerId.GetHashCode();
      if (Pos != 0) hash ^= Pos.GetHashCode();
      if (Reason != global::MiHomo.Protos.GCGReason.Default) hash ^= Reason.GetHashCode();
      if (Zone != global::MiHomo.Protos.GCGZoneType.Invalid) hash ^= Zone.GetHashCode();
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
      cardGuidList_.WriteTo(output, _repeated_cardGuidList_codec);
      if (Zone != global::MiHomo.Protos.GCGZoneType.Invalid) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Zone);
      }
      if (Reason != global::MiHomo.Protos.GCGReason.Default) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ControllerId);
      }
      if (Pos != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Pos);
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
      cardGuidList_.WriteTo(ref output, _repeated_cardGuidList_codec);
      if (Zone != global::MiHomo.Protos.GCGZoneType.Invalid) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Zone);
      }
      if (Reason != global::MiHomo.Protos.GCGReason.Default) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Reason);
      }
      if (ControllerId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ControllerId);
      }
      if (Pos != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Pos);
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
      size += cardGuidList_.CalculateSize(_repeated_cardGuidList_codec);
      if (ControllerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ControllerId);
      }
      if (Pos != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Pos);
      }
      if (Reason != global::MiHomo.Protos.GCGReason.Default) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (Zone != global::MiHomo.Protos.GCGZoneType.Invalid) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Zone);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGMsgAddCards other) {
      if (other == null) {
        return;
      }
      cardGuidList_.Add(other.cardGuidList_);
      if (other.ControllerId != 0) {
        ControllerId = other.ControllerId;
      }
      if (other.Pos != 0) {
        Pos = other.Pos;
      }
      if (other.Reason != global::MiHomo.Protos.GCGReason.Default) {
        Reason = other.Reason;
      }
      if (other.Zone != global::MiHomo.Protos.GCGZoneType.Invalid) {
        Zone = other.Zone;
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
          case 34:
          case 32: {
            cardGuidList_.AddEntriesFrom(input, _repeated_cardGuidList_codec);
            break;
          }
          case 40: {
            Zone = (global::MiHomo.Protos.GCGZoneType) input.ReadEnum();
            break;
          }
          case 56: {
            Reason = (global::MiHomo.Protos.GCGReason) input.ReadEnum();
            break;
          }
          case 72: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 112: {
            Pos = input.ReadUInt32();
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
          case 34:
          case 32: {
            cardGuidList_.AddEntriesFrom(ref input, _repeated_cardGuidList_codec);
            break;
          }
          case 40: {
            Zone = (global::MiHomo.Protos.GCGZoneType) input.ReadEnum();
            break;
          }
          case 56: {
            Reason = (global::MiHomo.Protos.GCGReason) input.ReadEnum();
            break;
          }
          case 72: {
            ControllerId = input.ReadUInt32();
            break;
          }
          case 112: {
            Pos = input.ReadUInt32();
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
