using System.Linq;
using Translatr.Portal.EntityFramework;
using Translatr.Portal.MultiTenancy;

namespace Translatr.Portal.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly PortalDbContext _context;

        public DefaultTenantCreator(PortalDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == "Default");
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = "Default", Name = "Default"});
                _context.SaveChanges();
            }
        }
    }
}