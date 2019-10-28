using Liang.BLL;
using Liang.Model;
using Liang.Model.Query;
using System;

namespace Liang.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Condition condition = new Condition(null,new PageInfo());

            //所有功能未测试
            //condition.Add(new Column("name11", "=", "1231", "and", 1, "and"));
            //condition.Add(new Column("name12", "=", "1232", "and", 1, null));
            //condition.Add(new Column("name21", "=", "123a", "and", 2, "and"));
            //condition.Add(new Column("name22", "=", "123b", "and", 2, "and"));
            //condition.Add(new Column("name31", "=", "1239", "and", 3, "and"));
            //condition.Add(new Column("name32", "=", "1230", "and", 3, "and"));
            //condition.Add(new Column("name4", "=", "1233", "and", 0, "and"));
            
            //var ss= condition.GetSql(true);

            //Console.WriteLine(ss);
            Console.ReadLine();
        }
    }
}
