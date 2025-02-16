namespace ASPNETMaker2024.Models;

// Partial class
public partial class UAMS_20250216_1835 {

    public class DateTimeOffsetTypeMapper : SqlMapper.TypeHandler<DateTimeOffset> {

        public override void SetValue(IDbDataParameter parameter, DateTimeOffset value) {
            if (parameter is SqlParameter sqlParameter) {
                sqlParameter.SqlDbType = SqlDbType.DateTimeOffset;
                sqlParameter.SqlValue = value;
                return;
            }
        }

        public override DateTimeOffset Parse(object value) {
            if (value is null || value is DBNull)
                return DateTimeOffset.MinValue;
            return (DateTimeOffset)value;
        }
    }

    public class NullableDateTimeOffsetTypeMapper : SqlMapper.TypeHandler<DateTimeOffset?> {

        public override void SetValue(IDbDataParameter parameter, DateTimeOffset? value) {
            if (parameter is SqlParameter sqlParameter) {
                sqlParameter.SqlDbType = SqlDbType.DateTimeOffset;
                sqlParameter.IsNullable = true;
                sqlParameter.SqlValue = value;
                return;
            }
        }

        public override DateTimeOffset? Parse(object value) {
            if (value is null || value is DBNull)
                return null;
            return (DateTimeOffset)value;
        }
    }

    public class SqlHierarchyIdTypeMapper : SqlMapper.TypeHandler<SqlHierarchyId>
    {
        /// <summary>
        /// Assign the value of a parameter before a command executes
        /// </summary>
        /// <param name="parameter">The parameter to configure</param>
        /// <param name="value">Parameter value</param>
        public override void SetValue(IDbDataParameter parameter, SqlHierarchyId value)
        {
            if (parameter is SqlParameter sqlParameter) {
                sqlParameter.SqlDbType = SqlDbType.Udt;
                sqlParameter.UdtTypeName = "hierarchyid";
                sqlParameter.SqlValue = value;
            }
        }

        /// <summary>
        /// Parse a database value back to a typed value
        /// </summary>
        /// <param name="value">The value from the database</param>
        /// <returns>The typed value</returns>
        public override SqlHierarchyId Parse(object value) => (SqlHierarchyId)value;
    }

    public class SqlGeometryTypeMapper : SqlMapper.TypeHandler<SqlGeometry>
    {
        /// <summary>
        /// Assign the value of a parameter before a command executes
        /// </summary>
        /// <param name="parameter">The parameter to configure</param>
        /// <param name="value">Parameter value</param>
        public override void SetValue(IDbDataParameter parameter, SqlGeometry? value)
        {
            if (parameter is SqlParameter sqlParameter) {
                sqlParameter.SqlDbType = SqlDbType.Udt;
                sqlParameter.UdtTypeName = "geometry";
                sqlParameter.SqlValue = value;
            }
        }

        /// <summary>
        /// Parse a database value back to a typed value
        /// </summary>
        /// <param name="value">The value from the database</param>
        /// <returns>The typed value</returns>
        public override SqlGeometry? Parse(object value) => (SqlGeometry)value;
    }

    public class SqlGeographyTypeMapper : SqlMapper.TypeHandler<SqlGeography>
    {
        /// <summary>
        /// Assign the value of a parameter before a command executes
        /// </summary>
        /// <param name="parameter">The parameter to configure</param>
        /// <param name="value">Parameter value</param>
        public override void SetValue(IDbDataParameter parameter, SqlGeography? value)
        {
            if (parameter is SqlParameter sqlParameter) {
                sqlParameter.SqlDbType = SqlDbType.Udt;
                sqlParameter.UdtTypeName = "geography";
                sqlParameter.SqlValue = value;
            }
        }

        /// <summary>
        /// Parse a database value back to a typed value
        /// </summary>
        /// <param name="value">The value from the database</param>
        /// <returns>The typed value</returns>
        public override SqlGeography? Parse(object value) => (SqlGeography)value;
    }

