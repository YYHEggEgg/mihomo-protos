// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WindFieldDungeonFailReason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from WindFieldDungeonFailReason.proto</summary>
  public static partial class WindFieldDungeonFailReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for WindFieldDungeonFailReason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WindFieldDungeonFailReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBXaW5kRmllbGREdW5nZW9uRmFpbFJlYXNvbi5wcm90bxINbWlIb21vLlBy",
            "b3RvcyreAQoaV2luZEZpZWxkRHVuZ2VvbkZhaWxSZWFzb24SIAocV0lORF9G",
            "SUVMRF9EVU5HRU9OX0ZBSUxfTk9ORRAAEiIKHldJTkRfRklFTERfRFVOR0VP",
            "Tl9GQUlMX0NBTkNFTBABEiMKH1dJTkRfRklFTERfRFVOR0VPTl9GQUlMX1RJ",
            "TUVPVVQQAhIqCiZXSU5EX0ZJRUxEX0RVTkdFT05fRkFJTF9BTExfQVZBVEFS",
            "X0RJRRADEikKJVdJTkRfRklFTERfRFVOR0VPTl9GQUlMX0xVQV9JTlRFUlJV",
            "UFQQBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MiHomo.Protos.WindFieldDungeonFailReason), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum WindFieldDungeonFailReason {
    [pbr::OriginalName("WIND_FIELD_DUNGEON_FAIL_NONE")] WindFieldDungeonFailNone = 0,
    [pbr::OriginalName("WIND_FIELD_DUNGEON_FAIL_CANCEL")] WindFieldDungeonFailCancel = 1,
    [pbr::OriginalName("WIND_FIELD_DUNGEON_FAIL_TIMEOUT")] WindFieldDungeonFailTimeout = 2,
    [pbr::OriginalName("WIND_FIELD_DUNGEON_FAIL_ALL_AVATAR_DIE")] WindFieldDungeonFailAllAvatarDie = 3,
    [pbr::OriginalName("WIND_FIELD_DUNGEON_FAIL_LUA_INTERRUPT")] WindFieldDungeonFailLuaInterrupt = 4,
  }

  #endregion

}

#endregion Designer generated code
