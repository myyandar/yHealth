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
    public class Diagnosis : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Diagnosis Date")]
        public virtual DateTime DiagnosisDate { get; set; }
        [Display(Name = "Diagnosed of"), StringLength(100)]
        public virtual string DiagnosisName { get; set; }
        [Display(Name = "Diagnosed of"), StringLength(100)]
        public virtual string DiagnosedOf { get; set; }
        [Display(Name = "Last Time and Place Heard of"), StringLength(1000)]
        public virtual string LastimeAndPlaceHeardOf { get; set; }
        [Display(Name = "Other Information"), StringLength(1000)]
        public virtual string OtherInfo { get; set; }
        public virtual Patient Patient {get; set;}
        public User Username {get; set;}

        public Diagnosis()
        {
            Username = (User)HttpContext.Current.User;
        }

    }
}
