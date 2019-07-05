// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: rtsp_stream.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Rtspstream {

  /// <summary>Holder for reflection information generated from rtsp_stream.proto</summary>
  public static partial class RtspStreamReflection {

    #region Descriptor
    /// <summary>File descriptor for rtsp_stream.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RtspStreamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFydHNwX3N0cmVhbS5wcm90bxIKcnRzcHN0cmVhbSJUCglBdXRoVG9rZW4S",
            "DQoFdG9rZW4YASABKAkSDwoHY2hhbm5lbBgCIAEoBRISCgppbWFnZVdpZHRo",
            "GAMgASgFEhMKC2ltYWdlSGVpZ2h0GAQgASgFIh8KCUNoZWNrRGF0YRISCgpy",
            "ZWFkeUNoZWNrGAEgASgFIlAKClN0cmVhbURhdGESDQoFdG9rZW4YASABKAkS",
            "DwoHY2hhbm5lbBgCIAEoBRITCgtjYXJEZXRlY3RlZBgEIAEoBRINCgVpbWFn",
            "ZRgFIAEoDDKSAQoKUnRzcHN0cmVhbRI/CgxHZXRTdHJlYW1pbmcSFS5ydHNw",
            "c3RyZWFtLkF1dGhUb2tlbhoWLnJ0c3BzdHJlYW0uU3RyZWFtRGF0YSIAEkMK",
            "EUdldENoZWNrU3RyZWFtaW5nEhUucnRzcHN0cmVhbS5BdXRoVG9rZW4aFS5y",
            "dHNwc3RyZWFtLkNoZWNrRGF0YSIAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Rtspstream.AuthToken), global::Rtspstream.AuthToken.Parser, new[]{ "Token", "Channel", "ImageWidth", "ImageHeight" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rtspstream.CheckData), global::Rtspstream.CheckData.Parser, new[]{ "ReadyCheck" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Rtspstream.StreamData), global::Rtspstream.StreamData.Parser, new[]{ "Token", "Channel", "CarDetected", "Image" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AuthToken : pb::IMessage<AuthToken> {
    private static readonly pb::MessageParser<AuthToken> _parser = new pb::MessageParser<AuthToken>(() => new AuthToken());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AuthToken> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rtspstream.RtspStreamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthToken() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthToken(AuthToken other) : this() {
      token_ = other.token_;
      channel_ = other.channel_;
      imageWidth_ = other.imageWidth_;
      imageHeight_ = other.imageHeight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AuthToken Clone() {
      return new AuthToken(this);
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 1;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 2;
    private int channel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Channel {
      get { return channel_; }
      set {
        channel_ = value;
      }
    }

    /// <summary>Field number for the "imageWidth" field.</summary>
    public const int ImageWidthFieldNumber = 3;
    private int imageWidth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ImageWidth {
      get { return imageWidth_; }
      set {
        imageWidth_ = value;
      }
    }

    /// <summary>Field number for the "imageHeight" field.</summary>
    public const int ImageHeightFieldNumber = 4;
    private int imageHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ImageHeight {
      get { return imageHeight_; }
      set {
        imageHeight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AuthToken);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AuthToken other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Token != other.Token) return false;
      if (Channel != other.Channel) return false;
      if (ImageWidth != other.ImageWidth) return false;
      if (ImageHeight != other.ImageHeight) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (Channel != 0) hash ^= Channel.GetHashCode();
      if (ImageWidth != 0) hash ^= ImageWidth.GetHashCode();
      if (ImageHeight != 0) hash ^= ImageHeight.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (Channel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Channel);
      }
      if (ImageWidth != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ImageWidth);
      }
      if (ImageHeight != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ImageHeight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (Channel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Channel);
      }
      if (ImageWidth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ImageWidth);
      }
      if (ImageHeight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ImageHeight);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AuthToken other) {
      if (other == null) {
        return;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.Channel != 0) {
        Channel = other.Channel;
      }
      if (other.ImageWidth != 0) {
        ImageWidth = other.ImageWidth;
      }
      if (other.ImageHeight != 0) {
        ImageHeight = other.ImageHeight;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 16: {
            Channel = input.ReadInt32();
            break;
          }
          case 24: {
            ImageWidth = input.ReadInt32();
            break;
          }
          case 32: {
            ImageHeight = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CheckData : pb::IMessage<CheckData> {
    private static readonly pb::MessageParser<CheckData> _parser = new pb::MessageParser<CheckData>(() => new CheckData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rtspstream.RtspStreamReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckData(CheckData other) : this() {
      readyCheck_ = other.readyCheck_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckData Clone() {
      return new CheckData(this);
    }

    /// <summary>Field number for the "readyCheck" field.</summary>
    public const int ReadyCheckFieldNumber = 1;
    private int readyCheck_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ReadyCheck {
      get { return readyCheck_; }
      set {
        readyCheck_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ReadyCheck != other.ReadyCheck) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ReadyCheck != 0) hash ^= ReadyCheck.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ReadyCheck != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ReadyCheck);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ReadyCheck != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReadyCheck);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckData other) {
      if (other == null) {
        return;
      }
      if (other.ReadyCheck != 0) {
        ReadyCheck = other.ReadyCheck;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ReadyCheck = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class StreamData : pb::IMessage<StreamData> {
    private static readonly pb::MessageParser<StreamData> _parser = new pb::MessageParser<StreamData>(() => new StreamData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StreamData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Rtspstream.RtspStreamReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamData(StreamData other) : this() {
      token_ = other.token_;
      channel_ = other.channel_;
      carDetected_ = other.carDetected_;
      image_ = other.image_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StreamData Clone() {
      return new StreamData(this);
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 1;
    private string token_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Token {
      get { return token_; }
      set {
        token_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "channel" field.</summary>
    public const int ChannelFieldNumber = 2;
    private int channel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Channel {
      get { return channel_; }
      set {
        channel_ = value;
      }
    }

    /// <summary>Field number for the "carDetected" field.</summary>
    public const int CarDetectedFieldNumber = 4;
    private int carDetected_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CarDetected {
      get { return carDetected_; }
      set {
        carDetected_ = value;
      }
    }

    /// <summary>Field number for the "image" field.</summary>
    public const int ImageFieldNumber = 5;
    private pb::ByteString image_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Image {
      get { return image_; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StreamData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StreamData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Token != other.Token) return false;
      if (Channel != other.Channel) return false;
      if (CarDetected != other.CarDetected) return false;
      if (Image != other.Image) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Token.Length != 0) hash ^= Token.GetHashCode();
      if (Channel != 0) hash ^= Channel.GetHashCode();
      if (CarDetected != 0) hash ^= CarDetected.GetHashCode();
      if (Image.Length != 0) hash ^= Image.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Token.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Token);
      }
      if (Channel != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Channel);
      }
      if (CarDetected != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(CarDetected);
      }
      if (Image.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Image);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Token.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Token);
      }
      if (Channel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Channel);
      }
      if (CarDetected != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CarDetected);
      }
      if (Image.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Image);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StreamData other) {
      if (other == null) {
        return;
      }
      if (other.Token.Length != 0) {
        Token = other.Token;
      }
      if (other.Channel != 0) {
        Channel = other.Channel;
      }
      if (other.CarDetected != 0) {
        CarDetected = other.CarDetected;
      }
      if (other.Image.Length != 0) {
        Image = other.Image;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Token = input.ReadString();
            break;
          }
          case 16: {
            Channel = input.ReadInt32();
            break;
          }
          case 32: {
            CarDetected = input.ReadInt32();
            break;
          }
          case 42: {
            Image = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
