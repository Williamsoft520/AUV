

using System.Collections.Generic;

namespace AUV.Cache
{
    /// <summary>
    /// 提供基本的对象缓存服务。
    /// </summary>
    public interface IObjectCache
    {
        /// <summary>
        /// 设置一个拥有唯一键的缓存对象。若指定的键存在，则将指定的对象进行更新；否则将新增一个缓存键和对象。
        /// </summary>
        /// <param name="key">缓存的键。若该键存在，则更新 value 的值；否则新增一个新缓存字段对象。</param>
        /// <param name="value">要存储到该缓存键中的对象。</param>
        void Set(string key, object value);
        /// <summary>
        /// 获取指定键的缓存对象。
        /// </summary>
        /// <param name="key">缓存键。</param>
        /// <returns>存储在指定缓存键的缓存对象。</returns>
        /// <exception cref="KeyNotFoundException">在缓存字典中无法找到指定的缓存键。</exception>
        object Get(string key);
        /// <summary>
        /// 判断指定的缓存键是否存在于缓存字典中。
        /// </summary>
        /// <param name="key">缓存键。</param>
        /// <returns>一个布尔值，<c>true</c> 表示存在缓存字典，否则为 <c>false</c>。</returns>
        bool Contains(string key);
        /// <summary>
        /// 移除缓存字典中的指定缓存键。
        /// </summary>
        /// <param name="key">缓存键。</param>
        /// <exception cref="KeyNotFoundException">在缓存字典中无法找到指定的缓存键。</exception>
        void Remove(string key);
        /// <summary>
        /// 清除缓存字典中的所有值。
        /// </summary>
        void Clear();
    }
}
