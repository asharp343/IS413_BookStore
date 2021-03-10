using System;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace IS413_BookStore.Infrastructure
{
    public static class SessionExtensions
    {

        // This class converts Cart objects to a JSON string and back. Sessions can only hold strings, ints, and bytes
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
