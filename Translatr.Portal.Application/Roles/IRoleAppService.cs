using System.Threading.Tasks;
using Abp.Application.Services;
using Translatr.Portal.Roles.Dto;

namespace Translatr.Portal.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
