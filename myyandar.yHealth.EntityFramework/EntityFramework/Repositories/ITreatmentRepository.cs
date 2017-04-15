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
    public interface ITreatmentRepository : IRepository<Treatment, int>
    {
        List<Treatment> GetAllTreatments(int? patientId);
        List<Treatment> GetSpecificTreatmentList(string treatTypes);
    }
}
