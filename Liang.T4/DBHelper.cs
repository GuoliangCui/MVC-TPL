﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.T4
{
    public class DBHelper
    {
        private static string sqlConnStr = "server=10.1.11.126;port=3306;uid=manager;password=Asdf1234;character set=utf8mb4;";
        private static string entitySql = @"select Col.TABLE_NAME as ClassName,
                                                  Col.COLUMN_NAME as PropName,
                                                  Col.DATA_TYPE as TypeName,
                                                  Col.IS_NULLABLE as IsNull,
                                                  if(Col.COLUMN_KEY='PRI',true,false) as IsPrimary,
                                                  Col.CHARACTER_MAXIMUM_LENGTH as PropLength,
                                                  Col.COLUMN_COMMENT as Comment 
                                                  from information_schema.COLUMNS as Col where TABLE_SCHEMA='{0}' order by Col.TABLE_NAME,Col.ORDINAL_POSITION";
        public static List<EntityInfo> GetEntitys(string dbname = "dgcapplyvehicledb")
        {
            List<EntityInfo> entitys = new List<EntityInfo>();
            string sql = string.Format(entitySql, dbname);

            using (MySqlConnection conn = new MySqlConnection(sqlConnStr))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string className = ToCamel(rd[0].ToString());
                    string propName = rd[1].ToString();
                    string typeName = GetCLRType(rd[2].ToString());

                    bool isNull = rd[3].ToString().ToLower() == "yes" ? true : false;
                    if (typeName == "string" || typeName == "byte[]") { isNull = false; }
                    bool isPrimary = rd[4].ToString().ToLower() == "true" ? true : false;
                    int propLength = string.IsNullOrEmpty(rd[5].ToString()) ? 0 : int.Parse(rd[4].ToString());
                    string comment = rd[6].ToString();

                    var entity = entitys.Find(item => item.ClassName == className);
                    if (entity != null)
                    {
                        entity.PropInfos.Add(new PropInfo()
                        {
                            PropName = propName,
                            TypeName = typeName,
                            IsNull = isNull,
                            IsPrimary = isPrimary,
                            Comment = comment,
                            Length = propLength
                        });
                    }
                    else
                    {
                        entity = new EntityInfo()
                        {
                            ClassName = className,
                            PropInfos = new List<PropInfo>() {
                                 new PropInfo(){
                                      PropName=propName,
                                      TypeName=typeName,
                                      IsNull=isNull,
                                      IsPrimary=isPrimary,
                                      Comment=comment,
                                      Length=propLength
                                 }
                            }
                        };
                        entitys.Add(entity);

                    }
                }
            }

            return entitys;
        }

        public static string GetSql(EntityInfo entity, string sqlType = "update")
        {
            string sql = string.Empty;
            if (sqlType == "insert")
            {
                string sqlInsert = string.Empty;
                string sqlValues = string.Empty;
                foreach (var prop in entity.PropInfos)
                {
                    sqlInsert += $" {prop.PropName} ,";
                    sqlValues += $" @{prop.PropName} ,";
                }

                sql = $"({sqlInsert.TrimEnd(',')}) values ({sqlValues.TrimEnd(',')})";
            }
            if (sqlType == "update")
            {
                string sqlUpdate = string.Empty;
                string sqlWhere = string.Empty;
                foreach (var prop in entity.PropInfos)
                {
                    if (prop.IsPrimary)
                    {
                        sqlWhere = $" {prop.PropName}=@{prop.PropName}";
                    }
                    else
                    {
                        sqlUpdate += $" {prop.PropName}=@{prop.PropName}, ";
                    }
                }
                sql = $"{sqlUpdate.TrimEnd(',')} WHERE {sqlWhere}";
            }
           
            return sql;
        }

        /// <summary>
        /// 实体类信息
        /// </summary>
        public class EntityInfo
        {
            public string ClassName { get; set; }
            public List<PropInfo> PropInfos { get; set; }
        }
        /// <summary>
        /// 属性信息
        /// </summary>
        public class PropInfo
        {
            /// <summary>
            /// 属性名称
            /// </summary>
            public string PropName { get; set; }
            /// <summary>
            /// 属性类型
            /// </summary>
            public string TypeName { get; set; }
            /// <summary>
            /// 是否为主键
            /// </summary>
            public bool IsPrimary { get; set; }
            /// <summary>
            /// 是否可空
            /// </summary>
            public bool IsNull { get; set; }
            /// <summary>
            /// 备注信息
            /// </summary>
            public string Comment { get; set; }
            /// <summary>
            /// 长度
            /// </summary>
            public int Length { get; set; }
        }

        private static string ToCamel(string str)
        {
            string[] wordArray = str.Split('_');
            string result = "";
            foreach (var word in wordArray)
            {
                result += System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(word);
            }
            return result;
        }



        private static string GetCLRType(string dbType, string cType = "")
        {
            string sysType = "string";
            switch (dbType)
            {
                case "bigint":
                case "bit":
                    sysType = "long";
                    break;
                case "smallint":
                    sysType = "short";
                    break;
                case "int":
                    sysType = "int";
                    break;
                case "uniqueidentifier":
                    sysType = "Guid";
                    break;
                case "smalldatetime":
                case "datetime":
                case "datetime2":
                case "date":
                case "time":
                    sysType = "DateTime";
                    break;
                case "float":
                    sysType = "float";
                    break;
                case "double":
                    sysType = "double";
                    break;
                case "real":
                    sysType = "float";
                    break;
                case "numeric":
                case "smallmoney":
                case "decimal":
                case "money":
                    sysType = "decimal";
                    break;
                case "tinyint":
                    if (cType == "tinyint(1)")
                    {
                        sysType = "bool";
                    }
                    else
                    {
                        sysType = "int";
                    }
                    break;
                case "image":
                case "binary":
                case "varbinary":
                case "timestamp":
                    sysType = "DateTime";
                    break;
                case "geography":
                    sysType = "Microsoft.SqlServer.Types.SqlGeography";
                    break;
                case "geometry":
                    sysType = "Microsoft.SqlServer.Types.SqlGeometry";
                    break;
            }
            return sysType;
        }
    }
}
