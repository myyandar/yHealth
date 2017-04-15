using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myyandar.yHealth.BizData
{
    public class MedPrescript : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public DateTime PrescDate { get; set; }
        [Display(Name = "Drug")]
        public virtual DrugInventory DrugName { get; set; }
        [Display(Name = "Dosage")]
        public virtual string Dosage { get; set; }
        [Display(Name = "Medication Period (in days)")]
        public virtual int MedicationPeriod { get; set; }
        [Display(Name = "Further Instructions")]
        public virtual string FurtherInstrs { get; set; }
        public virtual Patient Patient { get; set; }
        [Display(Name = "Prescribed By")]
        public User Username { get; set; }

        public MedPrescript()
        {
            Username = (User)HttpContext.Current.User;
            PrescDate = DateTime.Today;
        }
    }
}
