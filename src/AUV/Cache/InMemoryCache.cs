using System;
using System.Collections.Generic;

namespace AUV.Cache
{
    /// <summary>
    /// 表示提供内存作为缓存对象。
    /// </summary>
    public class InMemoryCache : IObjectCache
    {
        IDictionary<string, object> _cacheDictionary;

        /// <summary>
        /// 初始化 <see cref="InMemoryCache"/> 类的新实例。
        /// </summary>
        /// <remarks>缓存键将不区分大小写。</remarks>
        public InMemoryCache():this(StringComparer.OrdinalIgnoreCase)
        {

        }

        /// <summary>
        /// 使用自定义的 <see cref="IEqualityComparer{T}"/> 实例初始化 <see cref="InMemoryCache"/> 的新实例。
        /// </summary>
        /// <param name="comparer">用于区分和比较缓存键的存储方式。</param>
        public InMemoryCache(IEqualityComparer<string> comparer)
        {
            _cacheDictionary = new Dictionary<string, object>(comparer);
        }

        /// <summary>
        /// 清除缓存字典中的所有值。
        /// </summary>
        public virtual void Clear()
        {
            _cacheDictionary.Clear();
        }

        /// <summary>
        /// 判断指定的缓存键是否存在于缓存字典中。
        /// </summary>
        /// <param name="key">缓存键。</param>
        /// <returns>
        /// 一个布尔值，<c>true</c> 表示存在缓存字典，否则为 <c>false</c>。
        /// </returns>
        public virtual bool Contains(string key)
        {
            return _cacheDictionary.ContainsKey(key);
        }

        /// <summary>
        /// Gets the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>
        /// 存储在指定缓存键的缓存对象。
        /// </returns>
        /// <exception cref="KeyNotFoundException">在缓存字典中无法找到指定的缓存键。</exception>
        public virtual object Get(string key)
        {
            object value;
            if (!_cacheDictionary.TryGetValue(key, out value))
            {
                throw new KeyNotFoundException("在缓存字典中无法找到指定的缓存键。");
            }
            return value;
        }

        /// <summary>
        /// 移除缓存字典中的指定缓存键。
        /// </summary>
        /// <param name="key">缓存键。</param>
        /// <exception cref="KeyNotFoundException">在缓存字典中无法找到指定的缓存键。</exception>
        public virtual void Remove(string key)
        {
            if (!Contains(key))
            {
                throw new KeyNotFoundException("在缓存字典中无法找到指定的缓存键。");
            }
             _cacheDictionary.Remove(key);
        }

        /// <summary>
        /// 设置一个拥有唯一键的缓存对象。若指定的键存在，则将指定的对象进行更新；否则将新增一个缓存键和对象。
        /// </summary>
        /// <param name="key">缓存的键。若该键存在，则更新 value 的值；否则新增一个新缓存字段对象。</param>
        /// <param name="value">要存储到该缓存键中的对象。</param>
        public virtual void Set(string key, object value)
        {
            if (Contains(key))
            {
                _cacheDictionary[key] = value;
            }
            else
            {
                _cacheDictionary.Add(key, value);
            }
        }
    }
}
