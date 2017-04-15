using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using myyandar.yHealth.BizData;

namespace myyandar.yHealth.Patient.Dto
{
    [AutoMapFrom(typeof(BizData.Patient))]
    public class PatientListDto : EntityDto
    {
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public string Sex { get; set; }
        public DateTime DoB { get; set; }
        public string PicPath { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BedIndent { get; set; }
        public virtual Admission AdmitDate { get; set; }
        public bool PrevVisit { get; set; }
        public string PrevHosp { get; set; }
        public DateTime DateLastVisitPrevHosp { get; set; }
        public string ReasonLastVisitToPrev { get; set; }
        public string NHISCardId { get; set; }
        public bool IsActive { get; set; }
    }
}