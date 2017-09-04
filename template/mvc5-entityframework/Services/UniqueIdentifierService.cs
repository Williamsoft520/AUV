using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using AUV.Data;
    using Data;
    public class UniqueIdentifierService
    {
        // 只有 Guid 类型作为主键的实体可使用 IUniqueIdentifierRepository，一个仓储操作一个实体
        private readonly IUniqueIdentifierRepository<UniqueIdentifierEntity> _uniqueIdentifierRepository;

        private readonly IUnitOfWork _unitOfWork;

        public UniqueIdentifierService(IUniqueIdentifierRepository<UniqueIdentifierEntity> uniqueIdentifierRepository, IUnitOfWork unitOfWork)
        {
            this._uniqueIdentifierRepository = uniqueIdentifierRepository;
            this._unitOfWork = unitOfWork;
        }
    }
}
