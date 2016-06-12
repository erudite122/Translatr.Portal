using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Translatr.Portal.Authorization.Roles;
using Translatr.Portal.Editions;
using Translatr.Portal.Users;

namespace Translatr.Portal.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}