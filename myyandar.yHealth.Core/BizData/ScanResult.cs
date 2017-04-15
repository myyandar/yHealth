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
    public class ScanResult : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public DateTime ScanResultDate { get; set; }
        public virtual string ScanResultDetails { get; set; }
        public virtual string[] ScanResultImages { get; set; }
        public Patient Patient { get; set; }
        public ScanRequest ScanReqDoctor { get; set; }
        public User User { get; set; }

        public ScanResult()
        {
            User = (User)HttpContext.Current.User;
            ScanResultDate = DateTime.Today;
        }
    }
}
