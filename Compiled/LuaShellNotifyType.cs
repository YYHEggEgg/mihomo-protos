// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LuaShellNotifyType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from LuaShellNotifyType.proto</summary>
  public static partial class LuaShellNotifyTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for LuaShellNotifyType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LuaShellNotifyTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhMdWFTaGVsbE5vdGlmeVR5cGUucHJvdG8SDW1pSG9tby5Qcm90b3MqaAoS",
            "THVhU2hlbGxOb3RpZnlUeXBlEikKJUxVQV9TSEVMTF9OT1RJRllfVFlQRV9M",
            "VUFTSEVMTF9OT1RJRlkQABInCiNMVUFfU0hFTExfTk9USUZZX1RZUEVfTFVB",
            "U0hFTExfSElERRABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.LuaShellNotifyType), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum LuaShellNotifyType {
    [pbr::OriginalName("LUA_SHELL_NOTIFY_TYPE_LUASHELL_NOTIFY")] LuashellNotify = 0,
    [pbr::OriginalName("LUA_SHELL_NOTIFY_TYPE_LUASHELL_HIDE")] LuashellHide = 1,
  }

  #endregion

}

#endregion Designer generated code
