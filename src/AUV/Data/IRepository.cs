namespace AUV.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// 提供基本的仓储功能。
    /// </summary>
    /// <typeparam name="TEntity">派生自 <see cref="IEntity{TKey}"/> 的实例。</typeparam>
    /// <typeparam name="TKey">表示实体对象的主键标识。</typeparam>
    public interface IRepository<TEntity,TKey>
        where TEntity : IEntity<TKey>
    {
        /// <summary>
        /// 可以将指定实体添加到当前仓储。
        /// </summary>
        /// <param name="entity">需要添加的实体。</param>
        void Add(TEntity entity);

        /// <summary>
        /// 可以将指定实体从当前仓储中移除。
        /// </summary>
        /// <param name="entity">需要移除的实体。</param>
        void Remove(TEntity entity);

        /// <summary>
        /// 异步从当前仓储中查找指定唯一 Id 的实体。
        /// </summary>
        /// <param name="id">要查找的实体唯一 Id 值。</param>
        /// <returns></returns>
        Task<TEntity> FindAsync(TKey id);

        /// <summary>
        /// 表示查询集合的标准。
        /// </summary>
        /// <returns>可查询的实体对象。</returns>
        IQueryable<TEntity> Query();
    }
}
