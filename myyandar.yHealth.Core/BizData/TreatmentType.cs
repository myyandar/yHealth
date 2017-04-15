using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyandar.yHealth.BizData
{
    public class TreatmentType : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public virtual string TreatTypeName { get; set; }
    }
}
