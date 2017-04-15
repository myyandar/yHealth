using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.Patient
{
    public class GetPatientsInput
    {
        [Display(Name=("Patient Id"))]
        public int Id { get; set; }
    }
}