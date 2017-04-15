using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.Patient.Dto
{
    public class GetPatientsInput
    {
        [Required]
        [Display(Name="Patient Id (on Hosp Id card")]
        public int Id { get; }
    }
}