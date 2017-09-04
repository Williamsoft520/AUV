using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using AUV.Data;
    using Data;
    public class IdentityService
    {
        // 只有 int 类型作为主键的实体可使用 IIdentityRepository，一个仓储操作一个实体
        private readonly IIdentityRepository<IdentityEntity> _identityRepository;

        private readonly IUnitOfWork _unitOfWork;

        public IdentityService(IIdentityRepository<IdentityEntity> identityRepository,IUnitOfWork unitOfWork)
        {
            this._identityRepository = identityRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}
