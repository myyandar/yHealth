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
    public class Admission : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Date Admitted")]
        public virtual string AdmitDate { get; set; }
        [Display(Name = "Date Discharged")]
        public virtual string DischargeDate { get; set; }
        [Display(Name = "Discharge Insructions")]
        public virtual string DischargeInstr { get; set; }
        public virtual Ward WardName { get; set; }
        public User Username { get; set; }

        public Admission()
        {
            Username = (User)HttpContext.Current.User;
        }
    }
}
