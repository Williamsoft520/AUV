using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// 若要使用自增列作为主键，可使用内置 IIdentityEntity 接口作为实体基类
    /// </summary>
    public class IdentityEntityBase : AUV.Data.IIdentityEntity
    {
        public int Id { get; internal set; }
    }


    /// <summary>
    /// 若要使用 Guid 作为主键，可使用内置 IUniqueIdentifierEntity 接口作为实体基类
    /// </summary>
    public class UniqueIdentifierEntityBase : AUV.Data.IUniqueIdentifierEntity
    {
        public Guid Id { get; internal set; }
    }


    /// <summary>
    /// 若使用其他自定义类型作为主键，那就实现 IEntity 接口。
    /// </summary>
    public class EntityBase<TKey> : AUV.Data.IEntity<TKey>
    {
        public TKey Id { get; internal set; }
    }
}
