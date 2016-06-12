using System.Data.Common;
using Abp.Zero.EntityFramework;
using Translatr.Portal.Authorization.Roles;
using Translatr.Portal.MultiTenancy;
using Translatr.Portal.Users;

namespace Translatr.Portal.EntityFramework
{
    public class PortalDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public PortalDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in PortalDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of PortalDbContext since ABP automatically handles it.
         */
        public PortalDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public PortalDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
