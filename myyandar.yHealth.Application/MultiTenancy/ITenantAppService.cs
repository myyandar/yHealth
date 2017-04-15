using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myyandar.yHealth.MultiTenancy.Dto;

namespace myyandar.yHealth.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
