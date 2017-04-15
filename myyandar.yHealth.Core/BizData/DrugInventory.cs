using Abp.Domain.Entities;
using Abp.Events.Bus;
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
    public class DrugInventory : Entity
    {
#pragma warning disable CS0067 // The event 'DrugInventory.MinStockLevelReached' is never used
        public event EventHandler MinStockLevelReached;
#pragma warning restore CS0067 // The event 'DrugInventory.MinStockLevelReached' is never used

        public DrugInventory()
        {
            Username = (User)HttpContext.Current.User;
            LastRestockDate = DateTime.Today;
        }

        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        [Display(Name = "Last Restock Date")]
        public DateTime LastRestockDate { get; set;}
        [Display(Name = "Date Manufactured")]
        public virtual DateTime DateManufactured { get; set;}
        [Display(Name = "Drug Brand Name")]
        public virtual string DrugName { get; set;}
        [Display(Name = "Drug Unit: bottle, capsule, pill, tab, etc")]
        public virtual string DrugUnit { get; set;}
        [Display(Name = "Drug Class")]
        public virtual string DrugClass { get; set;}
        [Display(Name = "Available Qty")]
        public virtual int AvailableQty { get; set;} // Remember to add method to increment and decrement.
        [Display(Name = "Max Stock Level")]
        public virtual int MaxStockLevel { get; set;} // Remember to add method to keep checking.
        [Display(Name = "Min Stock Level")]
        public virtual int MinStockLevel { get; set; } // Remember to add method to keep checking.
        [Display(Name = "Drug is NHIS Covered?")]
        public virtual bool IsNHISCovered { get; set; } // Remember to set to 'true' when drug gets issued is covered by NHIS in the appropriate View.
        [Display(Name = "Restock Now")]
        public virtual bool RestockNow { get; set;}     // Remember to add method to set to 'true' when min stock level reached
        [Display(Name = "Cost of Drug")]
        public decimal MedCost { get; set; }
        [Display(Name = "Inventory Manager")]
        public User Username { get; set; }
    }

    class MinStockLevelReached : EventData
    {
        private static DrugInventory _drugInventory = new DrugInventory();
        private int minStockLevel = _drugInventory.MinStockLevel;
        private int availableQty = _drugInventory.AvailableQty;

        protected virtual void OnMinStockLevelReached(EventArgs e)
        {
            isMinStockLevelReached();
        }

        public bool isMinStockLevelReached()
        {
            if (minStockLevel != availableQty)
            {
            }
            return true;
        }
    }
}