    public abstract class SqlPrimitiveConverterBase<T> : JsonConverter where T : struct, INullable, IComparable
    {
        protected abstract object GetValue(T sqlValue);

        public override bool CanConvert(Type objectType) => typeof(T) == objectType;

        public override void WriteJson(JsonWriter writer, object? value, Newtonsoft.Json.JsonSerializer serializer)
        {
            T sqlValue = value != null ? (T)value : default!;
            if (sqlValue.IsNull)
                writer.WriteNull();
            else
                serializer.Serialize(writer, GetValue(sqlValue));
        }
    }

    public class SqlBinaryConverter : SqlPrimitiveConverterBase<SqlBinary>
    {
        protected override object GetValue(SqlBinary sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlBinary.Null;
            return (SqlBinary)serializer.Deserialize<byte[]>(reader)!;
        }
    }

    public class SqlBooleanConverter : SqlPrimitiveConverterBase<SqlBoolean>
    {
        protected override object GetValue(SqlBoolean sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlBoolean.Null;
            return (SqlBoolean)serializer.Deserialize<bool>(reader);
        }
    }

    public class SqlByteConverter : SqlPrimitiveConverterBase<SqlByte>
    {
        protected override object GetValue(SqlByte sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlByte.Null;
            return (SqlByte)serializer.Deserialize<byte>(reader);
        }
    }

    public class SqlDateTimeConverter : SqlPrimitiveConverterBase<SqlDateTime>
    {
        protected override object GetValue(SqlDateTime sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlDateTime.Null;
            return (SqlDateTime)serializer.Deserialize<DateTime>(reader);
        }
    }

    public class SqlDecimalConverter : SqlPrimitiveConverterBase<SqlDecimal>
    {
        protected override object GetValue(SqlDecimal sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlDecimal.Null;
            return (SqlDecimal)serializer.Deserialize<decimal>(reader);
        }
    }

    public class SqlDoubleConverter : SqlPrimitiveConverterBase<SqlDouble>
    {
        protected override object GetValue(SqlDouble sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlDouble.Null;
            return (SqlDouble)serializer.Deserialize<double>(reader);
        }
    }

    public class SqlGuidConverter : SqlPrimitiveConverterBase<SqlGuid>
    {
        protected override object GetValue(SqlGuid sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlGuid.Null;
            return (SqlGuid)serializer.Deserialize<Guid>(reader);
        }
    }

    public class SqlInt16Converter : SqlPrimitiveConverterBase<SqlInt16>
    {
        protected override object GetValue(SqlInt16 sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlInt16.Null;
            return (SqlInt16)serializer.Deserialize<short>(reader);
        }
    }

    public class SqlInt32Converter : SqlPrimitiveConverterBase<SqlInt32>
    {
        protected override object GetValue(SqlInt32 sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlInt32.Null;
            return (SqlInt32)serializer.Deserialize<int>(reader);
        }
    }

    public class SqlInt64Converter : SqlPrimitiveConverterBase<SqlInt64>
    {
        protected override object GetValue(SqlInt64 sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlInt64.Null;
            return (SqlInt64)serializer.Deserialize<long>(reader);
        }
    }

    public class SqlMoneyConverter : SqlPrimitiveConverterBase<SqlMoney>
    {
        protected override object GetValue(SqlMoney sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlMoney.Null;
            return (SqlMoney)serializer.Deserialize<decimal>(reader);
        }
    }

    public class SqlSingleConverter : SqlPrimitiveConverterBase<SqlSingle>
    {
        protected override object GetValue(SqlSingle sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlSingle.Null;
            return (SqlSingle)serializer.Deserialize<float>(reader);
        }
    }

    public class SqlStringConverter : SqlPrimitiveConverterBase<SqlString>
    {
        protected override object GetValue(SqlString sqlValue) => sqlValue.Value;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return SqlString.Null;
            return (SqlString)serializer.Deserialize<string>(reader)!;
        }
    }
} // End Partial class
