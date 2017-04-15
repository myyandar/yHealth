using Abp.Domain.Repositories;
using Abp.EntityFramework;
using myyandar.yHealth.BizData;
using myyandar.yHealth.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace myyandar.yHealth.EntityFramework
{
    public interface IPatApptRepository : IRepository<PatAppt, int>
    {
        List<PatAppt> GetAllApptsDue(DateTime? apptdatetime);
        List<PatAppt> GetAllApptsByDate(DateTime? apptdatetime);
    }
}
