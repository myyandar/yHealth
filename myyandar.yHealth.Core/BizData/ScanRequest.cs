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
    public class ScanRequest : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public DateTime ScanReqDate { get; set; }
        public virtual string ScanReqType { get; set; }
        public virtual string ScanReqDatails { get; set; }
        public User ScanReqDoctor { get; set; }

        public ScanRequest()
        {
            ScanReqDoctor = (User)HttpContext.Current.User;
            ScanReqDate = DateTime.Today;
        }
    }

}
