package org.wololo.flatgeobuf.generated;
// automatically generated by the FlatBuffers compiler, do not modify

@SuppressWarnings("unused")
public final class GeometryType {
  private GeometryType() { }
  public static final int Unknown = 0;
  public static final int Point = 1;
  public static final int LineString = 2;
  public static final int Polygon = 3;
  public static final int MultiPoint = 4;
  public static final int MultiLineString = 5;
  public static final int MultiPolygon = 6;
  public static final int GeometryCollection = 7;
  public static final int CircularString = 8;
  public static final int CompoundCurve = 9;
  public static final int CurvePolygon = 10;
  public static final int MultiCurve = 11;
  public static final int MultiSurface = 12;
  public static final int Curve = 13;
  public static final int Surface = 14;
  public static final int PolyhedralSurface = 15;
  public static final int TIN = 16;
  public static final int Triangle = 17;

  public static final String[] names = { "Unknown", "Point", "LineString", "Polygon", "MultiPoint", "MultiLineString", "MultiPolygon", "GeometryCollection", "CircularString", "CompoundCurve", "CurvePolygon", "MultiCurve", "MultiSurface", "Curve", "Surface", "PolyhedralSurface", "TIN", "Triangle", };

  public static String name(int e) { return names[e]; }
}