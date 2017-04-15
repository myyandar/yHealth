using Abp.Authorization.Users;
using Abp.AutoMapper;
using myyandar.yHealth.BizData;
using myyandar.yHealth.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.Patient.Dto
{
    [AutoMap(typeof(BizData.Patient))]
    public class CreatePatientInput
    {
        [Required]
        [StringLength(User.MaxNameLength)]
        public string Surname { get; set; }

        [Required]
        [StringLength(User.MaxNameLength)]
        public string Othernames { get; set; }

        [Display(Name = "Next Of Kin Name")]
        public virtual string NOKname { get; set; }

        [Display(Name = "Next Of Kin Phone")]
        public virtual string NOKPhone { get; set; }

        [Display(Name ="Blood Group")]
        public virtual string BloodGroup { get; set; }

        public virtual string Nationality { get; set; }

        public string Sex { get; set; }

        [Display(Name ="Date of Birth")]
        public DateTime DoB { get; set; }

        [Display(Name ="Upload Patient Photo")]
        public string PicPath { get; set; }

        [Display(Name = "HomeAddress")]
        public string HomeAddress { get; set; }

        [Display(Name = "Work Address")]
        public string WorkAddress { get; set; }

        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Display(Name ="Bed Number")]
        public string BedIndent { get; set; }

        [Display(Name = "Date of Last Admission")]
        public virtual Admission AdmitDate { get; set; }

        [Display(Name ="Any  Previous Visit?")]
        public bool PrevVisit { get; set; }

        [Display(Name ="Previous Hospital")]
        public string PrevHosp { get; set; }

        [Display(Name = "Date Last Visited Previous Hospital")]
        public DateTime DateLastVisitPrevHosp { get; set; }

        [Display(Name = "Reason for Last visit to Previous Hospital")]
        public string ReasonLastVisitToPrev { get; set; }

        [Display(Name = "NHIS Id Card No")]
        public string NHISCardId { get; set; }

        public bool IsActive { get; set; }
    }
}