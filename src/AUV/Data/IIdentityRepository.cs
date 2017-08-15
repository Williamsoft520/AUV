namespace AUV.Data
{
    /// <summary>
    /// 提供派生自 <see cref="IIdentityEntity" /> 实体的仓储规范。
    /// </summary>
    /// <typeparam name="TEntity">派生自 <see cref="IIdentityEntity" /> 的实例。</typeparam>
    public interface IIdentityRepository<TEntity>
        :IRepository<TEntity,int>
        where TEntity:IIdentityEntity
    {
    }
}
