// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ToTheMoonRemoveObstacleRsp.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from ToTheMoonRemoveObstacleRsp.proto</summary>
  public static partial class ToTheMoonRemoveObstacleRspReflection {

    #region Descriptor
    /// <summary>File descriptor for ToTheMoonRemoveObstacleRsp.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ToTheMoonRemoveObstacleRspReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBUb1RoZU1vb25SZW1vdmVPYnN0YWNsZVJzcC5wcm90bxINbWlIb21vLlBy",
            "b3RvcxoSRHluYW1pY05vZGVzLnByb3RvInMKGlRvVGhlTW9vblJlbW92ZU9i",
            "c3RhY2xlUnNwEjIKDWR5bmFtaWNfbm9kZXMYDCABKAsyGy5taUhvbW8uUHJv",
            "dG9zLkR5bmFtaWNOb2RlcxIQCghxdWVyeV9pZBgFIAEoBRIPCgdyZXRjb2Rl",
            "GA4gASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.DynamicNodesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.ToTheMoonRemoveObstacleRsp), global::MiHomo.Protos.ToTheMoonRemoveObstacleRsp.Parser, new[]{ "DynamicNodes", "QueryId", "Retcode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ToTheMoonRemoveObstacleRsp : pb::IMessage<ToTheMoonRemoveObstacleRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ToTheMoonRemoveObstacleRsp> _parser = new pb::MessageParser<ToTheMoonRemoveObstacleRsp>(() => new ToTheMoonRemoveObstacleRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ToTheMoonRemoveObstacleRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.ToTheMoonRemoveObstacleRspReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonRemoveObstacleRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonRemoveObstacleRsp(ToTheMoonRemoveObstacleRsp other) : this() {
      dynamicNodes_ = other.dynamicNodes_ != null ? other.dynamicNodes_.Clone() : null;
      queryId_ = other.queryId_;
      retcode_ = other.retcode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ToTheMoonRemoveObstacleRsp Clone() {
      return new ToTheMoonRemoveObstacleRsp(this);
    }

    /// <summary>Field number for the "dynamic_nodes" field.</summary>
    public const int DynamicNodesFieldNumber = 12;
    private global::MiHomo.Protos.DynamicNodes dynamicNodes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.DynamicNodes DynamicNodes {
      get { return dynamicNodes_; }
      set {
        dynamicNodes_ = value;
      }
    }

    /// <summary>Field number for the "query_id" field.</summary>
    public const int QueryIdFieldNumber = 5;
    private int queryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int QueryId {
      get { return queryId_; }
      set {
        queryId_ = value;
      }
    }

    /// <summary>Field number for the "retcode" field.</summary>
    public const int RetcodeFieldNumber = 14;
    private int retcode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Retcode {
      get { return retcode_; }
      set {
        retcode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ToTheMoonRemoveObstacleRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ToTheMoonRemoveObstacleRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(DynamicNodes, other.DynamicNodes)) return false;
      if (QueryId != other.QueryId) return false;
      if (Retcode != other.Retcode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (dynamicNodes_ != null) hash ^= DynamicNodes.GetHashCode();
      if (QueryId != 0) hash ^= QueryId.GetHashCode();
      if (Retcode != 0) hash ^= Retcode.GetHashCode();
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
      if (QueryId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(QueryId);
      }
      if (dynamicNodes_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(DynamicNodes);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (QueryId != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(QueryId);
      }
      if (dynamicNodes_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(DynamicNodes);
      }
      if (Retcode != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(Retcode);
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
      if (dynamicNodes_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DynamicNodes);
      }
      if (QueryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(QueryId);
      }
      if (Retcode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Retcode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ToTheMoonRemoveObstacleRsp other) {
      if (other == null) {
        return;
      }
      if (other.dynamicNodes_ != null) {
        if (dynamicNodes_ == null) {
          DynamicNodes = new global::MiHomo.Protos.DynamicNodes();
        }
        DynamicNodes.MergeFrom(other.DynamicNodes);
      }
      if (other.QueryId != 0) {
        QueryId = other.QueryId;
      }
      if (other.Retcode != 0) {
        Retcode = other.Retcode;
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
          case 40: {
            QueryId = input.ReadInt32();
            break;
          }
          case 98: {
            if (dynamicNodes_ == null) {
              DynamicNodes = new global::MiHomo.Protos.DynamicNodes();
            }
            input.ReadMessage(DynamicNodes);
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
          case 40: {
            QueryId = input.ReadInt32();
            break;
          }
          case 98: {
            if (dynamicNodes_ == null) {
              DynamicNodes = new global::MiHomo.Protos.DynamicNodes();
            }
            input.ReadMessage(DynamicNodes);
            break;
          }
          case 112: {
            Retcode = input.ReadInt32();
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
