using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace myyandar.yHealth.BizData
{
    public class PatAppt : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Appoitment Type")]
        public virtual ApptType ApptType { get; set; }
        public User Username { get; set; }
        public virtual Patient PatientId { get; set; }
        public virtual DateTime ApptDateTime { get; set; }
        public virtual bool HasAttended { get; set; }

        public PatAppt()
        {
            Username = (User)HttpContext.Current.User;
        }
    }
}
