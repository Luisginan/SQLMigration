﻿using System.Collections.Generic;

namespace SQLMigrationConverter.mapper
{

    public class DataTypeMap : IDataTypeMap
    {
        private readonly List<TablesFieldDataType> _mapDataTypes = new List<TablesFieldDataType>() {
            new TablesFieldDataType() { DataType="datetime", ConvertedDataType="timestamp" },
            new TablesFieldDataType() { DataType="bigint", ConvertedDataType="bigint" },
            new TablesFieldDataType() { DataType="binary", ConvertedDataType="bytea" },
            new TablesFieldDataType() { DataType="boolean", ConvertedDataType="boolean" },
            new TablesFieldDataType() { DataType="char", ConvertedDataType="char" },
        //    new TablesFieldDataType() { DataType="char", DataTypeSuffix="0", ConvertedDataType="char", ConvertedDataTypeSuffix="4000" },
            new TablesFieldDataType() { DataType="currency", ConvertedDataType="money" },
            new TablesFieldDataType() { DataType="dbdate", ConvertedDataType="date" },
            new TablesFieldDataType() { DataType="dbtime", ConvertedDataType="time" },
            new TablesFieldDataType() { DataType="dbtimestamp", ConvertedDataType="timestamp" },
            new TablesFieldDataType() { DataType="date", ConvertedDataType="date" },
            new TablesFieldDataType() { DataType="decimal", ConvertedDataType="decimal" },
            new TablesFieldDataType() { DataType="double", ConvertedDataType="double" },
            new TablesFieldDataType() { DataType="filetime", ConvertedDataType="timestamp" },
            new TablesFieldDataType() { DataType="guid", ConvertedDataType="uuid" },
            new TablesFieldDataType() { DataType="idispatch", ConvertedDataType="oid" },
            new TablesFieldDataType() { DataType="iunknown", ConvertedDataType="oid" },
            new TablesFieldDataType() { DataType="integer", ConvertedDataType="integer" },
            new TablesFieldDataType() { DataType="longvarbinary", ConvertedDataType="bytea" },
            new TablesFieldDataType() { DataType="longvarchar", ConvertedDataType="text" },
            new TablesFieldDataType() { DataType="longvarwchar", ConvertedDataType="text" },
            new TablesFieldDataType() { DataType="numeric", ConvertedDataType="numeric" },
            new TablesFieldDataType() { DataType="propvariant", ConvertedDataType="text" },
            new TablesFieldDataType() { DataType="single", ConvertedDataType="real" },
            new TablesFieldDataType() { DataType="smallint", ConvertedDataType="smallint" },
            new TablesFieldDataType() { DataType="tinyint", ConvertedDataType="smallint" },
            new TablesFieldDataType() { DataType="unsignedtinyint", ConvertedDataType="tinyint" },
          //  new TablesFieldDataType() { DataType="nvarchar", DataTypeSuffix = "0", ConvertedDataType="varchar", ConvertedDataTypeSuffix = "4000" },
            new TablesFieldDataType() { DataType="nvarchar", ConvertedDataType="varchar" },
            new TablesFieldDataType() { DataType="nchar", ConvertedDataType="varchar" },
           // new TablesFieldDataType() { DataType="nchar", DataTypeSuffix="0", ConvertedDataType="varchar", ConvertedDataTypeSuffix="4000" },
            new TablesFieldDataType() { DataType="varchar", ConvertedDataType="varchar" },
          //  new TablesFieldDataType() { DataType="varchar", DataTypeSuffix="0", ConvertedDataType="varchar", ConvertedDataTypeSuffix="4000" },
          //  new TablesFieldDataType() { DataType="varchar" , DataTypeSuffix="-1", ConvertedDataType="text" },
            new TablesFieldDataType() { DataType="varbinary", ConvertedDataType="bytea" },
          //  new TablesFieldDataType() { DataType="varbinary", DataTypeSuffix="0" , ConvertedDataType="bytea", ConvertedDataTypeSuffix="4000" },
            new TablesFieldDataType() { DataType="varnumeric", ConvertedDataType="numeric" },
            new TablesFieldDataType() { DataType="varwchar", ConvertedDataType="varchar" },
            new TablesFieldDataType() { DataType="variant", ConvertedDataType="oid" },
            new TablesFieldDataType() { DataType="wchar", ConvertedDataType="char" },
            new TablesFieldDataType() { DataType="image", ConvertedDataType="bytea" },
            new TablesFieldDataType() { DataType="bstr", ConvertedDataType="--" },
            new TablesFieldDataType() { DataType="empty", ConvertedDataType="--" },
            new TablesFieldDataType() { DataType="error", ConvertedDataType="--" },
            new TablesFieldDataType() { DataType="unsignedbigint", ConvertedDataType="--" },
            new TablesFieldDataType() { DataType="unsignedint", ConvertedDataType="--" },
            new TablesFieldDataType() { DataType="unsignedsmallint", ConvertedDataType="--" },
        };

        public List<TablesFieldDataType> GetDataTypeMap()
        {
            return _mapDataTypes;
        }
    }
}
