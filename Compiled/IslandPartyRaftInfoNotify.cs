// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: IslandPartyRaftInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from IslandPartyRaftInfoNotify.proto</summary>
  public static partial class IslandPartyRaftInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for IslandPartyRaftInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IslandPartyRaftInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Jc2xhbmRQYXJ0eVJhZnRJbmZvTm90aWZ5LnByb3RvEg1taUhvbW8uUHJv",
            "dG9zIqsBChlJc2xhbmRQYXJ0eVJhZnRJbmZvTm90aWZ5EgwKBGNvaW4YDyAB",
            "KA0SEQoJY29tcG9uZW50GA0gASgNEgwKBGZ1ZWwYAyABKA0SEAoIcG9pbnRf",
            "aWQYByABKA0iTQoFQ21kSWQSCAoETk9ORRAAEhMKD0VORVRfQ0hBTk5FTF9J",
            "RBAAEhQKEEVORVRfSVNfUkVMSUFCTEUQARILCgZDTURfSUQQvSsaAhABYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.IslandPartyRaftInfoNotify), global::MiHomo.Protos.IslandPartyRaftInfoNotify.Parser, new[]{ "Coin", "Component", "Fuel", "PointId" }, null, new[]{ typeof(global::MiHomo.Protos.IslandPartyRaftInfoNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IslandPartyRaftInfoNotify : pb::IMessage<IslandPartyRaftInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IslandPartyRaftInfoNotify> _parser = new pb::MessageParser<IslandPartyRaftInfoNotify>(() => new IslandPartyRaftInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<IslandPartyRaftInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.IslandPartyRaftInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IslandPartyRaftInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IslandPartyRaftInfoNotify(IslandPartyRaftInfoNotify other) : this() {
      coin_ = other.coin_;
      component_ = other.component_;
      fuel_ = other.fuel_;
      pointId_ = other.pointId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public IslandPartyRaftInfoNotify Clone() {
      return new IslandPartyRaftInfoNotify(this);
    }

    /// <summary>Field number for the "coin" field.</summary>
    public const int CoinFieldNumber = 15;
    private uint coin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Coin {
      get { return coin_; }
      set {
        coin_ = value;
      }
    }

    /// <summary>Field number for the "component" field.</summary>
    public const int ComponentFieldNumber = 13;
    private uint component_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Component {
      get { return component_; }
      set {
        component_ = value;
      }
    }

    /// <summary>Field number for the "fuel" field.</summary>
    public const int FuelFieldNumber = 3;
    private uint fuel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Fuel {
      get { return fuel_; }
      set {
        fuel_ = value;
      }
    }

    /// <summary>Field number for the "point_id" field.</summary>
    public const int PointIdFieldNumber = 7;
    private uint pointId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint PointId {
      get { return pointId_; }
      set {
        pointId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as IslandPartyRaftInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(IslandPartyRaftInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Coin != other.Coin) return false;
      if (Component != other.Component) return false;
      if (Fuel != other.Fuel) return false;
      if (PointId != other.PointId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Coin != 0) hash ^= Coin.GetHashCode();
      if (Component != 0) hash ^= Component.GetHashCode();
      if (Fuel != 0) hash ^= Fuel.GetHashCode();
      if (PointId != 0) hash ^= PointId.GetHashCode();
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
      if (Fuel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Fuel);
      }
      if (PointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PointId);
      }
      if (Component != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Component);
      }
      if (Coin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Coin);
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
      if (Fuel != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Fuel);
      }
      if (PointId != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(PointId);
      }
      if (Component != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(Component);
      }
      if (Coin != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(Coin);
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
      if (Coin != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Coin);
      }
      if (Component != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Component);
      }
      if (Fuel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Fuel);
      }
      if (PointId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PointId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(IslandPartyRaftInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.Coin != 0) {
        Coin = other.Coin;
      }
      if (other.Component != 0) {
        Component = other.Component;
      }
      if (other.Fuel != 0) {
        Fuel = other.Fuel;
      }
      if (other.PointId != 0) {
        PointId = other.PointId;
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
          case 24: {
            Fuel = input.ReadUInt32();
            break;
          }
          case 56: {
            PointId = input.ReadUInt32();
            break;
          }
          case 104: {
            Component = input.ReadUInt32();
            break;
          }
          case 120: {
            Coin = input.ReadUInt32();
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
          case 24: {
            Fuel = input.ReadUInt32();
            break;
          }
          case 56: {
            PointId = input.ReadUInt32();
            break;
          }
          case 104: {
            Component = input.ReadUInt32();
            break;
          }
          case 120: {
            Coin = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the IslandPartyRaftInfoNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 5565,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
