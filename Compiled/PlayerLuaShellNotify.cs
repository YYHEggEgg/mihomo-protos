// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PlayerLuaShellNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from PlayerLuaShellNotify.proto</summary>
  public static partial class PlayerLuaShellNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for PlayerLuaShellNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerLuaShellNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpQbGF5ZXJMdWFTaGVsbE5vdGlmeS5wcm90bxINbWlIb21vLlByb3RvcxoS",
            "THVhU2hlbGxUeXBlLnByb3RvIngKFFBsYXllckx1YVNoZWxsTm90aWZ5EgoK",
            "AmlkGAggASgNEhEKCWx1YV9zaGVsbBgEIAEoDBIvCgpzaGVsbF90eXBlGAEg",
            "ASgOMhsubWlIb21vLlByb3Rvcy5MdWFTaGVsbFR5cGUSEAoIdXNlX3R5cGUY",
            "AiABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.LuaShellTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.PlayerLuaShellNotify), global::MiHomo.Protos.PlayerLuaShellNotify.Parser, new[]{ "Id", "LuaShell", "ShellType", "UseType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PlayerLuaShellNotify : pb::IMessage<PlayerLuaShellNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PlayerLuaShellNotify> _parser = new pb::MessageParser<PlayerLuaShellNotify>(() => new PlayerLuaShellNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PlayerLuaShellNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.PlayerLuaShellNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLuaShellNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLuaShellNotify(PlayerLuaShellNotify other) : this() {
      id_ = other.id_;
      luaShell_ = other.luaShell_;
      shellType_ = other.shellType_;
      useType_ = other.useType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PlayerLuaShellNotify Clone() {
      return new PlayerLuaShellNotify(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 8;
    private uint id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "lua_shell" field.</summary>
    public const int LuaShellFieldNumber = 4;
    private pb::ByteString luaShell_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pb::ByteString LuaShell {
      get { return luaShell_; }
      set {
        luaShell_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shell_type" field.</summary>
    public const int ShellTypeFieldNumber = 1;
    private global::MiHomo.Protos.LuaShellType shellType_ = global::MiHomo.Protos.LuaShellType.LuashellNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.LuaShellType ShellType {
      get { return shellType_; }
      set {
        shellType_ = value;
      }
    }

    /// <summary>Field number for the "use_type" field.</summary>
    public const int UseTypeFieldNumber = 2;
    private uint useType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint UseType {
      get { return useType_; }
      set {
        useType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PlayerLuaShellNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PlayerLuaShellNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (LuaShell != other.LuaShell) return false;
      if (ShellType != other.ShellType) return false;
      if (UseType != other.UseType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (LuaShell.Length != 0) hash ^= LuaShell.GetHashCode();
      if (ShellType != global::MiHomo.Protos.LuaShellType.LuashellNone) hash ^= ShellType.GetHashCode();
      if (UseType != 0) hash ^= UseType.GetHashCode();
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
      if (ShellType != global::MiHomo.Protos.LuaShellType.LuashellNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ShellType);
      }
      if (UseType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UseType);
      }
      if (LuaShell.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(LuaShell);
      }
      if (Id != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Id);
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
      if (ShellType != global::MiHomo.Protos.LuaShellType.LuashellNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ShellType);
      }
      if (UseType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UseType);
      }
      if (LuaShell.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(LuaShell);
      }
      if (Id != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(Id);
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
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (LuaShell.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(LuaShell);
      }
      if (ShellType != global::MiHomo.Protos.LuaShellType.LuashellNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ShellType);
      }
      if (UseType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UseType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PlayerLuaShellNotify other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.LuaShell.Length != 0) {
        LuaShell = other.LuaShell;
      }
      if (other.ShellType != global::MiHomo.Protos.LuaShellType.LuashellNone) {
        ShellType = other.ShellType;
      }
      if (other.UseType != 0) {
        UseType = other.UseType;
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
            ShellType = (global::MiHomo.Protos.LuaShellType) input.ReadEnum();
            break;
          }
          case 16: {
            UseType = input.ReadUInt32();
            break;
          }
          case 34: {
            LuaShell = input.ReadBytes();
            break;
          }
          case 64: {
            Id = input.ReadUInt32();
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
            ShellType = (global::MiHomo.Protos.LuaShellType) input.ReadEnum();
            break;
          }
          case 16: {
            UseType = input.ReadUInt32();
            break;
          }
          case 34: {
            LuaShell = input.ReadBytes();
            break;
          }
          case 64: {
            Id = input.ReadUInt32();
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
