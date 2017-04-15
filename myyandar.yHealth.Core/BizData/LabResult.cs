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
    public class LabResult : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public DateTime LabDate { get; set; }
        public virtual string LabType { get; set; }
        public virtual string LabDetails { get; set; }
        public virtual List<string> LabImages { get; set; }
        public virtual LabRequest LabReqDoctor { get; set; }
        public User LabTechnician { get; set; }

        public LabResult()
        {
            LabTechnician = (User)HttpContext.Current.User;
            LabDate = DateTime.Today;
        }
    }

}
