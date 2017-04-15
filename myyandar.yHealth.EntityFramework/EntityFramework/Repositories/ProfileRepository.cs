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
    public class ProfileRepository : yHealthRepositoryBase<Profile, int>, IProfileRepository
    {
        public ProfileRepository(IDbContextProvider<yHealthDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        List<Profile> IProfileRepository.GetUserProfileById(int? userId)
        {
            var query = GetAll();
            if (userId.HasValue)
            {
                query = query.Where(profile => profile.Username.Id == userId);
            }
            return query
                .Include(profile => profile.UCategories)
                .Include(profile => profile.OtherNames)
                .Include(profile => profile.Surname)
                .Include(profile => profile.DoB)
                .Include(profile => profile.DateEmployed)
                .Include(profile => profile.Specialty)
                .Include(profile => profile.PrevSpecialty)
                .Include(profile => profile.PractStart)
                .Include(profile => profile.Phone1)
                .Include(profile => profile.Phone2)
                .Include(profile => profile.Username.EmailAddress)
                .Include(profile => profile.PicPath)
                .Include(profile => profile.AboutTheStaff)
                .Include(profile => profile.Sex)
                .ToList();
        }

        List<Profile> IProfileRepository.GetUserProfileByByPhone(string userPhone)
        {
            var query = GetAll();
            if (userPhone != null)
            {
                query = query.Where(profile => profile.Username.PhoneNumber == userPhone || profile.Phone1 == userPhone || profile.Phone2 == userPhone);
            }
            return query
                .Include(profile => profile.UCategories)
                .Include(profile => profile.OtherNames)
                .Include(profile => profile.Surname)
                .Include(profile => profile.DoB)
                .Include(profile => profile.DateEmployed)
                .Include(profile => profile.Specialty)
                .Include(profile => profile.PrevSpecialty)
                .Include(profile => profile.PractStart)
                .Include(profile => profile.Phone1)
                .Include(profile => profile.Phone2)
                .Include(profile => profile.Username.EmailAddress)
                .Include(profile => profile.PicPath)
                .Include(profile => profile.AboutTheStaff)
                .Include(profile => profile.Sex)
                .ToList();
        }
    }
}
