// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HomeLimitedShopInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from HomeLimitedShopInfoNotify.proto</summary>
  public static partial class HomeLimitedShopInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for HomeLimitedShopInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HomeLimitedShopInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Ib21lTGltaXRlZFNob3BJbmZvTm90aWZ5LnByb3RvEg1taUhvbW8uUHJv",
            "dG9zGhlIb21lTGltaXRlZFNob3BJbmZvLnByb3RvIrYBChlIb21lTGltaXRl",
            "ZFNob3BJbmZvTm90aWZ5EjUKCXNob3BfaW5mbxgCIAEoCzIiLm1pSG9tby5Q",
            "cm90b3MuSG9tZUxpbWl0ZWRTaG9wSW5mbyJiCgVDbWRJZBIICgROT05FEAAS",
            "EwoPRU5FVF9DSEFOTkVMX0lEEAASFAoQRU5FVF9JU19SRUxJQUJMRRABEhMK",
            "D0lTX0FMTE9XX0NMSUVOVBABEgsKBkNNRF9JRBCXJhoCEAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.HomeLimitedShopInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.HomeLimitedShopInfoNotify), global::MiHomo.Protos.HomeLimitedShopInfoNotify.Parser, new[]{ "ShopInfo" }, null, new[]{ typeof(global::MiHomo.Protos.HomeLimitedShopInfoNotify.Types.CmdId) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HomeLimitedShopInfoNotify : pb::IMessage<HomeLimitedShopInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HomeLimitedShopInfoNotify> _parser = new pb::MessageParser<HomeLimitedShopInfoNotify>(() => new HomeLimitedShopInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HomeLimitedShopInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.HomeLimitedShopInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfoNotify(HomeLimitedShopInfoNotify other) : this() {
      shopInfo_ = other.shopInfo_ != null ? other.shopInfo_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HomeLimitedShopInfoNotify Clone() {
      return new HomeLimitedShopInfoNotify(this);
    }

    /// <summary>Field number for the "shop_info" field.</summary>
    public const int ShopInfoFieldNumber = 2;
    private global::MiHomo.Protos.HomeLimitedShopInfo shopInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.HomeLimitedShopInfo ShopInfo {
      get { return shopInfo_; }
      set {
        shopInfo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HomeLimitedShopInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HomeLimitedShopInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ShopInfo, other.ShopInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (shopInfo_ != null) hash ^= ShopInfo.GetHashCode();
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
      if (shopInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ShopInfo);
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
      if (shopInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ShopInfo);
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
      if (shopInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShopInfo);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HomeLimitedShopInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.shopInfo_ != null) {
        if (shopInfo_ == null) {
          ShopInfo = new global::MiHomo.Protos.HomeLimitedShopInfo();
        }
        ShopInfo.MergeFrom(other.ShopInfo);
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
          case 18: {
            if (shopInfo_ == null) {
              ShopInfo = new global::MiHomo.Protos.HomeLimitedShopInfo();
            }
            input.ReadMessage(ShopInfo);
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
          case 18: {
            if (shopInfo_ == null) {
              ShopInfo = new global::MiHomo.Protos.HomeLimitedShopInfo();
            }
            input.ReadMessage(ShopInfo);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the HomeLimitedShopInfoNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum CmdId {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("ENET_CHANNEL_ID", PreferredAlias = false)] EnetChannelId = 0,
        [pbr::OriginalName("ENET_IS_RELIABLE")] EnetIsReliable = 1,
        [pbr::OriginalName("IS_ALLOW_CLIENT", PreferredAlias = false)] IsAllowClient = 1,
        [pbr::OriginalName("CMD_ID")] CmdId = 4887,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
