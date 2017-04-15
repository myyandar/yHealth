using myyandar.yHealth.BizData;
using System;
using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.Patient.Dto
{
    public class UpdatePatientInput
    {
        [Required]
        public string Surname { get; set; }

        [Required]
        public string Othernames { get; set; }

        public string Sex { get; set; }

        [Required]
        public DateTime DoB { get; set; }

        public string PicPath { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        public string WorkAddress { get; set; }

        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        public string BedIndent { get; set; }

        public virtual Admission AdmitDate { get; set; }

        public bool PrevVisit { get; set; }

        public string PrevHosp { get; set; }

        public DateTime DateLastVisitPrevHosp { get; set; }

        public string ReasonLastVisitToPrev { get; set; }

        public string NHISCardId { get; set; }
    }
}