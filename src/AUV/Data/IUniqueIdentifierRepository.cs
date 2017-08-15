using System;

namespace AUV.Data
{
    /// <summary>
    /// 提供派生自 <see cref="IUniqueIdentifierEntity"/> 实体的仓储规范。
    /// </summary>
    /// <typeparam name="TEntity">派生自 <see cref="IUniqueIdentifierEntity"/> 基类的实例。</typeparam>
    public interface IUniqueIdentifierRepository<TEntity>
        :IRepository<TEntity,Guid>
        where TEntity:IUniqueIdentifierEntity
    {
    }
}
