using System.Threading.Tasks;
using Abp.Application.Services;
using myyandar.yHealth.Roles.Dto;

namespace myyandar.yHealth.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
