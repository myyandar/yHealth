using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using myyandar.yHealth.BizData;
using myyandar.yHealth.Users;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    public class LabRequestRepository : yHealthRepositoryBase<LabRequest, int>, ILabRequestRepository
    {
        public LabRequestRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        void ILabRequestRepository.MakeLabRequest(CreateLabInput input)
        {
            var request = new LabRequest
            {
                LabReqDate = input.labReqDate,
                LabReqType = input.labReqType,
                LabReqDatails = input.labReqDatails,
                LabReqImages = input.labReqImages,
                LabReqDoctor = input.labReqDoctor
            };
        }
    }
}
