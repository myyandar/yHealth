using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using myyandar.yHealth.Users.Dto;

namespace myyandar.yHealth.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultDto<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}