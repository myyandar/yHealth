using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyandar.yHealth.BizData
{
    public class Payment : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Payment Date")]
        public DateTime PaymentDate { get; set; }
        [Display(Name = "Amount Paid")]
        public virtual string PaymentAmount { get; set; }
        [Display(Name = "Service Details")]
        public virtual string ServiceDetails { get; set; }
        [Display(Name = "Patient Id")]
        public virtual Patient Patient { get; set; }
        public virtual User User { get; set; }
    }
}
