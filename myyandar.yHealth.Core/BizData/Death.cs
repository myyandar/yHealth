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
    class Death : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Date of Death")]
        public DateTime DeathDate { get; set; }
        [Display(Name = "Cause of Death")]
        public virtual string CauseOfDeath { get; set; }
        [Display(Name = "Other Details of Death")]
        public virtual string OtherDetailsOfDeath { get; set; }
        public Patient Patient { get; set; }
        [Display(Name = "Doctor in Charge")]
        public User User { get; set; }

        public Death()
        {
            User = (User)HttpContext.Current.User;
        }
    }
}
