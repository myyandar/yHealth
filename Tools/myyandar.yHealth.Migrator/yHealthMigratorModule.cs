using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using myyandar.yHealth.EntityFramework;

namespace myyandar.yHealth.Migrator
{
    [DependsOn(typeof(yHealthDataModule))]
    public class yHealthMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<yHealthDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}