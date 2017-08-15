using System;

namespace AUV.Data
{
    /// <summary>
    /// 表示可以进行仓储操作的实体。
    /// </summary>
    /// <typeparam name="TKey">实体的唯一标识。</typeparam>
    public interface IEntity<out TKey>
    {
        /// <summary>
        /// 获取实体唯一的 Id 值。
        /// </summary>
        TKey Id { get; }
    }

    /// <summary>
    /// 表示使用 <see cref="Int32"/> 类型作为实体的主键。
    /// </summary>
    /// <seealso cref="IEntity{T}" />
    public interface IIdentityEntity : IEntity<int>
    {
    }

    /// <summary>
    /// 表示使用 <see cref="Guid"/> 类型作为实体的主键。
    /// </summary>
    /// <seealso cref="IEntity{T}" />
    public interface IUniqueIdentifierEntity : IEntity<Guid>
    {
    }
}
