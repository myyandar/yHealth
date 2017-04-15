using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myyandar.yHealth.Events
{
    public class DrugIssueEvent : EventData
    {
        public int DrugId { get; set; }
    }
}
/*
        protected int QtyIssued;
        protected int AvailableQty;
        public void UpdateDrugInventory()
        {
            AvailableQty =- QtyIssued;
        }
        protected virtual void OnDrugIssueEvent(DrugIssueEvent e)
        {
            if (UpdateDrugInventory != null)
            {
                DrugIssue(this, e);
            }
        }
*/