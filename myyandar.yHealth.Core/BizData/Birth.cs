using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myyandar.yHealth.BizData
{
    class Birth : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Date of  Birth")]
        public DateTime BirthDate { get; set; }
        public virtual string Sex { get; set; }
        [Display(Name = "Blood Group")]
        public virtual string BloodGroup { get; set; }
        [Display(Name = "Weight at Birth")]
        public virtual long WeightAtBirth { get; set; }
        [Display(Name = "Baby's Condition")]
        public virtual string BabyCondition { get; set; }
        public Patient Patient { get; set; }
        [Display(Name = "Doctor/Midwife in Charge")]
        public User User { get; set; }

        public Birth()
        {
            User = (User)HttpContext.Current.User;
        }
    }
}
