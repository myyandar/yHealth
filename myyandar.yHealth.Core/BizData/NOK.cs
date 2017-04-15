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
    public class NOK : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Name of Next of Kin")]
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Telephone { get; set; }
        [Display(Name = "Email"), DataType("Email")]
        public virtual string Email { get; set; }
        public Patient Patient { get; set; }
    }
}
