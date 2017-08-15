namespace AUV.Data.Domain
{
    /// <summary>
    /// 提供只为聚合根进行仓储操作的功能。
    /// </summary>
    /// <typeparam name="TAggragete">聚合根类型。</typeparam>
    /// <typeparam name="TKey">主键类型。</typeparam>
    public interface IAggregateRepository<TAggragete,TKey>
        :IRepository<TAggragete,TKey>
        where TAggragete:IAggregateRoot<TKey>
    {
    }
}
