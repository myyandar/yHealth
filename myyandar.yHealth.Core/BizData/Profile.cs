using Abp.Domain.Entities;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace myyandar.yHealth.BizData
{
    public class Profile : Entity
    {
        [Display(Name = "Tenant Id")]
        public virtual Tenant TenantId { get; set; }
        public virtual User Username {get; set;}
        public virtual string Surname { get; set; }
        [Display(Name = "Other Names")]
        public virtual string OtherNames { get; set; }
        public virtual string Specialty { get; set; }
        [Display(Name = "Photo Files")]
        public virtual string PicPath { get; set; }
        [Display(Name = "Date  Started Practice")]
        public virtual DateTime PractStart { get; set; }
        [Display(Name = "Previous Specialty")]
        public virtual string PrevSpecialty { get; set; }
        [Display(Name = "Date Started Previous Specialty")]
        public virtual DateTime PrevPractStart { get; set; }
        [Display(Name = "Date Employed")]
        public virtual DateTime DateEmployed { get; set; }
        [Display(Name = "Primary Phone")]
        public virtual string Phone1 { get; set; }
        [Display(Name = "Secondary Phone")]
        public virtual string Phone2 { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DoB { get; set; }
        public virtual string Sex { get; set; }
        public virtual string AboutTheStaff { get; set; }
        [Display(Name = "Fullname")]
        public string FullName { get; set; }
        [Display(Name = "Employee Category")]
        public virtual UCategory UCategories { get; set; }
        [Display(Name = "Employee's Department")]
        public virtual Department DeptName { get; set; }
        [Display(Name="Recorded By")]
        public User UserId {get; set;}

        public Profile()
        {
            FullName = OtherNames + " " +  Surname;
            UserId = (User)HttpContext.Current.User;
        }
    }
}
