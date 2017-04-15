using System.Data.Common;
using Abp.Zero.EntityFramework;
using myyandar.yHealth.Authorization.Roles;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;
using myyandar.yHealth.BizData;
using System.Data.Entity;

namespace myyandar.yHealth.EntityFramework
{
    public class yHealthDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public virtual IDbSet<Patient> Patients { get; set; }
        public virtual IDbSet<PatAppt> PatAppts { get; set; }
        public virtual IDbSet<Profile> Profiles { get; set; }
        public virtual IDbSet<Department> Departments { get; set; }
        public virtual IDbSet<UCategory> UCategories { get; set; }
        public virtual IDbSet<DrugInventory> DrugInventories { get; set; }
        public virtual IDbSet<PharmaDispensary> PharmaDispensaries { get; set; }
        public virtual IDbSet<TreatmentType> TreatmentTypes { get; set; }
        public virtual IDbSet<Treatment> Treatments { get; set; }
        public virtual IDbSet<Visit> Visits { get; set; }
        public virtual IDbSet<Ward> Wards { get; set; }
        public virtual IDbSet<Admission> Admissions { get; set; }
        public virtual IDbSet<HospIdCard> HospIdCards { get; set; }
        public virtual IDbSet<Diagnosis> Diagnostics { get; set; }
        public virtual IDbSet<MedPrescript> MedPrescripts { get; set; }
        public virtual IDbSet<ScanRequest> ScanRequests { get; set; }
        public virtual IDbSet<LabRequest> LabRequests { get; set; }
        public virtual IDbSet<LabResult> LabResults { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public yHealthDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in yHealthDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of yHealthDbContext since ABP automatically handles it.
         */
        public yHealthDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public yHealthDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public yHealthDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
