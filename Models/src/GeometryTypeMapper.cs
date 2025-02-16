namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {

    public class GeometryTypeMapper<TGeometry> : SqlMapper.TypeHandler<TGeometry>
        where TGeometry : NetTopologySuite.Geometries.Geometry
    {
        public override void SetValue(IDbDataParameter parameter, TGeometry? value) {
            throw new ArgumentException();
        }

        public override TGeometry? Parse(object value) {
            if (value is TGeometry geometry) {
                return geometry;
            }
            throw new ArgumentException();
        }
    }

    public class GeometryTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.Geometry>
    {
    }

    public class PointTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.Point>
    {
    }

    public class PolygonTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.Polygon>
    {
    }

    public class LineStringTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.LineString>
    {
    }

    public class GeometryCollectionTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.GeometryCollection>
    {
    }

    public class MultiPointTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.MultiPoint>
    {
    }

    public class MultiPolygonTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.MultiPolygon>
    {
    }

    public class MultiLineStringTypeMapper : GeometryTypeMapper<NetTopologySuite.Geometries.MultiLineString>
    {
    }
} // End Partial class
