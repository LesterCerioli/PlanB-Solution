using System;
using System.Collections.Generic;

namespace PlanB.Infrastructure.Extensions
{
    public static class DictionaryExtensions
    {
        internal static bool TryGetValue<T>(this IDictionary<string, object> dictionary, string key, out T value){
            if(dictionary.TryGetValue(key, out var valueObj) && valueObj is T variable){
                value = variable;
                return true;
            }

            value = default(T);
            return false;
        }
    }
}