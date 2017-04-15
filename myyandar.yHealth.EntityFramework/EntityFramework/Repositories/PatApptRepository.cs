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
    class PatApptRepository : yHealthRepositoryBase<PatAppt, int>, IPatApptRepository
    {
        public PatApptRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        List<PatAppt> IPatApptRepository.GetAllApptsDue(DateTime? apptdatetime)
        {
            var query = GetAll();
            apptdatetime = DateTime.Today;

            if (apptdatetime.HasValue)
            {
                query = query.Where(appt => appt.ApptDateTime == apptdatetime);
            }

            return query
                .OrderByDescending(appt => appt.ApptDateTime)
                .Include(appt => appt.Username.FullName)
                .Include(appt => appt.PatientId.Id)
                .Include(appt => appt.ApptType)
                .ToList();
        }

        List<PatAppt> IPatApptRepository.GetAllApptsByDate(DateTime? apptdatetime)
        {
            var query = GetAll();

            if (apptdatetime.HasValue)
            {
                query = query.Where(appt => appt.ApptDateTime == apptdatetime);
            }

            return query
                .OrderByDescending(appt => appt.ApptDateTime)
                .Include(appt => appt.Username.FullName)
                .Include(appt => appt.PatientId.Id)
                .Include(appt => appt.ApptType)
                .ToList();
        }
    }
}
