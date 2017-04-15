using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace myyandar.yHealth.BizData
{
    public class Visit : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public DateTime VisitDate { get; set; }
        public virtual string AilmentReported { get; set; }
        public virtual bool FisrtVisit { get; set; }
        public virtual bool NHIS { get; set; }
        public virtual Patient Fullname { get; set; }
        public User Username { get; set; }

        public Visit()
        {
            Username =  (User)HttpContext.Current.User;
            VisitDate = DateTime.Today;
        }
    }
}
