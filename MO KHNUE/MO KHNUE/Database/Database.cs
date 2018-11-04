using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Configuration;

namespace MO_KHNUE.Database
{
    public static class RedisDatabase
    {
        private static Lazy<ConnectionMultiplexer> lazyConnection = new Lazy<ConnectionMultiplexer>(() =>
        {
            var connStr = ConfigurationManager.ConnectionStrings["RedisConnection"].ConnectionString;
            return ConnectionMultiplexer.Connect(connStr);
        });

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return lazyConnection.Value;
            }
        }

        private static JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            PreserveReferencesHandling = PreserveReferencesHandling.Objects
        };

        private static IDatabase _db = null;

        public static IDatabase DB
        {
            get
            {
                if (_db == null)
                    _db = Connection.GetDatabase();
                return _db;
            }
        }
        public static string GetValue(string key)
        {
            return DB.StringGet(key);
        }

        public static T GetValue<T>(string key)
        {
            string val = DB.StringGet(key);
            if (val == null)
                return default(T);
            return JsonConvert.DeserializeObject<T>(val);
        }

        public static bool SetValue(string key, object value)
        {
            string val = JsonConvert.SerializeObject(value, Formatting.None, _settings);
            return DB.StringSet(key, val);
        }
    }
}
