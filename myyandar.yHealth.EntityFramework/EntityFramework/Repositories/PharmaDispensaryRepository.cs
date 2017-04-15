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
    class PharmaDispensaryRepository : yHealthRepositoryBase<PharmaDispensary, int>, IPharmaDispensaryRepository
    {
        public PharmaDispensaryRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        PharmaDispensary phamaAction = new PharmaDispensary();
        List<PharmaDispensary> IPharmaDispensaryRepository.GetNewPrescriptions()
        {
            var query = GetAll();
            query = query.Where(phamaAction => phamaAction.ReqSatisfied == false);

            return query
                .OrderByDescending(medprescript => medprescript.MedPrescripts.PrescDate)
                .Include(PharmaDispensary => PharmaDispensary.MedPrescripts.Patient.Id)
                .Include(PharmaDispensary => PharmaDispensary.MedPrescripts.Dosage)
                .Include(PharmaDispensary => PharmaDispensary.MedPrescripts.DrugName)
                .Include(PharmaDispensary => PharmaDispensary.MedPrescripts.MedicationPeriod)
                .Include(PharmaDispensary => PharmaDispensary.MedPrescripts.Username)
                .Include(PharmaDispensary => PharmaDispensary.PharmacyStaff)
                .ToList();
            }
        }
}
