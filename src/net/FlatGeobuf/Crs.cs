// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace FlatGeobuf
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Crs : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_12_23(); }
  public static Crs GetRootAsCrs(ByteBuffer _bb) { return GetRootAsCrs(_bb, new Crs()); }
  public static Crs GetRootAsCrs(ByteBuffer _bb, Crs obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Crs __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Org { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetOrgBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetOrgBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetOrgArray() { return __p.__vector_as_array<byte>(4); }
  public int Code { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Name { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(8); }
  public string Description { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetDescriptionBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetDescriptionArray() { return __p.__vector_as_array<byte>(10); }
  public string Wkt { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetWktBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetWktBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetWktArray() { return __p.__vector_as_array<byte>(12); }
  public string CodeString { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCodeStringBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetCodeStringBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetCodeStringArray() { return __p.__vector_as_array<byte>(14); }

  public static Offset<FlatGeobuf.Crs> CreateCrs(FlatBufferBuilder builder,
      StringOffset orgOffset = default(StringOffset),
      int code = 0,
      StringOffset nameOffset = default(StringOffset),
      StringOffset descriptionOffset = default(StringOffset),
      StringOffset wktOffset = default(StringOffset),
      StringOffset code_stringOffset = default(StringOffset)) {
    builder.StartTable(6);
    Crs.AddCodeString(builder, code_stringOffset);
    Crs.AddWkt(builder, wktOffset);
    Crs.AddDescription(builder, descriptionOffset);
    Crs.AddName(builder, nameOffset);
    Crs.AddCode(builder, code);
    Crs.AddOrg(builder, orgOffset);
    return Crs.EndCrs(builder);
  }

  public static void StartCrs(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddOrg(FlatBufferBuilder builder, StringOffset orgOffset) { builder.AddOffset(0, orgOffset.Value, 0); }
  public static void AddCode(FlatBufferBuilder builder, int code) { builder.AddInt(1, code, 0); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(2, nameOffset.Value, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(3, descriptionOffset.Value, 0); }
  public static void AddWkt(FlatBufferBuilder builder, StringOffset wktOffset) { builder.AddOffset(4, wktOffset.Value, 0); }
  public static void AddCodeString(FlatBufferBuilder builder, StringOffset codeStringOffset) { builder.AddOffset(5, codeStringOffset.Value, 0); }
  public static Offset<FlatGeobuf.Crs> EndCrs(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<FlatGeobuf.Crs>(o);
  }
  public CrsT UnPack() {
    var _o = new CrsT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CrsT _o) {
    _o.Org = this.Org;
    _o.Code = this.Code;
    _o.Name = this.Name;
    _o.Description = this.Description;
    _o.Wkt = this.Wkt;
    _o.CodeString = this.CodeString;
  }
  public static Offset<FlatGeobuf.Crs> Pack(FlatBufferBuilder builder, CrsT _o) {
    if (_o == null) return default(Offset<FlatGeobuf.Crs>);
    var _org = _o.Org == null ? default(StringOffset) : builder.CreateString(_o.Org);
    var _name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _description = _o.Description == null ? default(StringOffset) : builder.CreateString(_o.Description);
    var _wkt = _o.Wkt == null ? default(StringOffset) : builder.CreateString(_o.Wkt);
    var _code_string = _o.CodeString == null ? default(StringOffset) : builder.CreateString(_o.CodeString);
    return CreateCrs(
      builder,
      _org,
      _o.Code,
      _name,
      _description,
      _wkt,
      _code_string);
  }
}

public class CrsT
{
  public string Org { get; set; }
  public int Code { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public string Wkt { get; set; }
  public string CodeString { get; set; }

  public CrsT() {
    this.Org = null;
    this.Code = 0;
    this.Name = null;
    this.Description = null;
    this.Wkt = null;
    this.CodeString = null;
  }
}


static public class CrsVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Org*/, false)
      && verifier.VerifyField(tablePos, 6 /*Code*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Name*/, false)
      && verifier.VerifyString(tablePos, 10 /*Description*/, false)
      && verifier.VerifyString(tablePos, 12 /*Wkt*/, false)
      && verifier.VerifyString(tablePos, 14 /*CodeString*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
