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
    public class LabRequest : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public DateTime LabReqDate { get; set; }
        public virtual string LabReqType { get; set; }
        public virtual string LabReqDatails { get; set; }
        public virtual string LabReqImages { get; set; }
        public User LabReqDoctor { get; set; }

        public LabRequest()
        {
            LabReqDoctor = (User)HttpContext.Current.User;
            LabReqDate = DateTime.Today;
        }
    }

}
