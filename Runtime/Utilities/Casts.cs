using System;
using System.Reflection;

namespace UltEvents
{
    public static class Casts
    {
        public static readonly MethodInfo CastTo_methodinfo = typeof(Casts).GetMethod(nameof(CastTo));
        public static readonly MethodInfo Casted_methodinfo = typeof(Casts).GetMethod(nameof(Casted));

        public static object CastTo(string type, object value)
            => value;
        
        public static T Casted<T>(string type, object value)
            => (T)value;
    }
}