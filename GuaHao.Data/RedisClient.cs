using StackExchange.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace GuaHao.Data
{
    public class RedisHelper : IDisposable
    {
        
        private static ConnectionMultiplexer _connections;
        private static readonly object _locker = new object();
        private readonly IDatabase _db;

        public RedisHelper()
        {
            _connections = ConnectionMultiplexer.Connect("");
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
