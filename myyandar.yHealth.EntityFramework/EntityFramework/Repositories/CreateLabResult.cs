using myyandar.yHealth.BizData;
using myyandar.yHealth.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myyandar.yHealth.EntityFramework.Repositories
{
    internal class CreateLabResult
    {
        [Display(Name = "Lab Date")]
        public virtual DateTime LabDate { get; set; }
        [Display(Name = "Lab Type")]
        public virtual string LabType { get; set; }
        [Display(Name = "Lab Details")]
        public virtual string LabDetails { get; set; }
        [Display(Name = "Lab Images")]
        public virtual List<string> LabImages { get; set; }
        [Display(Name = "Lab Requesting Doctor")]
        public virtual LabRequest LabReqDoctor { get; set; }
        [Display(Name = "Lab Technician")]
        public virtual User LabTechnician { get; set; }
    }
}