

using System;
using System.Collections.Generic;

namespace AUV.Cache
{
    /// <summary>
    /// 表示缓存的扩展。
    /// </summary>
    public static class CacheExtension
    {/// <summary>
     /// 获取指定键的缓存对象。
     /// </summary>
     /// <typeparam name="T">一种数据类型。</typeparam>
     /// <param name="cache">派生自 <see cref="IObjectCache"/> 接口的实例。</param>
     /// <param name="key">缓存键。</param>
     /// <returns>存储在指定缓存键的缓存对象。</returns>
     /// <exception cref="KeyNotFoundException">在缓存字典中无法找到指定的缓存键。</exception>
     /// <exception cref="InvalidCastException">数据类型转换失败</exception>
        public static T Get<T>(this IObjectCache cache, string key)
            => (T)cache.Get(key);

        /// <summary>
        /// 设置一个拥有唯一键的缓存对象。若指定的键存在，则将指定的对象进行更新；否则将新增一个缓存键和对象。
        /// </summary>
        /// <param name="cache">派生自 <see cref="IObjectCache"/> 接口的实例。</param>
        /// <param name="key">缓存的键。若该键存在，则更新 value 的值；否则新增一个新缓存字段对象。</param>
        /// <param name="predicate">可使用委托的方式进行运算后将结果设置到指定缓存键中。</param>
        public static void Set<TResult>(this IObjectCache cache, string key, Func<TResult> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }
            cache.Set(key, predicate.Invoke());
        }
    }
}
