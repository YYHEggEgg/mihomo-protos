// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CreateGadgetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MiHomo.Protos {

  /// <summary>Holder for reflection information generated from CreateGadgetInfo.proto</summary>
  public static partial class CreateGadgetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CreateGadgetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CreateGadgetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDcmVhdGVHYWRnZXRJbmZvLnByb3RvEg1taUhvbW8uUHJvdG9zGhRHYWRn",
            "ZXRCb3JuVHlwZS5wcm90byK0AQoQQ3JlYXRlR2FkZ2V0SW5mbxIwCglib3Ju",
            "X3R5cGUYASABKA4yHS5taUhvbW8uUHJvdG9zLkdhZGdldEJvcm5UeXBlEjQK",
            "BWNoZXN0GAIgASgLMiUubWlIb21vLlByb3Rvcy5DcmVhdGVHYWRnZXRJbmZv",
            "LkNoZXN0GjgKBUNoZXN0EhUKDWNoZXN0X2Ryb3BfaWQYASABKA0SGAoQaXNf",
            "c2hvd19jdXRzY2VuZRgCIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MiHomo.Protos.GadgetBornTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CreateGadgetInfo), global::MiHomo.Protos.CreateGadgetInfo.Parser, new[]{ "BornType", "Chest" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::MiHomo.Protos.CreateGadgetInfo.Types.Chest), global::MiHomo.Protos.CreateGadgetInfo.Types.Chest.Parser, new[]{ "ChestDropId", "IsShowCutscene" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CreateGadgetInfo : pb::IMessage<CreateGadgetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateGadgetInfo> _parser = new pb::MessageParser<CreateGadgetInfo>(() => new CreateGadgetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateGadgetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::MiHomo.Protos.CreateGadgetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateGadgetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateGadgetInfo(CreateGadgetInfo other) : this() {
      bornType_ = other.bornType_;
      chest_ = other.chest_ != null ? other.chest_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateGadgetInfo Clone() {
      return new CreateGadgetInfo(this);
    }

    /// <summary>Field number for the "born_type" field.</summary>
    public const int BornTypeFieldNumber = 1;
    private global::MiHomo.Protos.GadgetBornType bornType_ = global::MiHomo.Protos.GadgetBornType.GadgetBornNone;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.GadgetBornType BornType {
      get { return bornType_; }
      set {
        bornType_ = value;
      }
    }

    /// <summary>Field number for the "chest" field.</summary>
    public const int ChestFieldNumber = 2;
    private global::MiHomo.Protos.CreateGadgetInfo.Types.Chest chest_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::MiHomo.Protos.CreateGadgetInfo.Types.Chest Chest {
      get { return chest_; }
      set {
        chest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateGadgetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateGadgetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BornType != other.BornType) return false;
      if (!object.Equals(Chest, other.Chest)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BornType != global::MiHomo.Protos.GadgetBornType.GadgetBornNone) hash ^= BornType.GetHashCode();
      if (chest_ != null) hash ^= Chest.GetHashCode();
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
      if (BornType != global::MiHomo.Protos.GadgetBornType.GadgetBornNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BornType);
      }
      if (chest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Chest);
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
      if (BornType != global::MiHomo.Protos.GadgetBornType.GadgetBornNone) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BornType);
      }
      if (chest_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Chest);
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
      if (BornType != global::MiHomo.Protos.GadgetBornType.GadgetBornNone) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BornType);
      }
      if (chest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Chest);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateGadgetInfo other) {
      if (other == null) {
        return;
      }
      if (other.BornType != global::MiHomo.Protos.GadgetBornType.GadgetBornNone) {
        BornType = other.BornType;
      }
      if (other.chest_ != null) {
        if (chest_ == null) {
          Chest = new global::MiHomo.Protos.CreateGadgetInfo.Types.Chest();
        }
        Chest.MergeFrom(other.Chest);
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
            BornType = (global::MiHomo.Protos.GadgetBornType) input.ReadEnum();
            break;
          }
          case 18: {
            if (chest_ == null) {
              Chest = new global::MiHomo.Protos.CreateGadgetInfo.Types.Chest();
            }
            input.ReadMessage(Chest);
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
            BornType = (global::MiHomo.Protos.GadgetBornType) input.ReadEnum();
            break;
          }
          case 18: {
            if (chest_ == null) {
              Chest = new global::MiHomo.Protos.CreateGadgetInfo.Types.Chest();
            }
            input.ReadMessage(Chest);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CreateGadgetInfo message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public sealed partial class Chest : pb::IMessage<Chest>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Chest> _parser = new pb::MessageParser<Chest>(() => new Chest());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Chest> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::MiHomo.Protos.CreateGadgetInfo.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Chest() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Chest(Chest other) : this() {
          chestDropId_ = other.chestDropId_;
          isShowCutscene_ = other.isShowCutscene_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Chest Clone() {
          return new Chest(this);
        }

        /// <summary>Field number for the "chest_drop_id" field.</summary>
        public const int ChestDropIdFieldNumber = 1;
        private uint chestDropId_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public uint ChestDropId {
          get { return chestDropId_; }
          set {
            chestDropId_ = value;
          }
        }

        /// <summary>Field number for the "is_show_cutscene" field.</summary>
        public const int IsShowCutsceneFieldNumber = 2;
        private bool isShowCutscene_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool IsShowCutscene {
          get { return isShowCutscene_; }
          set {
            isShowCutscene_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Chest);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Chest other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ChestDropId != other.ChestDropId) return false;
          if (IsShowCutscene != other.IsShowCutscene) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (ChestDropId != 0) hash ^= ChestDropId.GetHashCode();
          if (IsShowCutscene != false) hash ^= IsShowCutscene.GetHashCode();
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
          if (ChestDropId != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(ChestDropId);
          }
          if (IsShowCutscene != false) {
            output.WriteRawTag(16);
            output.WriteBool(IsShowCutscene);
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
          if (ChestDropId != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(ChestDropId);
          }
          if (IsShowCutscene != false) {
            output.WriteRawTag(16);
            output.WriteBool(IsShowCutscene);
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
          if (ChestDropId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChestDropId);
          }
          if (IsShowCutscene != false) {
            size += 1 + 1;
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Chest other) {
          if (other == null) {
            return;
          }
          if (other.ChestDropId != 0) {
            ChestDropId = other.ChestDropId;
          }
          if (other.IsShowCutscene != false) {
            IsShowCutscene = other.IsShowCutscene;
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
                ChestDropId = input.ReadUInt32();
                break;
              }
              case 16: {
                IsShowCutscene = input.ReadBool();
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
                ChestDropId = input.ReadUInt32();
                break;
              }
              case 16: {
                IsShowCutscene = input.ReadBool();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
