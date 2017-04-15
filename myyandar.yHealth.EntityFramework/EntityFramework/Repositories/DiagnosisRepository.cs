using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using myyandar.yHealth.BizData;
using System.Data.Entity;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    class DiagnosisRepository : yHealthRepositoryBase<Diagnosis, int>, IDiagnosisRepository
    {
        public DiagnosisRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        List<Diagnosis> IDiagnosisRepository.GetPatientByDiagnosis(string diagnosedof)
        {
            var query = GetAll();

            if (diagnosedof != null)
            {
                query = query.Where(diagnosis => diagnosis.DiagnosedOf == diagnosedof);
            }

            return query
                .OrderByDescending(diagnosis => diagnosis.Id)
                .Include(diagnosis => diagnosis.DiagnosisName)
                .Include(diagnosis => diagnosis.OtherInfo)
                .Include(diagnosis => diagnosis.Username)
                .Include(diagnosis => diagnosis.Patient.Id)
                .Include(diagnosis => diagnosis.Patient.DoB)
                .Include(diagnosis => diagnosis.Patient.Sex)
                .ToList();
        }

        List<Diagnosis> IDiagnosisRepository.GetPatientByPeriod(string diagnosedof, string year)
        {
            var query = GetAll();

            if (diagnosedof != null && year!=null)
            {
                query = query.Where(diagnosis => diagnosis.DiagnosedOf == diagnosedof && diagnosis.DiagnosisDate.Year.ToString() == year);
            }

            return query
                .OrderByDescending(diagnosis => diagnosis.Id)
                .Include(diagnosis => diagnosis.DiagnosisDate)
                .Include(diagnosis => diagnosis.DiagnosisName)
                .Include(diagnosis => diagnosis.OtherInfo)
                .Include(diagnosis => diagnosis.Username)
                .Include(diagnosis => diagnosis.Patient.Id)
                .Include(diagnosis => diagnosis.Patient.DoB)
                .Include(diagnosis => diagnosis.Patient.Sex)
                .ToList();
        }
    }
}
