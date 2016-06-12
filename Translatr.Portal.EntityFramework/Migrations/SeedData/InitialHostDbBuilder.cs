using Translatr.Portal.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Translatr.Portal.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly PortalDbContext _context;

        public InitialHostDbBuilder(PortalDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
