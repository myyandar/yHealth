using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace myyandar.yHealth
{
    [DependsOn(typeof(yHealthCoreModule), typeof(AbpAutoMapperModule))]
    public class yHealthApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                //Add your custom AutoMapper mappings here...
                //mapper.CreateMap<,>()
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
