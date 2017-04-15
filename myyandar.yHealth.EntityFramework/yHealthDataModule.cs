using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using myyandar.yHealth.EntityFramework;

namespace myyandar.yHealth
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(yHealthCoreModule))]
    public class yHealthDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<yHealthDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
