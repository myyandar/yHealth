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
    public class Department : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public virtual string DeptName { get; set; }
        public virtual string Description { get; set; }
        [Display(Name="Dept Contact No")]
        public virtual string DeptContactNo { get; set; }
    }
}
