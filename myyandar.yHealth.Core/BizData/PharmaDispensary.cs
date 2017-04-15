using Abp.Domain.Entities;
using Abp.Events.Bus;
using myyandar.yHealth.BizData;
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
    public class PharmaDispensary : Entity
    {
        public event EventHandler DrugIssuedEvent;

        public PharmaDispensary()
        {
            PharmacyStaff = (User)HttpContext.Current.User;
            DispencedDate = DateTime.Today;
        }

        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Date Prescription Dispenced")]
        public DateTime DispencedDate { get; set; }
        public virtual MedPrescript MedPrescripts { get; set; }
        [Display(Name = "Dispenced Drug (Id)")]
        public virtual DrugInventory DrugDispenced { get; set; }
        [Display(Name = "Qantity Issued")]
        public virtual int QtyIssued { get; set; }
        public virtual bool ReqSatisfied { get; set; } // Remember to set to 'true' when drug gets issued in the appropriate View.
        public User PharmacyStaff { get; set; }
    }

    class DrugIssuedEvent : EventData
    {
        private static DrugInventory _drugInventory = new DrugInventory();
        private static PharmaDispensary _pharmaDispensary = new PharmaDispensary();
        private int qtyIssued = _pharmaDispensary.QtyIssued;
        private int availQty = _drugInventory.AvailableQty;

        public void ReduceDrugInv()
        {
            availQty =- qtyIssued;
        }

        protected virtual void OnDrugIssuedEvent(EventArgs e)
        {
            ReduceDrugInv();
        }
    }
}