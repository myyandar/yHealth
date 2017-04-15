using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myyandar.yHealth.BizData
{
    public class HospIdCard : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public virtual string IdNo { get; set; }
        public virtual Patient Username { get; set; }
        [Display(Name="Date Issued")]
        public virtual DateTime DateIssued { get; set; }
        [Display(Name="Expiry Date")]
        public virtual DateTime DateExp { get; set; }
        public virtual string SignFilePath { get; set; }
        public virtual Patient PicPath { get; set; }
    }
}