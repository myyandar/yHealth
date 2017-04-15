using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using System;
using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.BizData
{
    public class Patient : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Othernames { get; set; }
        public virtual string NOKname { get; set; }
        public virtual string NOKPhone { get; set; }
        public virtual string BloodGroup { get; set; }
        public virtual string Nationality { get; set; }
        public virtual string Sex { get; set; }
        public virtual DateTime DoB { get; set; }
        public virtual string PicPath { get; set; }
        public virtual string HomeAddress { get; set; }
        public virtual string WorkAddress { get; set; }
        public virtual string Email { get; set; }
        public virtual string Phone { get; set; }
        public virtual string BedIndent { get; set; }
        public virtual Admission AdmitDate { get; set; }
        public virtual bool PrevVisit { get; set; }
        public virtual string PrevHosp { get; set; }
        public virtual DateTime DateLastVisitPrevHosp { get; set; }
        public virtual string ReasonLastVisitToPrev { get; set; }
        public virtual string NHISCardId { get; set; }
        public virtual bool IsActive { get; set; }
        public string Fullname { get; set; }

        public Patient()
        {
            Fullname = Othernames + " " + Surname;
        }
    }
}
