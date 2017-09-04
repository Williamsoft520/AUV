using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// 如果使用 int 作为主键，则派生自 <see cref="IdentityEntityBase"/>
    /// </summary>
    public class IdentityEntity:IdentityEntityBase
    {

    }

    /// <summary>
    /// 如果使用 Guid 作为主键，则派生自 <see cref="UniqueIdentifierEntityBase"/>
    /// </summary>
    public class UniqueIdentifierEntity : UniqueIdentifierEntityBase
    {

    }

    /// <summary>
    /// 自定义主键类型，则派生自 <see cref="EntityBase{TKey}"/>
    /// </summary>
    public class CustomeEntity : EntityBase<long>
    {

    }
}
