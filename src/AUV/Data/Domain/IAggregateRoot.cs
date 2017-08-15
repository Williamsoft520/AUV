namespace AUV.Data
{
    /// <summary>
    /// 表示继承该接口的实体是聚合根。
    /// </summary>
    /// <typeparam name="TKey">聚合根主键类型。</typeparam>
    /// <seealso cref="IEntity{TKey}" />
    public interface IAggregateRoot<TKey>:IEntity<TKey>
    {
    }
}
