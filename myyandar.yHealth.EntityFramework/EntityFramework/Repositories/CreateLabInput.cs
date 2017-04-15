using myyandar.yHealth.Users;
using System;
using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    public class CreateLabInput
    {
        [Display(Name = "Lab Reques Date")]
        public DateTime labReqDate { get; set; }
        [Display(Name = "Lab Reques Type")]
        public string labReqType { get; set; }
        [Display(Name = "Lab Reques Details")]
        public string labReqDatails { get; set; }
        [Display(Name = "Lab Reques Images")]
        public string labReqImages { get; set; }
        [Display(Name = "Requesting Doctor")]
        public User labReqDoctor { get; set; }
    }
}