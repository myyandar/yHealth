using System.Linq;
using myyandar.yHealth.EntityFramework;
using myyandar.yHealth.MultiTenancy;

namespace myyandar.yHealth.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly yHealthDbContext _context;

        public DefaultTenantCreator(yHealthDbContext context)
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

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
