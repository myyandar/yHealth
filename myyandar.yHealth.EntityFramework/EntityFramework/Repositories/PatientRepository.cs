using myyandar.yHealth.BizData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using System.Data.Entity;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    public class PatientRepository : yHealthRepositoryBase<Patient, int>, IPatientRepository
    {
        public PatientRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        List<Patient> IPatientRepository.GetPatientById(int? patientId)
        {
            var query = GetAll();

            if (patientId.HasValue)
            {
                query = query.Where(patient => patient.Id == patientId);
            }

            return query
                .OrderByDescending(patient => patient.Id)
                .Include(patient => patient.WorkAddress)
                .Include(patient => patient.Fullname)
                .ToList();
        }

        List<Patient> IPatientRepository.GetPatientByPhone(string patientPhone)
        {
            var query = GetAll();

            if (patientPhone != null)
            {
                query = query.Where(patient => patient.Phone == patientPhone);
            }

            return query
                .OrderByDescending(patient => patient.Id)
                .Include(patient => patient.WorkAddress)
                .Include(patient => patient.Email)
                .Include(patient => patient.Fullname)
                .ToList();
        }    
    }
}
