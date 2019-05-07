﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public partial interface IContextMethods
    {
        SqlSugarEngine Context { get; set; }
        ExpandoObject DataReaderToExpandoObject(IDataReader reader);
        List<ExpandoObject> DataReaderToExpandoObjectList(IDataReader reader);
        List<T> DataReaderToList<T>(IDataReader reader);
        string SerializeObject(object value);
        T DeserializeObject<T>(string value);
        T TranslateCopy<T>(T sourceObject);
        SqlSugarEngine CopyContext(bool isCopyEvents = false);
        dynamic DataTableToDynamic(DataTable table);
        List<T> DataTableToList<T>(DataTable table);
        ICacheService GetReflectionInoCacheInstance();
        void RemoveCacheAll();
        void RemoveCacheAll<T>();
        void RemoveCache<T>(string key);
        void PageEach<T>(IEnumerable<T> pageItems, int pageSize, Action<List<T>> action);

    }
}
