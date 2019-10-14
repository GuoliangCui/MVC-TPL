using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuaHao.Data
{
    public class RedisService
    {
        private static ConnectionMultiplexer redisConnect = null;
        private static IDatabase DataBase = null;
        public RedisService(IConfigurationRoot config)
        {
            IConfigurationSection redisConfig = config.GetSection("RedisConfig").GetSection("Redis_Default");
            var redisInstanceName = redisConfig["InstanceName"];
            var connStr = redisConfig["Connection"];
            var dbId = redisConfig["DefaultDatabase"];
            DataBase = ConnectionMultiplexer.Connect(connStr).GetDatabase(int.Parse(dbId));
        }
        public IDatabase DB {
            get {
                return DataBase;
            }
        }

    }
}
