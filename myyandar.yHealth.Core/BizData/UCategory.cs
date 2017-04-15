﻿using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyandar.yHealth.BizData
{
    public class UCategory : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Employee Category")]
        public virtual string UCategoryName { get; set; }
        [Display(Name = "Description")]
        public virtual string Description { get; set; }
    }
}
