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
    class TreatmentRepository : yHealthRepositoryBase<Treatment, int>, ITreatmentRepository
    {
        public TreatmentRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }


        List<Treatment> ITreatmentRepository.GetAllTreatments(int? patienId)
        {
            var query = GetAll();

            if (patienId.HasValue)
            {
                query = query.Where(patient => patient.Id == patienId);
            }

            return query
                .OrderByDescending(treatment => treatment.TreatDate)
                .Include(treatment => treatment.TreatDate)
                .Include(treatment => treatment.Visits.VisitDate)
                .Include(treatment => treatment.Diagnostics.DiagnosedOf)
                .Include(treatment => treatment.TreatTypes.TreatTypeName)
                .Include(treatment => treatment.MedPrescripts.DrugName)
                .Include(treatment => treatment.DocComment)
                .Include(treatment => treatment.Username.FullName)
                .ToList();
        }

        List<Treatment> ITreatmentRepository.GetSpecificTreatmentList(string treatTypes)
        {
            var query = GetAll();

            if (treatTypes!=null)
            {
                query = query.Where(treatment => treatment.TreatTypes.Equals(treatTypes));
            }

            return query
                .OrderByDescending(treatment => treatment.TreatDate)
                .Include(treatment => treatment.TreatDate)
                .Include(treatment => treatment.Diagnostics.DiagnosedOf)
                .Include(treatment => treatment.MedPrescripts.DrugName)
                .Include(treatment => treatment.DocComment)
                .Include(treatment => treatment.Username.FullName)
                .ToList();

        }

    }
}
