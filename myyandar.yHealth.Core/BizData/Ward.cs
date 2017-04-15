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
    public class Ward : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Ward Name or Number")]
        public virtual string WardName { get; set; }
        [Display(Name = "Total Number of Rooms")]
        public virtual int TotalRooms { get; set; }
        [Display(Name = "Total Number of Beds")]
        public virtual int TotalBeds { get; set; }
        [Display(Name = "Available Beds")]
        public virtual int AvailBeds { get; set; }
        [Display(Name = "Ward Type")]
        public virtual string WardType { get; set; }
        [Display(Name = "Ward Contact No")]
        public virtual string WardContactNo { get; set; }
    }
}
