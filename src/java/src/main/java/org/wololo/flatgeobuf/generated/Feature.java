package org.wololo.flatgeobuf.generated;
// automatically generated by the FlatBuffers compiler, do not modify

import com.google.flatbuffers.BaseVector;
import com.google.flatbuffers.BooleanVector;
import com.google.flatbuffers.ByteVector;
import com.google.flatbuffers.Constants;
import com.google.flatbuffers.DoubleVector;
import com.google.flatbuffers.FlatBufferBuilder;
import com.google.flatbuffers.FloatVector;
import com.google.flatbuffers.IntVector;
import com.google.flatbuffers.LongVector;
import com.google.flatbuffers.ShortVector;
import com.google.flatbuffers.StringVector;
import com.google.flatbuffers.Struct;
import com.google.flatbuffers.Table;
import com.google.flatbuffers.UnionVector;
import java.nio.ByteBuffer;
import java.nio.ByteOrder;

@SuppressWarnings("unused")
public final class Feature extends Table {
  public static void ValidateVersion() { Constants.FLATBUFFERS_24_12_23(); }
  public static Feature getRootAsFeature(ByteBuffer _bb) { return getRootAsFeature(_bb, new Feature()); }
  public static Feature getRootAsFeature(ByteBuffer _bb, Feature obj) { _bb.order(ByteOrder.LITTLE_ENDIAN); return (obj.__assign(_bb.getInt(_bb.position()) + _bb.position(), _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __reset(_i, _bb); }
  public Feature __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Geometry geometry() { return geometry(new Geometry()); }
  public Geometry geometry(Geometry obj) { int o = __offset(4); return o != 0 ? obj.__assign(__indirect(o + bb_pos), bb) : null; }
  public int properties(int j) { int o = __offset(6); return o != 0 ? bb.get(__vector(o) + j * 1) & 0xFF : 0; }
  public int propertiesLength() { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; }
  public ByteVector propertiesVector() { return propertiesVector(new ByteVector()); }
  public ByteVector propertiesVector(ByteVector obj) { int o = __offset(6); return o != 0 ? obj.__assign(__vector(o), bb) : null; }
  public ByteBuffer propertiesAsByteBuffer() { return __vector_as_bytebuffer(6, 1); }
  public ByteBuffer propertiesInByteBuffer(ByteBuffer _bb) { return __vector_in_bytebuffer(_bb, 6, 1); }
  public Column columns(int j) { return columns(new Column(), j); }
  public Column columns(Column obj, int j) { int o = __offset(8); return o != 0 ? obj.__assign(__indirect(__vector(o) + j * 4), bb) : null; }
  public int columnsLength() { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; }
  public Column.Vector columnsVector() { return columnsVector(new Column.Vector()); }
  public Column.Vector columnsVector(Column.Vector obj) { int o = __offset(8); return o != 0 ? obj.__assign(__vector(o), 4, bb) : null; }

  public static int createFeature(FlatBufferBuilder builder,
      int geometryOffset,
      int propertiesOffset,
      int columnsOffset) {
    builder.startTable(3);
    Feature.addColumns(builder, columnsOffset);
    Feature.addProperties(builder, propertiesOffset);
    Feature.addGeometry(builder, geometryOffset);
    return Feature.endFeature(builder);
  }

  public static void startFeature(FlatBufferBuilder builder) { builder.startTable(3); }
  public static void addGeometry(FlatBufferBuilder builder, int geometryOffset) { builder.addOffset(0, geometryOffset, 0); }
  public static void addProperties(FlatBufferBuilder builder, int propertiesOffset) { builder.addOffset(1, propertiesOffset, 0); }
  public static int createPropertiesVector(FlatBufferBuilder builder, byte[] data) { return builder.createByteVector(data); }
  public static int createPropertiesVector(FlatBufferBuilder builder, ByteBuffer data) { return builder.createByteVector(data); }
  public static void startPropertiesVector(FlatBufferBuilder builder, int numElems) { builder.startVector(1, numElems, 1); }
  public static void addColumns(FlatBufferBuilder builder, int columnsOffset) { builder.addOffset(2, columnsOffset, 0); }
  public static int createColumnsVector(FlatBufferBuilder builder, int[] data) { builder.startVector(4, data.length, 4); for (int i = data.length - 1; i >= 0; i--) builder.addOffset(data[i]); return builder.endVector(); }
  public static void startColumnsVector(FlatBufferBuilder builder, int numElems) { builder.startVector(4, numElems, 4); }
  public static int endFeature(FlatBufferBuilder builder) {
    int o = builder.endTable();
    return o;
  }
  public static void finishFeatureBuffer(FlatBufferBuilder builder, int offset) { builder.finish(offset); }
  public static void finishSizePrefixedFeatureBuffer(FlatBufferBuilder builder, int offset) { builder.finishSizePrefixed(offset); }

  public static final class Vector extends BaseVector {
    public Vector __assign(int _vector, int _element_size, ByteBuffer _bb) { __reset(_vector, _element_size, _bb); return this; }

    public Feature get(int j) { return get(new Feature(), j); }
    public Feature get(Feature obj, int j) {  return obj.__assign(__indirect(__element(j), bb), bb); }
  }
}