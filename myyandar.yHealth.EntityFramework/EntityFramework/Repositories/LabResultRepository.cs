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
    public class LabResultRepository : yHealthRepositoryBase<LabResult, int>, ILabResultRepository
    {
        public LabResultRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        LabResult ILabResultRepository.SaveLabResult(CreateLabResult input)
        {
            var result = new LabResult
            {
                LabDate = input.LabDate,
                LabType = input.LabType,
                LabDetails = input.LabDetails,
                LabImages = input.LabImages,
                LabTechnician = input.LabTechnician,
            };
            return result; // I should be saving this,not returningit!  ///Later!
        }                   // And also return same on user request.
    }
}
