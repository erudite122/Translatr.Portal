using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Translatr.Portal.EntityFramework;

namespace Translatr.Portal.Migrator
{
    [DependsOn(typeof(PortalDataModule))]
    public class PortalMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<PortalDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}