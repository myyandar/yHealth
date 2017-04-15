using Abp.Domain.Repositories;
using Abp.EntityFramework;
using myyandar.yHealth.BizData;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;
using System.Linq.Dynamic;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    public interface IProfileRepository : IRepository<Profile, int>
    {
        List<Profile> GetUserProfileById(int? userId);
        List<Profile> GetUserProfileByByPhone(string userPhone);
    }

}
