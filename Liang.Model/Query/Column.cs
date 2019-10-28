using System;
using System.Collections.Generic;
using System.Text;

namespace Liang.Model.Query
{
    /// <summary>
    /// 查询列信息
    /// </summary>
    public class Column
    {
        private string _name;
        private string _operat;
        private string _value;
        private string _logic;
        private int _group;
        private string _groupLogic;
        public Column(string name, string operat, string value, string logic=null, int group = 0, string groupLogic =null)
        {
            this._name = name;
            this._operat = operat;
            this._value = value;
            if (string.IsNullOrEmpty(logic))
            {
                logic = "and";
            }
            this._logic = logic;
            this._group = group;
            if (string.IsNullOrEmpty(groupLogic))
            {
                groupLogic = "and";
            }
            this._groupLogic = groupLogic;
        }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        /// <summary>
        /// 运算符+-*/><>=<==
        /// </summary>
        public string Operator
        {
            get { return this._operat; }
            set { this._operat = value; }
        }
        /// <summary>
        /// 值
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        /// <summary>
        /// 逻辑And,Or,Not,In
        /// </summary>
        public string Logic
        {
            get { return this._logic; }
            set { this._logic = value; }
        }
        /// <summary>
        /// 分组
        /// </summary>
        public int Group
        {
            get { return this._group; }
            set { this._group = value; }
        }
        /// <summary>
        /// 分组逻辑And,Or,Not,In
        /// </summary>
        public string GroupLogic
        {
            get { return this._groupLogic; }
            set { this._groupLogic = value; }
        }
    }
}
