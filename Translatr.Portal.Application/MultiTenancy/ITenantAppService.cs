using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Translatr.Portal.MultiTenancy.Dto;

namespace Translatr.Portal.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
