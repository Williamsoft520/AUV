using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    using AUV.Data;
    using Data;
    public class CustomService
    {
        // 只有自定义类型作为主键的实体可使用 IRepository，一个仓储操作一个实体
        private readonly IRepository<CustomeEntity, long> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomService(IRepository<CustomeEntity, long> repository, IUnitOfWork unitOfWork)
        {
            this._repository = repository;
            this._unitOfWork = unitOfWork;
        }
    }
}
