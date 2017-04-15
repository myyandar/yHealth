using Abp.Domain.Repositories;
using myyandar.yHealth.BizData;
using myyandar.yHealth.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    public interface ILabRequestRepository : IRepository<LabRequest, int>
    {
        void MakeLabRequest(CreateLabInput input);
    }
}
