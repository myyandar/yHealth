using Abp.Domain.Repositories;
using myyandar.yHealth.BizData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    interface IDiagnosisRepository : IRepository<Diagnosis, int>
    {
        List<Diagnosis> GetPatientByDiagnosis(string diagnosedof);
        List<Diagnosis> GetPatientByPeriod(string diagnosedof, string year);
    }
}
