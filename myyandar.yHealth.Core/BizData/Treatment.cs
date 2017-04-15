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
    public class Treatment : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Treatment Date")]
        public virtual DateTime TreatDate { get; set; }
        [Display(Name = "Doctor's Comments"), StringLength(1000)]
        public virtual string DocComment { get; set; }
        [Display(Name = "Scanned Images")]
        public virtual string ImagePath { get; set; }
        public virtual string NextActionRequired { get; set; }
        public virtual Visit Visits { get; set; }
        public virtual Diagnosis Diagnostics { get; set; }
        [Display(Name = "Treatment Type")]
        public virtual TreatmentType TreatTypes { get; set; }
        public virtual MedPrescript MedPrescripts { get; set; }
        public virtual Patient Patient { get; set; }
        public User Username { get; set; }

        public Treatment()
        {
            Username = (User)HttpContext.Current.User;
        }
    }
}
